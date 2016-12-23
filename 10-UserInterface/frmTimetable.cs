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
    public partial class frmTimetable : Form
    {
        public frmTimetable()
        {
            InitializeComponent();
        }

        internal Timetable physioTimetable;
        internal Maintenance timetableOperation;


        private void frmTimetable_Load(object sender, EventArgs e)
        {
            switch (this.timetableOperation)
            { 
                case Maintenance.Create:
                    chkMorning.Checked = false;
                    chkAfternoon.Checked = false;
                    break;
                case Maintenance.Edit:
                    chkMorning.Checked = !string.IsNullOrWhiteSpace(this.physioTimetable.MorningTimeStart);
                    chkAfternoon.Checked = !string.IsNullOrWhiteSpace(this.physioTimetable.AfternoonTimeStart);

                    bindDataControls();
                    break;
            }
        }

        private void chkMorning_CheckedChanged(object sender, EventArgs e)
        {
            grbMorning.Enabled = chkMorning.Checked;
        }
        private void chkAfternoon_CheckedChanged(object sender, EventArgs e)
        {
            grbAfternoon.Enabled = chkAfternoon.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isOK = checkFields();

            if (isOK)
            {
                saveTimetable();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }




        private void bindDataControls()
        {
            BindingSource bs = new BindingSource(physioTimetable, null);

            dtpDateBegin.DataBindings.Add("Value", bs, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpMorningTimeBegin.DataBindings.Add("Value", bs, "MorningTimeStart", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpMorningTimeEnd.DataBindings.Add("Value", bs, "MorningTimeFinish", true, DataSourceUpdateMode.OnPropertyChanged);
            nudMorningDuration.DataBindings.Add("Value", bs, "MorningDuration", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpAfternoonTimeBegin.DataBindings.Add("Value", bs, "AfternoonTimeStart", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpAfternoonTimeEnd.DataBindings.Add("Value", bs, "AfternoonTimeFinish", true, DataSourceUpdateMode.OnPropertyChanged);
            nudAfternoonDuration.DataBindings.Add("Value", bs, "AfternoonDuration", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool checkFields()
        {
            bool isOK = true;

            errTimetable.SetError(dtpDateEnd, string.Empty);
            errTimetable.SetError(dtpMorningTimeBegin, string.Empty);
            errTimetable.SetError(dtpMorningTimeEnd, string.Empty);
            errTimetable.SetError(nudMorningDuration, string.Empty);
            errTimetable.SetError(dtpAfternoonTimeBegin, string.Empty);
            errTimetable.SetError(dtpAfternoonTimeEnd, string.Empty);
            errTimetable.SetError(nudAfternoonDuration, string.Empty);

            if (dtpDateEnd.Checked)
            {
                if (DateTime.Compare(dtpDateBegin.Value, dtpDateEnd.Value) >= 0)
                {
                    errTimetable.SetError(dtpDateEnd, "Fecha Fin no puede ser anterior o igual que Fecha Inicio");
                    isOK = false;
                }
            }

            if (chkMorning.Checked)
            {
                if (DateTime.Compare(dtpMorningTimeBegin.Value, dtpMorningTimeEnd.Value) >= 0)
                {
                    errTimetable.SetError(dtpMorningTimeBegin, "Hora Inicio no puede ser posterior o igual que Hora Fin");
                    errTimetable.SetError(dtpMorningTimeEnd, "Hora Fin no puede ser anterior o igual que Hora Inicio");
                    isOK = false;
                }
                if (nudMorningDuration.Value == 0) 
                {
                    errTimetable.SetError(nudMorningDuration, "La duración tiene que ser mayor que cero");
                    isOK = false;
                }
            }

            if (chkAfternoon.Checked)
            {
                if (DateTime.Compare(dtpAfternoonTimeBegin.Value, dtpAfternoonTimeEnd.Value) >= 0)
                {
                    errTimetable.SetError(dtpAfternoonTimeBegin, "Hora Inicio no puede ser posterior o igual que Hora Fin");
                    errTimetable.SetError(dtpAfternoonTimeEnd, "Hora Fin no puede ser anterior o igual que Hora Inicio");
                    isOK = false;
                }
                if (nudAfternoonDuration.Value == 0)
                {
                    errTimetable.SetError(nudAfternoonDuration, "La duración tiene que ser mayor que cero");
                    isOK = false;
                }
            }

            return isOK;
        }


        private void saveTimetable()
        {
            bool saveOK = false;

            DateTime dtBeginAux = Convert.ToDateTime(dtpDateBegin.Value.ToShortDateString());
            DateTime dtEndAux = dtpDateBegin.Value;

            if (dtpDateEnd.Checked)
            {
                dtEndAux = dtpDateEnd.Value;
            }

            Timetable tmt = new Timetable();

            if (chkMorning.Checked)
            {
                tmt.MorningTimeStart = dtpMorningTimeBegin.Value.ToShortTimeString();
                tmt.MorningTimeFinish = dtpMorningTimeEnd.Value.ToShortTimeString();
                tmt.MorningDuration = Convert.ToByte(nudMorningDuration.Value);
            }
            else
            {
                tmt.MorningTimeStart = string.Empty;
                tmt.MorningTimeFinish = string.Empty;
                tmt.MorningDuration = 0;
            }

            if (chkAfternoon.Checked)
            {
                tmt.AfternoonTimeStart = dtpAfternoonTimeBegin.Value.ToShortTimeString();
                tmt.AfternoonTimeFinish = dtpAfternoonTimeEnd.Value.ToShortTimeString();
                tmt.AfternoonDuration = Convert.ToByte(nudAfternoonDuration.Value);
            }
            else
            {
                tmt.AfternoonTimeStart = string.Empty;
                tmt.AfternoonTimeFinish = string.Empty;
                tmt.AfternoonDuration = 0;
            }

            if (this.timetableOperation == Maintenance.Edit)
            {
                tmt.Identifier = this.physioTimetable.Identifier;
            }

            tmt.Physiotherapist = this.physioTimetable.Physiotherapist;

            while (dtBeginAux <= dtEndAux)
            {
                tmt.Date = dtBeginAux;

                saveOK = TimetableBL.saveTimetable(tmt);

                dtBeginAux = dtBeginAux.AddDays(1);
            }

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
