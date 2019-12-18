using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEconomique1
{
    abstract class InitialRepartition
    {
        public virtual double doCalcul()
        {
            return 0.0;
        }
    }
}
