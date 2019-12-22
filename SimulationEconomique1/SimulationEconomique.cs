using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEconomique1
{
    class SimulationEconomique
    {
        private int nombre_individu;
        private int n;
        private int index;
        private int index2;
        private int nb_iteration;
        List<Individu> individus;
        private Iteration iteration;
        private InitialRepartition initialRepartition;

        public SimulationEconomique(Iteration iteration, InitialRepartition initialRepartition,
            int nombre_individu = 100,
            int nb_iteration = 100)
        {
            this.nombre_individu = nombre_individu;
            this.nb_iteration = nb_iteration;
            this.iteration = iteration;
            this.initialRepartition = initialRepartition;
        }

        public void process()
        {
            individus = new List<Individu>();
            for (int i = 0; i < this.nombre_individu; i++)
            {
                double rand = this.initialRepartition.doCalcul();

                individus.Add(new Individu(rand, "individu_" + i));
            }

            Console.WriteLine("Gini = " + Gini.calculGini(this.nombre_individu, individus));
            for (int i = 0; i < this.nb_iteration; i++)
            {
                this.iteration.makeIteration(individus, new Random());
            }

            Console.WriteLine("Gini = " + Gini.calculGini(this.nombre_individu, individus));
        }
    }
}