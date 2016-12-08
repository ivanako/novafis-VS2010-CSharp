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
    public partial class frmTreatment : Form
    {
        public frmTreatment()
        {
            InitializeComponent();
        }

        internal Treatment patientTreatment;
        internal Maintenance treatmentOperation;
        internal int idPatient;

        private bool hasChanged;

        private void frmTreatment_Load(object sender, EventArgs e)
        {
            populateStatuses();
            populatePhysios();
            populateLocations();
            populateLesions();

            bindDataControls();

            this.hasChanged = false;
        }

        private void radLocSelect_CheckedChanged(object sender, EventArgs e)
        {
            cboLocations.Enabled = radLocSelect.Checked;
            txtLocation.Enabled = !radLocSelect.Checked;
        }
        private void radLocNew_CheckedChanged(object sender, EventArgs e)
        {
            cboLocations.Enabled = !radLocNew.Checked;
            txtLocation.Enabled = radLocNew.Checked;
        }

        private void radLesSelect_CheckedChanged(object sender, EventArgs e)
        {
            cboLesions.Enabled = radLesSelect.Checked;
            txtLesion.Enabled = !radLesSelect.Checked;
        }
        private void radLesNew_CheckedChanged(object sender, EventArgs e)
        {
            cboLesions.Enabled = !radLesNew.Checked;
            txtLesion.Enabled = radLesNew.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isOK = checkFields();

            if (isOK)
            {
                saveTreatment();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.hasChanged)
            {
                if (MessageBox.Show("Se han efectuado cambios en el Tratamiento, ¿quieres guardarlos?", this.Text, MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bool isOK = checkFields();

                    if (isOK)
                    {
                        saveTreatment();
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



        private void populateStatuses()
        {
            List<TreatmentStatus> lstStatuses = TreatmentStatusBL.findAllStatuses();

            cboStatuses.DataSource = lstStatuses;
            cboStatuses.DisplayMember = "Description";
            cboStatuses.ValueMember = "Identifier";
        }

        private void populatePhysios()
        {
            List<Physiotherapist> lstPhysios = PhysioBL.findAllPhysios();

            cboPhysiotherapists.DataSource = lstPhysios;
            cboPhysiotherapists.DisplayMember = "Alias";
            cboPhysiotherapists.ValueMember = "Identifier";
        }

        private void populateLocations()
        {
            List<Location> lstLocations = LocationBL.findAllLocations();

            cboLocations.DataSource = lstLocations;
            cboLocations.DisplayMember = "Description";
            cboLocations.ValueMember = "Identifier";
        }

        private void populateLesions()
        {
            List<Lesion> lstLesions = LesionBL.findAllLesions();

            cboLesions.DataSource = lstLesions;
            cboLesions.DisplayMember = "Description";
            cboLesions.ValueMember = "Identifier";
        }

        private void bindDataControls()
        {
            BindingSource bs = new BindingSource(patientTreatment, null);

            dtpDate.DataBindings.Add("Value", bs, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescription.DataBindings.Add("Text", bs, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            nudSessions.DataBindings.Add("Value", bs, "Sessions", true, DataSourceUpdateMode.OnPropertyChanged);

            if (patientTreatment.Status == null)
            {
                cboStatuses.SelectedItem = null;
            }
            else
            {
                cboStatuses.SelectedValue = patientTreatment.Status.Identifier;
            }

            if (patientTreatment.Physiotherapist == null)
            {
                cboPhysiotherapists.SelectedItem = null;
            }
            else
            {
                cboPhysiotherapists.SelectedValue = patientTreatment.Physiotherapist.Identifier;
            }

            if (patientTreatment.Location == null)
            {
                radLocNew.Checked = true;
            }
            else
            {
                radLocSelect.Checked = true;
                cboLocations.SelectedValue = patientTreatment.Location.Identifier;
            }

            if (patientTreatment.Lesion == null)
            {
                radLesNew.Checked = true;
            }
            else
            {
                radLesSelect.Checked = true;
                cboLesions.SelectedValue = patientTreatment.Lesion.Identifier;
            }
        }


        private void saveTreatment()
        {
            patientTreatment.Status = (TreatmentStatus)cboStatuses.SelectedItem;
            patientTreatment.Physiotherapist = (Physiotherapist)cboPhysiotherapists.SelectedItem;
            
            

            if (radLocNew.Checked)
            {
                Location newLoc = new Location()
                {
                    Description = txtLocation.Text
                };

                List<Location> lstLocations = LocationBL.saveLocation(newLoc);

                Location loc = lstLocations.OrderBy(l => l.Identifier).LastOrDefault<Location>();

                patientTreatment.Location = loc;
            }
            else
            {
                patientTreatment.Location = (Location)cboLocations.SelectedItem;
            }

            if (radLesNew.Checked)
            {
                Lesion newLes = new Lesion()
                {
                    Description = txtLesion.Text
                };

                List<Lesion> lstLesions = LesionBL.saveLesion(newLes);

                Lesion les = lstLesions.OrderBy(l => l.Identifier).LastOrDefault<Lesion>();

                patientTreatment.Lesion = les;
            }
            else
            {
                patientTreatment.Lesion = (Lesion)cboLesions.SelectedItem;
            }

            bool saveOK = TreatmentBL.saveTreatment(patientTreatment, this.idPatient);

            if (saveOK)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }


        private bool checkFields()
        {
            bool isOK = true;

            errTreatment.SetError(nudSessions, string.Empty);
            errTreatment.SetError(txtDescription, string.Empty);
            errTreatment.SetError(cboStatuses, string.Empty);
            errTreatment.SetError(cboPhysiotherapists, string.Empty);
            errTreatment.SetError(txtLocation, string.Empty);
            errTreatment.SetError(txtLesion, string.Empty);

            if (nudSessions.Value == 0)
            {
                errTreatment.SetError(nudSessions, "Sesiones deben ser mayores que 0");
                isOK = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errTreatment.SetError(txtDescription, "Proporcionar Descripción");
                isOK = false;
            }

            if (treatmentOperation == Maintenance.Create)
            {
                if (cboStatuses.SelectedItem == null)
                {
                    errTreatment.SetError(cboStatuses, "Proporcionar Estado");
                    isOK = false;
                }
                if (cboPhysiotherapists.SelectedItem == null)
                {
                    errTreatment.SetError(cboPhysiotherapists, "Proporcionar Fisioterapeuta");
                    isOK = false;
                }
            }

            if (radLocNew.Checked && string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                errTreatment.SetError(txtLocation, "Proporcionar Localización");
                isOK = false;
            }
            if (radLesNew.Checked && string.IsNullOrWhiteSpace(txtLesion.Text))
            {
                errTreatment.SetError(txtLesion, "Proporcionar Lesión");
                isOK = false;
            }

            return isOK;
        }




        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.hasChanged = true;
        }

        private void cboStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hasChanged = true;
        }

        private void nudSessions_ValueChanged(object sender, EventArgs e)
        {
            this.hasChanged = true;
        }

        private void cboPhysiotherapists_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hasChanged = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            this.hasChanged = true;
        }

        private void cboLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radLocSelect.Checked)
            {
                this.hasChanged = true;
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (radLocNew.Checked)
            {
                this.hasChanged = true;
            }
        }

        private void cboLesions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radLesSelect.Checked) 
            { 
                this.hasChanged = true; 
            }
        }

        private void txtLesion_TextChanged(object sender, EventArgs e)
        {
            if (radLesNew.Checked)
            {
                this.hasChanged = true;
            }
        }

        


        

        
        
    }
}
