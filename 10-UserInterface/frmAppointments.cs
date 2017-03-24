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
    public partial class frmAppointments : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetKeyState(Keys key);

        Physiotherapist PhysioSel;

        private const string NO_TIMETABLE = "El fisioterapeuta {0} no tiene asignado un horario para el día {1}";

        public frmAppointments()
        {
            InitializeComponent();
        }


        private Appointment selAppointment;
        private Maintenance appOperation;

        private List<Appointment> dateAppointments;

        private void frmAppointments_Load(object sender, EventArgs e)
        {
            loadPhysios();

            lblNoTimetable.SendToBack();

            manageDate();

            //preparePatientTextBox();

            loadPatients();

            //splAppointments.Panel2Collapsed = true;
        }
        private void frmAppointments_Activated(object sender, EventArgs e)
        {
            //preparePatientTextBox();
        }

        private void calAppointment_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            manageDate();

            this.Cursor = Cursors.Default;
        }

        private void manageDate()
        {
            lblDate.Text = calAppointment.SelectionStart.ToLongDateString();

            if (calAppointment.SelectionStart.DayOfWeek == DayOfWeek.Saturday || calAppointment.SelectionStart.DayOfWeek == DayOfWeek.Sunday)
            {
                lblDate.ForeColor = Color.Red;

                dgvAppointments.DataSource = null;
                btnAppPanel.Enabled = false;
            }
            else
            {
                lblDate.ForeColor = SystemColors.ControlText;

                populateDateNotes();

                this.dateAppointments = AppointmentBL.findAppointmentsByDate(calAppointment.SelectionStart, 0);

                if (this.PhysioSel != null)
                {
                    populateAppointmentsGrid();
                }
            }
        }

        private void radPhysio_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RadioButton radPhysio = (RadioButton)sender;

            radPhysio.Font = new Font(radPhysio.Font, FontStyle.Regular);

            if (radPhysio.Checked)
            {
                radPhysio.Font = new Font(radPhysio.Font, FontStyle.Bold);

                this.PhysioSel = (Physiotherapist)radPhysio.Tag;

                manageDate();
            }

            this.Cursor = Cursors.Default;
        }

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 1)
            {
                bool hasPatient = (dgvAppointments.SelectedRows[0].Cells["Patient"].Value != null);
                btnDelete.Enabled = hasPatient;
                btnPatient.Enabled = hasPatient;
            }
        }
        private void dgvAppointments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAppointments.SelectedRows.Count == 1)
            {
                buildApp();

                launchAppDetails();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar cita seleccionada?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                buildApp();

                bool delOK = AppointmentBL.deleteAppointment(this.selAppointment);

                if (delOK)
                {
                    MessageBox.Show("Cita eliminada correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    manageDate();
                    //populateAppointmentsGrid();
                }
            }
        }
        private void btnPatient_Click(object sender, EventArgs e)
        {
            buildApp();

            int patId = this.selAppointment.Patient.Identifier;

            Address patAddress = AddressBL.findOneAddress(patId);
            List<Cancellation> patCancellations = CancellationBL.findAllCancellations(patId);
            List<Observation> patObservations = ObservationBL.findObservationsByPatient(patId);
            List<Treatment> patTreatments = TreatmentBL.findTreatmentsByPatient(patId);

            this.selAppointment.Patient.Address = patAddress;
            this.selAppointment.Patient.Cancellations = patCancellations;
            this.selAppointment.Patient.Observations = patObservations;
            this.selAppointment.Patient.Treatments = patTreatments;

            frmPatientsDetail frmPatientDetail = new frmPatientsDetail();
            frmPatientDetail.patientDetails = this.selAppointment.Patient;
            frmPatientDetail.patientOperation = Maintenance.Edit;
            frmPatientDetail.tabIndex = 4;

            if (frmPatientDetail.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;

                //GlobalVars.Patients = PatientBL.findAllPatients();
                manageDate();

                frmPatientDetail.Dispose();

                this.Cursor = Cursors.Default;
            }
        }
        private void btnAppPanel_Click(object sender, EventArgs e)
        {
            toggleAppPanel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void loadPhysios()
        {
            int radLocX = 10;

            List<Physiotherapist> lstPhysios = GlobalVars.Physiotherapists
                .Where(p => p.TerminationDate == null)
                .OrderBy(p => p.Identifier)
                .ToList<Physiotherapist>();

            foreach (Physiotherapist phy in lstPhysios)
            {
                RadioButton radPhy = new RadioButton()
                {
                    Name = string.Format("radPhysio{0}", phy.Identifier),
                    Text = phy.Alias,
                    ForeColor = ColorTranslator.FromHtml(phy.Colour),
                    Tag = phy,
                    AutoSize = true,
                    Location = new Point(radLocX, 25)
                };

                radPhy.CheckedChanged += new EventHandler(this.radPhysio_CheckedChanged);

                grbPhysiotherapists.Controls.Add(radPhy);

                radLocX += radPhy.Width + 10;
            }
        }

        //private void loadAppointmentsDate()
        //{
        //    List<Appointment> lstAppointments = AppointmentBL.findAppointmentsByDate(calAppointment.SelectionStart);

        //    SortableBindingList<Appointment> sblAppointments = new SortableBindingList<Appointment>(lstAppointments);

        //    dgvAppointments.DataSource = sblAppointments;

        //    dgvAppointments.Columns["Identifier"].Visible = false;
        //    dgvAppointments.Columns["Date"].Visible = false;
        //    dgvAppointments.Columns["Paid"].Visible = false;
        //    dgvAppointments.Columns["Debt"].Visible = false;
        //    dgvAppointments.Columns["Patient"].Visible = false;
        //    dgvAppointments.Columns["Physiotherapist"].Visible = false;

        //    DataGridViewCellStyle style = new DataGridViewCellStyle();
        //    style.Format = "N0";
        //    style.Alignment = DataGridViewContentAlignment.MiddleRight;
        //    dgvAppointments.Columns["PatientId"].DefaultCellStyle = style;
        //}

        private List<Appointment> loadTimetablePhysio()
        {
            List<Appointment> lstAppointments = new List<Appointment>();

            Timetable timetable = TimetableBL.findTimetableByPhysioAndDate(this.PhysioSel.Identifier, calAppointment.SelectionStart);

            if (timetable != null)
            {
                if (!string.IsNullOrWhiteSpace(timetable.MorningTimeStart))
                {
                    string[] arrMornTimeStart = timetable.MorningTimeStart.Split(':');
                    string[] arrMornTimeFinish = timetable.MorningTimeFinish.Split(':');

                    DateTime mornTimeStart = new DateTime(timetable.Date.Year, timetable.Date.Month, timetable.Date.Day, int.Parse(arrMornTimeStart[0]), int.Parse(arrMornTimeStart[1]), 0);
                    DateTime mornTimeFinish = new DateTime(timetable.Date.Year, timetable.Date.Month, timetable.Date.Day, int.Parse(arrMornTimeFinish[0]), int.Parse(arrMornTimeFinish[1]), 0);

                    DateTime mornTimeAux = mornTimeStart;

                    while (mornTimeAux <= mornTimeFinish)
                    {
                        Appointment app = new Appointment() 
                        { 
                            Date = timetable.Date,
                            Time = mornTimeAux.ToString("HH:mm")
                        };

                        mornTimeAux = mornTimeAux.AddMinutes((int)timetable.MorningDuration);

                        lstAppointments.Add(app);
                    }
                }
                if (!string.IsNullOrWhiteSpace(timetable.AfternoonTimeStart))
                {
                    string[] arrAfterTimeStart = timetable.AfternoonTimeStart.Split(':');
                    string[] arrAfterTimeFinish = timetable.AfternoonTimeFinish.Split(':');

                    DateTime afterTimeStart = new DateTime(timetable.Date.Year, timetable.Date.Month, timetable.Date.Day, int.Parse(arrAfterTimeStart[0]), int.Parse(arrAfterTimeStart[1]), 0);
                    DateTime afterTimeFinish = new DateTime(timetable.Date.Year, timetable.Date.Month, timetable.Date.Day, int.Parse(arrAfterTimeFinish[0]), int.Parse(arrAfterTimeFinish[1]), 0);

                    DateTime afterTimeAux = afterTimeStart;

                    while (afterTimeAux <= afterTimeFinish)
                    {
                        Appointment app = new Appointment()
                        {
                            Date = timetable.Date,
                            Time = afterTimeAux.ToString("HH:mm")
                        };

                        afterTimeAux = afterTimeAux.AddMinutes((int)timetable.AfternoonDuration);

                        lstAppointments.Add(app);
                    }
                }
            }

            return lstAppointments;
        }


        private void populateAppointmentsGrid()
        {
            lblNoTimetable.SendToBack();

            List<Appointment> lstAppointments = new List<Appointment>();

            //List<Appointment> lstAppPhysioTable = loadTimetablePhysio();
            List<Appointment> lstAppPhysioTable = TimetableBL.loadTimetablePhysio(this.PhysioSel.Identifier, calAppointment.SelectionStart);

            if (lstAppPhysioTable.Count > 0)
            {
                //List<Appointment> lstAppDate = AppointmentBL.findAppointmentsByDate(calAppointment.SelectionStart, this.PhysioSel.Identifier);
                List<Appointment> lstAppPhysio = this.dateAppointments
                                                    .Where(a => a.Physiotherapist.Identifier == this.PhysioSel.Identifier)
                                                    .ToList<Appointment>();

                foreach (Appointment app in lstAppPhysioTable)
                {
                    int appCount = lstAppPhysio.Where(a => a.Time.Equals(app.Time)).Count<Appointment>();

                    if (appCount == 1)
                    {
                        Appointment appTime = lstAppPhysio.Where(a => a.Time.Equals(app.Time)).First<Appointment>();
                        lstAppointments.Add(appTime);
                    }
                    else
                    {
                        lstAppointments.Add(app);
                    }
                }

                SortableBindingList<Appointment> sblAppointments = new SortableBindingList<Appointment>(lstAppointments);

                dgvAppointments.DataSource = sblAppointments;

                dgvAppointments.Columns["Identifier"].Visible = false;
                dgvAppointments.Columns["Date"].Visible = false;
                dgvAppointments.Columns["Paid"].Visible = false;
                dgvAppointments.Columns["Debt"].Visible = false;
                dgvAppointments.Columns["Patient"].Visible = false;
                dgvAppointments.Columns["Physiotherapist"].Visible = false;
                dgvAppointments.Columns["CancellationWhy"].Visible = false;
                dgvAppointments.Columns["FormOfPayment"].Visible = false;
                dgvAppointments.Columns["RegistryDate"].Visible = false;


                //Color colPhyTuned = Color.FromArgb(200, ColorTranslator.FromHtml(this.PhysioSel.Colour));
                Color colPhy = ColorTranslator.FromHtml(this.PhysioSel.Colour);
                int colR = colPhy.R;
                int colG = colPhy.G;
                int colB = colPhy.B;
                int colNorm = ((colR * 299) + (colG * 587) + (colB * 114)) / 1000;

                dgvAppointments.DefaultCellStyle.BackColor = colPhy;
                dgvAppointments.DefaultCellStyle.ForeColor = colNorm >= 128 ? Color.Black : Color.White;

                DataGridViewCellStyle patIdStyle = new DataGridViewCellStyle();
                patIdStyle.Format = "N0";
                patIdStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvAppointments.Columns["PatientId"].DefaultCellStyle = patIdStyle;

                loadTimesByPhysio(lstAppointments);

                btnAppPanel.Enabled = true;
            }
            else
            {
                dgvAppointments.DataSource = null;

                lblNoTimetable.Text = string.Format(NO_TIMETABLE, this.PhysioSel.Alias, calAppointment.SelectionStart.ToShortDateString());
                lblNoTimetable.BringToFront();

                btnDelete.Enabled = false;
                btnPatient.Enabled = false;
                btnAppPanel.Enabled = false;
            }
        }


        private void launchAppDetails()
        {
            frmAppointmentsDetail frmAppDetail = new frmAppointmentsDetail();

            frmAppDetail.appDetails = this.selAppointment;
            frmAppDetail.appOperation = this.appOperation;
            //frmPatientDetail.Text = string.Format(frmPatientDetail.Text, selPatient.FullName);


            if (frmAppDetail.ShowDialog() == DialogResult.OK)
            {
                this.dateAppointments = AppointmentBL.findAppointmentsByDate(calAppointment.SelectionStart, 0);

                populateAppointmentsGrid();

                //MessageBox.Show("Cita guardada correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmAppDetail.Dispose();
            }
        }

        private void buildApp()
        {
            DataGridViewRow rowApp = dgvAppointments.SelectedRows[0];

            DateTime appDate = Convert.ToDateTime(rowApp.Cells["Date"].Value);
            string appTime = Convert.ToString(rowApp.Cells["Time"].Value);
            string appObs = Convert.ToString(rowApp.Cells["Observation"].Value);
            bool appIsCanc = Convert.ToBoolean(rowApp.Cells["IsCancelled"].Value);
            string appCanc = Convert.ToString(rowApp.Cells["CancellationWhy"].Value);
            double appPaid = Convert.ToDouble(rowApp.Cells["Paid"].Value);
            double appDebt = Convert.ToDouble(rowApp.Cells["Debt"].Value);
            Patient appPatient = (Patient)rowApp.Cells["Patient"].Value;
            Physiotherapist appPhysio = (Physiotherapist)rowApp.Cells["Physiotherapist"].Value;
            FormOfPayment appFormPayment = null;

            if (rowApp.Cells["FormOfPayment"].Value != null)
            {
                appFormPayment = (FormOfPayment)rowApp.Cells["FormOfPayment"].Value;
            }

            Nullable<DateTime> appRegistryDate = null;

            if (rowApp.Cells["RegistryDate"].Value != null)
            {
                appRegistryDate = Convert.ToDateTime(rowApp.Cells["RegistryDate"].Value);
            }

            this.selAppointment = new Appointment()
            {
                Date = appDate,
                Time = appTime,
                Observation = appObs,
                IsCancelled = appIsCanc,
                CancellationWhy = appCanc,
                Paid = appPaid,
                Debt = appDebt,
                Patient = appPatient,
                Physiotherapist = appPhysio,
                FormOfPayment = appFormPayment,
                RegistryDate = appRegistryDate
            };

            if (appPatient == null)
            {
                this.appOperation = Maintenance.Create;
            }
            else
            {
                this.appOperation = Maintenance.Edit;
                int appId = Convert.ToInt32(rowApp.Cells["Identifier"].Value);
                this.selAppointment.Identifier = appId;
            }
        }

        


        #region NOTES
            private System.Timers.Timer tmrNotes = new System.Timers.Timer();
            private byte blinkCount = 0;

            private void tmrNotes_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
            {
                this.blinkCount++;

                lstNotes.BackColor = lstNotes.BackColor == SystemColors.Window ? Color.Red : SystemColors.Window;
                lstNotes.ForeColor = lstNotes.ForeColor == SystemColors.WindowText ? Color.White : SystemColors.WindowText;

                if (this.blinkCount == 10)
                {
                    this.blinkCount = 0;
                    tmrNotes.Stop();
                }
            }

            private void populateDateNotes()
            {
                List<Note> lstDateNotes = NoteBL.findNotesByDate(calAppointment.SelectionStart);

                lstNotes.DataSource = lstDateNotes;
                lstNotes.DisplayMember = "Description";

                if (lstDateNotes.Count == 0)
                {
                    lstNotes.BackColor = lstNotes.BackColor = SystemColors.Window;

                    tmrNotes.Elapsed -= new System.Timers.ElapsedEventHandler(tmrNotes_Elapsed);
                }
                else
                {
                    tmrNotes.Interval = 1000;
                    tmrNotes.Start();

                    tmrNotes.Elapsed += new System.Timers.ElapsedEventHandler(tmrNotes_Elapsed);
                }
            }
        #endregion

        #region APPOINTMENT PANEL

            private List<Patient> appPatients;
            //private Patient appPatient;

            private void lstTimes_SelectedIndexChanged(object sender, EventArgs e)
            {
                checkAppFields();
            }
            private void dgvPatients_SelectionChanged(object sender, EventArgs e)
            {
                checkAppFields();
                //btnAppointment.Enabled = (dgvPatients.SelectedRows.Count == 1);
            }

            private void txtPatName_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyData == Keys.Enter && GetKeyState(Keys.Enter) < 0)
                {
                    managePatientField(true);
                }
            }
            private void txtPatName_Leave(object sender, EventArgs e)
            {
                if (txtPatName.TabStop)
                {
                    Patient pat = GlobalVars.Patients.Where(p => p.FullName.Equals(txtPatName.Text)).FirstOrDefault<Patient>();

                    bool hasPatient = (pat != null);

                    managePatientField(hasPatient);
                }
            }
            private void btnPatDelete_Click(object sender, EventArgs e)
            {
                resetPatient();
            }

            private void txtPatient_TextChanged(object sender, EventArgs e)
            {
                this.Cursor = Cursors.WaitCursor;

                filterPatients();

                this.Cursor = Cursors.Default;
            }

            private void btnAppointment_Click(object sender, EventArgs e)
            {
                DataGridViewRow rowPat = dgvPatients.SelectedRows[0];
                int patIdentifier = Convert.ToInt32(rowPat.Cells["Identifier"].Value);


                Patient appPatient = PatientBL.findOnePatient(patIdentifier);

                List<Observation> lstObs = ObservationBL.findObservationsByPatient(patIdentifier);
                appPatient.Observations = lstObs;

                //Patient appPatient = new Patient()
                //{
                //    Identifier = patIdentifier
                //};


                Appointment app = (Appointment)lstTimes.SelectedValue;
                //app.Patient = (Patient)txtPatName.Tag;
                app.Patient = appPatient;
                app.Physiotherapist = this.PhysioSel;
                if (appPatient.Observations.Count > 0)
                {
                    app.Observation = appPatient.Observations.First<Observation>().Description;
                }

                double patDebt = 0;
                DateTime patDebtDate = DateTime.Today.AddDays(-1);
                string patObs = string.Empty;

                bool checkOK = AppointmentBL.checkDebt(app.Patient.Identifier, app.Date, ref patDebt, ref patDebtDate, ref patObs);

                if (checkOK)
                {
                    StringBuilder sbDebtMsg = new StringBuilder();

                    string msgHeader = string.Format("El paciente {0} ", app.Patient.FullName) + "\n";

                    if (patDebt > 0)
                    {
                        sbDebtMsg.Append(msgHeader);
                        sbDebtMsg.AppendFormat("tiene una deuda pendiente de {0} euros del día {1}", patDebt, patDebtDate.ToShortDateString());
                    }
                    if (!string.IsNullOrWhiteSpace(patObs))
                    {
                        if (patDebt == 0)
                        {
                            sbDebtMsg.Append(msgHeader);
                        }
                        else
                        {
                            sbDebtMsg.AppendLine();
                        }

                        sbDebtMsg.AppendLine("presenta las siguientes observaciones permanentes:");
                        sbDebtMsg.Append(patObs);
                    }

                    if (sbDebtMsg.Length > 0)
                    {
                        MessageBox.Show(sbDebtMsg.ToString());
                    }
                }

                bool saveOK = AppointmentBL.saveAppointment(app);

                if (saveOK)
                {
                    //this.dateAppointments = AppointmentBL.findAppointmentsByDate(calAppointment.SelectionStart);

                    //populateAppointmentsGrid();

                    manageDate();

                    resetPatient();

                    //splAppointments.Panel2Collapsed = true;
                    //toggleAppPanel();
                }
            }

            private void loadTimesByPhysio(List<Appointment> lstAppointmentsByDateAndPhysio)
            {
                List<Appointment> lstEmptyApps = lstAppointmentsByDateAndPhysio.Where(a => a.Patient == null).ToList<Appointment>();

                lstTimes.DataSource = lstEmptyApps;
                lstTimes.DisplayMember = "Time";
            }

            private void preparePatientTextBox()
            {
                txtPatName.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtPatName.AutoCompleteSource = AutoCompleteSource.CustomSource;

                string[] arrPatients = GlobalVars.Patients.Where(p => p.Deleted == false).Select(p => p.FullName).ToArray();
                AutoCompleteStringCollection colPatients = new AutoCompleteStringCollection();
                colPatients.AddRange(arrPatients);
                txtPatName.AutoCompleteCustomSource = colPatients;
            }

            private void managePatientField(bool hasPatient)
            {
                if (hasPatient)
                {
                    Patient pat = GlobalVars.Patients.Where(p => p.FullName.Equals(txtPatName.Text)).First<Patient>();
                    txtPatName.Tag = pat;
                    txtPatPhysio.Text = pat.Physiotherapist.Alias;

                    List<Observation> lstObs = ObservationBL.findObservationsByPatient(pat.Identifier);
                    pat.Observations = lstObs;

                    if (pat.Observations.Count == 0)
                    {
                        txtPatObservation.Text = string.Empty;
                    }
                    else
                    {
                        txtPatObservation.Text = pat.Observations[0].Description;
                    }
                    chkPatBlackList.Checked = pat.BlackList;
                }
                //else
                //{
                //    txtPatName.ForeColor = SystemColors.ControlText;
                //}

                txtPatName.ReadOnly = hasPatient;
                txtPatName.TabStop = !hasPatient;

                btnPatDelete.Enabled = hasPatient;
                btnAppointment.Enabled = hasPatient;
            }

            private void resetPatient()
            {
                txtPatName.Text = string.Empty;
                txtPatName.Tag = null;
                txtPatName.ReadOnly = false;
                txtPatName.TabStop = true;

                txtPatPhysio.Text = string.Empty;
                txtPatObservation.Text = string.Empty;
                chkPatBlackList.Checked = false;

                btnPatDelete.Enabled = false;
                btnAppointment.Enabled = false;
            }

            private void toggleAppPanel()
            {
                splAppointments.Panel2Collapsed = !splAppointments.Panel2Collapsed;

                if (splAppointments.Panel2Collapsed)
                {
                    btnAppPanel.Text = "Mostrar panel";
                    tipAppointments.SetToolTip(btnAppPanel, "Mostrar panel de Citas");
                }
                else
                {
                    btnAppPanel.Text = "Ocultar panel";
                    tipAppointments.SetToolTip(btnAppPanel, "Ocultar panel de Citas");
                }
            }


            private enum FilterOrigins
            {
                Load, Filter
            }

            private void loadPatients()
            {
                //patientOperation = Maintenance.Edit;

                //this.selPatient = new Patient();

                //GlobalVars.Patients = PatientBL.findAllPatients();

                this.appPatients = GlobalVars.Patients.Where(p => p.Deleted == false).OrderBy(p => p.FullName).ToList<Patient>();

                //this.pageCount = calculatePageCount();
                //lblPageCount.Text = this.pageCount.ToString();

                populatePatientGrid(FilterOrigins.Load);

                //navigateGrid(Navigation.First);
                //grbNavigator.Enabled = (this.pageCount > 1);
            }

            private void populatePatientGrid(FilterOrigins origin)
            {
                List<Patient> lstPatLimit = this.appPatients;

                if (origin == FilterOrigins.Load || string.IsNullOrWhiteSpace(txtPatient.Text))
                {
                    lstPatLimit = this.appPatients
                        .Take<Patient>(100)
                        .ToList<Patient>();
                }

                foreach (Patient pat in lstPatLimit)
                {
                    List<Observation> lstObs = ObservationBL.findObservationsByPatient(pat.Identifier);
                    pat.Observations = lstObs;
                }

                SortableBindingList<Patient> sblPatients = new SortableBindingList<Patient>(lstPatLimit);

                dgvPatients.DataSource = sblPatients;

                dgvPatients.Columns["Identifier"].Visible = false;
                dgvPatients.Columns["Name"].Visible = false;
                dgvPatients.Columns["Surname1"].Visible = false;
                dgvPatients.Columns["Surname2"].Visible = false;
                dgvPatients.Columns["Identification"].Visible = false;
                dgvPatients.Columns["EntryDate"].Visible = false;
                dgvPatients.Columns["HowHeardAboutUs"].Visible = false;
                dgvPatients.Columns["Gender"].Visible = false;
                dgvPatients.Columns["DateOfBirth"].Visible = false;
                //dgvPatients.Columns["BlackList"].Visible = false;
                dgvPatients.Columns["Deleted"].Visible = false;
                dgvPatients.Columns["Source"].Visible = false;
                dgvPatients.Columns["Physiotherapist"].Visible = false;
                dgvPatients.Columns["Address"].Visible = false;
                dgvPatients.Columns["SourceDesc"].Visible = false;

                //DataGridViewCellStyle style = new DataGridViewCellStyle();
                //style.Format = "N0";
                //dgvPatients.Columns["Identifier"].DefaultCellStyle = style;

                dgvPatients.Columns["FullName"].DisplayIndex = 1;
                dgvPatients.Columns["PhysiotherapistName"].DisplayIndex = 7;
                dgvPatients.Columns["PermanentObs"].DisplayIndex = 8;
                dgvPatients.Columns["BlackList"].DisplayIndex = 9;
            }

            private void filterPatients()
            {
                string filterPatient = txtPatient.Text.Trim();

                var lst = GlobalVars.Patients.Where(
                    p => p.FullName.StartsWith(filterPatient, StringComparison.CurrentCultureIgnoreCase) &&
                    p.Deleted == false);

                this.appPatients = lst.OrderBy(p => p.FullName).ToList();
                
                populatePatientGrid(FilterOrigins.Filter);
            }

            private void checkAppFields()
            {
                bool okFields = false;

                okFields = (lstTimes.SelectedItems.Count > 0);

                if (okFields)
                {
                    okFields = (dgvPatients.SelectedRows.Count == 1);
                }

                btnAppointment.Enabled = okFields;
            }
        #endregion

            
    }
}
