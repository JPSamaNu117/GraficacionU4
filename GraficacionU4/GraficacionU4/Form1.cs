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

        public void Form1_Load(object sender, EventArgs e)
        {

            string[] ciudad = { "tlaxcala", "ecatepec", "karmaland" };


            int[] puntos = { 1, 3, 2 };
            int[] puntos1 = { 3, 2, 1 };
            int[] puntos2 = { 2, 1, 3 };
            


            chrPanelGrafico.Titles.Add("morfosis");

            for (int i = 0; i < ciudad.Length; i++)
            {

                Series serie = chrPanelGrafico.Series.Add(ciudad[i]);

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
                serie.Points.Add(puntos1[i]);
                serie.Points.Add(puntos2[i]);

            }

            string formaVariable = cbxDimensiones.Text;
            

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            cambio(cbxTipoGrafica.Text);
        }

        public void cambio(string forma)
        {


            int num = (cbxTipoGrafica.SelectedIndex);

            if (forma == "Point")
            {
                if (num == 3)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Point;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Point;
                    chrPanelGrafico.Series["karmaland"].ChartType = SeriesChartType.Point;
                }
                if (num == 2)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Point;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Point;
                }
                if (num == 1)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Point;
                }
            }
            if (forma == "FastPoint")
            {
                if (num == 3)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.FastPoint;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.FastPoint;
                    chrPanelGrafico.Series["karmaland"].ChartType = SeriesChartType.FastPoint;
                }
                if (num == 2)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.FastPoint;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.FastPoint;
                }
                if (num == 1)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.FastPoint;
                }
            }
            if (forma == "Bubble")
            {
                if (num == 3)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Bubble;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Bubble;
                    chrPanelGrafico.Series["karmaland"].ChartType = SeriesChartType.Bubble;
                }
                if (num == 2)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Bubble;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Bubble;
                }
                if (num == 1)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Bubble;
                }
            }
            if (forma == "Line")
            {
                if (num == 3)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Line;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Line;
                    chrPanelGrafico.Series["karmaland"].ChartType = SeriesChartType.Line;
                }
                if (num == 2)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Line;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Line;
                }
                if (num == 1)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Line;
                }
            }
            if (forma == "Spline")
            {
                if (num == 3)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Spline;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Spline;
                    chrPanelGrafico.Series["karmaland"].ChartType = SeriesChartType.Spline;
                }
                if (num == 2)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Spline;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Spline;
                }
                if (num == 1)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Spline;
                }
            }
            if (forma == "FastLine")
            {
                if (num == 3)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.FastLine;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.FastLine;
                    chrPanelGrafico.Series["karmaland"].ChartType = SeriesChartType.FastLine;
                }
                if (num == 2)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.FastLine;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.FastLine;
                }
                if (num == 1)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.FastLine;
                }
            }
            if (forma == "Bar")
            {
                if (num == 3)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Bar;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Bar;
                    chrPanelGrafico.Series["karmaland"].ChartType = SeriesChartType.Bar;
                }
                if (num == 2)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Bar;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Bar;
                }
                if (num == 1)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Bar;
                }
            }
            if (forma == "Column" )
            {
                if (num == 3)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Column;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Column;
                    chrPanelGrafico.Series["karmaland"].ChartType = SeriesChartType.Column;
                }
                if (num == 2)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Column;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Column;
                }
                if (num == 1)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Column;
                }
            }
            if (forma == "SplineArea")
            {
                if (num == 3)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.SplineArea;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.SplineArea;
                    chrPanelGrafico.Series["karmaland"].ChartType = SeriesChartType.SplineArea;
                }
                if (num == 2)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.SplineArea;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.SplineArea;
                }
                if (num == 1)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.SplineArea;
                }
            }
            if (forma == "Stock")
            {
                if (num == 3)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Stock;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Stock;
                    chrPanelGrafico.Series["karmaland"].ChartType = SeriesChartType.Stock;
                }
                if (num == 2)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Stock;
                    chrPanelGrafico.Series["ecatepec"].ChartType = SeriesChartType.Stock;
                }
                if (num == 1)
                {
                    chrPanelGrafico.Series["tlaxcala"].ChartType = SeriesChartType.Stock;
                }
            }

        }

        private void cbxTipoGrafica_ParentChanged(object sender, EventArgs e)
        {

            
        }

        private void chrPanelGrafico_Click(object sender, EventArgs e)
        {

        }
    }
}
