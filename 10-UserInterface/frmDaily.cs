using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using Objects;
using System.Windows.Forms.DataVisualization.Charting;

namespace UserInterface
{
    public partial class frmDaily : Form
    {
        public frmDaily()
        {
            InitializeComponent();
        }

        private const string NO_DATA = "Sin datos para las fechas elegidas";

        private void frmDaily_Load(object sender, EventArgs e)
        {
            dtpRepDateEnd.Checked = false;
            dtpRepDateStart.Value = DateTime.Today;
        }

        private void dtpRepDateStart_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpRepDateEnd.Checked && dtpRepDateStart.Value > dtpRepDateEnd.Value)
            //{
            //    MessageBox.Show("La Fecha de Inicio no puede ser posterior a la Fecha de Fin", this.Text,
            //                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            generateReportCaption();
                displayPhysioPatientChart();
                displayFormPaymentPatientChart();
            //}
        }
        private void dtpRepDateEnd_ValueChanged(object sender, EventArgs e)
        {
            dtpRepDateStart.MaxDate = dtpRepDateEnd.Checked ? dtpRepDateEnd.Value : Constants.DTP_MAX_DATE;

            generateReportCaption();
            displayPhysioPatientChart();
            displayFormPaymentPatientChart();
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            displayPhysioPatientChart();
            displayFormPaymentPatientChart();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void generateReportCaption()
        {
            StringBuilder sbRepCaption = new StringBuilder();

            if (dtpRepDateEnd.Checked)
            {
                sbRepCaption.AppendFormat("Actividad entre los días {0} y {1}", dtpRepDateStart.Value.ToShortDateString(), dtpRepDateEnd.Value.ToShortDateString());
            }
            else
            {
                sbRepCaption.AppendFormat("Actividad para el día {0}", dtpRepDateStart.Value.ToShortDateString());
            }

            lblRepCaption.Text = sbRepCaption.ToString();
        }

        private void displayPhysioPatientChart()
        {
            chtRepPhyPat.Annotations.Clear();
            chtRepPhyPat.Titles.Clear();
            chtRepPhyPat.ChartAreas.Clear();
            chtRepPhyPat.Series.Clear();

            Title ttlPhyPat = new Title();
            ttlPhyPat.Name = "ttlPhyPat";
            ttlPhyPat.Text = "Pacientes por Fisio";
            ttlPhyPat.Font = new Font("Verdana", 14, FontStyle.Bold);
            ttlPhyPat.Docking = Docking.Top;
            chtRepPhyPat.Titles.Add(ttlPhyPat);

            DateTime repDateStart = dtpRepDateStart.Value;
            Nullable<DateTime> repDateEnd = dtpRepDateEnd.Checked ? dtpRepDateEnd.Value : Constants.NULL_DATE;

            //List<ReportPhysioPat> lstPhyPat = ReportsBL.generatePhysioPatient(new DateTime(2017, 1, 27));
            List<ReportPhysioPat> lstPhyPat = ReportsBL.generatePhysioPatient(repDateStart, repDateEnd);

            if (lstPhyPat.Count == 0)
            {
                //crtRepPhyPat.Annotations.Add();

                TextAnnotation annotation = new TextAnnotation();
                annotation.Text = NO_DATA;
                annotation.X = 20;
                annotation.Y = 40;
                annotation.Font = new Font("Verdana", 10, FontStyle.Regular);
                annotation.ForeColor = Color.Red;
                chtRepPhyPat.Annotations.Add(annotation);
            }
            else
            {
                ChartArea chaPhyPat = new ChartArea("chaPhyPat");
                chaPhyPat.AxisY.Enabled = AxisEnabled.False;
                chaPhyPat.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chaPhyPat.AxisX.LabelStyle.Font = new Font("Verdana", 10, FontStyle.Regular);
                chaPhyPat.AxisX.MajorGrid.Enabled = false;
                chaPhyPat.AxisX.MajorTickMark.Enabled = false;
                chaPhyPat.AxisX.LineColor = chtRepPhyPat.BackColor;
                chtRepPhyPat.ChartAreas.Add(chaPhyPat);


                Series serPhyPat = new Series("serPhyPat");
                serPhyPat.ChartType = SeriesChartType.Column;
                serPhyPat.ChartArea = "chaPhyPat";
                serPhyPat.IsVisibleInLegend = false;
                serPhyPat.IsValueShownAsLabel = true;
                serPhyPat.Font = new Font("Verdana", 10, FontStyle.Regular);

                foreach (ReportPhysioPat phyPat in lstPhyPat)
                {
                    DataPoint dtpPhyPat = new DataPoint();
                    dtpPhyPat.AxisLabel = phyPat.Physio.Alias;
                    dtpPhyPat.SetValueY(phyPat.PatientCount);
                    //dtpPhyPat.Label = phyPat.PatientCount.ToString();
                    dtpPhyPat.Color = ColorTranslator.FromHtml(phyPat.Physio.Colour);

                    serPhyPat.Points.Add(dtpPhyPat);
                }

                chtRepPhyPat.Series.Add(serPhyPat);
            }
        }


        private void displayFormPaymentPatientChart()
        {
            chtFormPatientPatient.Annotations.Clear();
            chtFormPatientPatient.Titles.Clear();
            chtFormPatientPatient.ChartAreas.Clear();
            chtFormPatientPatient.Series.Clear();

            Title ttlFpyPat = new Title();
            ttlFpyPat.Name = "ttlFpyPat";
            ttlFpyPat.Text = "Pacientes por Forma de Pago";
            ttlFpyPat.Font = new Font("Verdana", 14, FontStyle.Bold);
            ttlFpyPat.Docking = Docking.Top;
            chtFormPatientPatient.Titles.Add(ttlFpyPat);

            DateTime repDateStart = dtpRepDateStart.Value;
            Nullable<DateTime> repDateEnd = dtpRepDateEnd.Checked ? dtpRepDateEnd.Value : Constants.NULL_DATE;

            // Retrieve data from DB
            List<ReportFormPaymentPat> lstFpyPat = ReportsBL.generateFormPaymentPatient(repDateStart, repDateEnd);

            if (lstFpyPat.Count == 0)
            {
                //crtRepPhyPat.Annotations.Add();

                TextAnnotation annotation = new TextAnnotation();
                annotation.Text = NO_DATA;
                annotation.X = 20;
                annotation.Y = 40;
                annotation.Font = new Font("Verdana", 10, FontStyle.Regular);
                annotation.ForeColor = Color.Red;
                chtFormPatientPatient.Annotations.Add(annotation);
            }
            else
            {
                ChartArea chaFpyPat = new ChartArea("chaFpyPat");
                chaFpyPat.AxisY.Enabled = AxisEnabled.False;
                chaFpyPat.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chaFpyPat.AxisX.LabelStyle.Font = new Font("Verdana", 10, FontStyle.Regular);
                chaFpyPat.AxisX.MajorGrid.Enabled = false;
                chaFpyPat.AxisX.MajorTickMark.Enabled = false;
                chaFpyPat.AxisX.LineColor = chtFormPatientPatient.BackColor;
                chtFormPatientPatient.ChartAreas.Add(chaFpyPat);


                Series serFpyPat = new Series("serFpyPat");
                serFpyPat.ChartType = SeriesChartType.Column;
                serFpyPat.ChartArea = "chaFpyPat";
                serFpyPat.IsVisibleInLegend = false;
                serFpyPat.IsValueShownAsLabel = true;
                serFpyPat.Font = new Font("Verdana", 10, FontStyle.Regular);

                foreach (ReportFormPaymentPat fpyPat in lstFpyPat)
                {
                    DataPoint dtpFpyPat = new DataPoint();
                    dtpFpyPat.AxisLabel = fpyPat.FormPayment.Name;
                    dtpFpyPat.SetValueY(fpyPat.PatientCount);
                    //dtpPhyPat.Color = ColorTranslator.FromHtml(fpyPat.Physio.Colour);

                    serFpyPat.Points.Add(dtpFpyPat);
                }

                chtFormPatientPatient.Series.Add(serFpyPat);
            }
        }

        

        

        
        
    }
}
