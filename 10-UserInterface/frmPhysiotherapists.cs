using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using BusinessLayer;
using Objects;

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
        

        private List<Timetable> TimetablePhysio;
        private List<Invoice> InvoicesPhysio;

        private int physioIndex = 0;

        private void frmPhysiotherapists_Load(object sender, EventArgs e)
        {
            initLoad();
        }

        private void dgvPhysios_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //dgvPhysios.CurrentRow.Cells["Colour"].Style.ForeColor = dgvPhysios.CurrentRow.Cells["Colour"].Style.BackColor;

            foreach (DataGridViewRow phy in dgvPhysios.SelectedRows)
            {
                selPhysio.Identifier = Convert.ToInt32(phy.Cells["Identifier"].Value);
                selPhysio.Name = phy.Cells["Name"].Value.ToString();
                selPhysio.Surname1 = phy.Cells["Surname1"].Value.ToString();
                selPhysio.Surname2 = phy.Cells["Surname2"].Value.ToString();
                selPhysio.LicenseNumber = phy.Cells["LicenseNumber"].Value.ToString();
                selPhysio.Alias = phy.Cells["Alias"].Value.ToString();
                selPhysio.Identification = phy.Cells["Identification"].Value.ToString();
                selPhysio.EntryDate = Convert.ToDateTime(phy.Cells["EntryDate"].Value);
                selPhysio.TerminationDate = Convert.ToDateTime(phy.Cells["TerminationDate"].Value);
                selPhysio.Gender = phy.Cells["Gender"].Value.ToString()[0];
                selPhysio.Colour = phy.Cells["Colour"].Value.ToString();
                selPhysio.IssueInvoice = Convert.ToBoolean(phy.Cells["IssueInvoice"].Value);
                
                DateTime termDate = selPhysio.TerminationDate ?? DateTime.Today;

                dtpTerminationDate.Value = selPhysio.TerminationDate.Equals(DateTime.MinValue) ? DateTime.Today : termDate;
                dtpTerminationDate.Checked = !selPhysio.TerminationDate.Equals(DateTime.MinValue);

                radMale.Checked = selPhysio.Gender.Equals(radMale.Tag.ToString()[0]);
                radFemale.Checked = selPhysio.Gender.Equals(radFemale.Tag.ToString()[0]);

                pcbColour.BackColor = ColorTranslator.FromHtml(selPhysio.Colour);
                pcbColour.Tag = selPhysio.Colour;

                getTimetablePhysio(selPhysio.Identifier);

                if (selPhysio.IssueInvoice)
                {
                    selPhysio.Invoices = InvoiceBL.findInvoicesByPhysio(selPhysio.Identifier);
                }

                //this.physioIndex = phy.Index;
            }

            lblIdValue.Text = this.selPhysio.Identifier.ToString();

            dtpDateBegin.ValueChanged -= dtpDateBegin_ValueChanged;
            dtpDateEnd.ValueChanged -= dtpDateEnd_ValueChanged;

            dtpDateBegin.Checked = false;
            dtpDateEnd.Checked = false;

            dtpDateBegin.ValueChanged += dtpDateBegin_ValueChanged;
            dtpDateEnd.ValueChanged += dtpDateEnd_ValueChanged;

            btnPhyInvoices.Enabled = selPhysio.IssueInvoice;

            


            //((Control)tbpInvoices).Enabled = selPhysio.IssueInvoice;


            //if (selPhysio.IssueInvoice)
            //{
            //    if (!tabDetails.TabPages.Contains(tbpInvoices))
            //    {
            //        tabDetails.TabPages.Add(tbpInvoices);
            //    }
            //}
            //else
            //{
            //    tabDetails.TabPages.Remove(tbpInvoices);
            //}

            this.Cursor = Cursors.Default;
        }

        private void dgvPhysios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvPhysios.Columns["Colour"].Index)
            {
                dgvPhysios.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorTranslator.FromHtml(e.Value.ToString());
                dgvPhysios.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = ColorTranslator.FromHtml(e.Value.ToString());
            }
            //if (dgvPhysios.Rows[e.RowIndex].Selected)
            //{
            //    dgvPhysios.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = dgvPhysios.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor;
            //}
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            physioOperation = Maintenance.Create;

            dgvPhysios.Enabled = false;

            resetPhysio();

            btnCancel.Visible = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.physioIndex = 0;

            //List<Physiotherapist> lstPhysios = PhysioBL.findAllPhysios();
            GlobalVars.Physiotherapists = PhysioBL.findAllPhysios();

            populatePhysioGrid(GlobalVars.Physiotherapists);
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
                    lblIdValue.Visible = true;
                    break;
                case Maintenance.Edit:
                    break;
            }

            errPhysios.SetError(txtLicNumber, string.Empty);
            errPhysios.SetError(txtName, string.Empty);
            errPhysios.SetError(txtSurname1, string.Empty);
            errPhysios.SetError(txtAlias, string.Empty);
            errPhysios.SetError(radMale, string.Empty);
            errPhysios.SetError(radFemale, string.Empty);
            errPhysios.SetError(pcbColour, string.Empty);
        }




        private void initLoad()
        {
            physioOperation = Maintenance.Edit;

            this.selPhysio = new Physiotherapist();

            //List<Physiotherapist> lstPhysios = PhysioBL.findAllPhysios();

            populatePhysioGrid(GlobalVars.Physiotherapists);

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

            if (this.physioIndex > 0)
            {
                dgvPhysios.Rows[this.physioIndex].Selected = true;
            }

            //lblIdValue.Visible = true;
        }


        private void bindControls()
        {
            BindingSource bs = new BindingSource(this.selPhysio, null);

            //lblIdValue.DataBindings.Add("Text", bs, "Identifier", true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", bs, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSurname1.DataBindings.Add("Text", bs, "Surname1", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSurname2.DataBindings.Add("Text", bs, "Surname2", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIdentification.DataBindings.Add("Text", bs, "Identification", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLicNumber.DataBindings.Add("Text", bs, "LicenseNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAlias.DataBindings.Add("Text", bs, "Alias", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpEntryDate.DataBindings.Add("Value", bs, "EntryDate", true, DataSourceUpdateMode.OnPropertyChanged);
            chkInvoice.DataBindings.Add("Checked", bs, "IssueInvoice", true, DataSourceUpdateMode.OnPropertyChanged);
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
            //lblIdValue.Visible = false;

            //this.selPhysio = new Physiotherapist();
        }


        private bool checkFields()
        {
            bool isOK = true;

            errPhysios.SetError(txtLicNumber, string.Empty);
            errPhysios.SetError(txtName, string.Empty);
            errPhysios.SetError(txtSurname1, string.Empty);
            errPhysios.SetError(txtAlias, string.Empty);
            errPhysios.SetError(radMale, string.Empty);
            errPhysios.SetError(radFemale, string.Empty);
            errPhysios.SetError(pcbColour, string.Empty);

            if (string.IsNullOrWhiteSpace(txtLicNumber.Text))
            {
                errPhysios.SetError(txtLicNumber, "Proporcionar Número de Colegiado");
                isOK = false;
            }
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
            if (!radMale.Checked && !radFemale.Checked)
            {
                errPhysios.SetError(radMale, "Proporcionar Sexo");
                errPhysios.SetError(radFemale, "Proporcionar Sexo");
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
            this.physioIndex = dgvPhysios.CurrentRow.Index;

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
                Colour = pcbColour.Tag.ToString(),
                IssueInvoice = chkInvoice.Checked
            };

            if (radMale.Checked || radFemale.Checked)
            {
                phys.Gender = radMale.Checked ? 'H' : 'M';
            }
            

            if (physioOperation == Maintenance.Edit)
            {
                phys.Identifier = Convert.ToInt32(lblIdValue.Text);
            }

            Physiotherapist physio = PhysioBL.savePhysio(phys);
            //GlobalVars.Physiotherapists = PhysioBL.savePhysio(phys);

            if (physio.Identifier == 0 || string.IsNullOrWhiteSpace(physio.Colour))
            {
                MessageBox.Show("Color repetido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.physioOperation == Maintenance.Edit)
                {
                    GlobalVars.Physiotherapists.RemoveAll(p => p.Identifier == phys.Identifier);
                }

                GlobalVars.Physiotherapists.Add(phys);
                //GlobalVars.Physiotherapists = lstPhysios;

                List<Physiotherapist> lstPhysios = GlobalVars.Physiotherapists
                                        .OrderBy(p => p.Alias).ToList<Physiotherapist>();

                //if (this.physioOperation == Maintenance.Create)
                //{
                    populatePhysioGrid(lstPhysios);
                //}

                if (physioOperation.Equals(Maintenance.Create))
                {
                    dgvPhysios.Enabled = true;
                    btnCancel.Visible = false;
                    physioOperation = Maintenance.Edit;
                }
            }
        }


        #region TIMETABLE
            private Timetable selTimetable;
            private Maintenance timetableOperation;
            private int timetableIndex = 0;

            private void dtpDateBegin_ValueChanged(object sender, EventArgs e)
            {
                filterTimetable();
            }
            private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
            {
                filterTimetable();
            }

            private void dgvTimetable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                this.timetableIndex = e.RowIndex;
                this.timetableOperation = Maintenance.Edit;
                launchTimetableDetails();
            }

            private void btnAddTimetable_Click(object sender, EventArgs e)
            {
                this.timetableOperation = Maintenance.Create;
                launchTimetableDetails();
            }

            private void getTimetablePhysio(int idPhysio)
            {
                this.TimetablePhysio = TimetableBL.findAllTimetablesByPhysio(idPhysio);

                populateTimetableGrid(this.TimetablePhysio);
            }

            private void populateTimetableGrid(List<Timetable> lstTimetable)
            {
                SortableBindingList<Timetable> sblTimetables = new SortableBindingList<Timetable>(lstTimetable);

                dgvTimetable.DataSource = sblTimetables;

                dgvTimetable.Columns["Identifier"].Visible = false;
                dgvTimetable.Columns["Physiotherapist"].Visible = false;

                if (this.timetableIndex > 0)
                {
                    dgvTimetable.Rows[this.timetableIndex].Selected = true;
                }
            }

            private void filterTimetable()
            {
                if (dtpDateBegin.Checked || dtpDateEnd.Checked)
                {
                    IEnumerable<Timetable> lstTimetable = this.TimetablePhysio;

                    if (dtpDateBegin.Checked)
                    {
                        lstTimetable = lstTimetable.Where(t => t.Date >= Convert.ToDateTime(dtpDateBegin.Value.ToShortDateString()));
                    }

                    if (dtpDateEnd.Checked)
                    {
                        lstTimetable = lstTimetable.Where(t => t.Date <= Convert.ToDateTime(dtpDateEnd.Value.ToShortDateString()));
                    }

                    populateTimetableGrid(lstTimetable.ToList<Timetable>());
                }
                else
                {
                    populateTimetableGrid(this.TimetablePhysio);
                }
            }

            private void launchTimetableDetails()
            {
                switch (this.timetableOperation)
                {
                    case Maintenance.Create:
                        selTimetable = new Timetable()
                        {
                            Identifier = 0,
                            Date = DateTime.Today,
                            MorningTimeStart = DateTime.Today.AddHours(1).TimeOfDay.ToString(),
                            MorningTimeFinish = DateTime.Today.TimeOfDay.ToString(),
                            MorningDuration = 0,
                            AfternoonTimeStart = DateTime.Today.TimeOfDay.ToString(),
                            AfternoonTimeFinish = DateTime.Today.TimeOfDay.ToString(),
                            AfternoonDuration = 0,
                            Physiotherapist = this.selPhysio
                        };

                        break;
                    case Maintenance.Edit:
                        foreach (DataGridViewRow tmtTable in dgvTimetable.SelectedRows)
                        {
                            selTimetable = new Timetable()
                            {
                                Identifier = Convert.ToInt32(tmtTable.Cells["Identifier"].Value),
                                Date = Convert.ToDateTime(tmtTable.Cells["Date"].Value),
                                MorningTimeStart = tmtTable.Cells["MorningTimeStart"].Value.ToString(),
                                MorningTimeFinish = tmtTable.Cells["MorningTimeFinish"].Value.ToString(),
                                MorningDuration = Convert.ToByte(tmtTable.Cells["MorningDuration"].Value),
                                AfternoonTimeStart = tmtTable.Cells["AfternoonTimeStart"].Value.ToString(),
                                AfternoonTimeFinish = tmtTable.Cells["AfternoonTimeFinish"].Value.ToString(),
                                AfternoonDuration = Convert.ToByte(tmtTable.Cells["AfternoonDuration"].Value),
                                Physiotherapist = this.selPhysio
                            };
                        }

                        break;
                }

                frmTimetable frmTimetable = new frmTimetable();
                frmTimetable.physioTimetable = selTimetable;
                frmTimetable.timetableOperation = this.timetableOperation;


                if (frmTimetable.ShowDialog() == DialogResult.OK)
                {
                    this.TimetablePhysio = TimetableBL.findAllTimetablesByPhysio(this.selPhysio.Identifier);
                    filterTimetable();

                    //getTimetablePhysio(this.selPhysio.Identifier);

                    frmTimetable.Dispose();
                }
            }
        #endregion


        #region INVOICES
            private void btnPhyInvoices_Click(object sender, EventArgs e)
            {
                launchPhysioInvoices();
            }

            private void launchPhysioInvoices()
            {
                frmInvoices frmInvoices = new frmInvoices();

                frmInvoices.physio = this.selPhysio;
                frmInvoices.invoiceOperation = Maintenance.View;

                frmInvoices.ShowDialog();
            }
        #endregion


            //#region INVOICES
        //    private Invoice selInvoice;
        //    private Maintenance invoiceOperation;

        //    private void getInvoices(int idPhysio)
        //    {
        //        this.InvoicesPhysio = InvoiceBL.findInvoicesByPhysio(idPhysio);

        //        populateInvoiceGrid(this.InvoicesPhysio);
        //    }
        //    private void populateInvoiceGrid(List<Invoice> lstInvoices)
        //    {
        //        SortableBindingList<Invoice> sblInvoices = new SortableBindingList<Invoice>(lstInvoices);

        //        dgvPhyInvoices.DataSource = sblInvoices;

        //        dgvPhyInvoices.Columns["Identifier"].Visible = false;
        //        dgvPhyInvoices.Columns["Physio"].Visible = false;
        //    }
        //#endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
            
    }
}
