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
    public partial class mdiContainer : Form
    {
        public mdiContainer()
        {
            InitializeComponent();
        }


        private void mdiContainer_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GlobalVars.Patients = PatientBL.findAllPatients();
            GlobalVars.Physiotherapists = PhysioBL.findAllPhysios();
            Cursor.Current = Cursors.Default;

            checkFormOpen(new frmAppointments());
        }
        private void mdiContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !exitApplication();
        }

        private void mnuMain_Physios_Click(object sender, EventArgs e)
        {
            checkFormOpen(new frmPhysiotherapists());
        }
        private void mnuMain_Patients_Click(object sender, EventArgs e)
        {
            checkFormOpen(new frmPatients());
        }
        private void mnuMain_Appointments_Click(object sender, EventArgs e)
        {
            checkFormOpen(new frmAppointments());
        }
        private void mnuMain_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAccesories_Locs_Les_Click(object sender, EventArgs e)
        {
            checkFormOpen(new frmLocsLes());
        }

        private void mnuAccesories_Sources_Notes_Click(object sender, EventArgs e)
        {
            checkFormOpen(new frmSourcesNotes());
        }




        /// <summary>
        /// Check if an MDI child is already open
        /// </summary>
        /// <param name="frm">Form to check if it is open</param>
        private void checkFormOpen(Form frm)
        {
            if (this.MdiChildren.Any())
            {
                //foreach (Form openForm in Application.OpenForms)
                foreach (Form mdiChild in this.MdiChildren)
                {
                    if (mdiChild.Name.Equals(frm.Name))
                    {
                        frm.BringToFront();
                        break;
                    }
                    else
                    {
                        openMDIChild(frm);
                    }
                }
            }
            else
            {
                openMDIChild(frm);
            }
        }

        private void openMDIChild(Form frm)
        {
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.Focus();
        }


        private bool exitApplication()
        {
            bool exitApp = true;

            if (MessageBox.Show("¿Salir de la Aplicación?", Application.ProductName, MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                exitApp = false;
            }

            return exitApp;
        }


    }
}
