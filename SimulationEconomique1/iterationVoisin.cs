using System;
using System.Collections.Generic;

namespace SimulationEconomique1
{
    class IterationVoisin : Iteration
    {
        public IterationVoisin(PotCommun potCommun) : base(potCommun)
        {
            this.potCommun = potCommun;
        }

        public override void makeIteration(List<Individu> individus, Random rand)
        {
            int index = rand.Next(individus.Count);
            int[] tabIndex2 = new[] {index - 1, index + 1};
            int index2 = tabIndex2[rand.Next(0,2)];
            if (index == 0)
            {
                index2 = index + 1;
            }
            else
            {
                if (index == individus.Count - 1)
                {
                    index2 = index - 1;
                }
            }

            
            double[] tabRepart;
            while (index2 == index)
            {
                index2 = rand.Next(individus.Count);
            }

            Console.WriteLine("Répartition entre " + individus[index].getName() + " et " + individus[index2].getName());
            Console.WriteLine(individus[index].getName() + " possède " + individus[index].getRichesse() +
                              " richesse(s) avant répartition");
            Console.WriteLine(individus[index2].getName() + " possède " + individus[index2].getRichesse() +
                              " richesse(s) avant répartition");
            this.potCommun.setValeur(individus[index].getRichesse() + individus[index2].getRichesse());
            tabRepart = this.potCommun.repartir();
            individus[index].setRichesse(tabRepart[0]);
            individus[index2].setRichesse(tabRepart[1]);
            Console.WriteLine(individus[index].getName() + " possède " + individus[index].getRichesse() +
                              " richesse(s) après répartition");
            Console.WriteLine(individus[index2].getName() + " possède " + individus[index2].getRichesse() +
                              " richesse(s) après répartition\n");
        }
    }
}