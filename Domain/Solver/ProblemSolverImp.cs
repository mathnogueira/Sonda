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
    public class ProblemSolverImp : ProblemSolver
    {
        private ProblemConfiguration configuration;
        private CommandFactory commandFactory;

        public ProblemSolverImp(ProblemConfiguration configuration, CommandFactory commandFactory)
        {
            this.configuration = configuration;
            this.commandFactory = commandFactory;
        }

        public IList<Solution> Solve()
        {
            IList<Sonda> sondas = BuildSondas();
            Container container = BuildSolutionContainer();
            ExecuteSondaCommands(sondas, container);
            return sondas
                .Select(sonda => new Solution(sonda.Position, sonda.Rotation))
                .ToList();
        }

        private IList<Sonda> BuildSondas()
        {
            var sondaBuilder = new SondaBuilder(commandFactory);

            return configuration.Sondas
                .Select(sondaConfig => sondaBuilder
                    .SetPosition(sondaConfig.StartingPoint)
                    .SetRotation(sondaConfig.StartingRotation)
                    .SetCommandList(sondaConfig.Commands)
                    .Build())
                .ToList();
        }

        private Container BuildSolutionContainer()
        {
            int height = this.configuration.TerrainHeight;
            int width = this.configuration.TerrainWidth;

            return new Rectangle(0, 0, width, height);
        }

        private void ExecuteSondaCommands(IList<Sonda> sondas, Container container)
        {
            foreach (var sonda in sondas)
            {
                ExecuteCommands(sonda, container);
            }
        }

        private void ExecuteCommands(Sonda sonda, Container container)
        {
            try
            {
                sonda.ExecuteCommands(container);
            }
            catch (SondaException ex)
            {
                throw new SondaException("Sonda went to an invalid position in Mars", ex);
            }
        }

    }
}
