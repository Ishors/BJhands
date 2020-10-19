using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BJ
{
    class Proba
    {
        public Proba() {

        }

        public int Calcul_Total(int[] arr){
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    total += arr[i];
                }
            }
            return total;
        }

    }
}
