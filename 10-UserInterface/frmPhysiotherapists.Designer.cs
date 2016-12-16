namespace UserInterface
{
    partial class frmPhysiotherapists
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
            this.tipPhysios = new System.Windows.Forms.ToolTip(this.components);
            this.errPhysios = new System.Windows.Forms.ErrorProvider(this.components);
            this.splPhysios = new System.Windows.Forms.SplitContainer();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvPhysios = new UserInterface.Controls.NovaGrid();
            this.tabDetails = new System.Windows.Forms.TabControl();
            this.tbpData = new System.Windows.Forms.TabPage();
            this.btnColour = new System.Windows.Forms.Button();
            this.pcbColour = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.lblColour = new System.Windows.Forms.Label();
            this.dtpTerminationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtSurname2 = new System.Windows.Forms.TextBox();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.txtSurname1 = new System.Windows.Forms.TextBox();
            this.txtLicNumber = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname2 = new System.Windows.Forms.Label();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblTerminationDate = new System.Windows.Forms.Label();
            this.lblLicNumber = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.lblSurname1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbpTimetable = new System.Windows.Forms.TabPage();
            this.btnAddTimetable = new System.Windows.Forms.Button();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateBegin = new System.Windows.Forms.DateTimePicker();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateBegin = new System.Windows.Forms.Label();
            this.dgvTimetable = new UserInterface.Controls.NovaGrid();
            ((System.ComponentModel.ISupportInitialize)(this.errPhysios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splPhysios)).BeginInit();
            this.splPhysios.Panel1.SuspendLayout();
            this.splPhysios.Panel2.SuspendLayout();
            this.splPhysios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhysios)).BeginInit();
            this.tabDetails.SuspendLayout();
            this.tbpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColour)).BeginInit();
            this.pnlGender.SuspendLayout();
            this.tbpTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // errPhysios
            // 
            this.errPhysios.ContainerControl = this;
            // 
            // splPhysios
            // 
            this.splPhysios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splPhysios.Location = new System.Drawing.Point(0, 0);
            this.splPhysios.Name = "splPhysios";
            this.splPhysios.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splPhysios.Panel1
            // 
            this.splPhysios.Panel1.Controls.Add(this.btnRefresh);
            this.splPhysios.Panel1.Controls.Add(this.btnNew);
            this.splPhysios.Panel1.Controls.Add(this.dgvPhysios);
            this.splPhysios.Panel1MinSize = 250;
            // 
            // splPhysios.Panel2
            // 
            this.splPhysios.Panel2.Controls.Add(this.tabDetails);
            this.splPhysios.Panel2MinSize = 300;
            this.splPhysios.Size = new System.Drawing.Size(930, 687);
            this.splPhysios.SplitterDistance = 333;
            this.splPhysios.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(813, 56);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 33);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refrescar";
            this.tipPhysios.SetToolTip(this.btnRefresh, "Recargar lista de Fisios");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(813, 17);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 33);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo";
            this.tipPhysios.SetToolTip(this.btnNew, "Alta de un Fisio");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvPhysios
            // 
            this.dgvPhysios.AllowUserToAddRows = false;
            this.dgvPhysios.AllowUserToDeleteRows = false;
            this.dgvPhysios.AllowUserToResizeRows = false;
            this.dgvPhysios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhysios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhysios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhysios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhysios.Location = new System.Drawing.Point(0, 0);
            this.dgvPhysios.MultiSelect = false;
            this.dgvPhysios.Name = "dgvPhysios";
            this.dgvPhysios.ReadOnly = true;
            this.dgvPhysios.RowHeadersVisible = false;
            this.dgvPhysios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPhysios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhysios.Size = new System.Drawing.Size(779, 333);
            this.dgvPhysios.TabIndex = 0;
            this.dgvPhysios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhysios_CellFormatting);
            this.dgvPhysios.SelectionChanged += new System.EventHandler(this.dgvPhysios_SelectionChanged);
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.tbpData);
            this.tabDetails.Controls.Add(this.tbpTimetable);
            this.tabDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetails.Location = new System.Drawing.Point(0, 0);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.SelectedIndex = 0;
            this.tabDetails.Size = new System.Drawing.Size(930, 350);
            this.tabDetails.TabIndex = 11;
            // 
            // tbpData
            // 
            this.tbpData.Controls.Add(this.btnColour);
            this.tbpData.Controls.Add(this.pcbColour);
            this.tbpData.Controls.Add(this.btnCancel);
            this.tbpData.Controls.Add(this.btnSave);
            this.tbpData.Controls.Add(this.pnlGender);
            this.tbpData.Controls.Add(this.lblColour);
            this.tbpData.Controls.Add(this.dtpTerminationDate);
            this.tbpData.Controls.Add(this.dtpEntryDate);
            this.tbpData.Controls.Add(this.txtAlias);
            this.tbpData.Controls.Add(this.txtSurname2);
            this.tbpData.Controls.Add(this.txtIdentification);
            this.tbpData.Controls.Add(this.txtSurname1);
            this.tbpData.Controls.Add(this.txtLicNumber);
            this.tbpData.Controls.Add(this.lblAlias);
            this.tbpData.Controls.Add(this.txtName);
            this.tbpData.Controls.Add(this.lblSurname2);
            this.tbpData.Controls.Add(this.lblIdentification);
            this.tbpData.Controls.Add(this.lblIdValue);
            this.tbpData.Controls.Add(this.lblTerminationDate);
            this.tbpData.Controls.Add(this.lblLicNumber);
            this.tbpData.Controls.Add(this.lblEntryDate);
            this.tbpData.Controls.Add(this.lblSurname1);
            this.tbpData.Controls.Add(this.lblName);
            this.tbpData.Controls.Add(this.lblId);
            this.tbpData.Location = new System.Drawing.Point(4, 22);
            this.tbpData.Name = "tbpData";
            this.tbpData.Padding = new System.Windows.Forms.Padding(3);
            this.tbpData.Size = new System.Drawing.Size(922, 324);
            this.tbpData.TabIndex = 0;
            this.tbpData.Text = "Datos profesionales";
            this.tbpData.UseVisualStyleBackColor = true;
            // 
            // btnColour
            // 
            this.btnColour.Location = new System.Drawing.Point(541, 162);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(32, 25);
            this.btnColour.TabIndex = 28;
            this.btnColour.Text = "...";
            this.tipPhysios.SetToolTip(this.btnColour, "Seleccionar color");
            this.btnColour.UseVisualStyleBackColor = true;
            // 
            // pcbColour
            // 
            this.pcbColour.Location = new System.Drawing.Point(395, 162);
            this.pcbColour.Name = "pcbColour";
            this.pcbColour.Size = new System.Drawing.Size(140, 25);
            this.pcbColour.TabIndex = 29;
            this.pcbColour.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(719, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 33);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancelar";
            this.tipPhysios.SetToolTip(this.btnCancel, "Cancelar alta Fisio");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(811, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 33);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Guardar";
            this.tipPhysios.SetToolTip(this.btnSave, "Cuardar cambios de un Fisio");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.lblGender);
            this.pnlGender.Controls.Add(this.radFemale);
            this.pnlGender.Controls.Add(this.radMale);
            this.pnlGender.Location = new System.Drawing.Point(13, 141);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(253, 68);
            this.pnlGender.TabIndex = 27;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(8, 27);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(49, 13);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Género";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(173, 25);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(57, 17);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Tag = "M";
            this.radFemale.Text = "Mujer";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(88, 25);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(70, 17);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Tag = "H";
            this.radMale.Text = "Hombre";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(295, 168);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(38, 13);
            this.lblColour.TabIndex = 26;
            this.lblColour.Text = "Color";
            // 
            // dtpTerminationDate
            // 
            this.dtpTerminationDate.CustomFormat = "dd/MM/yyyy";
            this.dtpTerminationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTerminationDate.Location = new System.Drawing.Point(711, 100);
            this.dtpTerminationDate.Name = "dtpTerminationDate";
            this.dtpTerminationDate.ShowCheckBox = true;
            this.dtpTerminationDate.Size = new System.Drawing.Size(178, 21);
            this.dtpTerminationDate.TabIndex = 25;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntryDate.Location = new System.Drawing.Point(387, 100);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(178, 21);
            this.dtpEntryDate.TabIndex = 24;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(72, 103);
            this.txtAlias.MaxLength = 50;
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(178, 21);
            this.txtAlias.TabIndex = 23;
            // 
            // txtSurname2
            // 
            this.txtSurname2.Location = new System.Drawing.Point(711, 52);
            this.txtSurname2.MaxLength = 50;
            this.txtSurname2.Name = "txtSurname2";
            this.txtSurname2.Size = new System.Drawing.Size(178, 21);
            this.txtSurname2.TabIndex = 22;
            // 
            // txtIdentification
            // 
            this.txtIdentification.Location = new System.Drawing.Point(711, 8);
            this.txtIdentification.MaxLength = 20;
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(178, 21);
            this.txtIdentification.TabIndex = 19;
            // 
            // txtSurname1
            // 
            this.txtSurname1.Location = new System.Drawing.Point(387, 52);
            this.txtSurname1.MaxLength = 50;
            this.txtSurname1.Name = "txtSurname1";
            this.txtSurname1.Size = new System.Drawing.Size(178, 21);
            this.txtSurname1.TabIndex = 21;
            // 
            // txtLicNumber
            // 
            this.txtLicNumber.Location = new System.Drawing.Point(264, 13);
            this.txtLicNumber.MaxLength = 50;
            this.txtLicNumber.Name = "txtLicNumber";
            this.txtLicNumber.Size = new System.Drawing.Size(178, 21);
            this.txtLicNumber.TabIndex = 9;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(13, 106);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(34, 13);
            this.lblAlias.TabIndex = 8;
            this.lblAlias.Text = "Alias";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 52);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 21);
            this.txtName.TabIndex = 20;
            // 
            // lblSurname2
            // 
            this.lblSurname2.AutoSize = true;
            this.lblSurname2.Location = new System.Drawing.Point(599, 55);
            this.lblSurname2.Name = "lblSurname2";
            this.lblSurname2.Size = new System.Drawing.Size(106, 13);
            this.lblSurname2.TabIndex = 12;
            this.lblSurname2.Text = "Segundo Apellido";
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.Location = new System.Drawing.Point(471, 16);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(206, 13);
            this.lblIdentification.TabIndex = 11;
            this.lblIdentification.Text = "Identificación (N.I.F., Pasaporte,...)";
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValue.Location = new System.Drawing.Point(100, 16);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(15, 13);
            this.lblIdValue.TabIndex = 18;
            this.lblIdValue.Text = "0";
            // 
            // lblTerminationDate
            // 
            this.lblTerminationDate.AutoSize = true;
            this.lblTerminationDate.Location = new System.Drawing.Point(599, 106);
            this.lblTerminationDate.Name = "lblTerminationDate";
            this.lblTerminationDate.Size = new System.Drawing.Size(70, 13);
            this.lblTerminationDate.TabIndex = 10;
            this.lblTerminationDate.Text = "Fecha Baja";
            // 
            // lblLicNumber
            // 
            this.lblLicNumber.AutoSize = true;
            this.lblLicNumber.Location = new System.Drawing.Point(145, 16);
            this.lblLicNumber.Name = "lblLicNumber";
            this.lblLicNumber.Size = new System.Drawing.Size(113, 13);
            this.lblLicNumber.TabIndex = 13;
            this.lblLicNumber.Text = "Número Colegiado";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Location = new System.Drawing.Point(287, 106);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(66, 13);
            this.lblEntryDate.TabIndex = 17;
            this.lblEntryDate.Text = "Fecha Alta";
            // 
            // lblSurname1
            // 
            this.lblSurname1.AutoSize = true;
            this.lblSurname1.Location = new System.Drawing.Point(287, 55);
            this.lblSurname1.Name = "lblSurname1";
            this.lblSurname1.Size = new System.Drawing.Size(94, 13);
            this.lblSurname1.TabIndex = 16;
            this.lblSurname1.Text = "Primer Apellido";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(79, 13);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Identificador";
            // 
            // tbpTimetable
            // 
            this.tbpTimetable.Controls.Add(this.btnAddTimetable);
            this.tbpTimetable.Controls.Add(this.dtpDateEnd);
            this.tbpTimetable.Controls.Add(this.dtpDateBegin);
            this.tbpTimetable.Controls.Add(this.lblDateEnd);
            this.tbpTimetable.Controls.Add(this.lblDateBegin);
            this.tbpTimetable.Controls.Add(this.dgvTimetable);
            this.tbpTimetable.Location = new System.Drawing.Point(4, 22);
            this.tbpTimetable.Name = "tbpTimetable";
            this.tbpTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTimetable.Size = new System.Drawing.Size(922, 324);
            this.tbpTimetable.TabIndex = 1;
            this.tbpTimetable.Text = "Horario";
            this.tbpTimetable.UseVisualStyleBackColor = true;
            // 
            // btnAddTimetable
            // 
            this.btnAddTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTimetable.Location = new System.Drawing.Point(809, 39);
            this.btnAddTimetable.Name = "btnAddTimetable";
            this.btnAddTimetable.Size = new System.Drawing.Size(86, 33);
            this.btnAddTimetable.TabIndex = 3;
            this.btnAddTimetable.Text = "Nuevo...";
            this.tipPhysios.SetToolTip(this.btnAddTimetable, "Nuevo Horario");
            this.btnAddTimetable.UseVisualStyleBackColor = true;
            this.btnAddTimetable.Click += new System.EventHandler(this.btnAddTimetable_Click);
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Checked = false;
            this.dtpDateEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateEnd.Location = new System.Drawing.Point(296, 12);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.ShowCheckBox = true;
            this.dtpDateEnd.Size = new System.Drawing.Size(112, 21);
            this.dtpDateEnd.TabIndex = 2;
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateEnd_ValueChanged);
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.Checked = false;
            this.dtpDateBegin.CustomFormat = "dd/MM/yyyy";
            this.dtpDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBegin.Location = new System.Drawing.Point(86, 12);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.ShowCheckBox = true;
            this.dtpDateBegin.Size = new System.Drawing.Size(112, 21);
            this.dtpDateBegin.TabIndex = 2;
            this.dtpDateBegin.ValueChanged += new System.EventHandler(this.dtpDateBegin_ValueChanged);
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(230, 18);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(60, 13);
            this.lblDateEnd.TabIndex = 1;
            this.lblDateEnd.Text = "Fecha Fin";
            // 
            // lblDateBegin
            // 
            this.lblDateBegin.AutoSize = true;
            this.lblDateBegin.Location = new System.Drawing.Point(5, 18);
            this.lblDateBegin.Name = "lblDateBegin";
            this.lblDateBegin.Size = new System.Drawing.Size(75, 13);
            this.lblDateBegin.TabIndex = 1;
            this.lblDateBegin.Text = "Fecha Inicio";
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.AllowUserToAddRows = false;
            this.dgvTimetable.AllowUserToDeleteRows = false;
            this.dgvTimetable.AllowUserToResizeRows = false;
            this.dgvTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimetable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Location = new System.Drawing.Point(8, 39);
            this.dgvTimetable.MultiSelect = false;
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.ReadOnly = true;
            this.dgvTimetable.RowHeadersVisible = false;
            this.dgvTimetable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimetable.Size = new System.Drawing.Size(767, 277);
            this.dgvTimetable.TabIndex = 0;
            this.dgvTimetable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTimetable_CellMouseDoubleClick);
            // 
            // frmPhysiotherapists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 687);
            this.Controls.Add(this.splPhysios);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPhysiotherapists";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fisioterapeutas";
            this.Load += new System.EventHandler(this.frmPhysiotherapists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errPhysios)).EndInit();
            this.splPhysios.Panel1.ResumeLayout(false);
            this.splPhysios.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splPhysios)).EndInit();
            this.splPhysios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhysios)).EndInit();
            this.tabDetails.ResumeLayout(false);
            this.tbpData.ResumeLayout(false);
            this.tbpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColour)).EndInit();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.tbpTimetable.ResumeLayout(false);
            this.tbpTimetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splPhysios;
        private Controls.NovaGrid dgvPhysios;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ToolTip tipPhysios;
        private System.Windows.Forms.ErrorProvider errPhysios;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabDetails;
        private System.Windows.Forms.TabPage tbpData;
        private System.Windows.Forms.TabPage tbpTimetable;
        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.PictureBox pcbColour;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.DateTimePicker dtpTerminationDate;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtSurname2;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.TextBox txtSurname1;
        private System.Windows.Forms.TextBox txtLicNumber;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname2;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblTerminationDate;
        private System.Windows.Forms.Label lblLicNumber;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblSurname1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private Controls.NovaGrid dgvTimetable;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateBegin;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblDateBegin;
        private System.Windows.Forms.Button btnAddTimetable;

    }
}