namespace UserInterface
{
    partial class frmAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tipAppointments = new System.Windows.Forms.ToolTip(this.components);
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAppPanel = new System.Windows.Forms.Button();
            this.splAppointments = new System.Windows.Forms.SplitContainer();
            this.lblNoTimetable = new System.Windows.Forms.Label();
            this.grbPhysiotherapists = new System.Windows.Forms.GroupBox();
            this.calAppointment = new System.Windows.Forms.MonthCalendar();
            this.lblDate = new System.Windows.Forms.Label();
            this.grbPatient = new System.Windows.Forms.GroupBox();
            this.btnPatDelete = new System.Windows.Forms.Button();
            this.txtPatPhysio = new System.Windows.Forms.TextBox();
            this.lblPatPhysio = new System.Windows.Forms.Label();
            this.lblPatName = new System.Windows.Forms.Label();
            this.txtPatName = new System.Windows.Forms.TextBox();
            this.lblAvailableTimes = new System.Windows.Forms.Label();
            this.lstTimes = new System.Windows.Forms.ListBox();
            this.lblPatObservation = new System.Windows.Forms.Label();
            this.txtPatObservation = new System.Windows.Forms.TextBox();
            this.chkPatBlackList = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.dgvAppointments = new UserInterface.Controls.NovaGrid();
            this.lblNotes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splAppointments)).BeginInit();
            this.splAppointments.Panel1.SuspendLayout();
            this.splAppointments.Panel2.SuspendLayout();
            this.splAppointments.SuspendLayout();
            this.grbPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatient.Enabled = false;
            this.btnPatient.Location = new System.Drawing.Point(1071, 222);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(86, 33);
            this.btnPatient.TabIndex = 14;
            this.btnPatient.Text = "Paciente...";
            this.tipAppointments.SetToolTip(this.btnPatient, "Mostrar ficha del Paciente");
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(1071, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 33);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Eliminar";
            this.tipAppointments.SetToolTip(this.btnDelete, "Eliminar Cita");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAppPanel
            // 
            this.btnAppPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppPanel.Enabled = false;
            this.btnAppPanel.Location = new System.Drawing.Point(1071, 261);
            this.btnAppPanel.Name = "btnAppPanel";
            this.btnAppPanel.Size = new System.Drawing.Size(86, 41);
            this.btnAppPanel.TabIndex = 14;
            this.btnAppPanel.Text = "Mostrar panel";
            this.tipAppointments.SetToolTip(this.btnAppPanel, "Mostrar panel de Citas");
            this.btnAppPanel.UseVisualStyleBackColor = true;
            this.btnAppPanel.Click += new System.EventHandler(this.btnAppPanel_Click);
            // 
            // splAppointments
            // 
            this.splAppointments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splAppointments.Location = new System.Drawing.Point(0, 0);
            this.splAppointments.Name = "splAppointments";
            this.splAppointments.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splAppointments.Panel1
            // 
            this.splAppointments.Panel1.Controls.Add(this.lblNotes);
            this.splAppointments.Panel1.Controls.Add(this.lstNotes);
            this.splAppointments.Panel1.Controls.Add(this.btnClose);
            this.splAppointments.Panel1.Controls.Add(this.lblNoTimetable);
            this.splAppointments.Panel1.Controls.Add(this.dgvAppointments);
            this.splAppointments.Panel1.Controls.Add(this.btnAppPanel);
            this.splAppointments.Panel1.Controls.Add(this.btnPatient);
            this.splAppointments.Panel1.Controls.Add(this.btnDelete);
            this.splAppointments.Panel1.Controls.Add(this.grbPhysiotherapists);
            this.splAppointments.Panel1.Controls.Add(this.calAppointment);
            this.splAppointments.Panel1.Controls.Add(this.lblDate);
            this.splAppointments.Panel1MinSize = 500;
            // 
            // splAppointments.Panel2
            // 
            this.splAppointments.Panel2.Controls.Add(this.btnAppointment);
            this.splAppointments.Panel2.Controls.Add(this.grbPatient);
            this.splAppointments.Panel2.Controls.Add(this.lblAvailableTimes);
            this.splAppointments.Panel2.Controls.Add(this.lstTimes);
            this.splAppointments.Panel2MinSize = 170;
            this.splAppointments.Size = new System.Drawing.Size(1173, 678);
            this.splAppointments.SplitterDistance = 500;
            this.splAppointments.TabIndex = 8;
            // 
            // lblNoTimetable
            // 
            this.lblNoTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoTimetable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTimetable.ForeColor = System.Drawing.Color.Red;
            this.lblNoTimetable.Location = new System.Drawing.Point(12, 183);
            this.lblNoTimetable.Name = "lblNoTimetable";
            this.lblNoTimetable.Size = new System.Drawing.Size(1053, 20);
            this.lblNoTimetable.TabIndex = 17;
            this.lblNoTimetable.Text = "El fisioterapeuta {0} no tiene asignado un horario para el día {1}";
            this.lblNoTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbPhysiotherapists
            // 
            this.grbPhysiotherapists.Location = new System.Drawing.Point(214, 52);
            this.grbPhysiotherapists.Name = "grbPhysiotherapists";
            this.grbPhysiotherapists.Size = new System.Drawing.Size(361, 90);
            this.grbPhysiotherapists.TabIndex = 11;
            this.grbPhysiotherapists.TabStop = false;
            this.grbPhysiotherapists.Text = "Fisioterapeutas";
            // 
            // calAppointment
            // 
            this.calAppointment.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calAppointment.Location = new System.Drawing.Point(10, 9);
            this.calAppointment.MaxSelectionCount = 1;
            this.calAppointment.MinDate = new System.DateTime(2006, 5, 3, 0, 0, 0, 0);
            this.calAppointment.Name = "calAppointment";
            this.calAppointment.TabIndex = 9;
            this.calAppointment.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calAppointment_DateChanged);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(10, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(1147, 20);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbPatient
            // 
            this.grbPatient.Controls.Add(this.chkPatBlackList);
            this.grbPatient.Controls.Add(this.btnPatDelete);
            this.grbPatient.Controls.Add(this.txtPatObservation);
            this.grbPatient.Controls.Add(this.txtPatPhysio);
            this.grbPatient.Controls.Add(this.lblPatObservation);
            this.grbPatient.Controls.Add(this.lblPatPhysio);
            this.grbPatient.Controls.Add(this.lblPatName);
            this.grbPatient.Controls.Add(this.txtPatName);
            this.grbPatient.Location = new System.Drawing.Point(214, 16);
            this.grbPatient.Name = "grbPatient";
            this.grbPatient.Size = new System.Drawing.Size(500, 144);
            this.grbPatient.TabIndex = 12;
            this.grbPatient.TabStop = false;
            this.grbPatient.Text = "Paciente";
            // 
            // btnPatDelete
            // 
            this.btnPatDelete.Enabled = false;
            this.btnPatDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatDelete.Location = new System.Drawing.Point(444, 20);
            this.btnPatDelete.Name = "btnPatDelete";
            this.btnPatDelete.Size = new System.Drawing.Size(28, 21);
            this.btnPatDelete.TabIndex = 14;
            this.btnPatDelete.Text = "X";
            this.btnPatDelete.UseVisualStyleBackColor = true;
            this.btnPatDelete.Click += new System.EventHandler(this.btnPatDelete_Click);
            // 
            // txtPatPhysio
            // 
            this.txtPatPhysio.Location = new System.Drawing.Point(96, 52);
            this.txtPatPhysio.Name = "txtPatPhysio";
            this.txtPatPhysio.ReadOnly = true;
            this.txtPatPhysio.Size = new System.Drawing.Size(149, 21);
            this.txtPatPhysio.TabIndex = 13;
            // 
            // lblPatPhysio
            // 
            this.lblPatPhysio.AutoSize = true;
            this.lblPatPhysio.Location = new System.Drawing.Point(58, 55);
            this.lblPatPhysio.Name = "lblPatPhysio";
            this.lblPatPhysio.Size = new System.Drawing.Size(32, 13);
            this.lblPatPhysio.TabIndex = 12;
            this.lblPatPhysio.Text = "Fisio";
            // 
            // lblPatName
            // 
            this.lblPatName.AutoSize = true;
            this.lblPatName.Location = new System.Drawing.Point(38, 24);
            this.lblPatName.Name = "lblPatName";
            this.lblPatName.Size = new System.Drawing.Size(52, 13);
            this.lblPatName.TabIndex = 12;
            this.lblPatName.Text = "Nombre";
            // 
            // txtPatName
            // 
            this.txtPatName.Location = new System.Drawing.Point(96, 20);
            this.txtPatName.Name = "txtPatName";
            this.txtPatName.Size = new System.Drawing.Size(342, 21);
            this.txtPatName.TabIndex = 11;
            this.txtPatName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPatName_KeyDown);
            this.txtPatName.Leave += new System.EventHandler(this.txtPatName_Leave);
            // 
            // lblAvailableTimes
            // 
            this.lblAvailableTimes.AutoSize = true;
            this.lblAvailableTimes.Location = new System.Drawing.Point(7, 16);
            this.lblAvailableTimes.Name = "lblAvailableTimes";
            this.lblAvailableTimes.Size = new System.Drawing.Size(107, 13);
            this.lblAvailableTimes.TabIndex = 4;
            this.lblAvailableTimes.Text = "Horas disponibles";
            // 
            // lstTimes
            // 
            this.lstTimes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTimes.ColumnWidth = 50;
            this.lstTimes.FormattingEnabled = true;
            this.lstTimes.Location = new System.Drawing.Point(10, 39);
            this.lstTimes.MultiColumn = true;
            this.lstTimes.Name = "lstTimes";
            this.lstTimes.Size = new System.Drawing.Size(192, 121);
            this.lstTimes.TabIndex = 3;
            // 
            // lblPatObservation
            // 
            this.lblPatObservation.Location = new System.Drawing.Point(15, 84);
            this.lblPatObservation.Name = "lblPatObservation";
            this.lblPatObservation.Size = new System.Drawing.Size(85, 31);
            this.lblPatObservation.TabIndex = 12;
            this.lblPatObservation.Text = "Observación permanente";
            // 
            // txtPatObservation
            // 
            this.txtPatObservation.Location = new System.Drawing.Point(96, 88);
            this.txtPatObservation.Name = "txtPatObservation";
            this.txtPatObservation.ReadOnly = true;
            this.txtPatObservation.Size = new System.Drawing.Size(342, 21);
            this.txtPatObservation.TabIndex = 13;
            // 
            // chkPatBlackList
            // 
            this.chkPatBlackList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPatBlackList.Location = new System.Drawing.Point(18, 121);
            this.chkPatBlackList.Name = "chkPatBlackList";
            this.chkPatBlackList.Size = new System.Drawing.Size(93, 17);
            this.chkPatBlackList.TabIndex = 15;
            this.chkPatBlackList.Text = "Lista negra";
            this.chkPatBlackList.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkPatBlackList.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1071, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 33);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Cerrar";
            this.tipAppointments.SetToolTip(this.btnClose, "Eliminar Cita");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAppointment.Enabled = false;
            this.btnAppointment.Location = new System.Drawing.Point(751, 127);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(86, 33);
            this.btnAppointment.TabIndex = 19;
            this.btnAppointment.Text = "Citar";
            this.tipAppointments.SetToolTip(this.btnAppointment, "Eliminar Cita");
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // lstNotes
            // 
            this.lstNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.Location = new System.Drawing.Point(922, 37);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstNotes.Size = new System.Drawing.Size(235, 134);
            this.lstNotes.TabIndex = 19;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.Location = new System.Drawing.Point(10, 183);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(1055, 299);
            this.dgvAppointments.TabIndex = 16;
            this.dgvAppointments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppointments_CellMouseDoubleClick);
            this.dgvAppointments.SelectionChanged += new System.EventHandler(this.dgvAppointments_SelectionChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(919, 13);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(81, 13);
            this.lblNotes.TabIndex = 20;
            this.lblNotes.Text = "Notas diarias";
            // 
            // frmAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 678);
            this.Controls.Add(this.splAppointments);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAppointments";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.frmAppointments_Load);
            this.splAppointments.Panel1.ResumeLayout(false);
            this.splAppointments.Panel1.PerformLayout();
            this.splAppointments.Panel2.ResumeLayout(false);
            this.splAppointments.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splAppointments)).EndInit();
            this.splAppointments.ResumeLayout(false);
            this.grbPatient.ResumeLayout(false);
            this.grbPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tipAppointments;
        private System.Windows.Forms.SplitContainer splAppointments;
        private System.Windows.Forms.MonthCalendar calAppointment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grbPhysiotherapists;
        private System.Windows.Forms.Label lblNoTimetable;
        private Controls.NovaGrid dgvAppointments;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAppPanel;
        private System.Windows.Forms.ListBox lstTimes;
        private System.Windows.Forms.Label lblAvailableTimes;
        private System.Windows.Forms.GroupBox grbPatient;
        private System.Windows.Forms.TextBox txtPatPhysio;
        private System.Windows.Forms.Label lblPatPhysio;
        private System.Windows.Forms.Label lblPatName;
        private System.Windows.Forms.TextBox txtPatName;
        private System.Windows.Forms.Button btnPatDelete;
        private System.Windows.Forms.CheckBox chkPatBlackList;
        private System.Windows.Forms.TextBox txtPatObservation;
        private System.Windows.Forms.Label lblPatObservation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.Label lblNotes;
    }
}