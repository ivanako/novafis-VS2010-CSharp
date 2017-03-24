namespace UserInterface
{
    partial class frmDaily
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpRepDateStart = new System.Windows.Forms.DateTimePicker();
            this.chtRepPhyPat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRepDateStart = new System.Windows.Forms.Label();
            this.dtpRepDateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblRepDateEnd = new System.Windows.Forms.Label();
            this.chtFormPatientPatient = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRepCaption = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tipDaily = new System.Windows.Forms.ToolTip(this.components);
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtRepPhyPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtFormPatientPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpRepDateStart
            // 
            this.dtpRepDateStart.CustomFormat = "dd/MM/yyy";
            this.dtpRepDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRepDateStart.Location = new System.Drawing.Point(297, 73);
            this.dtpRepDateStart.Name = "dtpRepDateStart";
            this.dtpRepDateStart.Size = new System.Drawing.Size(98, 21);
            this.dtpRepDateStart.TabIndex = 0;
            this.dtpRepDateStart.ValueChanged += new System.EventHandler(this.dtpRepDateStart_ValueChanged);
            // 
            // chtRepPhyPat
            // 
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chtRepPhyPat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend100";
            this.chtRepPhyPat.Legends.Add(legend1);
            this.chtRepPhyPat.Location = new System.Drawing.Point(32, 120);
            this.chtRepPhyPat.Name = "chtRepPhyPat";
            this.chtRepPhyPat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend100";
            series1.LegendText = "hhh";
            series1.Name = "Fisios";
            this.chtRepPhyPat.Series.Add(series1);
            this.chtRepPhyPat.Size = new System.Drawing.Size(386, 221);
            this.chtRepPhyPat.TabIndex = 2;
            this.chtRepPhyPat.Text = "chart1";
            title1.Name = "titulo100";
            title1.Text = "yyyy";
            this.chtRepPhyPat.Titles.Add(title1);
            // 
            // lblRepDateStart
            // 
            this.lblRepDateStart.AutoSize = true;
            this.lblRepDateStart.Location = new System.Drawing.Point(218, 76);
            this.lblRepDateStart.Name = "lblRepDateStart";
            this.lblRepDateStart.Size = new System.Drawing.Size(73, 13);
            this.lblRepDateStart.TabIndex = 3;
            this.lblRepDateStart.Text = "Fecha inicio";
            // 
            // dtpRepDateEnd
            // 
            this.dtpRepDateEnd.CustomFormat = "dd/MM/yyy";
            this.dtpRepDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRepDateEnd.Location = new System.Drawing.Point(532, 73);
            this.dtpRepDateEnd.Name = "dtpRepDateEnd";
            this.dtpRepDateEnd.ShowCheckBox = true;
            this.dtpRepDateEnd.Size = new System.Drawing.Size(119, 21);
            this.dtpRepDateEnd.TabIndex = 0;
            this.dtpRepDateEnd.ValueChanged += new System.EventHandler(this.dtpRepDateEnd_ValueChanged);
            // 
            // lblRepDateEnd
            // 
            this.lblRepDateEnd.AutoSize = true;
            this.lblRepDateEnd.Location = new System.Drawing.Point(468, 76);
            this.lblRepDateEnd.Name = "lblRepDateEnd";
            this.lblRepDateEnd.Size = new System.Drawing.Size(58, 13);
            this.lblRepDateEnd.TabIndex = 3;
            this.lblRepDateEnd.Text = "Fecha fin";
            // 
            // chtFormPatientPatient
            // 
            chartArea2.Name = "ChartArea1";
            this.chtFormPatientPatient.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtFormPatientPatient.Legends.Add(legend2);
            this.chtFormPatientPatient.Location = new System.Drawing.Point(451, 120);
            this.chtFormPatientPatient.Name = "chtFormPatientPatient";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtFormPatientPatient.Series.Add(series2);
            this.chtFormPatientPatient.Size = new System.Drawing.Size(386, 221);
            this.chtFormPatientPatient.TabIndex = 4;
            this.chtFormPatientPatient.Text = "chart1";
            // 
            // lblRepCaption
            // 
            this.lblRepCaption.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepCaption.Location = new System.Drawing.Point(29, 20);
            this.lblRepCaption.Name = "lblRepCaption";
            this.lblRepCaption.Size = new System.Drawing.Size(808, 21);
            this.lblRepCaption.TabIndex = 5;
            this.lblRepCaption.Text = "Actividad";
            this.lblRepCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(765, 473);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 33);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Cerrar";
            this.tipDaily.SetToolTip(this.btnClose, "Cerrar ventana");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(673, 473);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(86, 33);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Recargar";
            this.tipDaily.SetToolTip(this.btnReload, "Recargar informe actual");
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 518);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRepCaption);
            this.Controls.Add(this.chtFormPatientPatient);
            this.Controls.Add(this.lblRepDateEnd);
            this.Controls.Add(this.lblRepDateStart);
            this.Controls.Add(this.chtRepPhyPat);
            this.Controls.Add(this.dtpRepDateEnd);
            this.Controls.Add(this.dtpRepDateStart);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmDaily";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad diaria";
            this.Load += new System.EventHandler(this.frmDaily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtRepPhyPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtFormPatientPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpRepDateStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRepPhyPat;
        private System.Windows.Forms.Label lblRepDateStart;
        private System.Windows.Forms.DateTimePicker dtpRepDateEnd;
        private System.Windows.Forms.Label lblRepDateEnd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtFormPatientPatient;
        private System.Windows.Forms.Label lblRepCaption;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip tipDaily;
        private System.Windows.Forms.Button btnReload;
    }
}