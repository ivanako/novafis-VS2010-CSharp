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
using System.IO;

namespace UserInterface
{
    public partial class frmInvoices : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetKeyState(Keys key);

        public frmInvoices()
        {
            InitializeComponent();
        }

        internal Physiotherapist physio;
        private List<Invoice> yearInvoices;
        internal Maintenance invoiceOperation;
        private Invoice selInvoice;

        private void frmInvoices_Load(object sender, EventArgs e)
        {
            this.selInvoice = new Invoice();

            populateYears();

            populateInvoiceGrid(Convert.ToInt32(nudInvoiceYear.Value));

            bindInvControls();


            txtInvPatient.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtInvPatient.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string[] arrPatients = GlobalVars.Patients.Where(p => p.Deleted == false).Select(p => p.FullName).ToArray();
            AutoCompleteStringCollection colPatients = new AutoCompleteStringCollection();
            colPatients.AddRange(arrPatients);
            txtInvPatient.AutoCompleteCustomSource = colPatients;


            grbPhyInvoice.Enabled = false;
        }

        private void nudInvoiceYear_ValueChanged(object sender, EventArgs e)
        {
            populateInvoiceGrid(Convert.ToInt32(nudInvoiceYear.Value));
        }

        private void dgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            buildInvoice();

            rdbInvPatient.Checked = (this.selInvoice.Patient != null);
            rdbInvOther.Checked = (this.selInvoice.Patient == null);

            if (this.selInvoice.Patient == null)
            {
                txtInvPatient.Text = string.Empty;
                txtInvPatient.Tag = null;
            }
            else
            {
                txtInvPatient.Text = this.selInvoice.Patient.FullName;
                txtInvPatient.Tag = this.selInvoice.Patient;
            }
        }

        private void btnInvNew_Click(object sender, EventArgs e)
        {
            this.invoiceOperation = Maintenance.Create;

            resetInvControls();

            nudInvoiceYear.Enabled = false;
            dgvInvoices.Enabled = false;
            btnInvNew.Enabled = false;
            btnInvGenerate.Enabled = false;
            grbPhyInvoice.Enabled = true;
        }
        private void btnInvGenerate_Click(object sender, EventArgs e)
        {
            buildInvoice();
            generateInvoiceFile(this.selInvoice);
        }
        private void btnInvClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rdbInvPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (this.invoiceOperation == Maintenance.Create)
            {
                txtInvPatient.ReadOnly = !rdbInvPatient.Checked;
                txtInvPatient.TabStop = rdbInvPatient.Checked;

                if (rdbInvPatient.Checked)
                {
                    txtInvPatient.Focus();
                }

                txtInvOther.Text = string.Empty;
                txtInvOther.TabStop = false;
            }
        }
        private void rdbInvOther_CheckedChanged(object sender, EventArgs e)
        {
            if (this.invoiceOperation == Maintenance.Create)
            {
                txtInvOther.ReadOnly = !rdbInvOther.Checked;
                txtInvOther.TabStop = rdbInvOther.Checked;

                if (rdbInvOther.Checked)
                {
                    txtInvOther.Focus();
                }

                txtInvPatient.Text = string.Empty;
                txtInvPatient.Tag = null;
                txtInvPatient.TabStop = false;
                btnInvDelPatient.Enabled = false;
            }
        }

        private void txtInvPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && GetKeyState(Keys.Enter) < 0)
            {
                managePatientField(true);
            }
        }
        private void txtInvPatient_Leave(object sender, EventArgs e)
        {
            if (txtInvPatient.TabStop)
            {
                Patient pat = GlobalVars.Patients.Where(p => p.FullName.Equals(txtInvPatient.Text.Trim())).FirstOrDefault<Patient>();

                bool hasPatient = (pat != null);

                managePatientField(hasPatient);
            }
        }
        private void btnInvDelPatient_Click(object sender, EventArgs e)
        {
            txtInvPatient.Text = string.Empty;
            txtInvPatient.Tag = null;
            txtInvIdentification.Text = string.Empty;

            managePatientField(false);
        }

        private void btnInvSave_Click(object sender, EventArgs e)
        {
            bool fieldsOK = checkInvFields();

            if (fieldsOK)
            {
                addInvoice();
            }
        }
        private void btnInvCancel_Click(object sender, EventArgs e)
        {
            this.invoiceOperation = Maintenance.View;

            nudInvoiceYear.Enabled = true;

            dgvInvoices.Enabled = true;
            if (dgvInvoices.CurrentRow != null)
            {
                dgvInvoices.CurrentRow.Selected = false;
                dgvInvoices.CurrentRow.Selected = true;
            }
            btnInvNew.Enabled = true;
            btnInvGenerate.Enabled = true;
            grbPhyInvoice.Enabled = false;
        }


        private void populateYears()
        {
            nudInvoiceYear.ValueChanged -= nudInvoiceYear_ValueChanged;

            int minYear = 2010;
            int maxYear = DateTime.Today.Year;

            if (this.physio.Invoices.Count == 0)
            {
                minYear = maxYear;
            }
            else
            {
                var tttt = this.physio.Invoices.Select(i => i.Date.Year).Distinct();

                //int maxYear = this.physio.Invoices.Select(i => i.Date.Year).Distinct().Max<int>();
                minYear = this.physio.Invoices.Select(i => i.Date.Year).Distinct().Min<int>();

                //if (maxYear < DateTime.Today.Year)
                //{
                //    maxYear = DateTime.Today.Year;
                //}
            }

            nudInvoiceYear.Minimum = minYear;
            nudInvoiceYear.Maximum = maxYear;

            nudInvoiceYear.ValueChanged += nudInvoiceYear_ValueChanged;

            nudInvoiceYear.Value = maxYear;
        }

        private void populateInvoiceGrid(int invYear)
        {
            this.yearInvoices = this.physio.Invoices.Where(i => i.Date.Year == invYear).ToList<Invoice>();

            SortableBindingList<Invoice> sblInvoices = new SortableBindingList<Invoice>(this.yearInvoices);

            dgvInvoices.DataSource = sblInvoices;

            dgvInvoices.Columns["Identifier"].Visible = false;
            dgvInvoices.Columns["Identification"].Visible = false;
            dgvInvoices.Columns["Client"].Visible = false;
            dgvInvoices.Columns["Sessions"].Visible = false;
            dgvInvoices.Columns["Treatment"].Visible = false;
            dgvInvoices.Columns["Amount"].Visible = false;
            dgvInvoices.Columns["Patient"].Visible = false;
            dgvInvoices.Columns["Physio"].Visible = false;

            if (this.yearInvoices.Count == 0)
            {
                resetInvControls();
            }
        }

        private void bindInvControls()
        {
            BindingSource bs = new BindingSource(this.selInvoice, null);

            txtInvNumber.DataBindings.Add("Text", bs, "InvoiceNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpInvDate.DataBindings.Add("Value", bs, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            //txtInvPatient.DataBindings.Add("Text", bs, "ClientName", true, DataSourceUpdateMode.OnPropertyChanged);
            //txtInvPatient.DataBindings.Add("Text", bs, "Patient.FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtInvOther.DataBindings.Add("Text", bs, "Client", true, DataSourceUpdateMode.OnPropertyChanged);
            txtInvIdentification.DataBindings.Add("Text", bs, "Identification", true, DataSourceUpdateMode.OnPropertyChanged);
            nudInvSessions.DataBindings.Add("Value", bs, "Sessions", true, DataSourceUpdateMode.OnPropertyChanged);
            nudInvAmount.DataBindings.Add("Value", bs, "Amount", true, DataSourceUpdateMode.OnPropertyChanged);
            txtInvTreatment.DataBindings.Add("Text", bs, "Treatment", true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void resetInvControls()
        {
            txtInvNumber.Text = string.Empty;
            dtpInvDate.Value = DateTime.Today;
            rdbInvPatient.Checked = false;
            txtInvPatient.Text = string.Empty;
            txtInvPatient.Tag = null;
            rdbInvOther.Checked = false;
            txtInvOther.Text = string.Empty;
            txtInvIdentification.Text = string.Empty;
            nudInvSessions.Value = 0;
            nudInvAmount.Value = 0;
            txtInvTreatment.Text = string.Empty;

            this.selInvoice.Patient = new Patient();
        }

        private bool checkInvFields()
        {
            bool isOK = true;

            errInvoices.SetError(rdbInvPatient, string.Empty);
            errInvoices.SetError(rdbInvOther, string.Empty);
            errInvoices.SetError(txtInvPatient, string.Empty);
            errInvoices.SetError(txtInvOther, string.Empty);
            errInvoices.SetError(txtInvIdentification, string.Empty);
            errInvoices.SetError(nudInvSessions, string.Empty);
            errInvoices.SetError(nudInvAmount, string.Empty);
            errInvoices.SetError(txtInvTreatment, string.Empty);

            if (!rdbInvPatient.Checked && !rdbInvOther.Checked)
            {
                errInvoices.SetError(rdbInvPatient, "Seleccionar Paciente u Otro");
                errInvoices.SetError(rdbInvOther, "Seleccionar Paciente u Otro");
                isOK = false;
            }
            if (rdbInvPatient.Checked && string.IsNullOrWhiteSpace(txtInvPatient.Text))
            {
                errInvoices.SetError(txtInvPatient, "Proporcionar Paciente");
                isOK = false;
            }
            if (rdbInvOther.Checked && string.IsNullOrWhiteSpace(txtInvOther.Text))
            {
                errInvoices.SetError(txtInvOther, "Proporcionar Otro");
                isOK = false;
            }
            if (string.IsNullOrWhiteSpace(txtInvIdentification.Text))
            {
                errInvoices.SetError(txtInvIdentification, "Proporcionar Identificación");
                isOK = false;
            }
            if (nudInvSessions.Value == 0)
            {
                errInvoices.SetError(nudInvSessions, "Las Sesiones no puden ser 0");
                isOK = false;
            }
            if (nudInvAmount.Value == 0)
            {
                errInvoices.SetError(nudInvAmount, "El Importe no puden ser 0");
                isOK = false;
            }
            if (string.IsNullOrWhiteSpace(txtInvTreatment.Text))
            {
                errInvoices.SetError(txtInvTreatment, "Proporcionar Tratamiento");
                isOK = false;

            }

            return isOK;
        }

        private void managePatientField(bool hasPatient)
        {
            if (hasPatient)
            {
                Patient pat = GlobalVars.Patients.Where(p => p.FullName.Equals(txtInvPatient.Text)).First<Patient>();
                txtInvPatient.Tag = pat;
                txtInvIdentification.Text = pat.Identification;
            }

            txtInvPatient.ReadOnly = hasPatient;
            txtInvPatient.TabStop = !hasPatient;

            btnInvDelPatient.Enabled = hasPatient;
            //btnAppointment.Enabled = hasPatient;
        }

        private void buildInvoice()
        {
            foreach (DataGridViewRow inv in dgvInvoices.SelectedRows)
            {
                this.selInvoice.Identifier = Convert.ToInt32(inv.Cells["Identifier"].Value);
                this.selInvoice.InvoiceNumber = Convert.ToString(inv.Cells["InvoiceNumber"].Value);
                this.selInvoice.Date = DateTime.Parse(inv.Cells["Date"].Value.ToString());
                this.selInvoice.Patient = (Patient)inv.Cells["Patient"].Value;
                this.selInvoice.Client = Convert.ToString(inv.Cells["Client"].Value);
                this.selInvoice.Identification = Convert.ToString(inv.Cells["Identification"].Value);
                this.selInvoice.Sessions = Convert.ToByte(inv.Cells["Sessions"].Value);
                this.selInvoice.Amount = Convert.ToDouble(inv.Cells["Amount"].Value);
                this.selInvoice.Treatment = Convert.ToString(inv.Cells["Treatment"].Value);
                //this.selInvoice.Patient = (Patient)inv.Cells["Patient"].Value;
                //this.selInvoice.Physio = (Physiotherapist)inv.Cells["Physio"].Value;
            }
        }

        private void addInvoice()
        {
            Invoice inv = new Invoice()
            {
                InvoiceNumber = string.Empty,
                Date = dtpInvDate.Value,
                Identification = txtInvIdentification.Text.Trim().ToUpper(),
                Sessions = Convert.ToByte(nudInvSessions.Value),
                Amount = Convert.ToDouble(nudInvAmount.Value),
                Treatment = txtInvTreatment.Text.Trim().ToUpper(),
                Physio = this.physio
            };

            if (rdbInvPatient.Checked)
            {
                inv.Patient = (Patient)txtInvPatient.Tag;
            }
            if (rdbInvOther.Checked)
            {
                inv.Client = txtInvOther.Text.Trim().ToUpper();
            }

            Invoice newInvoice = InvoiceBL.addInvoice(inv);

            if (string.IsNullOrWhiteSpace(newInvoice.InvoiceNumber))
            {
                MessageBox.Show("La Factura no se ha podido guardar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.invoiceOperation = Maintenance.View;

                this.physio.Invoices.Add(newInvoice);

                populateInvoiceGrid(Convert.ToInt32(nudInvoiceYear.Value));

                nudInvoiceYear.Enabled = true;
                dgvInvoices.Enabled = true;
                btnInvNew.Enabled = true;
                btnInvGenerate.Enabled = true;
                grbPhyInvoice.Enabled = false;

                generateInvoiceFile(newInvoice);
            }
        }

        
        private void generateInvoiceFile(Invoice inv)
        {
            Microsoft.Office.Interop.Word.Application wordApp = null;
            Microsoft.Office.Interop.Word.Document wordDoc = null;

            object _missing = Type.Missing;

            string wordTemplatePath = Application.StartupPath + "\\Factura.dotx";

            if (this.physio.Identifier == 1)
            {
                wordTemplatePath = Application.StartupPath + "\\Factura-novafis.dotx";
            }
            
            try
            {
                // Start Word instance
                wordApp = new Microsoft.Office.Interop.Word.Application();
                // Open template
                wordDoc = wordApp.Documents.Add(wordTemplatePath, _missing, _missing, _missing);

                // Invoice number
                var bm1 = wordDoc.Bookmarks["invNumber"];
                bm1.Range.Text = inv.InvoiceNumber;

                // Client
                var bm2 = wordDoc.Bookmarks["invClient"];
                bm2.Range.Text = inv.ClientName;

                // Identification
                var bm3 = wordDoc.Bookmarks["invIdentification"];
                bm3.Range.Text = inv.Identification;

                // Amount
                var bm4 = wordDoc.Bookmarks["invAmount"];
                bm4.Range.Text = inv.Amount.ToString("n2");

                // Sessiona
                var bm5 = wordDoc.Bookmarks["invSessions"];
                bm5.Range.Text = inv.Sessions == 1 ?  "1 sesión" : inv.Sessions.ToString("n0") + " sesiones";

                // Treatment
                var bm6 = wordDoc.Bookmarks["invTreatment"];
                bm6.Range.Text = inv.Treatment;

                // Date
                var bm7 = wordDoc.Bookmarks["invDate"];
                bm7.Range.Text = inv.Date.ToString("d 'de' MMMM 'de' yyyy");

                // Physio name
                var bm8 = wordDoc.Bookmarks["invPhyName"];
                bm8.Range.Text = this.physio.FullName;

                // Physio license
                var bm9 = wordDoc.Bookmarks["invPhyLicense"];
                bm9.Range.Text = this.physio.LicenseNumber;

                // Physio identification
                var bm10 = wordDoc.Bookmarks["invPhyIdentification"];
                bm10.Range.Text = this.physio.Identification;
            }
            finally
            {
                wordApp.Visible = true;
            }
        }


    }
}
