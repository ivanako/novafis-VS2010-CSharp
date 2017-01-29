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
    public partial class frmPatientsDetail : Form
    {
        public frmPatientsDetail()
        {
            InitializeComponent();
        }

        internal Patient patientDetails;
        internal Maintenance patientOperation;

        private bool hasChanged;

        private void frmPatientsDetail_Load(object sender, EventArgs e)
        {
            populateSources();
            populatePhysios();
            populateProvinces();

            bindDataControls();
            bindAddressControls();

            if (this.patientOperation == Maintenance.Create)
            {
                dtpBirthDate.Checked = false;
                tabDetails.TabPages.Remove(tbpCancellations);
                tabDetails.TabPages.Remove(tbpObservations);
                tabDetails.TabPages.Remove(tbpTreatments);
            }
            else
            {
                initCancellations();
                initObservations();
                initTreatments();
            }

            hasChanged = false;
        }


        #region DATA
            private void bindDataControls()
            {
                BindingSource bs = new BindingSource(patientDetails, null);

                lblIdentifierValue.DataBindings.Add("Text", bs, "Identifier", true, DataSourceUpdateMode.OnPropertyChanged);
                txtName.DataBindings.Add("Text", bs, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSurname1.DataBindings.Add("Text", bs, "Surname1", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSurname2.DataBindings.Add("Text", bs, "Surname2", true, DataSourceUpdateMode.OnPropertyChanged);
                txtIdentification.DataBindings.Add("Text", bs, "Identification", true, DataSourceUpdateMode.OnPropertyChanged);
                dtpEntryDate.DataBindings.Add("Value", bs, "EntryDate", true, DataSourceUpdateMode.OnPropertyChanged);
                txtHowHeardAboutUs.DataBindings.Add("Text", bs, "HowHeardAboutUs", true, DataSourceUpdateMode.OnPropertyChanged);
                chkBlackList.DataBindings.Add("Checked", bs, "BlackList", true, DataSourceUpdateMode.OnPropertyChanged);

                DateTime birthDate = patientDetails.DateOfBirth ?? DateTime.Today;

                dtpBirthDate.Value = patientDetails.DateOfBirth.Equals(DateTime.MinValue) ? DateTime.Today : birthDate;
                dtpBirthDate.Checked = !patientDetails.DateOfBirth.Equals(DateTime.MinValue);

                radMale.Checked = patientDetails.Gender.Equals(radMale.Tag.ToString()[0]);
                radFemale.Checked = patientDetails.Gender.Equals(radFemale.Tag.ToString()[0]);

                if (patientDetails.Source == null)
                {
                    cboSources.SelectedItem = null;
                }
                else
                {
                    cboSources.SelectedValue = patientDetails.Source.Identifier;
                }

                if (patientDetails.Physiotherapist == null)
                {
                    cboPhysios.SelectedItem = null;
                }
                else
                {
                    cboPhysios.SelectedValue = patientDetails.Physiotherapist.Identifier;
                }
            }

            private void populateSources()
            {
                List<Source> lstSources = SourceBL.findAllSources();

                cboSources.DataSource = lstSources;
                cboSources.DisplayMember = "Description";
                cboSources.ValueMember = "Identifier";
            }

            private bool checkDataFields()
            {
                bool isOK = true;

                errData.SetError(txtName, string.Empty);
                errData.SetError(txtSurname1, string.Empty);
                errData.SetError(radMale, string.Empty);
                errData.SetError(radFemale, string.Empty);
                errData.SetError(cboPhysios, string.Empty);

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    errData.SetError(txtName, "Proporcionar Nombre");
                    isOK = false;
                }

                if (string.IsNullOrWhiteSpace(txtSurname1.Text))
                {
                    errData.SetError(txtSurname1, "Proporcionar Primer Apellido");
                    isOK = false;
                }

                if (!radMale.Checked && !radFemale.Checked)
                {
                    errData.SetError(radMale, "Proporcionar Sexo");
                    errData.SetError(radFemale, "Proporcionar Sexo");
                    isOK = false;
                }

                if (cboPhysios.SelectedItem == null)
                {
                    errData.SetError(cboPhysios, "Proporcionar Fisioterapeuta");
                    isOK = false;
                }

                return isOK; 
            }
        #endregion


        #region ADDRESS
            private void populateProvinces()
            {
                List<Province> lstProvinces = GeographyBL.findAllProvinces();

                cboProvinces.DataSource = lstProvinces;
                cboProvinces.DisplayMember = "Name";
                cboProvinces.ValueMember = "Identifier";
            }

            private void bindAddressControls()
            {
                BindingSource bs = new BindingSource(patientDetails.Address, null);

                txtThoroughfare.DataBindings.Add("Text", bs, "Thoroughfare", true, DataSourceUpdateMode.OnPropertyChanged);
                txtNumber.DataBindings.Add("Text", bs, "Number", true, DataSourceUpdateMode.OnPropertyChanged);
                txtBlock.DataBindings.Add("Text", bs, "Block", true, DataSourceUpdateMode.OnPropertyChanged);
                txtStair.DataBindings.Add("Text", bs, "Stair", true, DataSourceUpdateMode.OnPropertyChanged);
                txtFloor.DataBindings.Add("Text", bs, "Floor", true, DataSourceUpdateMode.OnPropertyChanged);
                txtGate.DataBindings.Add("Text", bs, "Gate", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPostCode.DataBindings.Add("Text", bs, "PostCode", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPhone1.DataBindings.Add("Text", bs, "Phone1", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPhone2.DataBindings.Add("Text", bs, "Phone2", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPhone3.DataBindings.Add("Text", bs, "Phone3", true, DataSourceUpdateMode.OnPropertyChanged);
                txtEmail.DataBindings.Add("Text", bs, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWeb.DataBindings.Add("Text", bs, "Web", true, DataSourceUpdateMode.OnPropertyChanged);
                txtCity.DataBindings.Add("Text", bs, "City", true, DataSourceUpdateMode.OnPropertyChanged);

                if (patientDetails.Address.Province == null)
                {
                    cboProvinces.SelectedItem = null;
                }
                else
                {
                    cboProvinces.SelectedValue = patientDetails.Address.Province.Identifier;
                }

                //cboPhysios.SelectedValue = patientDetails.Physiotherapist.Identifier;
            }
        #endregion


        #region CANCELLATIONS

            private Cancellation selCancellation;
            private Maintenance cancellationOperation;

            List<Cancellation> Cancellations;

            private void dgvCancellations_SelectionChanged(object sender, EventArgs e)
            {
                foreach (DataGridViewRow canc in dgvCancellations.SelectedRows)
                {
                    selCancellation.Identifier = Convert.ToInt32(canc.Cells["Identifier"].Value);
                    selCancellation.Date = Convert.ToDateTime(canc.Cells["Date"].Value);
                    selCancellation.Reason = canc.Cells["Reason"].Value.ToString();
                }
            }

            private void btnCancAdd_Click(object sender, EventArgs e)
            {
                prepareCancellationCreation();
            }

            private void btnCancSave_Click(object sender, EventArgs e)
            {
                bool isOK = checkCancFields();

                if (isOK)
                {
                    saveCancellation();
                }
            }

            private void btnCancCancel_Click(object sender, EventArgs e)
            {
                if (cancellationOperation.Equals(Maintenance.Create))
                {
                    dgvCancellations.Enabled = true;
                    btnCancCancel.Visible = false;
                    dgvCancellations.CurrentRow.Selected = false;
                    dgvCancellations.CurrentRow.Selected = true;

                    cancellationOperation = Maintenance.Edit;
                }
            }




            private void initCancellations()
            {
                this.selCancellation = new Cancellation();

                //this.Cancellations = CancellationBL.findAllCancellations(this.patientDetails.Identifier);

                if (this.patientDetails.Cancellations.Count == 0)
                {
                    prepareCancellationCreation();
                }
                else
                {
                    cancellationOperation = Maintenance.Edit;
                    populateCancellationsGrid(this.patientDetails.Cancellations);
                }

                bindCancellationControls();
            }

            private void populateCancellationsGrid(List<Cancellation> lstCancellations)
            {
                SortableBindingList<Cancellation> sblCancellations = new SortableBindingList<Cancellation>(lstCancellations);

                dgvCancellations.DataSource = sblCancellations;

                dgvCancellations.Columns["Identifier"].Visible = false;
            }

            private void bindCancellationControls()
            {
                BindingSource bs = new BindingSource(selCancellation, null);

                dtpCancDate.DataBindings.Add("Value", bs, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
                txtCancReason.DataBindings.Add("Text", bs, "Reason", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            private void prepareCancellationCreation()
            {
                cancellationOperation = Maintenance.Create;

                dgvCancellations.Enabled = false;

                resetCancellation();

                btnCancCancel.Visible = true;
            }

            private void resetCancellation()
            {
                dtpCancDate.Value = DateTime.Today;
                txtCancReason.Text = string.Empty;
            }

            private bool checkCancFields()
            {
                bool isOK = true;

                errCancellations.SetError(txtCancReason, string.Empty);

                if (string.IsNullOrWhiteSpace(txtCancReason.Text))
                {
                    errCancellations.SetError(txtCancReason, "Proporcionar Motivo anulación");
                    isOK = false;
                }

                return isOK;
            }

            private void saveCancellation()
            {
                Cancellation canc = new Cancellation()
                {
                    Date = dtpCancDate.Value,
                    Reason = txtCancReason.Text.Trim()
                };

                bool saveOK = false;

                switch (cancellationOperation)
                {
                    case Maintenance.Create:
                        saveOK = CancellationBL.addCancellation(canc, patientDetails.Identifier);
                        break;
                    case Maintenance.Edit:
                        canc.Identifier = selCancellation.Identifier;
                        saveOK = CancellationBL.modifyCancellation(canc);
                        break;
                }


                if (saveOK)
                {
                    List<Cancellation> lstCancellations = CancellationBL.findAllCancellations(patientDetails.Identifier);

                    populateCancellationsGrid(lstCancellations);

                    if (cancellationOperation.Equals(Maintenance.Create))
                    {
                        dgvCancellations.Enabled = true;
                        btnCancCancel.Visible = false;
                        cancellationOperation = Maintenance.Edit;
                    }
                }
            }
        #endregion


        #region OBSERVATIONS

            private Observation selObservation;
            private Maintenance observationOperation;


            private void dgvObservations_SelectionChanged(object sender, EventArgs e)
            {
                foreach (DataGridViewRow obs in dgvObservations.SelectedRows)
                {
                    selObservation.Identifier = Convert.ToInt32(obs.Cells["Identifier"].Value);
                    selObservation.Description = obs.Cells["Description"].Value.ToString();
                }
            }

            private void btnObsAdd_Click(object sender, EventArgs e)
            {
                prepareObservationCreation();
            }

            private void btnObsSave_Click(object sender, EventArgs e)
            {
                bool isOK = checkObsFields();

                if (isOK)
                {
                    saveObservation();
                }
            }

            private void btnObsCancel_Click(object sender, EventArgs e)
            {
                if (observationOperation.Equals(Maintenance.Create))
                {
                    dgvObservations.Enabled = true;
                    btnObsCancel.Visible = false;
                    dgvObservations.CurrentRow.Selected = false;
                    dgvObservations.CurrentRow.Selected = true;

                    observationOperation = Maintenance.Edit;
                }
            }


            private void initObservations()
            {
                this.selObservation = new Observation();

                //this.Cancellations = CancellationBL.findAllCancellations(this.patientDetails.Identifier);

                if (this.patientDetails.Observations.Count == 0)
                {
                    prepareObservationCreation();
                }
                else
                {
                    observationOperation = Maintenance.Edit;
                    populateObservationsGrid(this.patientDetails.Observations);
                }

                bindObservationControls();
            }

            private void populateObservationsGrid(List<Observation> lstObservations)
            {
                SortableBindingList<Observation> sblObservations = new SortableBindingList<Observation>(lstObservations);

                dgvObservations.DataSource = sblObservations;

                dgvObservations.Columns["Identifier"].Visible = false;
            }

            private void bindObservationControls()
            {
                BindingSource bs = new BindingSource(selObservation, null);

                txtObsDescription.DataBindings.Add("Text", bs, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            private void prepareObservationCreation()
            {
                observationOperation = Maintenance.Create;

                dgvObservations.Enabled = false;

                resetObservation();

                btnObsCancel.Visible = true;
            }

            private void resetObservation()
            {
                txtObsDescription.Text = string.Empty;
            }

            private bool checkObsFields()
            {
                bool isOK = true;

                errObservations.SetError(txtObsDescription, string.Empty);

                if (string.IsNullOrWhiteSpace(txtObsDescription.Text))
                {
                    errObservations.SetError(txtObsDescription, "Proporcionar Descripción observación");
                    isOK = false;
                }

                return isOK;
            }

            private void saveObservation()
            {
                Observation obs = new Observation()
                {
                    Description = txtObsDescription.Text.Trim()
                };

                bool saveOK = false;
                
                switch (observationOperation)
                {
                    case Maintenance.Create:
                        saveOK = ObservationBL.addObservation(obs, patientDetails.Identifier);
                        break;
                    case Maintenance.Edit:
                        obs.Identifier = selObservation.Identifier;
                        saveOK = ObservationBL.modifyObservation(obs);
                        break;
                }


                if (saveOK)
                {
                    List<Observation> lstObservations = ObservationBL.findObservationsByPatient(patientDetails.Identifier);

                    populateObservationsGrid(lstObservations);

                    if (observationOperation.Equals(Maintenance.Create))
                    {
                        dgvObservations.Enabled = true;
                        btnObsCancel.Visible = false;
                        observationOperation = Maintenance.Edit;
                    }
                }
            }
        #endregion


        #region TREATMENTS
            private Treatment selTreatment;
            private Maintenance treatmentOperation;


            private void dgvTreatments_SelectionChanged(object sender, EventArgs e)
            {
                foreach (DataGridViewRow treat in dgvTreatments.SelectedRows)
                {
                    selTreatment.Identifier = Convert.ToInt32(treat.Cells["Identifier"].Value);
                    selTreatment.Date = Convert.ToDateTime(treat.Cells["Date"].Value);
                    selTreatment.Description = treat.Cells["Description"].Value.ToString();
                    selTreatment.Sessions = Convert.ToInt16(treat.Cells["Sessions"].Value);
                }
            }

            private void dgvTreatments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    treatmentOperation = Maintenance.Edit;
                    launchTreatmentDetails();
                }
            }

            private void btnTreatsAdd_Click(object sender, EventArgs e)
            {
                treatmentOperation = Maintenance.Create;
                launchTreatmentDetails();
            }


            private void initTreatments()
            {
                //treatmentOperation = Maintenance.Edit;

                this.selTreatment = new Treatment();

                populatePatientGrid(this.patientDetails.Treatments);
            }

            private void populatePatientGrid(List<Treatment> lstTreatments)
            {
                SortableBindingList<Treatment> sblTreatments = new SortableBindingList<Treatment>(lstTreatments);

                dgvTreatments.DataSource = sblTreatments;

                dgvTreatments.Columns["Identifier"].Visible = false;
                dgvTreatments.Columns["Status"].Visible = false;
                dgvTreatments.Columns["Location"].Visible = false;
                dgvTreatments.Columns["Lesion"].Visible = false;
                dgvTreatments.Columns["Physiotherapist"].Visible = false;

                dgvTreatments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                dgvTreatments.Columns["Date"].Width = 120;
                dgvTreatments.Columns["Description"].Width = 170;
                dgvTreatments.Columns["Paid"].Width = 70;
                dgvTreatments.Columns["Debt"].Width = 70;
                dgvTreatments.Columns["Sessions"].Width = 70;
                dgvTreatments.Columns["PhysiotherapistName"].Width = 70;
            }


            private void launchTreatmentDetails()
            {
                switch (this.treatmentOperation)
                {
                    case Maintenance.Create:
                        selTreatment = new Treatment()
                        {
                            Identifier = 0,
                            Date = DateTime.Today
                        };

                        break;
                    case Maintenance.Edit:
                        foreach (DataGridViewRow treat in dgvTreatments.SelectedRows)
                        {
                            Lesion treatLes = (Lesion)treat.Cells["Lesion"].Value;
                            Location treatLoc = (Location)treat.Cells["Location"].Value;
                            Physiotherapist treatPhysio = (Physiotherapist)treat.Cells["Physiotherapist"].Value;
                            TreatmentStatus treatStat = (TreatmentStatus)treat.Cells["Status"].Value;

                            selTreatment = new Treatment()
                            {
                                Identifier = Convert.ToInt32(treat.Cells["Identifier"].Value),
                                Date = Convert.ToDateTime(treat.Cells["Date"].Value),
                                Description = treat.Cells["Description"].Value.ToString(),
                                Sessions = Convert.ToInt16(treat.Cells["Sessions"].Value),
                                Location = treatLoc,
                                Lesion = treatLes,
                                Physiotherapist = treatPhysio,
                                Status = treatStat
                            };
                        }

                        break;
                }

                frmTreatment frmPatientTreatment = new frmTreatment();
                frmPatientTreatment.patientTreatment = selTreatment;
                frmPatientTreatment.treatmentOperation = this.treatmentOperation;
                frmPatientTreatment.idPatient = patientDetails.Identifier;

                if (frmPatientTreatment.ShowDialog() == DialogResult.OK)
                {
                    this.patientDetails.Treatments = TreatmentBL.findTreatmentsByPatient(patientDetails.Identifier);

                    Patient pat = GlobalVars.Patients.Single(p => p.Identifier == this.patientDetails.Identifier);
                    pat.Treatments = this.patientDetails.Treatments;

                    initTreatments();
                }
            }
        #endregion


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isOK = checkDataFields();

            if (isOK)
            {
                savePatient();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            
            if (this.hasChanged)
            {
                if (MessageBox.Show("Se han efectuado cambios en el Paciente, ¿quieres guardarlos?", "Ficha Paciente", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bool isOK = checkDataFields();

                    if (isOK)
                    {
                        savePatient();
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }


        private void populatePhysios()
        {
            List<Physiotherapist> lstPhysios = PhysioBL.findAllPhysios();

            cboPhysios.DataSource = lstPhysios;
            cboPhysios.DisplayMember = "Alias";
            cboPhysios.ValueMember = "Identifier";
        }


        private void savePatient()
        {
            patientDetails.DateOfBirth = dtpBirthDate.Checked ? dtpBirthDate.Value : Constants.NULL_DATE;
            patientDetails.Gender = radMale.Checked ? 'H' : 'M';
            patientDetails.Physiotherapist = (Physiotherapist)cboPhysios.SelectedItem;

            if (cboSources.SelectedItem != null)
            {
                patientDetails.Source = (Source)cboSources.SelectedItem;
            }


            bool saveOK = PatientBL.savePatient(patientDetails);

            if (saveOK)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }



        private void txtName_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtSurname1_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtSurname2_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtIdentification_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void dtpEntryDate_ValueChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtHowHeardAboutUs_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void cboSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void cboPhysios_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtThoroughfare_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtBlock_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtStair_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtFloor_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtGate_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtPostCode_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void cboProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtPhone2_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtPhone3_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void txtWeb_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        

        

        


    }
}
