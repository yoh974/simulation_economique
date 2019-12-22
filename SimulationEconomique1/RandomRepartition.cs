using System;

namespace SimulationEconomique1
{
    class RandomRepartition : InitialRepartition
    {
        public RandomRepartition()
        {
            
        }

        public override double doCalcul()
        {
            Random random = new Random();
            return random.Next(1,101);
        }
    }
}