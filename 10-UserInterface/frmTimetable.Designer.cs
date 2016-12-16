namespace UserInterface
{
    partial class frmTimetable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbDates = new System.Windows.Forms.GroupBox();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateBegin = new System.Windows.Forms.DateTimePicker();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateBegin = new System.Windows.Forms.Label();
            this.grbTimetable = new System.Windows.Forms.GroupBox();
            this.chkMorning = new System.Windows.Forms.CheckBox();
            this.grbMorning = new System.Windows.Forms.GroupBox();
            this.lblMorningMin = new System.Windows.Forms.Label();
            this.nudMorningDuration = new System.Windows.Forms.NumericUpDown();
            this.dtpMorningTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpMorningTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.lblMorningDuration = new System.Windows.Forms.Label();
            this.lblMorningTimeEnd = new System.Windows.Forms.Label();
            this.lblMorningTimeBegin = new System.Windows.Forms.Label();
            this.chkAfternoon = new System.Windows.Forms.CheckBox();
            this.grbAfternoon = new System.Windows.Forms.GroupBox();
            this.lblAfternoonMin = new System.Windows.Forms.Label();
            this.nudAfternoonDuration = new System.Windows.Forms.NumericUpDown();
            this.dtpAfternoonTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpAfternoonTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.lblAfternoonDuration = new System.Windows.Forms.Label();
            this.lblAfternoonTimeEnd = new System.Windows.Forms.Label();
            this.lblAfternoonTimeBegin = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tipTimetable = new System.Windows.Forms.ToolTip(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.errTimetable = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDates.SuspendLayout();
            this.grbTimetable.SuspendLayout();
            this.grbMorning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMorningDuration)).BeginInit();
            this.grbAfternoon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfternoonDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDates
            // 
            this.grbDates.Controls.Add(this.dtpDateEnd);
            this.grbDates.Controls.Add(this.dtpDateBegin);
            this.grbDates.Controls.Add(this.lblDateEnd);
            this.grbDates.Controls.Add(this.lblDateBegin);
            this.grbDates.Location = new System.Drawing.Point(12, 12);
            this.grbDates.Name = "grbDates";
            this.grbDates.Size = new System.Drawing.Size(363, 104);
            this.grbDates.TabIndex = 0;
            this.grbDates.TabStop = false;
            this.grbDates.Text = "Fechas";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Checked = false;
            this.dtpDateEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateEnd.Location = new System.Drawing.Point(193, 57);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.ShowCheckBox = true;
            this.dtpDateEnd.Size = new System.Drawing.Size(126, 21);
            this.dtpDateEnd.TabIndex = 1;
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.CustomFormat = "dd/MM/yyyy";
            this.dtpDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBegin.Location = new System.Drawing.Point(33, 57);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Size = new System.Drawing.Size(126, 21);
            this.dtpDateBegin.TabIndex = 0;
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(222, 30);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(60, 13);
            this.lblDateEnd.TabIndex = 0;
            this.lblDateEnd.Text = "Fecha Fin";
            // 
            // lblDateBegin
            // 
            this.lblDateBegin.AutoSize = true;
            this.lblDateBegin.Location = new System.Drawing.Point(58, 30);
            this.lblDateBegin.Name = "lblDateBegin";
            this.lblDateBegin.Size = new System.Drawing.Size(75, 13);
            this.lblDateBegin.TabIndex = 0;
            this.lblDateBegin.Text = "Fecha Inicio";
            // 
            // grbTimetable
            // 
            this.grbTimetable.Controls.Add(this.chkMorning);
            this.grbTimetable.Controls.Add(this.grbMorning);
            this.grbTimetable.Controls.Add(this.chkAfternoon);
            this.grbTimetable.Controls.Add(this.grbAfternoon);
            this.grbTimetable.Location = new System.Drawing.Point(12, 122);
            this.grbTimetable.Name = "grbTimetable";
            this.grbTimetable.Size = new System.Drawing.Size(363, 255);
            this.grbTimetable.TabIndex = 1;
            this.grbTimetable.TabStop = false;
            this.grbTimetable.Text = "Horario";
            // 
            // chkMorning
            // 
            this.chkMorning.AutoSize = true;
            this.chkMorning.Checked = true;
            this.chkMorning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMorning.Location = new System.Drawing.Point(33, 33);
            this.chkMorning.Name = "chkMorning";
            this.chkMorning.Size = new System.Drawing.Size(70, 17);
            this.chkMorning.TabIndex = 1;
            this.chkMorning.Text = "Mañana";
            this.chkMorning.UseVisualStyleBackColor = true;
            this.chkMorning.CheckedChanged += new System.EventHandler(this.chkMorning_CheckedChanged);
            // 
            // grbMorning
            // 
            this.grbMorning.Controls.Add(this.lblMorningMin);
            this.grbMorning.Controls.Add(this.nudMorningDuration);
            this.grbMorning.Controls.Add(this.dtpMorningTimeEnd);
            this.grbMorning.Controls.Add(this.dtpMorningTimeBegin);
            this.grbMorning.Controls.Add(this.lblMorningDuration);
            this.grbMorning.Controls.Add(this.lblMorningTimeEnd);
            this.grbMorning.Controls.Add(this.lblMorningTimeBegin);
            this.grbMorning.Location = new System.Drawing.Point(15, 34);
            this.grbMorning.Name = "grbMorning";
            this.grbMorning.Size = new System.Drawing.Size(332, 92);
            this.grbMorning.TabIndex = 0;
            this.grbMorning.TabStop = false;
            // 
            // lblMorningMin
            // 
            this.lblMorningMin.AutoSize = true;
            this.lblMorningMin.Location = new System.Drawing.Point(272, 55);
            this.lblMorningMin.Name = "lblMorningMin";
            this.lblMorningMin.Size = new System.Drawing.Size(32, 13);
            this.lblMorningMin.TabIndex = 5;
            this.lblMorningMin.Text = "min.";
            // 
            // nudMorningDuration
            // 
            this.nudMorningDuration.Location = new System.Drawing.Point(219, 53);
            this.nudMorningDuration.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMorningDuration.Name = "nudMorningDuration";
            this.nudMorningDuration.Size = new System.Drawing.Size(47, 21);
            this.nudMorningDuration.TabIndex = 2;
            // 
            // dtpMorningTimeEnd
            // 
            this.dtpMorningTimeEnd.CustomFormat = "HH:mm";
            this.dtpMorningTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMorningTimeEnd.Location = new System.Drawing.Point(121, 50);
            this.dtpMorningTimeEnd.Name = "dtpMorningTimeEnd";
            this.dtpMorningTimeEnd.Size = new System.Drawing.Size(72, 21);
            this.dtpMorningTimeEnd.TabIndex = 1;
            // 
            // dtpMorningTimeBegin
            // 
            this.dtpMorningTimeBegin.CustomFormat = "HH:mm";
            this.dtpMorningTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMorningTimeBegin.Location = new System.Drawing.Point(22, 50);
            this.dtpMorningTimeBegin.Name = "dtpMorningTimeBegin";
            this.dtpMorningTimeBegin.Size = new System.Drawing.Size(72, 21);
            this.dtpMorningTimeBegin.TabIndex = 0;
            // 
            // lblMorningDuration
            // 
            this.lblMorningDuration.AutoSize = true;
            this.lblMorningDuration.Location = new System.Drawing.Point(221, 31);
            this.lblMorningDuration.Name = "lblMorningDuration";
            this.lblMorningDuration.Size = new System.Drawing.Size(58, 13);
            this.lblMorningDuration.TabIndex = 2;
            this.lblMorningDuration.Text = "Duración";
            // 
            // lblMorningTimeEnd
            // 
            this.lblMorningTimeEnd.AutoSize = true;
            this.lblMorningTimeEnd.Location = new System.Drawing.Point(130, 31);
            this.lblMorningTimeEnd.Name = "lblMorningTimeEnd";
            this.lblMorningTimeEnd.Size = new System.Drawing.Size(54, 13);
            this.lblMorningTimeEnd.TabIndex = 2;
            this.lblMorningTimeEnd.Text = "Hora Fin";
            // 
            // lblMorningTimeBegin
            // 
            this.lblMorningTimeBegin.AutoSize = true;
            this.lblMorningTimeBegin.Location = new System.Drawing.Point(22, 31);
            this.lblMorningTimeBegin.Name = "lblMorningTimeBegin";
            this.lblMorningTimeBegin.Size = new System.Drawing.Size(69, 13);
            this.lblMorningTimeBegin.TabIndex = 2;
            this.lblMorningTimeBegin.Text = "Hora Inicio";
            // 
            // chkAfternoon
            // 
            this.chkAfternoon.AutoSize = true;
            this.chkAfternoon.Checked = true;
            this.chkAfternoon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAfternoon.Location = new System.Drawing.Point(33, 144);
            this.chkAfternoon.Name = "chkAfternoon";
            this.chkAfternoon.Size = new System.Drawing.Size(58, 17);
            this.chkAfternoon.TabIndex = 1;
            this.chkAfternoon.Text = "Tarde";
            this.chkAfternoon.UseVisualStyleBackColor = true;
            this.chkAfternoon.CheckedChanged += new System.EventHandler(this.chkAfternoon_CheckedChanged);
            // 
            // grbAfternoon
            // 
            this.grbAfternoon.Controls.Add(this.lblAfternoonMin);
            this.grbAfternoon.Controls.Add(this.nudAfternoonDuration);
            this.grbAfternoon.Controls.Add(this.dtpAfternoonTimeEnd);
            this.grbAfternoon.Controls.Add(this.dtpAfternoonTimeBegin);
            this.grbAfternoon.Controls.Add(this.lblAfternoonDuration);
            this.grbAfternoon.Controls.Add(this.lblAfternoonTimeEnd);
            this.grbAfternoon.Controls.Add(this.lblAfternoonTimeBegin);
            this.grbAfternoon.Location = new System.Drawing.Point(15, 146);
            this.grbAfternoon.Name = "grbAfternoon";
            this.grbAfternoon.Size = new System.Drawing.Size(332, 92);
            this.grbAfternoon.TabIndex = 0;
            this.grbAfternoon.TabStop = false;
            // 
            // lblAfternoonMin
            // 
            this.lblAfternoonMin.AutoSize = true;
            this.lblAfternoonMin.Location = new System.Drawing.Point(272, 55);
            this.lblAfternoonMin.Name = "lblAfternoonMin";
            this.lblAfternoonMin.Size = new System.Drawing.Size(32, 13);
            this.lblAfternoonMin.TabIndex = 5;
            this.lblAfternoonMin.Text = "min.";
            // 
            // nudAfternoonDuration
            // 
            this.nudAfternoonDuration.Location = new System.Drawing.Point(219, 53);
            this.nudAfternoonDuration.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudAfternoonDuration.Name = "nudAfternoonDuration";
            this.nudAfternoonDuration.Size = new System.Drawing.Size(47, 21);
            this.nudAfternoonDuration.TabIndex = 2;
            // 
            // dtpAfternoonTimeEnd
            // 
            this.dtpAfternoonTimeEnd.CustomFormat = "HH:mm";
            this.dtpAfternoonTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAfternoonTimeEnd.Location = new System.Drawing.Point(121, 50);
            this.dtpAfternoonTimeEnd.Name = "dtpAfternoonTimeEnd";
            this.dtpAfternoonTimeEnd.Size = new System.Drawing.Size(72, 21);
            this.dtpAfternoonTimeEnd.TabIndex = 1;
            // 
            // dtpAfternoonTimeBegin
            // 
            this.dtpAfternoonTimeBegin.CustomFormat = "HH:mm";
            this.dtpAfternoonTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAfternoonTimeBegin.Location = new System.Drawing.Point(22, 50);
            this.dtpAfternoonTimeBegin.Name = "dtpAfternoonTimeBegin";
            this.dtpAfternoonTimeBegin.Size = new System.Drawing.Size(72, 21);
            this.dtpAfternoonTimeBegin.TabIndex = 0;
            // 
            // lblAfternoonDuration
            // 
            this.lblAfternoonDuration.AutoSize = true;
            this.lblAfternoonDuration.Location = new System.Drawing.Point(221, 31);
            this.lblAfternoonDuration.Name = "lblAfternoonDuration";
            this.lblAfternoonDuration.Size = new System.Drawing.Size(58, 13);
            this.lblAfternoonDuration.TabIndex = 2;
            this.lblAfternoonDuration.Text = "Duración";
            // 
            // lblAfternoonTimeEnd
            // 
            this.lblAfternoonTimeEnd.AutoSize = true;
            this.lblAfternoonTimeEnd.Location = new System.Drawing.Point(130, 31);
            this.lblAfternoonTimeEnd.Name = "lblAfternoonTimeEnd";
            this.lblAfternoonTimeEnd.Size = new System.Drawing.Size(54, 13);
            this.lblAfternoonTimeEnd.TabIndex = 2;
            this.lblAfternoonTimeEnd.Text = "Hora Fin";
            // 
            // lblAfternoonTimeBegin
            // 
            this.lblAfternoonTimeBegin.AutoSize = true;
            this.lblAfternoonTimeBegin.Location = new System.Drawing.Point(22, 31);
            this.lblAfternoonTimeBegin.Name = "lblAfternoonTimeBegin";
            this.lblAfternoonTimeBegin.Size = new System.Drawing.Size(69, 13);
            this.lblAfternoonTimeBegin.TabIndex = 2;
            this.lblAfternoonTimeBegin.Text = "Hora Inicio";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.tipTimetable.SetToolTip(this.btnCancel, "Cerrar ventana");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.tipTimetable.SetToolTip(this.btnSave, "Guardar Horario");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errTimetable
            // 
            this.errTimetable.ContainerControl = this;
            // 
            // frmTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 449);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbTimetable);
            this.Controls.Add(this.grbDates);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTimetable";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.frmTimetable_Load);
            this.grbDates.ResumeLayout(false);
            this.grbDates.PerformLayout();
            this.grbTimetable.ResumeLayout(false);
            this.grbTimetable.PerformLayout();
            this.grbMorning.ResumeLayout(false);
            this.grbMorning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMorningDuration)).EndInit();
            this.grbAfternoon.ResumeLayout(false);
            this.grbAfternoon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfternoonDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTimetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDates;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateBegin;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblDateBegin;
        private System.Windows.Forms.GroupBox grbTimetable;
        private System.Windows.Forms.GroupBox grbAfternoon;
        private System.Windows.Forms.Label lblAfternoonMin;
        private System.Windows.Forms.NumericUpDown nudAfternoonDuration;
        private System.Windows.Forms.DateTimePicker dtpAfternoonTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpAfternoonTimeBegin;
        private System.Windows.Forms.Label lblAfternoonDuration;
        private System.Windows.Forms.Label lblAfternoonTimeEnd;
        private System.Windows.Forms.Label lblAfternoonTimeBegin;
        private System.Windows.Forms.CheckBox chkAfternoon;
        private System.Windows.Forms.GroupBox grbMorning;
        private System.Windows.Forms.Label lblMorningMin;
        private System.Windows.Forms.NumericUpDown nudMorningDuration;
        private System.Windows.Forms.DateTimePicker dtpMorningTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpMorningTimeBegin;
        private System.Windows.Forms.Label lblMorningDuration;
        private System.Windows.Forms.Label lblMorningTimeEnd;
        private System.Windows.Forms.Label lblMorningTimeBegin;
        private System.Windows.Forms.CheckBox chkMorning;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip tipTimetable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errTimetable;
    }
}