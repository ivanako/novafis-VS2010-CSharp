namespace UserInterface
{
    partial class frmTreatment
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblSessions = new System.Windows.Forms.Label();
            this.nudSessions = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatuses = new System.Windows.Forms.ComboBox();
            this.lblPhysio = new System.Windows.Forms.Label();
            this.cboPhysiotherapists = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grbLocation = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.radLocNew = new System.Windows.Forms.RadioButton();
            this.cboLocations = new System.Windows.Forms.ComboBox();
            this.radLocSelect = new System.Windows.Forms.RadioButton();
            this.grbLesion = new System.Windows.Forms.GroupBox();
            this.txtLesion = new System.Windows.Forms.TextBox();
            this.radLesNew = new System.Windows.Forms.RadioButton();
            this.cboLesions = new System.Windows.Forms.ComboBox();
            this.radLesSelect = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tipTreatment = new System.Windows.Forms.ToolTip(this.components);
            this.errTreatment = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSessions)).BeginInit();
            this.grbLocation.SuspendLayout();
            this.grbLesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTreatment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Fecha";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(100, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(142, 21);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblSessions
            // 
            this.lblSessions.AutoSize = true;
            this.lblSessions.Location = new System.Drawing.Point(14, 58);
            this.lblSessions.Name = "lblSessions";
            this.lblSessions.Size = new System.Drawing.Size(58, 13);
            this.lblSessions.TabIndex = 2;
            this.lblSessions.Text = "Sesiones";
            // 
            // nudSessions
            // 
            this.nudSessions.Location = new System.Drawing.Point(100, 56);
            this.nudSessions.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSessions.Name = "nudSessions";
            this.nudSessions.Size = new System.Drawing.Size(98, 21);
            this.nudSessions.TabIndex = 3;
            this.nudSessions.ValueChanged += new System.EventHandler(this.nudSessions_ValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(305, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Estado";
            // 
            // cboStatuses
            // 
            this.cboStatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatuses.FormattingEnabled = true;
            this.cboStatuses.Location = new System.Drawing.Point(380, 15);
            this.cboStatuses.Name = "cboStatuses";
            this.cboStatuses.Size = new System.Drawing.Size(108, 21);
            this.cboStatuses.TabIndex = 5;
            this.cboStatuses.SelectedIndexChanged += new System.EventHandler(this.cboStatuses_SelectedIndexChanged);
            // 
            // lblPhysio
            // 
            this.lblPhysio.AutoSize = true;
            this.lblPhysio.Location = new System.Drawing.Point(305, 56);
            this.lblPhysio.Name = "lblPhysio";
            this.lblPhysio.Size = new System.Drawing.Size(32, 13);
            this.lblPhysio.TabIndex = 4;
            this.lblPhysio.Text = "Fisio";
            // 
            // cboPhysiotherapists
            // 
            this.cboPhysiotherapists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhysiotherapists.FormattingEnabled = true;
            this.cboPhysiotherapists.Location = new System.Drawing.Point(380, 53);
            this.cboPhysiotherapists.Name = "cboPhysiotherapists";
            this.cboPhysiotherapists.Size = new System.Drawing.Size(108, 21);
            this.cboPhysiotherapists.TabIndex = 5;
            this.cboPhysiotherapists.SelectedIndexChanged += new System.EventHandler(this.cboPhysiotherapists_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 112);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(166, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Descripción del Tratamiento";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(17, 137);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(471, 43);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // grbLocation
            // 
            this.grbLocation.Controls.Add(this.txtLocation);
            this.grbLocation.Controls.Add(this.radLocNew);
            this.grbLocation.Controls.Add(this.cboLocations);
            this.grbLocation.Controls.Add(this.radLocSelect);
            this.grbLocation.Location = new System.Drawing.Point(17, 206);
            this.grbLocation.Name = "grbLocation";
            this.grbLocation.Size = new System.Drawing.Size(247, 172);
            this.grbLocation.TabIndex = 7;
            this.grbLocation.TabStop = false;
            this.grbLocation.Text = "Localización";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(13, 108);
            this.txtLocation.MaxLength = 100;
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(212, 39);
            this.txtLocation.TabIndex = 8;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // radLocNew
            // 
            this.radLocNew.AutoSize = true;
            this.radLocNew.Location = new System.Drawing.Point(14, 75);
            this.radLocNew.Name = "radLocNew";
            this.radLocNew.Size = new System.Drawing.Size(133, 17);
            this.radLocNew.TabIndex = 7;
            this.radLocNew.TabStop = true;
            this.radLocNew.Text = "Nueva Localización";
            this.radLocNew.UseVisualStyleBackColor = true;
            this.radLocNew.CheckedChanged += new System.EventHandler(this.radLocNew_CheckedChanged);
            // 
            // cboLocations
            // 
            this.cboLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocations.FormattingEnabled = true;
            this.cboLocations.Location = new System.Drawing.Point(34, 33);
            this.cboLocations.Name = "cboLocations";
            this.cboLocations.Size = new System.Drawing.Size(192, 21);
            this.cboLocations.TabIndex = 6;
            this.cboLocations.SelectedIndexChanged += new System.EventHandler(this.cboLocations_SelectedIndexChanged);
            // 
            // radLocSelect
            // 
            this.radLocSelect.AutoSize = true;
            this.radLocSelect.Location = new System.Drawing.Point(14, 36);
            this.radLocSelect.Name = "radLocSelect";
            this.radLocSelect.Size = new System.Drawing.Size(14, 13);
            this.radLocSelect.TabIndex = 0;
            this.radLocSelect.TabStop = true;
            this.radLocSelect.UseVisualStyleBackColor = true;
            this.radLocSelect.CheckedChanged += new System.EventHandler(this.radLocSelect_CheckedChanged);
            // 
            // grbLesion
            // 
            this.grbLesion.Controls.Add(this.txtLesion);
            this.grbLesion.Controls.Add(this.radLesNew);
            this.grbLesion.Controls.Add(this.cboLesions);
            this.grbLesion.Controls.Add(this.radLesSelect);
            this.grbLesion.Location = new System.Drawing.Point(292, 206);
            this.grbLesion.Name = "grbLesion";
            this.grbLesion.Size = new System.Drawing.Size(247, 172);
            this.grbLesion.TabIndex = 7;
            this.grbLesion.TabStop = false;
            this.grbLesion.Text = "Lesión";
            // 
            // txtLesion
            // 
            this.txtLesion.Location = new System.Drawing.Point(13, 108);
            this.txtLesion.MaxLength = 100;
            this.txtLesion.Multiline = true;
            this.txtLesion.Name = "txtLesion";
            this.txtLesion.Size = new System.Drawing.Size(212, 39);
            this.txtLesion.TabIndex = 8;
            this.txtLesion.TextChanged += new System.EventHandler(this.txtLesion_TextChanged);
            // 
            // radLesNew
            // 
            this.radLesNew.AutoSize = true;
            this.radLesNew.Location = new System.Drawing.Point(14, 75);
            this.radLesNew.Name = "radLesNew";
            this.radLesNew.Size = new System.Drawing.Size(101, 17);
            this.radLesNew.TabIndex = 7;
            this.radLesNew.TabStop = true;
            this.radLesNew.Text = "Nueva Lesión";
            this.radLesNew.UseVisualStyleBackColor = true;
            this.radLesNew.CheckedChanged += new System.EventHandler(this.radLesNew_CheckedChanged);
            // 
            // cboLesions
            // 
            this.cboLesions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLesions.FormattingEnabled = true;
            this.cboLesions.Location = new System.Drawing.Point(34, 33);
            this.cboLesions.Name = "cboLesions";
            this.cboLesions.Size = new System.Drawing.Size(192, 21);
            this.cboLesions.TabIndex = 6;
            this.cboLesions.SelectedIndexChanged += new System.EventHandler(this.cboLesions_SelectedIndexChanged);
            // 
            // radLesSelect
            // 
            this.radLesSelect.AutoSize = true;
            this.radLesSelect.Location = new System.Drawing.Point(14, 36);
            this.radLesSelect.Name = "radLesSelect";
            this.radLesSelect.Size = new System.Drawing.Size(14, 13);
            this.radLesSelect.TabIndex = 0;
            this.radLesSelect.TabStop = true;
            this.radLesSelect.UseVisualStyleBackColor = true;
            this.radLesSelect.CheckedChanged += new System.EventHandler(this.radLesSelect_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(453, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 33);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cerrar";
            this.tipTreatment.SetToolTip(this.btnClose, "Cerrar Tratamiento");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(352, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.tipTreatment.SetToolTip(this.btnSave, "Guardar Tratamiento");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errTreatment
            // 
            this.errTreatment.ContainerControl = this;
            // 
            // frmTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 448);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbLesion);
            this.Controls.Add(this.grbLocation);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cboPhysiotherapists);
            this.Controls.Add(this.cboStatuses);
            this.Controls.Add(this.lblPhysio);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.nudSessions);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSessions);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTreatment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamiento";
            this.Load += new System.EventHandler(this.frmTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSessions)).EndInit();
            this.grbLocation.ResumeLayout(false);
            this.grbLocation.PerformLayout();
            this.grbLesion.ResumeLayout(false);
            this.grbLesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTreatment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblSessions;
        private System.Windows.Forms.NumericUpDown nudSessions;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatuses;
        private System.Windows.Forms.Label lblPhysio;
        private System.Windows.Forms.ComboBox cboPhysiotherapists;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox grbLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.RadioButton radLocNew;
        private System.Windows.Forms.ComboBox cboLocations;
        private System.Windows.Forms.RadioButton radLocSelect;
        private System.Windows.Forms.GroupBox grbLesion;
        private System.Windows.Forms.TextBox txtLesion;
        private System.Windows.Forms.RadioButton radLesNew;
        private System.Windows.Forms.ComboBox cboLesions;
        private System.Windows.Forms.RadioButton radLesSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip tipTreatment;
        private System.Windows.Forms.ErrorProvider errTreatment;
    }
}