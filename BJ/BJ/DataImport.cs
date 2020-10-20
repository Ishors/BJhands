using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BJ
{
    class DataImport
    {
        private StreamReader reader;

        public DataImport()
        {

        }

        public void ImportDataCSV()
        {
            using (reader = new StreamReader(@"C:\Users\a.capeyron\Desktop\Data.csv"))
            {
                ///Variable temporaire pour stocker chaque ligne lue
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = reader.ReadLine()) != null)
                {
                    //Découpage de la ligne lue selon le séparateur ";"
                    //Le résultat est un tableau de trois strings: [ienks_card ,croupier_card,win/loss]
                    string[] import = line.Split(';');

                }
            }
        }
    }
}
