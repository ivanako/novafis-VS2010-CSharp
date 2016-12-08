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
    public partial class frmLocsLes : Form
    {
        public frmLocsLes()
        {
            InitializeComponent();
        }

        private void frmLocsLes_Load(object sender, EventArgs e)
        {
            initLocations();
            initLesions();
        }


        #region LOCATIONS
            private Maintenance locOperation;
            private Location selLoc;



            private void dgvLocations_SelectionChanged(object sender, EventArgs e)
            {
                foreach (DataGridViewRow loc in dgvLocations.SelectedRows)
                {
                    selLoc.Identifier = Convert.ToInt32(loc.Cells["Identifier"].Value);
                    selLoc.Description = loc.Cells["Description"].Value.ToString();
                }
            }

            private void btnNew_Click(object sender, EventArgs e)
            {
                locOperation = Maintenance.Create;

                dgvLocations.Enabled = false;

                resetLocation();

                btnCancelLocation.Visible = true;
            }

            private void btnRefresh_Click(object sender, EventArgs e)
            {
                List<Location> lstLocations = LocationBL.findAllLocations();

                populateLocationGrid(lstLocations);
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                bool isOK = checkLocationFields();

                if (isOK)
                {
                    saveLocation();
                }
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                dgvLocations.Enabled = true;
                btnCancelLocation.Visible = false;
                dgvLocations.CurrentRow.Selected = false;
                dgvLocations.CurrentRow.Selected = true;
            }



            private void initLocations()
            {
                locOperation = Maintenance.Edit;

                this.selLoc = new Location();

                List<Location> lstLocations = LocationBL.findAllLocations();

                populateLocationGrid(lstLocations);

                bindLocationControls();
            }

            private void populateLocationGrid(List<Location> lstLocations)
            {
                SortableBindingList<Location> sblLocations = new SortableBindingList<Location>(lstLocations);

                dgvLocations.DataSource = sblLocations;

                dgvLocations.Columns["Identifier"].Visible = false;
            }

            private void bindLocationControls()
            {
                BindingSource bs = new BindingSource(selLoc, null);

                txtLocation.DataBindings.Add("Text", bs, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            private void resetLocation()
            {
                txtLocation.Text = string.Empty;
            }

            private bool checkLocationFields()
            {
                bool isOK = true;

                errLocsLes.SetError(txtLocation, string.Empty);

                if (string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    errLocsLes.SetError(txtLocation, "Proporcionar Localización");
                    isOK = false;
                }

                return isOK;
            }

            private void saveLocation()
            {
                Location location = new Location()
                {
                    Description = txtLocation.Text.Trim(),
                };


                if (locOperation.Equals(Maintenance.Edit))
                {
                    location.Identifier = selLoc.Identifier;
                }

                List<Location> lstLocations = LocationBL.saveLocation(location);

                populateLocationGrid(lstLocations);

                if (locOperation.Equals(Maintenance.Create))
                {
                    dgvLocations.Enabled = true;
                    btnCancelLocation.Visible = false;
                    locOperation = Maintenance.Edit;
                }
            }
        #endregion


        #region LESIONS
            private Maintenance lesOperation;
            private Lesion selLesion;



            private void dgvLesions_SelectionChanged(object sender, EventArgs e)
            {
                foreach (DataGridViewRow les in dgvLesions.SelectedRows)
                {
                    selLesion.Identifier = Convert.ToInt32(les.Cells["Identifier"].Value);
                    selLesion.Description = les.Cells["Description"].Value.ToString();
                }
            }

            private void btnNewLesion_Click(object sender, EventArgs e)
            {
                lesOperation = Maintenance.Create;

                dgvLesions.Enabled = false;

                resetLesion();

                btnCancelLesion.Visible = true;
            }

            private void btnRefreshLesions_Click(object sender, EventArgs e)
            {
                List<Lesion> lstLesions = LesionBL.findAllLesions();

                populateLesionGrid(lstLesions);
            }

            private void btnSaveLesion_Click(object sender, EventArgs e)
            {
                bool isOK = checkLesionFields();

                if (isOK)
                {
                    saveLesion();
                }
            }

            private void btnCancelLesion_Click(object sender, EventArgs e)
            {
                dgvLesions.Enabled = true;
                btnCancelLesion.Visible = false;
                dgvLesions.CurrentRow.Selected = false;
                dgvLesions.CurrentRow.Selected = true;
            }



            private void initLesions()
            {
                lesOperation = Maintenance.Edit;

                this.selLesion = new Lesion();

                List<Lesion> lstLesions = LesionBL.findAllLesions();

                populateLesionGrid(lstLesions);

                bindLesionControls();
            }

            private void populateLesionGrid(List<Lesion> lstLocations)
            {
                SortableBindingList<Lesion> sblLesions = new SortableBindingList<Lesion>(lstLocations);

                dgvLesions.DataSource = sblLesions;

                dgvLesions.Columns["Identifier"].Visible = false;
            }

            private void bindLesionControls()
            {
                BindingSource bs = new BindingSource(selLesion, null);

                txtLesion.DataBindings.Add("Text", bs, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            private void resetLesion()
            {
                txtLesion.Text = string.Empty;
            }

            private bool checkLesionFields()
            {
                bool isOK = true;

                errLocsLes.SetError(txtLesion, string.Empty);

                if (string.IsNullOrWhiteSpace(txtLesion.Text))
                {
                    errLocsLes.SetError(txtLesion, "Proporcionar Lesión");
                    isOK = false;
                }

                return isOK;
            }

            private void saveLesion()
            {
                Lesion lesion = new Lesion()
                {
                    Description = txtLesion.Text.Trim(),
                };


                if (lesOperation == Maintenance.Edit)
                {
                    lesion.Identifier = selLesion.Identifier;
                }

                List<Lesion> lstLesions = LesionBL.saveLesion(lesion);

                populateLesionGrid(lstLesions);

                if (lesOperation.Equals(Maintenance.Create))
                {
                    dgvLesions.Enabled = true;
                    btnCancelLesion.Visible = false;
                    lesOperation = Maintenance.Edit;
                }
            }
        #endregion


    }
}
