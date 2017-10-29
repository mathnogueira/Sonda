using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Parser;

namespace Gui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do arquivo com as definições do programa: ");
            //string filename = Console.ReadLine();
            string input = "5 6\n1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM";
            ConfigurationParser parser = new ConfigurationParser();
            ProblemConfiguration conf = parser.Parse(input);

            return ;
        }
    }
}
