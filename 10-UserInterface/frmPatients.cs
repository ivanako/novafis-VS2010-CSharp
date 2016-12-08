using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Objects;
using BusinessLayer;

namespace UserInterface
{
    public partial class frmPatients : Form
    {
        public frmPatients()
        {
            InitializeComponent();
        }


        private Patient selPatient;
        private Maintenance patientOperation;

        private const int PATIENTS_PER_PAGE = 35;
        private int currentPage = 0;
        private int pageCount = 0;

        private List<Patient> Patients;

        private void frmPatients_Load(object sender, EventArgs e)
        {
            initLoad();
        }

        private void grbFilter_Paint(object sender, PaintEventArgs e)
        {
            GroupBox grb = (GroupBox)sender;
            Graphics grbGraphics = e.Graphics;

            Brush textBrush = new SolidBrush(Color.Black);
            Brush borderBrush = new SolidBrush(Color.Gray);
            Pen borderPen = new Pen(borderBrush);
            SizeF strSize = grbGraphics.MeasureString(grb.Text, grb.Font);
            Rectangle rect = new Rectangle(grb.ClientRectangle.X,
                                           grb.ClientRectangle.Y + (int)(strSize.Height / 2),
                                           grb.ClientRectangle.Width - 1,
                                           grb.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            // Clear text and border
            grbGraphics.Clear(this.BackColor);

            // Draw text
            grbGraphics.DrawString(grb.Text, grb.Font, textBrush, grb.Padding.Left, 0);

            // Drawing Border
            //Left
            grbGraphics.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
            //Right
            grbGraphics.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Bottom
            grbGraphics.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Top1
            grbGraphics.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + grb.Padding.Left, rect.Y));
            //Top2
            grbGraphics.DrawLine(borderPen, new Point(rect.X + grb.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
        }


        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            filterPatients();
        }
        private void txtFilterSurname1_TextChanged(object sender, EventArgs e)
        {
            filterPatients();
        }
        private void txtFilterSurname2_TextChanged(object sender, EventArgs e)
        {
            filterPatients();
        }
        private void chkBlackList_CheckedChanged(object sender, EventArgs e)
        {
            filterPatients();
        }

        private void dgvPatients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvPatients.Columns["BlackList"].Index)
            {
                if (Convert.ToBoolean(dgvPatients.Rows[e.RowIndex].Cells["BlackList"].Value))
                {
                    dgvPatients.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                //dgvPatients.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorTranslator.FromHtml(e.Value.ToString());
                //dgvPhysios.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = ColorTranslator.FromHtml(e.Value.ToString());
            }
        }
        private void dgvPatients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.patientOperation = Maintenance.Edit;
                launchPatientDetails();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.patientOperation = Maintenance.Create;
            launchPatientDetails();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                this.patientOperation = Maintenance.Edit;
                launchPatientDetails();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Eliminar el Paciente seleccionado?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idPatient = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["Identifier"].Value);

                    if (PatientBL.deletePatient(idPatient))
                    {
                        MessageBox.Show("Paciente eliminado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GlobalVars.Patients = PatientBL.findAllPatients();
                        initLoad();
                    }
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GlobalVars.Patients = PatientBL.findAllPatients();
            initLoad();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }




        private void btnFirst_Click(object sender, EventArgs e)
        {
            navigateGrid(Navigation.First);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            navigateGrid(Navigation.Previous);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            navigateGrid(Navigation.Next);
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            navigateGrid(Navigation.Last);
        }


        private void initLoad()
        {
            Cursor.Current = Cursors.WaitCursor;

            //patientOperation = Maintenance.Edit;

            this.selPatient = new Patient();

            //GlobalVars.Patients = PatientBL.findAllPatients();

            this.Patients = GlobalVars.Patients;

            this.pageCount = calculatePageCount();
            lblPageCount.Text = this.pageCount.ToString();

            populatePatientGrid();

            navigateGrid(Navigation.First);
            grbNavigator.Enabled = (this.pageCount > 1);

            Cursor.Current = Cursors.Default;
        }

        private void populatePatientGrid()
        {
            List<Patient> lstPatPag = this.Patients
                .Skip<Patient>(PATIENTS_PER_PAGE * this.currentPage)
                .Take<Patient>(PATIENTS_PER_PAGE)
                .ToList<Patient>();

            SortableBindingList<Patient> sblPatients = new SortableBindingList<Patient>(lstPatPag);

            dgvPatients.DataSource = sblPatients;

            dgvPatients.Columns["Name"].Visible = false;
            dgvPatients.Columns["Surname1"].Visible = false;
            dgvPatients.Columns["Surname2"].Visible = false;
            dgvPatients.Columns["HowHeardAboutUs"].Visible = false;
            dgvPatients.Columns["Gender"].Visible = false;
            dgvPatients.Columns["DateOfBirth"].Visible = false;
            //dgvPatients.Columns["BlackList"].Visible = false;
            dgvPatients.Columns["Deleted"].Visible = false;
            dgvPatients.Columns["Source"].Visible = false;
            dgvPatients.Columns["Physiotherapist"].Visible = false;
            dgvPatients.Columns["Address"].Visible = false;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Format = "N0";
            dgvPatients.Columns["Identifier"].DefaultCellStyle = style;

            dgvPatients.Columns["FullName"].DisplayIndex = 1;
            dgvPatients.Columns["SourceDesc"].DisplayIndex = 7;
            dgvPatients.Columns["PhysiotherapistName"].DisplayIndex = 8;
        }


        private void filterPatients()
        {
            string filterName = txtFilterName.Text.Trim();
            string filterSurname1 = txtFilterSurname1.Text.Trim();
            string filterSurname2 = txtFilterSurname2.Text.Trim();

            var lst = GlobalVars.Patients.Where(
                p => p.Name.StartsWith(filterName, StringComparison.CurrentCultureIgnoreCase) &&
                p.Surname1.StartsWith(filterSurname1, StringComparison.CurrentCultureIgnoreCase) &&
                p.Surname2.StartsWith(filterSurname2, StringComparison.CurrentCultureIgnoreCase));

            if (chkBlackList.Checked)
            {
                lst = lst.Where(p => p.BlackList == chkBlackList.Checked);
            }


            this.Patients = lst.ToList();
            this.pageCount = calculatePageCount();
            lblPageCount.Text = this.pageCount.ToString();

            navigateGrid(Navigation.First);
            grbNavigator.Enabled = (this.pageCount > 1);

            //if (this.pageCount > 1)
            //{
            //    grbNavigator.Enabled = true;
            //    navigateGrid(Navigation.First);
            //}
            //else
            //{
            //    grbNavigator.Enabled = false;
            //}

            populatePatientGrid();
        }


        private void launchPatientDetails()
        {
            frmPatientsDetail frmPatientDetail = new frmPatientsDetail();

            Address patAddress = null;

            switch (this.patientOperation)
            { 
                case Maintenance.Create:
                    patAddress = new Address();
                    patAddress.Province = new Province()
                    {
                        Identifier = "28",
                        Name = "Madrid"
                    };

                    selPatient = new Patient()
                    {
                        Identifier = 0,
                        EntryDate = DateTime.Today,
                        Address = patAddress
                    };

                    //selPatient.Cancellations = new List<Cancellation>();
                    //selPatient.Observations = new List<Observation>();
                    //selPatient.Treatments = new List<Treatment>();

                    frmPatientDetail.Text = "Nuevo Paciente";

                    break;
                case Maintenance.Edit:
                    foreach (DataGridViewRow pat in dgvPatients.SelectedRows)
                    {
                        selPatient = new Patient()
                        {
                            Identifier = Convert.ToInt32(pat.Cells["Identifier"].Value),
                            Name = pat.Cells["Name"].Value.ToString(),
                            Surname1 = pat.Cells["Surname1"].Value.ToString(),
                            Surname2 = pat.Cells["Surname2"].Value.ToString(),
                            Identification = pat.Cells["Identification"].Value.ToString(),
                            EntryDate = Convert.ToDateTime(pat.Cells["EntryDate"].Value),
                            HowHeardAboutUs = pat.Cells["HowHeardAboutUs"].Value.ToString(),
                            Gender = Convert.ToChar(pat.Cells["Gender"].Value),
                            DateOfBirth = Convert.ToDateTime(pat.Cells["DateOfBirth"].Value),
                            BlackList = Convert.ToBoolean(pat.Cells["BlackList"].Value),
                            Deleted = Convert.ToBoolean(pat.Cells["Deleted"].Value),
                            Source = (Source)pat.Cells["Source"].Value,
                            Physiotherapist = (Physiotherapist)pat.Cells["Physiotherapist"].Value
                        };

                        patAddress = AddressBL.findOneAddress(selPatient.Identifier);
                        List<Cancellation> patCancellations = CancellationBL.findAllCancellations(selPatient.Identifier);
                        List<Observation> patObservations = ObservationBL.findObservationsByPatient(selPatient.Identifier);
                        List<Treatment> patTreatments = TreatmentBL.findTreatmentsByPatient(selPatient.Identifier);

                        selPatient.Address = patAddress;
                        selPatient.Cancellations = patCancellations;
                        selPatient.Observations = patObservations;
                        selPatient.Treatments = patTreatments;
                    }

                    frmPatientDetail.Text = selPatient.FullName;

                    break;
            }

            

            
            frmPatientDetail.patientDetails = selPatient;
            frmPatientDetail.patientOperation = this.patientOperation;
            //frmPatientDetail.Text = string.Format(frmPatientDetail.Text, selPatient.FullName);


            if (frmPatientDetail.ShowDialog() == DialogResult.OK)
            {
                GlobalVars.Patients = PatientBL.findAllPatients();
                initLoad();

                MessageBox.Show("Paciente guardado correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private int calculatePageCount()
        {
            int pageCountAux = 0;
            int pageCountRem = 0;

            pageCountAux = Math.DivRem(this.Patients.Count, PATIENTS_PER_PAGE, out pageCountRem);

            if (pageCountRem != 0)
            {
                pageCountAux++;
            }

            return pageCountAux;
        }

        private void navigateGrid(Navigation nav)
        {
            switch (nav)
            { 
                case Navigation.First:
                    this.currentPage = 0;

                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;

                    break;
                case Navigation.Previous:
                    this.currentPage--;

                    btnFirst.Enabled = !(this.currentPage == 0);
                    btnPrevious.Enabled = !(this.currentPage == 0);;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    
                    break;
                case Navigation.Next:
                    this.currentPage++;

                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = !(this.currentPage + 1 >= this.pageCount);
                    btnLast.Enabled = !(this.currentPage + 1 >= this.pageCount);

                    break;
                case Navigation.Last:
                    this.currentPage = this.pageCount - 1;

                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;

                    break;
            }

            lblPageCurrent.Text = (this.currentPage + 1).ToString();

            populatePatientGrid();
        }

        

        

        

        

        

        

        

        
    }
}
