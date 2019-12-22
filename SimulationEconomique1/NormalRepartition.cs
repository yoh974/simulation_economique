using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEconomique1
{
    class NormalRepartition : InitialRepartition
    {
        private int mu;
        private int sigma;
        private Random rand;
        public NormalRepartition(int mu, int sigma)
        {
            this.mu = mu;
            this.sigma = sigma;
            this.rand = new Random();
        }
        public override double doCalcul()
        {
            double u1 = this.rand.NextDouble();
            double u2 = this.rand.NextDouble();

            double rand_std_normal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                                Math.Sin(2.0 * Math.PI * u2);

            double rand_normal = this.mu + this.sigma * rand_std_normal;
            return rand_normal;
        }
    }
}
