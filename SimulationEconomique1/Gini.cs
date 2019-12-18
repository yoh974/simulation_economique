using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEconomique1
{
    class Gini
    {

        public static double calculGini(int nombre_individu, List<Individu> individus)
        {
            double gini2 = 0;
            double gini = 0;
            for (int i = 0; i < nombre_individu; i++)
            {
                gini += (i + 1) * individus[i].getRichesse();
                gini2 += individus[i].getRichesse();
            }
            gini = (2 * gini) / (nombre_individu * gini2) - ((nombre_individu + 1) / nombre_individu);
            return Math.Round(gini, 2);
        }
    }
}
