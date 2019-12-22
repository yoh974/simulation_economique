using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;


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
                if (parametre.testNull())
                {
                    MessageBox.Show(
                        "Les paramètres du fichier ne sont pas chargé.","Erreur Paramètres");
                }
                else
                {
                    SimulationEconomique simulationEconomique = new SimulationEconomique(new Iteration(new PotCommun(parametre.Repart)),new NormalRepartition(parametre.Mu,parametre.Sigma), parametre.Nombre_Individus,  parametre.Nb_Iteration);
                    simulationEconomique.process();
                    Console.ReadKey(); 
                }

            }

        }

    }
}
