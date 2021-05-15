using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cina
{
    public partial class Form1 : Form
    {
        CinaFestiva cinafestiva;
        public Form1()
        {
            InitializeComponent();
            cinafestiva = new CinaFestiva() { NumarDePersoane = 5 };
            numericUpDown1.Value = 5;//adaugat
            cinafestiva.OptiuneaEco(ecoBox.Checked);
            cinafestiva.CalculCostDecoratii(artificiiBox.Checked);
            DisplayCinaFestivaCost();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                cinafestiva.NumarDePersoane = (int)numericUpDown1.Value;
                cinafestiva.CalculCostDecoratii(artificiiBox.Checked);
                cinafestiva.OptiuneaEco(ecoBox.Checked);
                DisplayCinaFestivaCost();
            }  
            else
            {
                lbStatus.Text = 0.ToString("c");
                costLabel.Text = 0.ToString("c");
            }
        }
        private void artificiiBox_CheckedChanged(object sender, EventArgs e)
        {
            cinafestiva.CalculCostDecoratii(artificiiBox.Checked);
            DisplayCinaFestivaCost();
        }

        private void ecoBox_CheckedChanged(object sender, EventArgs e)
        {
            cinafestiva.OptiuneaEco(ecoBox.Checked);
            DisplayCinaFestivaCost();
        }
        private void DisplayCinaFestivaCost()
        {
            decimal Cost = cinafestiva.CalculareCost(ecoBox.Checked);
            lbStatus.Text ="Suma totala ___" + cinafestiva.totacCostF.ToString("c")  + 
                "\n" + "Cost decoratii ___" +cinafestiva.CostDecoratii.ToString("c");

            costLabel.Text = Cost.ToString("c");
        }
    }
}