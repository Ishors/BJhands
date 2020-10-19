using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BJ
{
    public partial class Form1 : Form
    {
        int[] arr;
        int[] arrTot;
        int total_ienks, total_croupier;
        List<int> listRes;
        Proba proba;

        StreamWriter writer;

        public Form1()
        {
            InitializeComponent();
            listRes = new List<int>();
            arrTot = new int[3];
            arr = new int[13];
            proba = new Proba();
        }
        
        private void button_dame_Click(object sender, EventArgs e)
        {
            arr[10] =10;
        }

        private void button_roi_Click(object sender, EventArgs e)
        {
            arr[11] = 10;
        }

        private void button_as_Click(object sender, EventArgs e)
        {
            arr[12] = 100;
        }

        private void button_valet_Click(object sender, EventArgs e)
        {
            arr[9] = 10;
        }

        private void button_ienks_Click(object sender, EventArgs e)
        {
            //Calculer le total des cartes du joueur
            total_ienks = proba.Calcul_Total(arr);
            //Ajouter ce resultat à notre arrTot
            arrTot[0] = total_ienks;
            //Réinitialiser l'arr
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            arr[8] = 10;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            arr[7] = 9;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            arr[6] = 8;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            arr[5] = 7;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            arr[4] = 6;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            arr[3] = 5;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            arr[2] = 4;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            arr[1] = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_2_Click(object sender, EventArgs e)
        {
            arr[0] = 2;
        }

        private void button_croupier_Click(object sender, EventArgs e)
        {
            //Calculer le total des cartes du croupier
            total_croupier = proba.Calcul_Total(arr);

            //Ajouter ce resultat à notre arrTot
            arrTot[1] = total_croupier;

            //Réinitialiser l'arr
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }

        private void buttonwin_Click(object sender, EventArgs e)
        {
            //Ajouter la win à nos totaux
            arrTot[2] = 1;
            //Écrire dans le fichier
            using (writer = new StreamWriter(@"C:\Users\a.capeyron\Desktop\Data.csv", true))
            {
                writer.WriteLine("{0};{1};{2}", arrTot[0], arrTot[1], arrTot[2]);
            }
            //Réinitialiser totaux ienks et croupier
            arrTot[0] = arrTot[1] = total_ienks = total_croupier = 0;
        }
        private void button_export_Click(object sender, EventArgs e)
        {
        }

        private void button_loose_Click(object sender, EventArgs e)
        {
            //Ajouter la loose à nos totaux
            arrTot[2] = 0;
            //Écrire dans le fichier
            using (writer= new StreamWriter(@"C:\Users\a.capeyron\Desktop\Data.csv",true))
            {
                writer.WriteLine("{0};{1};{2}", arrTot[0], arrTot[1], arrTot[2]);
            }
            //Réinitialiser totaux ienks et croupier
            arrTot[0] = arrTot[1] = total_ienks = total_croupier = 0;
        }
    }
}
