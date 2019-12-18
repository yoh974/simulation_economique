using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEconomique1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimulationEconomique simulationEconomique = new SimulationEconomique(100, 0.5, 100, 20, 100);
            simulationEconomique.process();
            Console.ReadKey();

        }

    }
}
