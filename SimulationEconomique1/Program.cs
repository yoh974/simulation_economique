using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SimulationEconomique1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string jsonFile = "conf.json";
            if (!File.Exists(jsonFile))
            {
                MessageBox.Show("Fichier json inexistant merci d'indiquer son emplacement");
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) ;
                openFileDialog1.Filter = "Fichier json (*.json)|*.json" ;
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.RestoreDirectory = true ;

                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    jsonFile = openFileDialog1.FileName;
                    //...
                }
                else
                {
                    MessageBox.Show("Erreur fichier");
                    Application.Exit();
                }
            }
            
            using (StreamReader r = new StreamReader(jsonFile))
            {
                string json = r.ReadToEnd();
                Parametre parametre = JsonConvert.DeserializeObject<Parametre>(json);
                                    
                SimulationEconomique simulationEconomique = new SimulationEconomique(parametre.Nombre_Individus, parametre.Repart, parametre.Mu, parametre.Sigma, parametre.Nb_Iteration);
                simulationEconomique.process();
                Console.ReadKey();
            }

        }

    }
}
