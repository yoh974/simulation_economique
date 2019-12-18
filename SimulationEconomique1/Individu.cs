using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEconomique1
{
    class Individu
    {
        private double richesse;
        private string name;
        public Individu(double richesse,string name)
        {
            this.richesse = richesse;
            this.name = name;
        }
        public void setRichesse(double richesse)
        {
            this.richesse = richesse;
        }
        public double getRichesse()
        {
            return this.richesse;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
