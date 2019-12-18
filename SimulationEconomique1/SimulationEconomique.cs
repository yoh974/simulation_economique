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
        private double repart;
        private int mu;
        private int sigma;
        private int n;
        private int index;
        private int index2;
        private int nb_iteration;
        PotCommun pot;
        List<Individu> individus;


        public SimulationEconomique(int nombre_individu = 100, double repart = 0.5, int mu = 100, int sigma = 20,
            int nb_iteration = 100)
        {
            this.nombre_individu = nombre_individu;
            this.repart = repart;
            this.mu = mu;
            this.sigma = sigma;
            this.nb_iteration = nb_iteration;
            this.pot = new PotCommun(repart);
        }

        public void process()
        {
            individus = new List<Individu>();
            NormalRepartition normalRepartition = new NormalRepartition(this.mu, this.sigma);
            for (int i = 0; i < this.nombre_individu; i++)
            {
                double rand_normal = normalRepartition.doCalcul();

                individus.Add(new Individu(rand_normal, "individu_" + i));
            }

            Console.WriteLine("Gini = " + Gini.calculGini(this.nombre_individu, individus));
            for (int i = 0; i < this.nb_iteration; i++)
            {
                Iteration.makeIterationRnd(pot, individus, new Random());
            }

            Console.WriteLine("Gini = " + Gini.calculGini(this.nombre_individu, individus));
        }
    }
}