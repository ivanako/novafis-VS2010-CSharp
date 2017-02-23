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

namespace UserInterface
{
    public partial class frmDebts : Form
    {
        public frmDebts()
        {
            InitializeComponent();
        }

        private void frmDebts_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            dtpDebtDate.Value = DateTime.Today;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void populateDefaulters()
        {
            List<Appointment> lstDefaulters = AppointmentBL.searchDefaulters(dtpDebtDate.Value);

            SortableBindingList<Appointment> sblDefaulters = new SortableBindingList<Appointment>(lstDefaulters);

            dgvDefaulters.DataSource = sblDefaulters;

            dgvDefaulters.Columns["Identifier"].Visible = false;
            dgvDefaulters.Columns["Physio"].Visible = false;
            dgvDefaulters.Columns["PatientId"].Visible = false;
            dgvDefaulters.Columns["SourceName"].Visible = false;
            dgvDefaulters.Columns["Observation"].Visible = false;

            dgvDefaulters.Columns["IsPaid"].Visible = false;
            dgvDefaulters.Columns["HasDebt"].Visible = false;
            dgvDefaulters.Columns["IsCancelled"].Visible = false;
            dgvDefaulters.Columns["HasTreatment"].Visible = false;

            dgvDefaulters.Columns["Paid"].Visible = false;
            dgvDefaulters.Columns["CancellationWhy"].Visible = false;
            dgvDefaulters.Columns["Patient"].Visible = false;
            dgvDefaulters.Columns["Physiotherapist"].Visible = false;

            lblDebtDefaulterCount.Text = string.Format("Morosos: {0}", lstDefaulters.Count);
        }

        private void dtpDebtDate_ValueChanged(object sender, EventArgs e)
        {
            populateDefaulters();
        }
    }
}
