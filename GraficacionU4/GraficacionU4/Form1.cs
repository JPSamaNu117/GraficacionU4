using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraficacionU4
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] ciudad = { "tlaxcala", "ecatepec", "karmaland" };

            //if(nudSeries.Value == 1)
            //{
            //    series1.enable
            //}


            int[] puntos = { 1, 3, 2 };

            chrPanelGrafico.Titles.Add("morfosis");

            for(int i=0; i < ciudad.Length; i++)
            {
                Series serie = chrPanelGrafico.Series.Add(ciudad[i]);

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);

            }
        }

    }
}
