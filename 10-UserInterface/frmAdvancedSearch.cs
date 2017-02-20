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
    public partial class frmAdvancedSearch : Form
    {
        public frmAdvancedSearch()
        {
            InitializeComponent();
        }

        private void frmAdvancedSearch_Load(object sender, EventArgs e)
        {
            populateSources();
        }

        private void btnPatSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            populatePatientGrid();

            this.Cursor = Cursors.Default;
        }
        private void btnPatDetails_Click(object sender, EventArgs e)
        {
            launchPatientDetails();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void populateSources()
        {
            List<Source> lstSources = SourceBL.findAllSources();

            Source srcAll = new Source()
            {
                Identifier = 0,
                Description = "<Ninguna>"
            };

            lstSources.Insert(0, srcAll);

            cboPatSources.DataSource = lstSources;
            cboPatSources.DisplayMember = "Description";
            cboPatSources.ValueMember = "Identifier";
        }


        private void populatePatientGrid()
        {
            List<Patient> lstPatients = searchPatients2();

            SortableBindingList<Patient> sblPatients = new SortableBindingList<Patient>(lstPatients);

            dgvPatientsSearch.DataSource = sblPatients;

            dgvPatientsSearch.Columns["Identifier"].Visible = false;
            dgvPatientsSearch.Columns["Name"].Visible = false;
            dgvPatientsSearch.Columns["Surname1"].Visible = false;
            dgvPatientsSearch.Columns["Surname2"].Visible = false;
            dgvPatientsSearch.Columns["Identification"].Visible = false;
            dgvPatientsSearch.Columns["EntryDate"].Visible = false;
            dgvPatientsSearch.Columns["Gender"].Visible = false;
            dgvPatientsSearch.Columns["DateOfBirth"].Visible = false;
            dgvPatientsSearch.Columns["BlackList"].Visible = false;
            dgvPatientsSearch.Columns["Deleted"].Visible = false;

            dgvPatientsSearch.Columns["Source"].Visible = false;
            dgvPatientsSearch.Columns["Physiotherapist"].Visible = false;
            dgvPatientsSearch.Columns["Address"].Visible = false;
            dgvPatientsSearch.Columns["PhysiotherapistName"].Visible = false;

            dgvPatientsSearch.Columns["FullName"].DisplayIndex = 0;

            lblPatCount.Text = string.Format("Pacientes: {0}", dgvPatientsSearch.Rows.Count);

            btnPatDetails.Enabled = (dgvPatientsSearch.SelectedRows.Count == 1);
        }

        private List<Patient> searchPatients()
        {
            var lst = GlobalVars.Patients
                .Where(p => p.Name.StartsWith(txtPatName.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))
                .Where(p => p.Surname1.StartsWith(txtPatSurname1.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))
                .Where(p => p.Surname2.StartsWith(txtPatSurname2.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))
                .Where(p => p.Identification.StartsWith(txtPatIdentification.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))
                .Where(p => p.HowHeardAboutUs.StartsWith(txtPatHeardAboutUs.Text.Trim(), StringComparison.CurrentCultureIgnoreCase));


            int idSource = int.Parse(cboPatSources.SelectedValue.ToString());

            if (idSource > 0)
            {
                lst = lst.Where(p => p.Source != null);
                lst = lst.Where(p => p.Source.Identifier == idSource);
            }


            List<Patient> lstPatients = lst.ToList<Patient>();

            if (!string.IsNullOrWhiteSpace(txtPatPhone.Text))
            {
                string phone = txtPatPhone.Text.Trim();

                foreach (Patient pat in lstPatients)
                {
                    Address addr = AddressBL.findOneAddress(pat.Identifier);

                    pat.Address = addr;
                }

                lstPatients = lstPatients
                    .Where(p => p.Address.Phone1.StartsWith(phone) || 
                                p.Address.Phone2.StartsWith(phone) || 
                                p.Address.Phone3.StartsWith(phone))
                    .ToList<Patient>();
            }

            return lstPatients;
        }


        private List<Patient> searchPatients2()
        {
            string patName = txtPatName.Text.Trim();
            string patSurname1 = txtPatSurname1.Text.Trim();
            string patSurname2 = txtPatSurname2.Text.Trim();
            string patIdentification = txtPatIdentification.Text.Trim();
            string patAboutUs = txtPatHeardAboutUs.Text.Trim();
            string patPhone = txtPatPhone.Text.Trim();
            int patSource = int.Parse(cboPatSources.SelectedValue.ToString());

            List<Patient> lstPats = PatientBL.searchPatients(patName, patSurname1, patSurname2, patIdentification, patAboutUs, patPhone, patSource);

            return lstPats;
        }

        private void launchPatientDetails()
        {
            frmPatientsDetail frmPatientDetail = new frmPatientsDetail();

            Patient selPatient = null;

            foreach (DataGridViewRow pat in dgvPatientsSearch.SelectedRows)
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

                Address patAddress = AddressBL.findOneAddress(selPatient.Identifier);
                List<Cancellation> patCancellations = CancellationBL.findAllCancellations(selPatient.Identifier);
                List<Observation> patObservations = ObservationBL.findObservationsByPatient(selPatient.Identifier);
                List<Treatment> patTreatments = TreatmentBL.findTreatmentsByPatient(selPatient.Identifier);

                selPatient.Address = patAddress;
                selPatient.Cancellations = patCancellations;
                selPatient.Observations = patObservations;
                selPatient.Treatments = patTreatments;
            }

            frmPatientDetail.Text = selPatient.FullName;




            frmPatientDetail.patientDetails = selPatient;
            frmPatientDetail.patientOperation = Maintenance.Edit;


            if (frmPatientDetail.ShowDialog() == DialogResult.OK)
            {
                GlobalVars.Patients.RemoveAll(p => p.Identifier == frmPatientDetail.patientDetails.Identifier);

                GlobalVars.Patients.Add(frmPatientDetail.patientDetails);

                //initLoad();
                //populatePatientGrid();
                //filterPatients(FilterOrigins.SavePatient);

                MessageBox.Show("Paciente guardado correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPatientDetail.Dispose();
            }
        }

        

        

    }
}
