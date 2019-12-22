using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEconomique1
{
    public class PotCommun
    {
        protected double valeur;
        protected double repartition;
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
        public virtual double[] repartir()
        {
            double[] tab = new double[2];
            tab[0] = this.valeur * this.repartition;
            tab[1] = this.valeur * (1 - this.repartition);
            return tab;
        }
    }
}
