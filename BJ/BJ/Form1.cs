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
        private int[] arrTot;

        public int[] ArrTot { get => arrTot; set => arrTot = value; }

        public Form1()
        {
            InitializeComponent();
            arrTot = new int[3];

        }
       
        private void textBox_Ienks_KeyDown(object sender, KeyEventArgs e)
        {
            int ienks_card = 0;
            if (e.KeyValue == (char)97)
            {
                //Ici on cherche à différencier l'as des autres cartes
                ienks_card = 100;
            }
            if (e.KeyValue == (char)98)
            {
                ienks_card = 2;
            }
            if (e.KeyValue == (char)99)
            {
                ienks_card = 3;
            }
            if (e.KeyValue == (char)100)
            {
                ienks_card = 4;
            }
            if (e.KeyValue == (char)101)
            {
                ienks_card = 5;
            }
            if (e.KeyValue == (char)102)
            {
                ienks_card = 6;
            }
            if (e.KeyValue == (char)103)
            {
                ienks_card = 7;
            }
            if (e.KeyValue == (char)104)
            {
                ienks_card = 8;
            }
            if (e.KeyValue == (char)105)
            {
                ienks_card = 9;
            }
            if (e.KeyValue == (char)96)
            {
                ienks_card = 10;
            }          
            arrTot[0] += ienks_card;     
        }

        private void textBox_Croupier_KeyDown(object sender, KeyEventArgs e)
        {
            int croupier_card = 0;
            if (e.KeyValue == (char)97)
            {
                //Ici on cherche à différencier l'as des autres cartes
                croupier_card = 100;
            }
            if (e.KeyValue == (char)98)
            {
                croupier_card = 2;
            }
            if (e.KeyValue == (char)99)
            {
                croupier_card = 3;
            }
            if (e.KeyValue == (char)100)
            {
                croupier_card = 4;
            }
            if (e.KeyValue == (char)101)
            {
                croupier_card = 5;
            }
            if (e.KeyValue == (char)102)
            {
                croupier_card = 6;
            }
            if (e.KeyValue == (char)103)
            {
                croupier_card = 7;
            }
            if (e.KeyValue == (char)104)
            {
                croupier_card = 8;
            }
            if (e.KeyValue == (char)105)
            {
                croupier_card = 9;
            }
            if (e.KeyValue == (char)96)
            {
                croupier_card = 10;
            }
            arrTot[1] += croupier_card;
        }

        private void button_Win_Click(object sender, EventArgs e)
        {
            //Ajouter la win à nos totaux
            arrTot[2] = 1;
            //Écrire dans le fichier
            DataExport data = new DataExport();
            data.DataExportCSV(arrTot);
            //Réinitialiser totaux ienks et croupier
            arrTot[0] = arrTot[1] = 0;
            textBox_Ienks.Text = "";
            textBox_Croupier.Text = "";
        }

        private void button_Loss_Click(object sender, EventArgs e)
        {
            //Ajouter la loose à nos totaux
            arrTot[2] = 0;
            //Écrire dans le fichier
            DataExport data = new DataExport();
            data.DataExportCSV(arrTot);
            //Réinitialiser totaux ienks et croupier
            arrTot[0] = arrTot[1] = 0;
            textBox_Ienks.Text = "";
            textBox_Croupier.Text = "";
        }

        private void button_oups_Click_1(object sender, EventArgs e)
        {
            arrTot[0] = arrTot[1] = 0;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\a.capeyron\Desktop\Data.csv", String.Empty);
        }
    }
}
