﻿using System;
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
        private int patientIndex = 0;

        private enum FilterOrigins
        {
            Filter, SavePatient, DeletePatient
        }

        private List<Patient> Patients;

        private void frmPatients_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            initLoad();

            this.Cursor = Cursors.Default;
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
            filterPatients(FilterOrigins.Filter);
        }
        private void txtFilterSurname1_TextChanged(object sender, EventArgs e)
        {
            filterPatients(FilterOrigins.Filter);
        }
        private void txtFilterSurname2_TextChanged(object sender, EventArgs e)
        {
            filterPatients(FilterOrigins.Filter);
        }
        private void chkBlackList_CheckedChanged(object sender, EventArgs e)
        {
            filterPatients(FilterOrigins.Filter);
        }
        private void chkDeleted_CheckedChanged(object sender, EventArgs e)
        {
            filterPatients(FilterOrigins.Filter);
        }

        private void dgvPatients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvPatients.Columns["BlackList"].Index)
            {
                if (Convert.ToBoolean(dgvPatients.Rows[e.RowIndex].Cells["BlackList"].Value))
                {
                    dgvPatients.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                //dgvPatients.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorTranslator.FromHtml(e.Value.ToString());
                //dgvPhysios.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = ColorTranslator.FromHtml(e.Value.ToString());
            }
            if (e.ColumnIndex == dgvPatients.Columns["Deleted"].Index)
            {
                if (Convert.ToBoolean(dgvPatients.Rows[e.RowIndex].Cells["Deleted"].Value))
                {
                    dgvPatients.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dgvPatients.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        private void dgvPatients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(dgvPatients.Rows[e.RowIndex].Cells["Deleted"].Value))
                {
                    MessageBox.Show("Este Paciente está eliminado. No se puede modificar.", this.Text, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    this.patientOperation = Maintenance.Edit;
                    this.patientIndex = e.RowIndex;

                    launchPatientDetails();
                }
            }
        }
        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1)
            {
                btnModify.Enabled = !Convert.ToBoolean(dgvPatients.SelectedRows[0].Cells["Deleted"].Value);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.patientOperation = Maintenance.Create;
            launchPatientDetails();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1)
            {
                this.patientOperation = Maintenance.Edit;
                this.patientIndex = dgvPatients.CurrentRow.Index;

                launchPatientDetails();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1)
            {
                int idPatient = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["Identifier"].Value);

                Patient pat = GlobalVars.Patients.Single<Patient>(p => p.Identifier == idPatient);

                string msgDeletionConfirm = pat.Deleted ? "¿Recuperar el Paciente seleccionado?" : "¿Eliminar el Paciente seleccionado?";

                if (MessageBox.Show(msgDeletionConfirm, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (PatientBL.deletePatient(idPatient))
                    {
                        pat.Deleted = !pat.Deleted;

                        string msgDeletionResult = pat.Deleted ? "Paciente eliminado" : "Paciente recuperado";

                        MessageBox.Show(msgDeletionResult, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //populatePatientGrid();
                        filterPatients(FilterOrigins.DeletePatient);

                        //GlobalVars.Patients = PatientBL.findAllPatients();
                        //initLoad();
                    }
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.patientIndex = 0;

            GlobalVars.Patients = PatientBL.findAllPatients();

            initLoad();

            resetFilter();

            this.Cursor = Cursors.Default;
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
            //patientOperation = Maintenance.Edit;

            this.selPatient = new Patient();

            //GlobalVars.Patients = PatientBL.findAllPatients();

            this.Patients = GlobalVars.Patients.Where(p => p.Deleted == false).OrderBy(p => p.FullName).ToList<Patient>();

            this.pageCount = calculatePageCount();
            lblPageCount.Text = this.pageCount.ToString();

            populatePatientGrid();

            navigateGrid(Navigation.First);
            grbNavigator.Enabled = (this.pageCount > 1);
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
            //dgvPatients.Columns["Deleted"].Visible = false;
            dgvPatients.Columns["Source"].Visible = false;
            dgvPatients.Columns["Physiotherapist"].Visible = false;
            dgvPatients.Columns["Address"].Visible = false;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Format = "N0";
            dgvPatients.Columns["Identifier"].DefaultCellStyle = style;

            dgvPatients.Columns["FullName"].DisplayIndex = 1;
            dgvPatients.Columns["SourceDesc"].DisplayIndex = 7;
            dgvPatients.Columns["PhysiotherapistName"].DisplayIndex = 8;

            if (this.patientIndex > 0 && dgvPatients.Rows.Count > 0)
            {
                dgvPatients.Rows[this.patientIndex].Selected = true;
            }
        }


        private void filterPatients(FilterOrigins origin)
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
            //if (chkDeleted.Checked)
            //{
            lst = lst.Where(p => p.Deleted == chkDeleted.Checked);
            //}

            this.Patients = lst.OrderBy(p => p.FullName).ToList();
            this.pageCount = calculatePageCount();
            lblPageCount.Text = this.pageCount.ToString();

            if (origin == FilterOrigins.Filter)
            {
                navigateGrid(Navigation.First);
                this.patientIndex = 0;
            }

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

        private void resetFilter()
        {
            txtFilterName.TextChanged -= txtFilterName_TextChanged;
            txtFilterSurname1.TextChanged -= txtFilterSurname1_TextChanged;
            txtFilterSurname2.TextChanged -= txtFilterSurname2_TextChanged;
            chkBlackList.CheckedChanged -= chkBlackList_CheckedChanged;
            chkDeleted.CheckedChanged -= chkDeleted_CheckedChanged;

            txtFilterName.Text = string.Empty;
            txtFilterSurname1.Text = string.Empty;
            txtFilterSurname2.Text = string.Empty;
            chkBlackList.Checked = false;
            chkDeleted.Checked = false;

            txtFilterName.TextChanged += txtFilterName_TextChanged;
            txtFilterSurname1.TextChanged += txtFilterSurname1_TextChanged;
            txtFilterSurname2.TextChanged += txtFilterSurname2_TextChanged;
            chkBlackList.CheckedChanged += chkBlackList_CheckedChanged;
            chkDeleted.CheckedChanged += chkDeleted_CheckedChanged;
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

                    this.selPatient = new Patient()
                    {
                        Identifier = 0,
                        Surname2 = string.Empty,
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
                        this.selPatient = new Patient()
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

                        this.selPatient.Address = patAddress;
                        this.selPatient.Cancellations = patCancellations;
                        this.selPatient.Observations = patObservations;
                        this.selPatient.Treatments = patTreatments;
                    }

                    frmPatientDetail.Text = String.Format("Paciente: {0}", this.selPatient.FullName);

                    break;
            }

            

            
            frmPatientDetail.patientDetails = this.selPatient;
            frmPatientDetail.patientOperation = this.patientOperation;
            //frmPatientDetail.Text = string.Format(frmPatientDetail.Text, selPatient.FullName);


            if (frmPatientDetail.ShowDialog() == DialogResult.OK)
            {
                if (this.patientOperation == Maintenance.Edit)
                {
                    GlobalVars.Patients.RemoveAll(p => p.Identifier == frmPatientDetail.patientDetails.Identifier);
                }

                GlobalVars.Patients.Add(frmPatientDetail.patientDetails);

                //initLoad();
                //populatePatientGrid();
                filterPatients(FilterOrigins.SavePatient);

                MessageBox.Show("Paciente guardado correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPatientDetail.Dispose();
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
