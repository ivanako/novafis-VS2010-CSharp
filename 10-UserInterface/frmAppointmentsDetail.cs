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
using System.Diagnostics;

namespace UserInterface
{
    public partial class frmAppointmentsDetail : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetKeyState(Keys key);

        public frmAppointmentsDetail()
        {
            InitializeComponent();
        }

        internal Appointment appDetails;
        internal Maintenance appOperation;

        private bool hasChanged;


        private void frmAppointmentsDetail_Load(object sender, EventArgs e)
        {
            populatePhysios();

            bindAppControls();
        }

        private void txtAppPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && GetKeyState(Keys.Enter) < 0)
            {
                managePatientField(true);
            }
        }
        private void txtAppPatient_Leave(object sender, EventArgs e)
        {
            if (txtAppPatient.TabStop)
            {
                Patient pat = GlobalVars.Patients.Where(p => p.FullName.Equals(txtAppPatient.Text)).FirstOrDefault<Patient>();

                bool hasPatient = (pat != null);

                managePatientField(hasPatient);
            }
        }
        private void btnAppDelPatient_Click(object sender, EventArgs e)
        {
            txtAppPatient.Text = string.Empty;
            txtAppPatient.Tag = null;
            //txtAppPatient.ReadOnly = false;

            //btnAppDelPatient.Enabled = false;

            managePatientField(false);
        }

        private void btnAppPatient_Click(object sender, EventArgs e)
        {
            int patId = this.appDetails.Patient.Identifier;

            Address patAddress = AddressBL.findOneAddress(patId);
            List<Cancellation> patCancellations = CancellationBL.findAllCancellations(patId);
            List<Observation> patObservations = ObservationBL.findObservationsByPatient(patId);
            List<Treatment> patTreatments = TreatmentBL.findTreatmentsByPatient(patId);

            this.appDetails.Patient.Address = patAddress;
            this.appDetails.Patient.Cancellations = patCancellations;
            this.appDetails.Patient.Observations = patObservations;
            this.appDetails.Patient.Treatments = patTreatments;

            frmPatientsDetail frmPatientDetail = new frmPatientsDetail();
            frmPatientDetail.patientDetails = this.appDetails.Patient;
            frmPatientDetail.patientOperation = Maintenance.Edit;

            if (frmPatientDetail.ShowDialog() == DialogResult.OK)
            {
                GlobalVars.Patients = PatientBL.findAllPatients();
            }
        }

        private void chkAppCancelled_CheckedChanged(object sender, EventArgs e)
        {
            txtAppCancellationReason.ReadOnly = !chkAppCancelled.Checked;
        }

        private void btnAppSave_Click(object sender, EventArgs e)
        {
            bool isOK = checkAppFields();

            if (isOK)
            {
                saveAppointment();
            }
        }
        private void btnAppCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void bindAppControls()
        {
            BindingSource bs = new BindingSource(appDetails, null);

            txtAppDate.DataBindings.Add("Text", bs, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAppTime.DataBindings.Add("Text", bs, "Time", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAppObservation.DataBindings.Add("Text", bs, "Observation", true, DataSourceUpdateMode.OnPropertyChanged);
            chkAppCancelled.DataBindings.Add("Checked", bs, "IsCancelled", true, DataSourceUpdateMode.OnPropertyChanged);
            nudAppPaid.DataBindings.Add("Value", bs, "Paid", true, DataSourceUpdateMode.OnPropertyChanged);
            nudAppDebt.DataBindings.Add("Value", bs, "Debt", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAppCancellationReason.DataBindings.Add("Text", bs, "CancellationWhy", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAppPatient.DataBindings.Add("Text", bs, "Patient.FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAppPatient.DataBindings.Add("Tag", bs, "Patient", true, DataSourceUpdateMode.OnPropertyChanged);

            txtAppPatient.ReadOnly = (this.appDetails.Patient != null);
            btnAppDelPatient.Enabled = (this.appDetails.Patient != null); ;

            txtAppPatient.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAppPatient.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string[] arrPatients = GlobalVars.Patients.Select(p => p.FullName).ToArray();
            AutoCompleteStringCollection colPatients = new AutoCompleteStringCollection();
            colPatients.AddRange(arrPatients);
            txtAppPatient.AutoCompleteCustomSource = colPatients;

            txtAppCancellationReason.ReadOnly = !this.appDetails.IsCancelled;

            if (this.appDetails.Physiotherapist == null)
            {
                cboAppPhysiotherapists.SelectedItem = null;
            }
            else
            {
                cboAppPhysiotherapists.SelectedValue = this.appDetails.Physiotherapist.Identifier;
            }
        }

        private void populatePhysios()
        {
            //List<Physiotherapist> lstPhysios = PhysioBL.findAllPhysios();

            List<Physiotherapist> lstPhysios = GlobalVars.Physiotherapists
                .Where(p => p.TerminationDate == null)
                .OrderBy(p => p.Identifier)
                .ToList<Physiotherapist>();

            cboAppPhysiotherapists.DataSource = lstPhysios;
            cboAppPhysiotherapists.DisplayMember = "Alias";
            cboAppPhysiotherapists.ValueMember = "Identifier";
        }

        private void managePatientField(bool hasPatient)
        {
            if (hasPatient)
            {
                Patient pat = GlobalVars.Patients.Where(p => p.FullName.Equals(txtAppPatient.Text)).First<Patient>();
                txtAppPatient.Tag = pat;
                cboAppPhysiotherapists.SelectedValue = pat.Physiotherapist.Identifier;

                if (pat.BlackList)
                {
                    btnAppPatient.ForeColor = Color.Red;
                }
            }
            else
            {
                cboAppPhysiotherapists.SelectedItem = null;
                btnAppPatient.ForeColor = SystemColors.ControlText;
            }

            txtAppPatient.ReadOnly = hasPatient;
            txtAppPatient.TabStop = !hasPatient;

            btnAppDelPatient.Enabled = hasPatient;
            btnAppPatient.Enabled = hasPatient;
        }

        private bool checkAppFields()
        {
            bool isOK = true;

            errAppDetail.SetError(txtAppPatient, string.Empty);
            errAppDetail.SetError(cboAppPhysiotherapists, string.Empty);

            if (string.IsNullOrWhiteSpace(txtAppPatient.Text))
            {
                errAppDetail.SetError(txtAppPatient, "Proporcionar Paciente");
                isOK = false;
            }

            if (cboAppPhysiotherapists.SelectedItem == null)
            {
                errAppDetail.SetError(cboAppPhysiotherapists, "Proporcionar Fisioterapeuta");
                isOK = false;
            }

            return isOK;
        }


        private void saveAppointment()
        {
            this.appDetails.Physiotherapist = (Physiotherapist)cboAppPhysiotherapists.SelectedItem;

            bool saveOK = AppointmentBL.saveAppointment(this.appDetails);

            if (saveOK)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        

        
        
    }
}