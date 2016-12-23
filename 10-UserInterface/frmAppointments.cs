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
        Physiotherapist PhysioSel;

        private const string NO_TIMETABLE = "El fisioterapeuta {0} no tiene asignado un horario para el día {1}";

        public frmAppointments()
        {
            InitializeComponent();
        }

        private void frmAppointments_Load(object sender, EventArgs e)
        {
            loadPhysios();

            lblNoTimetable.SendToBack();
            calAppointment.SelectionStart = DateTime.Today;
        }

        private void calAppointment_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblDate.Text = calAppointment.SelectionStart.ToLongDateString();

            //loadAppointmentsDate();

            if (this.PhysioSel != null)
            {
                populateAppointmentsGrid();
            }
        }

        private void radPhysio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radPhysio = (RadioButton)sender;

            radPhysio.Font = new Font(radPhysio.Font, FontStyle.Regular);

            if (radPhysio.Checked)
            {
                radPhysio.Font = new Font(radPhysio.Font, FontStyle.Bold);

                this.PhysioSel = (Physiotherapist)radPhysio.Tag;
                //loadTimetablePhysio();
                populateAppointmentsGrid();
            }
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
            this.Cursor = Cursors.WaitCursor;

            lblNoTimetable.SendToBack();

            List<Appointment> lstAppointments = new List<Appointment>();

            List<Appointment> lstAppPhysio = loadTimetablePhysio();

            if (lstAppPhysio.Count > 0)
            {
                List<Appointment> lstAppDate = AppointmentBL.findAppointmentsByDate(calAppointment.SelectionStart, this.PhysioSel.Identifier);

                foreach (Appointment app in lstAppPhysio)
                {
                    int appCount = lstAppDate.Where(a => a.Time.Equals(app.Time)).Count<Appointment>();

                    if (appCount == 1)
                    {
                        Appointment appTime = lstAppDate.Where(a => a.Time.Equals(app.Time)).First<Appointment>();
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

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Format = "N0";
                style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvAppointments.Columns["PatientId"].DefaultCellStyle = style;
            }
            else
            {
                dgvAppointments.DataSource = null;

                lblNoTimetable.Text = string.Format(NO_TIMETABLE, this.PhysioSel.Alias, calAppointment.SelectionStart.ToShortDateString());
                lblNoTimetable.BringToFront();

                btnDelete.Enabled = false;
                btnPatient.Enabled = false;
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
        
    }
}
