using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEconomique1
{
    class Iteration
    {

        public static void makeIterationRnd(PotCommun pot, List<Individu> individus, Random rand)
        {
            int index = rand.Next(individus.Count);
            int index2 = rand.Next(individus.Count);
            double[] tabRepart;
            while (index2 == index)
            {
                index2 = rand.Next(individus.Count);
            }
            Console.WriteLine("Répartition entre " + individus[index].getName() + " et " + individus[index2].getName());
            Console.WriteLine(individus[index].getName() + " possède " + individus[index].getRichesse() + " richesse(s) avant répartition");
            Console.WriteLine(individus[index2].getName() + " possède " + individus[index2].getRichesse() + " richesse(s) avant répartition");
            pot.setValeur(individus[index].getRichesse() + individus[index2].getRichesse());
            tabRepart = pot.repartir();
            individus[index].setRichesse(tabRepart[0]);
            individus[index2].setRichesse(tabRepart[1]);
            Console.WriteLine(individus[index].getName() + " possède " + individus[index].getRichesse() + " richesse(s) après répartition");
            Console.WriteLine(individus[index2].getName() + " possède " + individus[index2].getRichesse() + " richesse(s) après répartition\n");
        }
    }
}
