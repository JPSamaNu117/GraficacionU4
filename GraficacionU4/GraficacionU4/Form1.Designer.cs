namespace GraficacionU4
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrPanelGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nudSeries = new System.Windows.Forms.NumericUpDown();
            this.lblNumSeries = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrPanelGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // chrPanelGrafico
            // 
            this.chrPanelGrafico.BackColor = System.Drawing.Color.Gray;
            this.chrPanelGrafico.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chrPanelGrafico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chrPanelGrafico.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "ChartArea1";
            this.chrPanelGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrPanelGrafico.Legends.Add(legend1);
            this.chrPanelGrafico.Location = new System.Drawing.Point(12, 12);
            this.chrPanelGrafico.Name = "chrPanelGrafico";
            this.chrPanelGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chrPanelGrafico.Series.Add(series1);
            this.chrPanelGrafico.Series.Add(series2);
            this.chrPanelGrafico.Series.Add(series3);
            this.chrPanelGrafico.Size = new System.Drawing.Size(514, 426);
            this.chrPanelGrafico.TabIndex = 0;
            this.chrPanelGrafico.Text = "chart1";
            // 
            // nudSeries
            // 
            this.nudSeries.Location = new System.Drawing.Point(667, 26);
            this.nudSeries.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSeries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeries.Name = "nudSeries";
            this.nudSeries.Size = new System.Drawing.Size(39, 22);
            this.nudSeries.TabIndex = 1;
            this.nudSeries.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumSeries
            // 
            this.lblNumSeries.AutoSize = true;
            this.lblNumSeries.BackColor = System.Drawing.Color.Purple;
            this.lblNumSeries.ForeColor = System.Drawing.Color.White;
            this.lblNumSeries.Location = new System.Drawing.Point(541, 28);
            this.lblNumSeries.Name = "lblNumSeries";
            this.lblNumSeries.Size = new System.Drawing.Size(120, 17);
            this.lblNumSeries.TabIndex = 2;
            this.lblNumSeries.Text = "Numero de series";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2D",
            "3D"});
            this.comboBox1.Location = new System.Drawing.Point(667, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(558, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de grafica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(541, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estado de grafica";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "columna",
            "barras",
            "puntos",
            "lineas",
            "pastel"});
            this.comboBox2.Location = new System.Drawing.Point(667, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(544, 124);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(244, 43);
            this.btnGraficar.TabIndex = 7;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNumSeries);
            this.Controls.Add(this.nudSeries);
            this.Controls.Add(this.chrPanelGrafico);
            this.Name = "frmPrincipal";
            this.Text = "Grafiacion U4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrPanelGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrPanelGrafico;
        private System.Windows.Forms.NumericUpDown nudSeries;
        private System.Windows.Forms.Label lblNumSeries;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnGraficar;
    }
}

