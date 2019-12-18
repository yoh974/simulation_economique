using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEconomique1
{
    class PotCommun
    {
        private double valeur;
        private double repartition;
        public PotCommun(double repartition)
        {
            this.repartition = repartition;
        }
        public double getValeur()
        {
            return this.valeur;
        }
        public void setValeur(double valeur)
        {
            this.valeur = valeur;
        }
        public double[] repartir()
        {
            double[] tab = new double[2];
            tab[0] = this.valeur * this.repartition;
            tab[1] = this.valeur * (1 - this.repartition);
            return tab;
        }
        public double[] repartirRnd()
        {
            Random random = new Random();
            double[] tab = new double[2];
            int firstIndice = random.Next(0, 2);
            int secondIndice = 0;
            tab[firstIndice] = this.valeur * this.repartition;
            secondIndice = (firstIndice == 0) ? 1 : 0;
            tab[secondIndice] = this.valeur * (1 - this.repartition);
            return tab;
        }
    }
}
