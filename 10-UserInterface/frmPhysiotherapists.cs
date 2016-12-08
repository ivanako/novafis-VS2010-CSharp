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
using System.Reflection;

namespace UserInterface
{
    public partial class frmPhysiotherapists : Form
    {
        public frmPhysiotherapists()
        {
            InitializeComponent();
        }


        private Physiotherapist selPhysio;
        private Maintenance physioOperation;

        private void frmPhysiotherapists_Load(object sender, EventArgs e)
        {
            initLoad();
        }

        private void dgvPhysios_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow phy in dgvPhysios.SelectedRows)
            {
                selPhysio.Identifier = Convert.ToInt32(phy.Cells["Identifier"].Value);
                selPhysio.Name = phy.Cells["Name"].Value.ToString();
                selPhysio.Surname1 = phy.Cells["Surname1"].Value.ToString();
                selPhysio.Surname2 = phy.Cells["Surname1"].Value.ToString();
                selPhysio.LicenseNumber = phy.Cells["LicenseNumber"].Value.ToString();
                selPhysio.Alias = phy.Cells["Alias"].Value.ToString();
                selPhysio.Identification = phy.Cells["Identification"].Value.ToString();
                selPhysio.EntryDate = Convert.ToDateTime(phy.Cells["EntryDate"].Value);
                selPhysio.TerminationDate = Convert.ToDateTime(phy.Cells["TerminationDate"].Value);
                selPhysio.Gender = phy.Cells["Gender"].Value.ToString()[0];
                selPhysio.Colour = phy.Cells["Colour"].Value.ToString();

                DateTime termDate = selPhysio.TerminationDate ?? DateTime.Today;

                dtpTerminationDate.Value = selPhysio.TerminationDate.Equals(DateTime.MinValue) ? DateTime.Today : termDate;
                dtpTerminationDate.Checked = !selPhysio.TerminationDate.Equals(DateTime.MinValue);

                radMale.Checked = selPhysio.Gender.Equals(radMale.Tag.ToString()[0]);
                radFemale.Checked = selPhysio.Gender.Equals(radFemale.Tag.ToString()[0]);

                pcbColour.BackColor = ColorTranslator.FromHtml(selPhysio.Colour);
                pcbColour.Tag = selPhysio.Colour;
            }
        }

        private void dgvPhysios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvPhysios.Columns["Colour"].Index)
            {
                dgvPhysios.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorTranslator.FromHtml(e.Value.ToString());
                dgvPhysios.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = ColorTranslator.FromHtml(e.Value.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            physioOperation = Maintenance.Create;

            dgvPhysios.Enabled = false;

            resetPhysio();

            btnCancel.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<Physiotherapist> lstPhysios = PhysioBL.findAllPhysios();

            populatePhysioGrid(lstPhysios);
        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();

            if (cld.ShowDialog() == DialogResult.OK)
            {
                Color selColour = cld.Color;
                pcbColour.BackColor = selColour;
                pcbColour.Tag = string.Format("#{0:x6}", selColour.ToArgb() & 0x00FFFFFF).ToUpper();
                //if (selColour.IsKnownColor || selColour.IsNamedColor)
                //{
                //    pcbColour.Tag = string.Format("#{0:x6}", selColour.ToArgb() & 0x00FFFFFF);
                //}
                //else
                //{
                //    pcbColour.Tag = ColorTranslator.ToHtml(selColour);
                //}
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isOK = checkFields();

            if (isOK)
            {
                savePhysio();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            switch (physioOperation)
            { 
                case Maintenance.Create:
                    dgvPhysios.Enabled = true;
                    btnCancel.Visible = false;
                    dgvPhysios.CurrentRow.Selected = false;
                    dgvPhysios.CurrentRow.Selected = true;
                    break;
                case Maintenance.Edit:
                    break;
            }
        }




        private void initLoad()
        {
            physioOperation = Maintenance.Edit;

            this.selPhysio = new Physiotherapist();

            List<Physiotherapist> lstPhysios = PhysioBL.findAllPhysios();

            populatePhysioGrid(lstPhysios);

            bindControls();
        }

        private void populatePhysioGrid(List<Physiotherapist> lstPhysios)
        {
            SortableBindingList<Physiotherapist> sblPhysios = new SortableBindingList<Physiotherapist>(lstPhysios);

            dgvPhysios.DataSource = sblPhysios;

            dgvPhysios.Columns["Identifier"].Visible = false;
            dgvPhysios.Columns["Name"].Visible = false;
            dgvPhysios.Columns["Surname1"].Visible = false;
            dgvPhysios.Columns["Surname2"].Visible = false;
            dgvPhysios.Columns["Gender"].Visible = false;

            dgvPhysios.Columns["FullName"].DisplayIndex = 0;

            lblIdValue.Visible = true;
        }


        private void bindControls()
        {
            BindingSource bs = new BindingSource(selPhysio, null);

            lblIdValue.DataBindings.Add("Text", bs, "Identifier", true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", bs, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSurname1.DataBindings.Add("Text", bs, "Surname1", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSurname2.DataBindings.Add("Text", bs, "Surname2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIdentification.DataBindings.Add("Text", bs, "Identification", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLicNumber.DataBindings.Add("Text", bs, "LicenseNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAlias.DataBindings.Add("Text", bs, "Alias", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpEntryDate.DataBindings.Add("Value", bs, "EntryDate", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        
        private void resetPhysio()
        {
            txtLicNumber.Text = string.Empty;
            txtIdentification.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSurname1.Text = string.Empty;
            txtSurname2.Text = string.Empty;
            txtAlias.Text = string.Empty;
            dtpEntryDate.Value = DateTime.Today;
            dtpTerminationDate.Value = DateTime.Today;
            dtpTerminationDate.Checked = false;
            radMale.Checked = false;
            radFemale.Checked = false;
            pcbColour.BackColor = Color.FromKnownColor(KnownColor.Control);
            pcbColour.Tag = string.Empty;

            lblIdValue.Text = string.Empty;
            lblIdValue.Visible = false;
        }


        private bool checkFields()
        {
            bool isOK = true;

            errPhysios.SetError(txtName, string.Empty);
            errPhysios.SetError(txtSurname1, string.Empty);
            errPhysios.SetError(txtAlias, string.Empty);
            errPhysios.SetError(pcbColour, string.Empty);

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errPhysios.SetError(txtName, "Proporcionar Nombre");
                isOK = false;
            }
            if (string.IsNullOrWhiteSpace(txtSurname1.Text))
            {
                errPhysios.SetError(txtSurname1, "Proporcionar Primer Apellido");
                isOK = false;
            }
            if (string.IsNullOrWhiteSpace(txtAlias.Text))
            {
                errPhysios.SetError(txtAlias, "Proporcionar Alias");
                isOK = false;
            }
            if (string.IsNullOrWhiteSpace(pcbColour.Tag.ToString()))
            {
                errPhysios.SetIconAlignment(pcbColour, ErrorIconAlignment.MiddleLeft);
                errPhysios.SetError(pcbColour, "Proporcionar Color");
                isOK = false;
            }

            return isOK;
        }


        private void savePhysio() 
        {
            Physiotherapist phys = new Physiotherapist()
            {
                Name = txtName.Text.Trim(),
                Surname1 = txtSurname1.Text.Trim(),
                Surname2 = txtSurname2.Text.Trim(),
                Alias = txtAlias.Text.Trim(),
                Identification = txtIdentification.Text.Trim(),
                LicenseNumber = txtLicNumber.Text.Trim(),
                EntryDate = dtpEntryDate.Value,
                TerminationDate = dtpTerminationDate.Checked ? dtpTerminationDate.Value : Constants.NULL_DATE,
                Colour = pcbColour.Tag.ToString()
            };

            if (radMale.Checked || radFemale.Checked)
            {
                phys.Gender = radMale.Checked ? 'H' : 'M';
            }
            

            if (physioOperation == Maintenance.Edit)
            {
                phys.Identifier = Convert.ToInt32(lblIdValue.Text);
            }

            List<Physiotherapist> lstPhysios = PhysioBL.savePhysio(phys);

            if (lstPhysios.Count == 0)
            {
                MessageBox.Show("Color repetido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                populatePhysioGrid(lstPhysios);

                if (physioOperation.Equals(Maintenance.Create))
                {
                    dgvPhysios.Enabled = true;
                    btnCancel.Visible = false;
                    physioOperation = Maintenance.Edit;
                }
            }
        }

    }
}
