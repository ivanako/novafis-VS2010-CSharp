namespace UserInterface
{
    partial class frmInvoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInvoices = new UserInterface.Controls.NovaGrid();
            this.lblInvoiceYear = new System.Windows.Forms.Label();
            this.nudInvoiceYear = new System.Windows.Forms.NumericUpDown();
            this.tipInvoices = new System.Windows.Forms.ToolTip(this.components);
            this.btnInvCancel = new System.Windows.Forms.Button();
            this.btnInvSave = new System.Windows.Forms.Button();
            this.btnInvNew = new System.Windows.Forms.Button();
            this.btnInvClose = new System.Windows.Forms.Button();
            this.grbPhyInvoice = new System.Windows.Forms.GroupBox();
            this.btnInvDelPatient = new System.Windows.Forms.Button();
            this.txtInvTreatment = new System.Windows.Forms.TextBox();
            this.nudInvAmount = new System.Windows.Forms.NumericUpDown();
            this.nudInvSessions = new System.Windows.Forms.NumericUpDown();
            this.rdbInvOther = new System.Windows.Forms.RadioButton();
            this.rdbInvPatient = new System.Windows.Forms.RadioButton();
            this.dtpInvDate = new System.Windows.Forms.DateTimePicker();
            this.txtInvOther = new System.Windows.Forms.TextBox();
            this.txtInvPatient = new System.Windows.Forms.TextBox();
            this.txtInvIdentification = new System.Windows.Forms.TextBox();
            this.txtInvNumber = new System.Windows.Forms.TextBox();
            this.lblInvAmount = new System.Windows.Forms.Label();
            this.lblInvSessions = new System.Windows.Forms.Label();
            this.lblInvTreatment = new System.Windows.Forms.Label();
            this.lblInvIdentification = new System.Windows.Forms.Label();
            this.lblInvDate = new System.Windows.Forms.Label();
            this.lblInvNumber = new System.Windows.Forms.Label();
            this.errInvoices = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnInvGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoiceYear)).BeginInit();
            this.grbPhyInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToResizeRows = false;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInvoices.Location = new System.Drawing.Point(14, 52);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(547, 260);
            this.dgvInvoices.TabIndex = 1;
            this.dgvInvoices.SelectionChanged += new System.EventHandler(this.dgvInvoices_SelectionChanged);
            // 
            // lblInvoiceYear
            // 
            this.lblInvoiceYear.AutoSize = true;
            this.lblInvoiceYear.Location = new System.Drawing.Point(14, 21);
            this.lblInvoiceYear.Name = "lblInvoiceYear";
            this.lblInvoiceYear.Size = new System.Drawing.Size(29, 13);
            this.lblInvoiceYear.TabIndex = 1;
            this.lblInvoiceYear.Text = "Año";
            // 
            // nudInvoiceYear
            // 
            this.nudInvoiceYear.Location = new System.Drawing.Point(49, 19);
            this.nudInvoiceYear.Name = "nudInvoiceYear";
            this.nudInvoiceYear.ReadOnly = true;
            this.nudInvoiceYear.Size = new System.Drawing.Size(73, 21);
            this.nudInvoiceYear.TabIndex = 0;
            this.nudInvoiceYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudInvoiceYear.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudInvoiceYear.ValueChanged += new System.EventHandler(this.nudInvoiceYear_ValueChanged);
            // 
            // btnInvCancel
            // 
            this.btnInvCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvCancel.Location = new System.Drawing.Point(297, 277);
            this.btnInvCancel.Name = "btnInvCancel";
            this.btnInvCancel.Size = new System.Drawing.Size(86, 33);
            this.btnInvCancel.TabIndex = 9;
            this.btnInvCancel.Text = "Cancelar";
            this.tipInvoices.SetToolTip(this.btnInvCancel, "Cancelar generación de Factura");
            this.btnInvCancel.UseVisualStyleBackColor = true;
            this.btnInvCancel.Click += new System.EventHandler(this.btnInvCancel_Click);
            // 
            // btnInvSave
            // 
            this.btnInvSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvSave.Location = new System.Drawing.Point(154, 277);
            this.btnInvSave.Name = "btnInvSave";
            this.btnInvSave.Size = new System.Drawing.Size(86, 33);
            this.btnInvSave.TabIndex = 8;
            this.btnInvSave.Text = "Guardar";
            this.tipInvoices.SetToolTip(this.btnInvSave, "Guardar Factura");
            this.btnInvSave.UseVisualStyleBackColor = true;
            this.btnInvSave.Click += new System.EventHandler(this.btnInvSave_Click);
            // 
            // btnInvNew
            // 
            this.btnInvNew.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvNew.Location = new System.Drawing.Point(580, 52);
            this.btnInvNew.Name = "btnInvNew";
            this.btnInvNew.Size = new System.Drawing.Size(86, 33);
            this.btnInvNew.TabIndex = 2;
            this.btnInvNew.Text = "Nueva";
            this.tipInvoices.SetToolTip(this.btnInvNew, "Emitir Factura");
            this.btnInvNew.UseVisualStyleBackColor = true;
            this.btnInvNew.Click += new System.EventHandler(this.btnInvNew_Click);
            // 
            // btnInvClose
            // 
            this.btnInvClose.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvClose.Location = new System.Drawing.Point(580, 279);
            this.btnInvClose.Name = "btnInvClose";
            this.btnInvClose.Size = new System.Drawing.Size(86, 33);
            this.btnInvClose.TabIndex = 3;
            this.btnInvClose.Text = "Cerrar";
            this.btnInvClose.UseVisualStyleBackColor = true;
            this.btnInvClose.Click += new System.EventHandler(this.btnInvClose_Click);
            // 
            // grbPhyInvoice
            // 
            this.grbPhyInvoice.Controls.Add(this.btnInvDelPatient);
            this.grbPhyInvoice.Controls.Add(this.btnInvCancel);
            this.grbPhyInvoice.Controls.Add(this.btnInvSave);
            this.grbPhyInvoice.Controls.Add(this.txtInvTreatment);
            this.grbPhyInvoice.Controls.Add(this.nudInvAmount);
            this.grbPhyInvoice.Controls.Add(this.nudInvSessions);
            this.grbPhyInvoice.Controls.Add(this.rdbInvOther);
            this.grbPhyInvoice.Controls.Add(this.rdbInvPatient);
            this.grbPhyInvoice.Controls.Add(this.dtpInvDate);
            this.grbPhyInvoice.Controls.Add(this.txtInvOther);
            this.grbPhyInvoice.Controls.Add(this.txtInvPatient);
            this.grbPhyInvoice.Controls.Add(this.txtInvIdentification);
            this.grbPhyInvoice.Controls.Add(this.txtInvNumber);
            this.grbPhyInvoice.Controls.Add(this.lblInvAmount);
            this.grbPhyInvoice.Controls.Add(this.lblInvSessions);
            this.grbPhyInvoice.Controls.Add(this.lblInvTreatment);
            this.grbPhyInvoice.Controls.Add(this.lblInvIdentification);
            this.grbPhyInvoice.Controls.Add(this.lblInvDate);
            this.grbPhyInvoice.Controls.Add(this.lblInvNumber);
            this.grbPhyInvoice.Location = new System.Drawing.Point(14, 332);
            this.grbPhyInvoice.Name = "grbPhyInvoice";
            this.grbPhyInvoice.Size = new System.Drawing.Size(547, 316);
            this.grbPhyInvoice.TabIndex = 10;
            this.grbPhyInvoice.TabStop = false;
            // 
            // btnInvDelPatient
            // 
            this.btnInvDelPatient.Enabled = false;
            this.btnInvDelPatient.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvDelPatient.Location = new System.Drawing.Point(428, 71);
            this.btnInvDelPatient.Name = "btnInvDelPatient";
            this.btnInvDelPatient.Size = new System.Drawing.Size(30, 21);
            this.btnInvDelPatient.TabIndex = 2;
            this.btnInvDelPatient.Text = "X";
            this.btnInvDelPatient.UseVisualStyleBackColor = true;
            this.btnInvDelPatient.Click += new System.EventHandler(this.btnInvDelPatient_Click);
            // 
            // txtInvTreatment
            // 
            this.txtInvTreatment.Location = new System.Drawing.Point(121, 226);
            this.txtInvTreatment.MaxLength = 100;
            this.txtInvTreatment.Multiline = true;
            this.txtInvTreatment.Name = "txtInvTreatment";
            this.txtInvTreatment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInvTreatment.Size = new System.Drawing.Size(337, 34);
            this.txtInvTreatment.TabIndex = 7;
            // 
            // nudInvAmount
            // 
            this.nudInvAmount.DecimalPlaces = 2;
            this.nudInvAmount.Location = new System.Drawing.Point(339, 191);
            this.nudInvAmount.Name = "nudInvAmount";
            this.nudInvAmount.Size = new System.Drawing.Size(119, 21);
            this.nudInvAmount.TabIndex = 6;
            this.nudInvAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudInvSessions
            // 
            this.nudInvSessions.Location = new System.Drawing.Point(121, 191);
            this.nudInvSessions.Name = "nudInvSessions";
            this.nudInvSessions.Size = new System.Drawing.Size(119, 21);
            this.nudInvSessions.TabIndex = 5;
            this.nudInvSessions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbInvOther
            // 
            this.rdbInvOther.AutoSize = true;
            this.rdbInvOther.Location = new System.Drawing.Point(35, 110);
            this.rdbInvOther.Name = "rdbInvOther";
            this.rdbInvOther.Size = new System.Drawing.Size(50, 17);
            this.rdbInvOther.TabIndex = 21;
            this.rdbInvOther.TabStop = true;
            this.rdbInvOther.Text = "Otro";
            this.rdbInvOther.UseVisualStyleBackColor = true;
            this.rdbInvOther.CheckedChanged += new System.EventHandler(this.rdbInvOther_CheckedChanged);
            // 
            // rdbInvPatient
            // 
            this.rdbInvPatient.AutoSize = true;
            this.rdbInvPatient.Location = new System.Drawing.Point(35, 72);
            this.rdbInvPatient.Name = "rdbInvPatient";
            this.rdbInvPatient.Size = new System.Drawing.Size(73, 17);
            this.rdbInvPatient.TabIndex = 22;
            this.rdbInvPatient.TabStop = true;
            this.rdbInvPatient.Text = "Paciente";
            this.rdbInvPatient.UseVisualStyleBackColor = true;
            this.rdbInvPatient.CheckedChanged += new System.EventHandler(this.rdbInvPatient_CheckedChanged);
            // 
            // dtpInvDate
            // 
            this.dtpInvDate.CustomFormat = "dd/MM/yyyy";
            this.dtpInvDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvDate.Location = new System.Drawing.Point(340, 20);
            this.dtpInvDate.Name = "dtpInvDate";
            this.dtpInvDate.Size = new System.Drawing.Size(118, 21);
            this.dtpInvDate.TabIndex = 0;
            // 
            // txtInvOther
            // 
            this.txtInvOther.Location = new System.Drawing.Point(121, 109);
            this.txtInvOther.MaxLength = 100;
            this.txtInvOther.Name = "txtInvOther";
            this.txtInvOther.ReadOnly = true;
            this.txtInvOther.Size = new System.Drawing.Size(337, 21);
            this.txtInvOther.TabIndex = 3;
            this.txtInvOther.TabStop = false;
            // 
            // txtInvPatient
            // 
            this.txtInvPatient.Location = new System.Drawing.Point(121, 71);
            this.txtInvPatient.Name = "txtInvPatient";
            this.txtInvPatient.ReadOnly = true;
            this.txtInvPatient.Size = new System.Drawing.Size(301, 21);
            this.txtInvPatient.TabIndex = 1;
            this.txtInvPatient.TabStop = false;
            this.txtInvPatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvPatient_KeyDown);
            this.txtInvPatient.Leave += new System.EventHandler(this.txtInvPatient_Leave);
            // 
            // txtInvIdentification
            // 
            this.txtInvIdentification.Location = new System.Drawing.Point(121, 151);
            this.txtInvIdentification.MaxLength = 15;
            this.txtInvIdentification.Name = "txtInvIdentification";
            this.txtInvIdentification.Size = new System.Drawing.Size(337, 21);
            this.txtInvIdentification.TabIndex = 4;
            // 
            // txtInvNumber
            // 
            this.txtInvNumber.Location = new System.Drawing.Point(121, 20);
            this.txtInvNumber.MaxLength = 9;
            this.txtInvNumber.Name = "txtInvNumber";
            this.txtInvNumber.ReadOnly = true;
            this.txtInvNumber.Size = new System.Drawing.Size(119, 21);
            this.txtInvNumber.TabIndex = 18;
            this.txtInvNumber.TabStop = false;
            // 
            // lblInvAmount
            // 
            this.lblInvAmount.AutoSize = true;
            this.lblInvAmount.Location = new System.Drawing.Point(276, 193);
            this.lblInvAmount.Name = "lblInvAmount";
            this.lblInvAmount.Size = new System.Drawing.Size(53, 13);
            this.lblInvAmount.TabIndex = 12;
            this.lblInvAmount.Text = "Importe";
            // 
            // lblInvSessions
            // 
            this.lblInvSessions.AutoSize = true;
            this.lblInvSessions.Location = new System.Drawing.Point(50, 193);
            this.lblInvSessions.Name = "lblInvSessions";
            this.lblInvSessions.Size = new System.Drawing.Size(58, 13);
            this.lblInvSessions.TabIndex = 11;
            this.lblInvSessions.Text = "Sesiones";
            // 
            // lblInvTreatment
            // 
            this.lblInvTreatment.AutoSize = true;
            this.lblInvTreatment.Location = new System.Drawing.Point(33, 229);
            this.lblInvTreatment.Name = "lblInvTreatment";
            this.lblInvTreatment.Size = new System.Drawing.Size(75, 13);
            this.lblInvTreatment.TabIndex = 10;
            this.lblInvTreatment.Text = "Tratamiento";
            // 
            // lblInvIdentification
            // 
            this.lblInvIdentification.AutoSize = true;
            this.lblInvIdentification.Location = new System.Drawing.Point(32, 154);
            this.lblInvIdentification.Name = "lblInvIdentification";
            this.lblInvIdentification.Size = new System.Drawing.Size(83, 13);
            this.lblInvIdentification.TabIndex = 15;
            this.lblInvIdentification.Text = "Identificación";
            // 
            // lblInvDate
            // 
            this.lblInvDate.AutoSize = true;
            this.lblInvDate.Location = new System.Drawing.Point(294, 23);
            this.lblInvDate.Name = "lblInvDate";
            this.lblInvDate.Size = new System.Drawing.Size(40, 13);
            this.lblInvDate.TabIndex = 14;
            this.lblInvDate.Text = "Fecha";
            // 
            // lblInvNumber
            // 
            this.lblInvNumber.AutoSize = true;
            this.lblInvNumber.Location = new System.Drawing.Point(56, 23);
            this.lblInvNumber.Name = "lblInvNumber";
            this.lblInvNumber.Size = new System.Drawing.Size(52, 13);
            this.lblInvNumber.TabIndex = 13;
            this.lblInvNumber.Text = "Número";
            // 
            // errInvoices
            // 
            this.errInvoices.ContainerControl = this;
            // 
            // btnInvGenerate
            // 
            this.btnInvGenerate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvGenerate.Location = new System.Drawing.Point(580, 91);
            this.btnInvGenerate.Name = "btnInvGenerate";
            this.btnInvGenerate.Size = new System.Drawing.Size(86, 33);
            this.btnInvGenerate.TabIndex = 2;
            this.btnInvGenerate.Text = "Generar";
            this.tipInvoices.SetToolTip(this.btnInvGenerate, "Generar Factura");
            this.btnInvGenerate.UseVisualStyleBackColor = true;
            this.btnInvGenerate.Click += new System.EventHandler(this.btnInvGenerate_Click);
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 669);
            this.ControlBox = false;
            this.Controls.Add(this.grbPhyInvoice);
            this.Controls.Add(this.btnInvGenerate);
            this.Controls.Add(this.btnInvNew);
            this.Controls.Add(this.btnInvClose);
            this.Controls.Add(this.nudInvoiceYear);
            this.Controls.Add(this.lblInvoiceYear);
            this.Controls.Add(this.dgvInvoices);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmInvoices";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvoiceYear)).EndInit();
            this.grbPhyInvoice.ResumeLayout(false);
            this.grbPhyInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.NovaGrid dgvInvoices;
        private System.Windows.Forms.Label lblInvoiceYear;
        private System.Windows.Forms.NumericUpDown nudInvoiceYear;
        private System.Windows.Forms.ToolTip tipInvoices;
        private System.Windows.Forms.Button btnInvClose;
        private System.Windows.Forms.GroupBox grbPhyInvoice;
        private System.Windows.Forms.Button btnInvCancel;
        private System.Windows.Forms.Button btnInvSave;
        private System.Windows.Forms.TextBox txtInvTreatment;
        private System.Windows.Forms.NumericUpDown nudInvAmount;
        private System.Windows.Forms.NumericUpDown nudInvSessions;
        private System.Windows.Forms.RadioButton rdbInvOther;
        private System.Windows.Forms.RadioButton rdbInvPatient;
        private System.Windows.Forms.DateTimePicker dtpInvDate;
        private System.Windows.Forms.TextBox txtInvOther;
        private System.Windows.Forms.TextBox txtInvPatient;
        private System.Windows.Forms.TextBox txtInvIdentification;
        private System.Windows.Forms.TextBox txtInvNumber;
        private System.Windows.Forms.Label lblInvAmount;
        private System.Windows.Forms.Label lblInvSessions;
        private System.Windows.Forms.Label lblInvTreatment;
        private System.Windows.Forms.Label lblInvIdentification;
        private System.Windows.Forms.Label lblInvDate;
        private System.Windows.Forms.Label lblInvNumber;
        private System.Windows.Forms.Button btnInvNew;
        private System.Windows.Forms.ErrorProvider errInvoices;
        private System.Windows.Forms.Button btnInvDelPatient;
        private System.Windows.Forms.Button btnInvGenerate;
    }
}