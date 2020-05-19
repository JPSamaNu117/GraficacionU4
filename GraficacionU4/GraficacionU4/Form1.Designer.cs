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
            this.chrPanelGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nudSeries = new System.Windows.Forms.NumericUpDown();
            this.lblNumSeries = new System.Windows.Forms.Label();
            this.cbxDimensiones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoGrafica = new System.Windows.Forms.ComboBox();
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
            this.chrPanelGrafico.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chrPanelGrafico.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chrPanelGrafico.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            chartArea1.Name = "ChartArea1";
            this.chrPanelGrafico.ChartAreas.Add(chartArea1);
            this.chrPanelGrafico.Dock = System.Windows.Forms.DockStyle.Left;
            this.chrPanelGrafico.Location = new System.Drawing.Point(0, 0);
            this.chrPanelGrafico.Name = "chrPanelGrafico";
            this.chrPanelGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chrPanelGrafico.Size = new System.Drawing.Size(517, 195);
            this.chrPanelGrafico.TabIndex = 0;
            this.chrPanelGrafico.Text = "chart1";
            this.chrPanelGrafico.Click += new System.EventHandler(this.chrPanelGrafico_Click);
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
            // cbxDimensiones
            // 
            this.cbxDimensiones.FormattingEnabled = true;
            this.cbxDimensiones.Items.AddRange(new object[] {
            "2D",
            "3D"});
            this.cbxDimensiones.Location = new System.Drawing.Point(667, 54);
            this.cbxDimensiones.Name = "cbxDimensiones";
            this.cbxDimensiones.Size = new System.Drawing.Size(121, 24);
            this.cbxDimensiones.TabIndex = 3;
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
            // cbxTipoGrafica
            // 
            this.cbxTipoGrafica.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxTipoGrafica.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbxTipoGrafica.FormattingEnabled = true;
            this.cbxTipoGrafica.Items.AddRange(new object[] {
            "Point",
            "FastPoint",
            "Bubble",
            "Line",
            "Spline",
            "Bar",
            "Column",
            "SplineArea",
            "Stock",
            "FastLine"});
            this.cbxTipoGrafica.Location = new System.Drawing.Point(667, 84);
            this.cbxTipoGrafica.Name = "cbxTipoGrafica";
            this.cbxTipoGrafica.Size = new System.Drawing.Size(121, 23);
            this.cbxTipoGrafica.TabIndex = 5;
            this.cbxTipoGrafica.ParentChanged += new System.EventHandler(this.cbxTipoGrafica_ParentChanged);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(544, 114);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(244, 43);
            this.btnGraficar.TabIndex = 7;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(830, 195);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipoGrafica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDimensiones);
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
        private System.Windows.Forms.ComboBox cbxDimensiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoGrafica;
        private System.Windows.Forms.Button btnGraficar;
    }
}

