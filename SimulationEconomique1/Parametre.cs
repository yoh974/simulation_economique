namespace SimulationEconomique1
{
    public class Parametre
    {
        public int Nombre_Individus { get; set; }
        public double Repart { get; set; }
        public int Mu { get; set; }
        public int Sigma { get; set; }
        public int Nb_Iteration { get; set; }

        public bool testNull()
        {
            return Nombre_Individus == default(int) || Repart == default(double) || Mu == default(int) || Sigma == default(int) || Nb_Iteration == default(int);
        }
    }
}