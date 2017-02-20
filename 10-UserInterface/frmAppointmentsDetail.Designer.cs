namespace UserInterface
{
    partial class frmAppointmentsDetail
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
            this.lblAppDate = new System.Windows.Forms.Label();
            this.txtAppDate = new System.Windows.Forms.TextBox();
            this.lblAppTime = new System.Windows.Forms.Label();
            this.txtAppTime = new System.Windows.Forms.TextBox();
            this.lblAppPatient = new System.Windows.Forms.Label();
            this.txtAppPatient = new System.Windows.Forms.TextBox();
            this.grbAppAccounting = new System.Windows.Forms.GroupBox();
            this.nudAppDebt = new System.Windows.Forms.NumericUpDown();
            this.nudAppPaid = new System.Windows.Forms.NumericUpDown();
            this.lblAppDebtCurrency = new System.Windows.Forms.Label();
            this.lblAppPaidCurrency = new System.Windows.Forms.Label();
            this.lblAppDebt = new System.Windows.Forms.Label();
            this.lblAppPaid = new System.Windows.Forms.Label();
            this.chkAppCancelled = new System.Windows.Forms.CheckBox();
            this.txtAppCancellationReason = new System.Windows.Forms.TextBox();
            this.cboAppPhysiotherapists = new System.Windows.Forms.ComboBox();
            this.lblAppPhysio = new System.Windows.Forms.Label();
            this.lblAppObservation = new System.Windows.Forms.Label();
            this.txtAppObservation = new System.Windows.Forms.TextBox();
            this.btnAppCancel = new System.Windows.Forms.Button();
            this.tipAppDetail = new System.Windows.Forms.ToolTip(this.components);
            this.btnAppSave = new System.Windows.Forms.Button();
            this.btnAppPatient = new System.Windows.Forms.Button();
            this.btnAppNewPatient = new System.Windows.Forms.Button();
            this.btnAppDelPatient = new System.Windows.Forms.Button();
            this.errAppDetail = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbAppAccounting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAppDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAppPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAppDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Location = new System.Drawing.Point(37, 20);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(40, 13);
            this.lblAppDate.TabIndex = 0;
            this.lblAppDate.Text = "Fecha";
            // 
            // txtAppDate
            // 
            this.txtAppDate.Location = new System.Drawing.Point(83, 17);
            this.txtAppDate.Name = "txtAppDate";
            this.txtAppDate.ReadOnly = true;
            this.txtAppDate.Size = new System.Drawing.Size(123, 21);
            this.txtAppDate.TabIndex = 1;
            this.txtAppDate.TabStop = false;
            this.txtAppDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAppTime
            // 
            this.lblAppTime.AutoSize = true;
            this.lblAppTime.Location = new System.Drawing.Point(276, 20);
            this.lblAppTime.Name = "lblAppTime";
            this.lblAppTime.Size = new System.Drawing.Size(34, 13);
            this.lblAppTime.TabIndex = 0;
            this.lblAppTime.Text = "Hora";
            // 
            // txtAppTime
            // 
            this.txtAppTime.Location = new System.Drawing.Point(316, 17);
            this.txtAppTime.Name = "txtAppTime";
            this.txtAppTime.ReadOnly = true;
            this.txtAppTime.Size = new System.Drawing.Size(144, 21);
            this.txtAppTime.TabIndex = 1;
            this.txtAppTime.TabStop = false;
            this.txtAppTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAppPatient
            // 
            this.lblAppPatient.AutoSize = true;
            this.lblAppPatient.Location = new System.Drawing.Point(22, 64);
            this.lblAppPatient.Name = "lblAppPatient";
            this.lblAppPatient.Size = new System.Drawing.Size(55, 13);
            this.lblAppPatient.TabIndex = 0;
            this.lblAppPatient.Text = "Paciente";
            // 
            // txtAppPatient
            // 
            this.txtAppPatient.Location = new System.Drawing.Point(83, 61);
            this.txtAppPatient.Name = "txtAppPatient";
            this.txtAppPatient.Size = new System.Drawing.Size(342, 21);
            this.txtAppPatient.TabIndex = 1;
            this.txtAppPatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAppPatient_KeyDown);
            this.txtAppPatient.Leave += new System.EventHandler(this.txtAppPatient_Leave);
            // 
            // grbAppAccounting
            // 
            this.grbAppAccounting.Controls.Add(this.nudAppDebt);
            this.grbAppAccounting.Controls.Add(this.nudAppPaid);
            this.grbAppAccounting.Controls.Add(this.lblAppDebtCurrency);
            this.grbAppAccounting.Controls.Add(this.lblAppPaidCurrency);
            this.grbAppAccounting.Controls.Add(this.lblAppDebt);
            this.grbAppAccounting.Controls.Add(this.lblAppPaid);
            this.grbAppAccounting.Location = new System.Drawing.Point(25, 110);
            this.grbAppAccounting.Name = "grbAppAccounting";
            this.grbAppAccounting.Size = new System.Drawing.Size(216, 102);
            this.grbAppAccounting.TabIndex = 2;
            this.grbAppAccounting.TabStop = false;
            this.grbAppAccounting.Text = "Contabilidad";
            // 
            // nudAppDebt
            // 
            this.nudAppDebt.DecimalPlaces = 2;
            this.nudAppDebt.Location = new System.Drawing.Point(81, 65);
            this.nudAppDebt.Name = "nudAppDebt";
            this.nudAppDebt.Size = new System.Drawing.Size(85, 21);
            this.nudAppDebt.TabIndex = 2;
            this.nudAppDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudAppPaid
            // 
            this.nudAppPaid.DecimalPlaces = 2;
            this.nudAppPaid.Location = new System.Drawing.Point(81, 32);
            this.nudAppPaid.Name = "nudAppPaid";
            this.nudAppPaid.Size = new System.Drawing.Size(85, 21);
            this.nudAppPaid.TabIndex = 2;
            this.nudAppPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAppDebtCurrency
            // 
            this.lblAppDebtCurrency.AutoSize = true;
            this.lblAppDebtCurrency.Location = new System.Drawing.Point(172, 67);
            this.lblAppDebtCurrency.Name = "lblAppDebtCurrency";
            this.lblAppDebtCurrency.Size = new System.Drawing.Size(14, 13);
            this.lblAppDebtCurrency.TabIndex = 1;
            this.lblAppDebtCurrency.Text = "€";
            // 
            // lblAppPaidCurrency
            // 
            this.lblAppPaidCurrency.AutoSize = true;
            this.lblAppPaidCurrency.Location = new System.Drawing.Point(172, 34);
            this.lblAppPaidCurrency.Name = "lblAppPaidCurrency";
            this.lblAppPaidCurrency.Size = new System.Drawing.Size(14, 13);
            this.lblAppPaidCurrency.TabIndex = 1;
            this.lblAppPaidCurrency.Text = "€";
            // 
            // lblAppDebt
            // 
            this.lblAppDebt.AutoSize = true;
            this.lblAppDebt.Location = new System.Drawing.Point(19, 67);
            this.lblAppDebt.Name = "lblAppDebt";
            this.lblAppDebt.Size = new System.Drawing.Size(44, 13);
            this.lblAppDebt.TabIndex = 1;
            this.lblAppDebt.Text = "Deuda";
            // 
            // lblAppPaid
            // 
            this.lblAppPaid.AutoSize = true;
            this.lblAppPaid.Location = new System.Drawing.Point(19, 34);
            this.lblAppPaid.Name = "lblAppPaid";
            this.lblAppPaid.Size = new System.Drawing.Size(56, 13);
            this.lblAppPaid.TabIndex = 1;
            this.lblAppPaid.Text = "Cobrado";
            // 
            // chkAppCancelled
            // 
            this.chkAppCancelled.AutoSize = true;
            this.chkAppCancelled.Location = new System.Drawing.Point(279, 110);
            this.chkAppCancelled.Name = "chkAppCancelled";
            this.chkAppCancelled.Size = new System.Drawing.Size(87, 17);
            this.chkAppCancelled.TabIndex = 3;
            this.chkAppCancelled.Text = "Anular cita";
            this.chkAppCancelled.UseVisualStyleBackColor = true;
            this.chkAppCancelled.CheckedChanged += new System.EventHandler(this.chkAppCancelled_CheckedChanged);
            // 
            // txtAppCancellationReason
            // 
            this.txtAppCancellationReason.Location = new System.Drawing.Point(279, 141);
            this.txtAppCancellationReason.MaxLength = 200;
            this.txtAppCancellationReason.Multiline = true;
            this.txtAppCancellationReason.Name = "txtAppCancellationReason";
            this.txtAppCancellationReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAppCancellationReason.Size = new System.Drawing.Size(181, 71);
            this.txtAppCancellationReason.TabIndex = 4;
            // 
            // cboAppPhysiotherapists
            // 
            this.cboAppPhysiotherapists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAppPhysiotherapists.FormattingEnabled = true;
            this.cboAppPhysiotherapists.Location = new System.Drawing.Point(316, 229);
            this.cboAppPhysiotherapists.Name = "cboAppPhysiotherapists";
            this.cboAppPhysiotherapists.Size = new System.Drawing.Size(144, 21);
            this.cboAppPhysiotherapists.TabIndex = 5;
            // 
            // lblAppPhysio
            // 
            this.lblAppPhysio.AutoSize = true;
            this.lblAppPhysio.Location = new System.Drawing.Point(223, 232);
            this.lblAppPhysio.Name = "lblAppPhysio";
            this.lblAppPhysio.Size = new System.Drawing.Size(87, 13);
            this.lblAppPhysio.TabIndex = 6;
            this.lblAppPhysio.Text = "Fisioterapeuta";
            // 
            // lblAppObservation
            // 
            this.lblAppObservation.AutoSize = true;
            this.lblAppObservation.Location = new System.Drawing.Point(22, 232);
            this.lblAppObservation.Name = "lblAppObservation";
            this.lblAppObservation.Size = new System.Drawing.Size(114, 13);
            this.lblAppObservation.TabIndex = 6;
            this.lblAppObservation.Text = "Observación diaria";
            // 
            // txtAppObservation
            // 
            this.txtAppObservation.Location = new System.Drawing.Point(25, 256);
            this.txtAppObservation.MaxLength = 200;
            this.txtAppObservation.Multiline = true;
            this.txtAppObservation.Name = "txtAppObservation";
            this.txtAppObservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAppObservation.Size = new System.Drawing.Size(436, 55);
            this.txtAppObservation.TabIndex = 7;
            // 
            // btnAppCancel
            // 
            this.btnAppCancel.Location = new System.Drawing.Point(375, 327);
            this.btnAppCancel.Name = "btnAppCancel";
            this.btnAppCancel.Size = new System.Drawing.Size(86, 33);
            this.btnAppCancel.TabIndex = 8;
            this.btnAppCancel.Text = "Cancelar";
            this.tipAppDetail.SetToolTip(this.btnAppCancel, "Cerrar ventana");
            this.btnAppCancel.UseVisualStyleBackColor = true;
            this.btnAppCancel.Click += new System.EventHandler(this.btnAppCancel_Click);
            // 
            // btnAppSave
            // 
            this.btnAppSave.Location = new System.Drawing.Point(283, 327);
            this.btnAppSave.Name = "btnAppSave";
            this.btnAppSave.Size = new System.Drawing.Size(86, 33);
            this.btnAppSave.TabIndex = 8;
            this.btnAppSave.Text = "Guardar";
            this.tipAppDetail.SetToolTip(this.btnAppSave, "Guardar Cita");
            this.btnAppSave.UseVisualStyleBackColor = true;
            this.btnAppSave.Click += new System.EventHandler(this.btnAppSave_Click);
            // 
            // btnAppPatient
            // 
            this.btnAppPatient.Enabled = false;
            this.btnAppPatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAppPatient.Location = new System.Drawing.Point(25, 327);
            this.btnAppPatient.Name = "btnAppPatient";
            this.btnAppPatient.Size = new System.Drawing.Size(86, 33);
            this.btnAppPatient.TabIndex = 8;
            this.btnAppPatient.Text = "Paciente...";
            this.tipAppDetail.SetToolTip(this.btnAppPatient, "Mostrar ficha del Paciente");
            this.btnAppPatient.UseVisualStyleBackColor = true;
            this.btnAppPatient.Click += new System.EventHandler(this.btnAppPatient_Click);
            // 
            // btnAppNewPatient
            // 
            this.btnAppNewPatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAppNewPatient.Location = new System.Drawing.Point(117, 327);
            this.btnAppNewPatient.Name = "btnAppNewPatient";
            this.btnAppNewPatient.Size = new System.Drawing.Size(86, 33);
            this.btnAppNewPatient.TabIndex = 8;
            this.btnAppNewPatient.Text = "Nuevo...";
            this.tipAppDetail.SetToolTip(this.btnAppNewPatient, "Nuevo Paciente");
            this.btnAppNewPatient.UseVisualStyleBackColor = true;
            this.btnAppNewPatient.Click += new System.EventHandler(this.btnAppNewPatient_Click);
            // 
            // btnAppDelPatient
            // 
            this.btnAppDelPatient.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppDelPatient.Location = new System.Drawing.Point(431, 61);
            this.btnAppDelPatient.Name = "btnAppDelPatient";
            this.btnAppDelPatient.Size = new System.Drawing.Size(30, 21);
            this.btnAppDelPatient.TabIndex = 9;
            this.btnAppDelPatient.Text = "X";
            this.btnAppDelPatient.UseVisualStyleBackColor = true;
            this.btnAppDelPatient.Click += new System.EventHandler(this.btnAppDelPatient_Click);
            // 
            // errAppDetail
            // 
            this.errAppDetail.ContainerControl = this;
            // 
            // frmAppointmentsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 381);
            this.ControlBox = false;
            this.Controls.Add(this.btnAppDelPatient);
            this.Controls.Add(this.btnAppNewPatient);
            this.Controls.Add(this.btnAppPatient);
            this.Controls.Add(this.btnAppSave);
            this.Controls.Add(this.btnAppCancel);
            this.Controls.Add(this.txtAppObservation);
            this.Controls.Add(this.lblAppObservation);
            this.Controls.Add(this.lblAppPhysio);
            this.Controls.Add(this.cboAppPhysiotherapists);
            this.Controls.Add(this.txtAppCancellationReason);
            this.Controls.Add(this.chkAppCancelled);
            this.Controls.Add(this.grbAppAccounting);
            this.Controls.Add(this.txtAppTime);
            this.Controls.Add(this.lblAppTime);
            this.Controls.Add(this.txtAppPatient);
            this.Controls.Add(this.txtAppDate);
            this.Controls.Add(this.lblAppPatient);
            this.Controls.Add(this.lblAppDate);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAppointmentsDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de la cita";
            this.Activated += new System.EventHandler(this.frmAppointmentsDetail_Activated);
            this.Load += new System.EventHandler(this.frmAppointmentsDetail_Load);
            this.grbAppAccounting.ResumeLayout(false);
            this.grbAppAccounting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAppDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAppPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAppDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.TextBox txtAppDate;
        private System.Windows.Forms.Label lblAppTime;
        private System.Windows.Forms.TextBox txtAppTime;
        private System.Windows.Forms.Label lblAppPatient;
        private System.Windows.Forms.TextBox txtAppPatient;
        private System.Windows.Forms.GroupBox grbAppAccounting;
        private System.Windows.Forms.NumericUpDown nudAppDebt;
        private System.Windows.Forms.NumericUpDown nudAppPaid;
        private System.Windows.Forms.Label lblAppDebtCurrency;
        private System.Windows.Forms.Label lblAppPaidCurrency;
        private System.Windows.Forms.Label lblAppDebt;
        private System.Windows.Forms.Label lblAppPaid;
        private System.Windows.Forms.CheckBox chkAppCancelled;
        private System.Windows.Forms.TextBox txtAppCancellationReason;
        private System.Windows.Forms.ComboBox cboAppPhysiotherapists;
        private System.Windows.Forms.Label lblAppPhysio;
        private System.Windows.Forms.Label lblAppObservation;
        private System.Windows.Forms.TextBox txtAppObservation;
        private System.Windows.Forms.Button btnAppCancel;
        private System.Windows.Forms.ToolTip tipAppDetail;
        private System.Windows.Forms.Button btnAppSave;
        private System.Windows.Forms.Button btnAppPatient;
        private System.Windows.Forms.Button btnAppDelPatient;
        private System.Windows.Forms.ErrorProvider errAppDetail;
        private System.Windows.Forms.Button btnAppNewPatient;
    }
}