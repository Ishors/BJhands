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

        public string[] ImportDataCSV()
        {
            string[] import = new string[3];
            using (reader = new StreamReader(@"C:\Users\a.capeyron\Desktop\Data.csv"))
            {
                /// Local variable used to stock every readed line
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = reader.ReadLine()) != null)
                {
                    // Splitting the line every ";"
                    // and putting it into an array made of three strings : [ienks_card, croupier_card, win/loss]
                    import = line.Split(';');
                }
            }
        return import;
        }
    }
}
