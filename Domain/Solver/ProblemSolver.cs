using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Builders;
using Domain.Commands;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Geometry;
using Domain.Parser;

namespace Domain.Solver
{
    public class ProblemSolver : IProblemSolver
    {

        private ProblemConfiguration configuration;

        public ProblemSolver(ProblemConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IList<Solution> Solve()
        {
            IList<Sonda> sondas = BuildSondas();
            IContainer container = BuildSolutionContainer();
            ExecuteSondaCommands(sondas, container);
            return sondas
                .Select(sonda => new Solution(sonda.Position, sonda.Rotation))
                .ToList();
        }

        private IList<Sonda> BuildSondas()
        {
            IList<Sonda> sondas = new List<Sonda>();
            var commandFactory = new CommandFactory();
            var sondaBuilder = new SondaBuilder(commandFactory);

            foreach (var sondaConfig in configuration.Sondas)
            {
                var sonda = sondaBuilder
                    .SetPosition(sondaConfig.StartingPoint)
                    .SetRotation(sondaConfig.StartingRotation)
                    .SetCommandList(sondaConfig.Commands)
                    .Build();

                sondas.Add(sonda);
            }

            return sondas;
        }

        private IContainer BuildSolutionContainer()
        {
            int height = this.configuration.TerrainHeight;
            int width = this.configuration.TerrainWidth;

            return new Rectangle(0, 0, width, height);
        }

        private void ExecuteSondaCommands(IList<Sonda> sondas, IContainer container)
        {
            int sondaNumber = 1;
            foreach (var sonda in sondas)
            {
                try
                {
                    sonda.ExecuteCommands(container);
                    ++sondaNumber;
                }
                catch (SondaMovementException ex)
                {
                    string exMessage = String.Format("Sonda #{0} went to an invalid position in Mars", sondaNumber);
                    throw new SondaMovementException(exMessage, ex);
                }
            }
        }

    }
}
