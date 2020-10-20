using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BJ
{
    class DataExport
    {
        private StreamWriter writer;

        public void DataExportCSV(int[] arr)
        {
            using (writer = new StreamWriter(@"C:\Users\a.capeyron\Desktop\Data.csv", true))
            {
                writer.WriteLine("{0};{1};{2}", arr[0], arr[1], arr[2]);
            }
        }
    }
}
