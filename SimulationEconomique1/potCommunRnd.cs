using System;

namespace SimulationEconomique1
{
    public class potCommunRnd : PotCommun
    {
        public potCommunRnd(double repartition) : base(repartition)
        {
            this.repartition = repartition;
        }
        public override double[] repartir()
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