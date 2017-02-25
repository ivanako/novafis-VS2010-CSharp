namespace UserInterface
{
    partial class frmPatientsDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panButtons = new System.Windows.Forms.Panel();
            this.chkBlackList = new System.Windows.Forms.CheckBox();
            this.cboPhysios = new System.Windows.Forms.ComboBox();
            this.lblRefPhysio = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panDetails = new System.Windows.Forms.Panel();
            this.tabDetails = new System.Windows.Forms.TabControl();
            this.tbpData = new System.Windows.Forms.TabPage();
            this.cboSources = new System.Windows.Forms.ComboBox();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.lblIdentifierValue = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblHowHeardAboutUs = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.lblSurname2 = new System.Windows.Forms.Label();
            this.lblSurname1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.txtHowHeardAboutUs = new System.Windows.Forms.TextBox();
            this.txtSurname2 = new System.Windows.Forms.TextBox();
            this.txtSurname1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.tbpAddress = new System.Windows.Forms.TabPage();
            this.cboProvinces = new System.Windows.Forms.ComboBox();
            this.lblGate = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPhone3 = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStair = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblBlock = new System.Windows.Forms.Label();
            this.txtGate = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone3 = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtStair = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.txtThoroughfare = new System.Windows.Forms.TextBox();
            this.lblThoroughfare = new System.Windows.Forms.Label();
            this.tbpCancellations = new System.Windows.Forms.TabPage();
            this.btnCancCancel = new System.Windows.Forms.Button();
            this.btnCancSave = new System.Windows.Forms.Button();
            this.btnCancAdd = new System.Windows.Forms.Button();
            this.txtCancReason = new System.Windows.Forms.TextBox();
            this.lblCancReason = new System.Windows.Forms.Label();
            this.dtpCancDate = new System.Windows.Forms.DateTimePicker();
            this.lblCancDate = new System.Windows.Forms.Label();
            this.tbpObservations = new System.Windows.Forms.TabPage();
            this.btnObsCancel = new System.Windows.Forms.Button();
            this.btnObsSave = new System.Windows.Forms.Button();
            this.txtObsDescription = new System.Windows.Forms.TextBox();
            this.lblObsDescription = new System.Windows.Forms.Label();
            this.btnObsAdd = new System.Windows.Forms.Button();
            this.tbpTreatments = new System.Windows.Forms.TabPage();
            this.btnTreatsAdd = new System.Windows.Forms.Button();
            this.tipPatientsDetail = new System.Windows.Forms.ToolTip(this.components);
            this.errObservations = new System.Windows.Forms.ErrorProvider(this.components);
            this.errData = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCancellations = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnObsDelete = new System.Windows.Forms.Button();
            this.btnTreatsDelete = new System.Windows.Forms.Button();
            this.dgvCancellations = new UserInterface.Controls.NovaGrid();
            this.dgvObservations = new UserInterface.Controls.NovaGrid();
            this.dgvTreatments = new UserInterface.Controls.NovaGrid();
            this.panButtons.SuspendLayout();
            this.panDetails.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.tbpData.SuspendLayout();
            this.grbGender.SuspendLayout();
            this.tbpAddress.SuspendLayout();
            this.tbpCancellations.SuspendLayout();
            this.tbpObservations.SuspendLayout();
            this.tbpTreatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errObservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCancellations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancellations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.chkBlackList);
            this.panButtons.Controls.Add(this.cboPhysios);
            this.panButtons.Controls.Add(this.lblRefPhysio);
            this.panButtons.Controls.Add(this.btnSave);
            this.panButtons.Controls.Add(this.btnClose);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtons.Location = new System.Drawing.Point(0, 395);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(1009, 58);
            this.panButtons.TabIndex = 1;
            // 
            // chkBlackList
            // 
            this.chkBlackList.AutoSize = true;
            this.chkBlackList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBlackList.ForeColor = System.Drawing.Color.Red;
            this.chkBlackList.Location = new System.Drawing.Point(575, 22);
            this.chkBlackList.Name = "chkBlackList";
            this.chkBlackList.Size = new System.Drawing.Size(89, 17);
            this.chkBlackList.TabIndex = 1;
            this.chkBlackList.Text = "Lista negra";
            this.chkBlackList.UseVisualStyleBackColor = true;
            // 
            // cboPhysios
            // 
            this.cboPhysios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhysios.FormattingEnabled = true;
            this.cboPhysios.Location = new System.Drawing.Point(142, 20);
            this.cboPhysios.Name = "cboPhysios";
            this.cboPhysios.Size = new System.Drawing.Size(400, 21);
            this.cboPhysios.TabIndex = 0;
            this.cboPhysios.SelectedIndexChanged += new System.EventHandler(this.cboPhysios_SelectedIndexChanged);
            // 
            // lblRefPhysio
            // 
            this.lblRefPhysio.AutoSize = true;
            this.lblRefPhysio.Location = new System.Drawing.Point(42, 23);
            this.lblRefPhysio.Name = "lblRefPhysio";
            this.lblRefPhysio.Size = new System.Drawing.Size(94, 13);
            this.lblRefPhysio.TabIndex = 4;
            this.lblRefPhysio.Text = "Fiso Referencia";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(809, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.tipPatientsDetail.SetToolTip(this.btnSave, "Guardar Datos del Paciente");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(911, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cerrar";
            this.tipPatientsDetail.SetToolTip(this.btnClose, "Cerrar ventana");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panDetails
            // 
            this.panDetails.Controls.Add(this.tabDetails);
            this.panDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDetails.Location = new System.Drawing.Point(0, 0);
            this.panDetails.Name = "panDetails";
            this.panDetails.Size = new System.Drawing.Size(1009, 395);
            this.panDetails.TabIndex = 2;
            // 
            // tabDetails
            // 
            this.tabDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDetails.Controls.Add(this.tbpData);
            this.tabDetails.Controls.Add(this.tbpAddress);
            this.tabDetails.Controls.Add(this.tbpCancellations);
            this.tabDetails.Controls.Add(this.tbpObservations);
            this.tabDetails.Controls.Add(this.tbpTreatments);
            this.tabDetails.Location = new System.Drawing.Point(0, 0);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.SelectedIndex = 0;
            this.tabDetails.Size = new System.Drawing.Size(1009, 395);
            this.tabDetails.TabIndex = 1;
            this.tabDetails.SelectedIndexChanged += new System.EventHandler(this.tabDetails_SelectedIndexChanged);
            this.tabDetails.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabDetails_Selected);
            // 
            // tbpData
            // 
            this.tbpData.Controls.Add(this.cboSources);
            this.tbpData.Controls.Add(this.grbGender);
            this.tbpData.Controls.Add(this.dtpBirthDate);
            this.tbpData.Controls.Add(this.dtpEntryDate);
            this.tbpData.Controls.Add(this.lblIdentifierValue);
            this.tbpData.Controls.Add(this.lblSource);
            this.tbpData.Controls.Add(this.lblHowHeardAboutUs);
            this.tbpData.Controls.Add(this.lblBirthDate);
            this.tbpData.Controls.Add(this.lblEntryDate);
            this.tbpData.Controls.Add(this.lblIdentification);
            this.tbpData.Controls.Add(this.lblSurname2);
            this.tbpData.Controls.Add(this.lblSurname1);
            this.tbpData.Controls.Add(this.lblName);
            this.tbpData.Controls.Add(this.txtIdentification);
            this.tbpData.Controls.Add(this.txtHowHeardAboutUs);
            this.tbpData.Controls.Add(this.txtSurname2);
            this.tbpData.Controls.Add(this.txtSurname1);
            this.tbpData.Controls.Add(this.txtName);
            this.tbpData.Controls.Add(this.lblIdentifier);
            this.tbpData.Location = new System.Drawing.Point(4, 22);
            this.tbpData.Name = "tbpData";
            this.tbpData.Padding = new System.Windows.Forms.Padding(3);
            this.tbpData.Size = new System.Drawing.Size(1001, 369);
            this.tbpData.TabIndex = 0;
            this.tbpData.Text = "Datos personales";
            this.tbpData.UseVisualStyleBackColor = true;
            // 
            // cboSources
            // 
            this.cboSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSources.FormattingEnabled = true;
            this.cboSources.Location = new System.Drawing.Point(138, 278);
            this.cboSources.Name = "cboSources";
            this.cboSources.Size = new System.Drawing.Size(399, 21);
            this.cboSources.TabIndex = 9;
            this.cboSources.SelectedIndexChanged += new System.EventHandler(this.cboSources_SelectedIndexChanged);
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.radFemale);
            this.grbGender.Controls.Add(this.radMale);
            this.grbGender.Location = new System.Drawing.Point(353, 122);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(184, 76);
            this.grbGender.TabIndex = 8;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Sexo";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(95, 30);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(57, 17);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Tag = "M";
            this.radFemale.Text = "Mujer";
            this.radFemale.UseVisualStyleBackColor = true;
            this.radFemale.CheckedChanged += new System.EventHandler(this.radFemale_CheckedChanged);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(19, 30);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(70, 17);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Tag = "H";
            this.radMale.Text = "Hombre";
            this.radMale.UseVisualStyleBackColor = true;
            this.radMale.CheckedChanged += new System.EventHandler(this.radMale_CheckedChanged);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(138, 177);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.ShowCheckBox = true;
            this.dtpBirthDate.Size = new System.Drawing.Size(163, 21);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntryDate.Location = new System.Drawing.Point(138, 150);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(163, 21);
            this.dtpEntryDate.TabIndex = 4;
            this.dtpEntryDate.ValueChanged += new System.EventHandler(this.dtpEntryDate_ValueChanged);
            // 
            // lblIdentifierValue
            // 
            this.lblIdentifierValue.AutoSize = true;
            this.lblIdentifierValue.BackColor = System.Drawing.Color.White;
            this.lblIdentifierValue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifierValue.Location = new System.Drawing.Point(138, 14);
            this.lblIdentifierValue.Name = "lblIdentifierValue";
            this.lblIdentifierValue.Size = new System.Drawing.Size(67, 13);
            this.lblIdentifierValue.TabIndex = 3;
            this.lblIdentifierValue.Text = "Matrícula";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(87, 281);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(45, 13);
            this.lblSource.TabIndex = 2;
            this.lblSource.Text = "Fuente";
            // 
            // lblHowHeardAboutUs
            // 
            this.lblHowHeardAboutUs.AutoSize = true;
            this.lblHowHeardAboutUs.Location = new System.Drawing.Point(8, 210);
            this.lblHowHeardAboutUs.Name = "lblHowHeardAboutUs";
            this.lblHowHeardAboutUs.Size = new System.Drawing.Size(124, 13);
            this.lblHowHeardAboutUs.TabIndex = 2;
            this.lblHowHeardAboutUs.Text = "¿Cómo nos conoció?";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(26, 182);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(106, 13);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Fecha nacimiento";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Location = new System.Drawing.Point(44, 154);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(88, 13);
            this.lblEntryDate.TabIndex = 2;
            this.lblEntryDate.Text = "Fecha registro";
            // 
            // lblIdentification
            // 
            this.lblIdentification.Location = new System.Drawing.Point(11, 120);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(121, 28);
            this.lblIdentification.TabIndex = 2;
            this.lblIdentification.Text = "Identificación (N.I.F., Pasaporte)";
            this.lblIdentification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSurname2
            // 
            this.lblSurname2.AutoSize = true;
            this.lblSurname2.Location = new System.Drawing.Point(27, 98);
            this.lblSurname2.Name = "lblSurname2";
            this.lblSurname2.Size = new System.Drawing.Size(105, 13);
            this.lblSurname2.TabIndex = 2;
            this.lblSurname2.Text = "Segundo apellido";
            // 
            // lblSurname1
            // 
            this.lblSurname1.AutoSize = true;
            this.lblSurname1.Location = new System.Drawing.Point(39, 70);
            this.lblSurname1.Name = "lblSurname1";
            this.lblSurname1.Size = new System.Drawing.Size(93, 13);
            this.lblSurname1.TabIndex = 2;
            this.lblSurname1.Text = "Primer apellido";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre";
            // 
            // txtIdentification
            // 
            this.txtIdentification.Location = new System.Drawing.Point(138, 123);
            this.txtIdentification.MaxLength = 20;
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(200, 21);
            this.txtIdentification.TabIndex = 3;
            this.txtIdentification.TextChanged += new System.EventHandler(this.txtIdentification_TextChanged);
            // 
            // txtHowHeardAboutUs
            // 
            this.txtHowHeardAboutUs.Location = new System.Drawing.Point(138, 207);
            this.txtHowHeardAboutUs.MaxLength = 100;
            this.txtHowHeardAboutUs.Multiline = true;
            this.txtHowHeardAboutUs.Name = "txtHowHeardAboutUs";
            this.txtHowHeardAboutUs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHowHeardAboutUs.Size = new System.Drawing.Size(400, 55);
            this.txtHowHeardAboutUs.TabIndex = 7;
            this.txtHowHeardAboutUs.TextChanged += new System.EventHandler(this.txtHowHeardAboutUs_TextChanged);
            // 
            // txtSurname2
            // 
            this.txtSurname2.Location = new System.Drawing.Point(138, 95);
            this.txtSurname2.MaxLength = 50;
            this.txtSurname2.Name = "txtSurname2";
            this.txtSurname2.Size = new System.Drawing.Size(400, 21);
            this.txtSurname2.TabIndex = 2;
            this.txtSurname2.TextChanged += new System.EventHandler(this.txtSurname2_TextChanged);
            // 
            // txtSurname1
            // 
            this.txtSurname1.Location = new System.Drawing.Point(138, 67);
            this.txtSurname1.MaxLength = 50;
            this.txtSurname1.Name = "txtSurname1";
            this.txtSurname1.Size = new System.Drawing.Size(400, 21);
            this.txtSurname1.TabIndex = 1;
            this.txtSurname1.TextChanged += new System.EventHandler(this.txtSurname1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 39);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 21);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblIdentifier
            // 
            this.lblIdentifier.AutoSize = true;
            this.lblIdentifier.Location = new System.Drawing.Point(74, 14);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(58, 13);
            this.lblIdentifier.TabIndex = 0;
            this.lblIdentifier.Text = "Matrícula";
            // 
            // tbpAddress
            // 
            this.tbpAddress.Controls.Add(this.cboProvinces);
            this.tbpAddress.Controls.Add(this.lblGate);
            this.tbpAddress.Controls.Add(this.lblFloor);
            this.tbpAddress.Controls.Add(this.lblProvince);
            this.tbpAddress.Controls.Add(this.lblPhone3);
            this.tbpAddress.Controls.Add(this.lblWeb);
            this.tbpAddress.Controls.Add(this.lblPhone2);
            this.tbpAddress.Controls.Add(this.lblEmail);
            this.tbpAddress.Controls.Add(this.lblPhone1);
            this.tbpAddress.Controls.Add(this.lblPostCode);
            this.tbpAddress.Controls.Add(this.lblCity);
            this.tbpAddress.Controls.Add(this.lblStair);
            this.tbpAddress.Controls.Add(this.lblNumber);
            this.tbpAddress.Controls.Add(this.lblBlock);
            this.tbpAddress.Controls.Add(this.txtGate);
            this.tbpAddress.Controls.Add(this.txtFloor);
            this.tbpAddress.Controls.Add(this.txtCity);
            this.tbpAddress.Controls.Add(this.txtPhone3);
            this.tbpAddress.Controls.Add(this.txtPhone2);
            this.tbpAddress.Controls.Add(this.txtWeb);
            this.tbpAddress.Controls.Add(this.txtEmail);
            this.tbpAddress.Controls.Add(this.txtPhone1);
            this.tbpAddress.Controls.Add(this.txtPostCode);
            this.tbpAddress.Controls.Add(this.txtStair);
            this.tbpAddress.Controls.Add(this.txtNumber);
            this.tbpAddress.Controls.Add(this.txtBlock);
            this.tbpAddress.Controls.Add(this.txtThoroughfare);
            this.tbpAddress.Controls.Add(this.lblThoroughfare);
            this.tbpAddress.Location = new System.Drawing.Point(4, 22);
            this.tbpAddress.Name = "tbpAddress";
            this.tbpAddress.Size = new System.Drawing.Size(1001, 369);
            this.tbpAddress.TabIndex = 1;
            this.tbpAddress.Text = "Dirección";
            this.tbpAddress.UseVisualStyleBackColor = true;
            // 
            // cboProvinces
            // 
            this.cboProvinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvinces.FormattingEnabled = true;
            this.cboProvinces.Location = new System.Drawing.Point(311, 163);
            this.cboProvinces.Name = "cboProvinces";
            this.cboProvinces.Size = new System.Drawing.Size(245, 21);
            this.cboProvinces.TabIndex = 11;
            this.cboProvinces.SelectedIndexChanged += new System.EventHandler(this.cboProvinces_SelectedIndexChanged);
            // 
            // lblGate
            // 
            this.lblGate.AutoSize = true;
            this.lblGate.Location = new System.Drawing.Point(397, 94);
            this.lblGate.Name = "lblGate";
            this.lblGate.Size = new System.Drawing.Size(44, 13);
            this.lblGate.TabIndex = 2;
            this.lblGate.Text = "Puerta";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(258, 94);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(30, 13);
            this.lblFloor.TabIndex = 2;
            this.lblFloor.Text = "Piso";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(246, 166);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(59, 13);
            this.lblProvince.TabIndex = 2;
            this.lblProvince.Text = "Provincia";
            // 
            // lblPhone3
            // 
            this.lblPhone3.AutoSize = true;
            this.lblPhone3.Location = new System.Drawing.Point(41, 274);
            this.lblPhone3.Name = "lblPhone3";
            this.lblPhone3.Size = new System.Drawing.Size(66, 13);
            this.lblPhone3.TabIndex = 2;
            this.lblPhone3.Text = "Teléfono 3";
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(246, 238);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(31, 13);
            this.lblWeb.TabIndex = 2;
            this.lblWeb.Text = "Web";
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Location = new System.Drawing.Point(41, 238);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(66, 13);
            this.lblPhone2.TabIndex = 2;
            this.lblPhone2.Text = "Teléfono 2";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(246, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(113, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Correo electrónico";
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Location = new System.Drawing.Point(41, 202);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(66, 13);
            this.lblPhone1.TabIndex = 2;
            this.lblPhone1.Text = "Teléfono 1";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(26, 166);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(85, 13);
            this.lblPostCode.TabIndex = 2;
            this.lblPostCode.Text = "Código Postal";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(52, 130);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(59, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Municipio";
            // 
            // lblStair
            // 
            this.lblStair.AutoSize = true;
            this.lblStair.Location = new System.Drawing.Point(52, 94);
            this.lblStair.Name = "lblStair";
            this.lblStair.Size = new System.Drawing.Size(55, 13);
            this.lblStair.TabIndex = 2;
            this.lblStair.Text = "Escalera";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(55, 58);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Número";
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Location = new System.Drawing.Point(348, 57);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(46, 13);
            this.lblBlock.TabIndex = 2;
            this.lblBlock.Text = "Bloque";
            // 
            // txtGate
            // 
            this.txtGate.Location = new System.Drawing.Point(447, 91);
            this.txtGate.MaxLength = 20;
            this.txtGate.Name = "txtGate";
            this.txtGate.Size = new System.Drawing.Size(109, 21);
            this.txtGate.TabIndex = 5;
            this.txtGate.TextChanged += new System.EventHandler(this.txtGate_TextChanged);
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(294, 91);
            this.txtFloor.MaxLength = 10;
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(90, 21);
            this.txtFloor.TabIndex = 4;
            this.txtFloor.TextChanged += new System.EventHandler(this.txtFloor_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(138, 127);
            this.txtCity.MaxLength = 100;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(418, 21);
            this.txtCity.TabIndex = 6;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtPhone3
            // 
            this.txtPhone3.Location = new System.Drawing.Point(138, 271);
            this.txtPhone3.MaxLength = 20;
            this.txtPhone3.Name = "txtPhone3";
            this.txtPhone3.Size = new System.Drawing.Size(90, 21);
            this.txtPhone3.TabIndex = 10;
            this.txtPhone3.TextChanged += new System.EventHandler(this.txtPhone3_TextChanged);
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(138, 235);
            this.txtPhone2.MaxLength = 20;
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(90, 21);
            this.txtPhone2.TabIndex = 9;
            this.txtPhone2.TextChanged += new System.EventHandler(this.txtPhone2_TextChanged);
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(294, 235);
            this.txtWeb.MaxLength = 100;
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(262, 21);
            this.txtWeb.TabIndex = 13;
            this.txtWeb.TextChanged += new System.EventHandler(this.txtWeb_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(365, 199);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 21);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(138, 199);
            this.txtPhone1.MaxLength = 20;
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(90, 21);
            this.txtPhone1.TabIndex = 8;
            this.txtPhone1.TextChanged += new System.EventHandler(this.txtPhone1_TextChanged);
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(138, 163);
            this.txtPostCode.MaxLength = 10;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(90, 21);
            this.txtPostCode.TabIndex = 7;
            this.txtPostCode.TextChanged += new System.EventHandler(this.txtPostCode_TextChanged);
            // 
            // txtStair
            // 
            this.txtStair.Location = new System.Drawing.Point(138, 91);
            this.txtStair.MaxLength = 20;
            this.txtStair.Name = "txtStair";
            this.txtStair.Size = new System.Drawing.Size(90, 21);
            this.txtStair.TabIndex = 3;
            this.txtStair.TextChanged += new System.EventHandler(this.txtStair_TextChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(138, 54);
            this.txtNumber.MaxLength = 20;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(156, 21);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtBlock
            // 
            this.txtBlock.Location = new System.Drawing.Point(400, 54);
            this.txtBlock.MaxLength = 50;
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(156, 21);
            this.txtBlock.TabIndex = 2;
            this.txtBlock.TextChanged += new System.EventHandler(this.txtBlock_TextChanged);
            // 
            // txtThoroughfare
            // 
            this.txtThoroughfare.Location = new System.Drawing.Point(138, 19);
            this.txtThoroughfare.MaxLength = 100;
            this.txtThoroughfare.Name = "txtThoroughfare";
            this.txtThoroughfare.Size = new System.Drawing.Size(418, 21);
            this.txtThoroughfare.TabIndex = 0;
            this.txtThoroughfare.TextChanged += new System.EventHandler(this.txtThoroughfare_TextChanged);
            // 
            // lblThoroughfare
            // 
            this.lblThoroughfare.AutoSize = true;
            this.lblThoroughfare.Location = new System.Drawing.Point(38, 22);
            this.lblThoroughfare.Name = "lblThoroughfare";
            this.lblThoroughfare.Size = new System.Drawing.Size(69, 13);
            this.lblThoroughfare.TabIndex = 0;
            this.lblThoroughfare.Text = "Vía pública";
            // 
            // tbpCancellations
            // 
            this.tbpCancellations.Controls.Add(this.btnCancCancel);
            this.tbpCancellations.Controls.Add(this.btnCancSave);
            this.tbpCancellations.Controls.Add(this.btnCancAdd);
            this.tbpCancellations.Controls.Add(this.txtCancReason);
            this.tbpCancellations.Controls.Add(this.lblCancReason);
            this.tbpCancellations.Controls.Add(this.dtpCancDate);
            this.tbpCancellations.Controls.Add(this.lblCancDate);
            this.tbpCancellations.Controls.Add(this.dgvCancellations);
            this.tbpCancellations.Location = new System.Drawing.Point(4, 22);
            this.tbpCancellations.Name = "tbpCancellations";
            this.tbpCancellations.Size = new System.Drawing.Size(1001, 369);
            this.tbpCancellations.TabIndex = 2;
            this.tbpCancellations.Text = "Anulaciones";
            this.tbpCancellations.UseVisualStyleBackColor = true;
            // 
            // btnCancCancel
            // 
            this.btnCancCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancCancel.Location = new System.Drawing.Point(835, 323);
            this.btnCancCancel.Name = "btnCancCancel";
            this.btnCancCancel.Size = new System.Drawing.Size(76, 26);
            this.btnCancCancel.TabIndex = 4;
            this.btnCancCancel.Text = "Cancelar";
            this.tipPatientsDetail.SetToolTip(this.btnCancCancel, "Cancelar añadir Cancelación");
            this.btnCancCancel.UseVisualStyleBackColor = true;
            this.btnCancCancel.Visible = false;
            this.btnCancCancel.Click += new System.EventHandler(this.btnCancCancel_Click);
            // 
            // btnCancSave
            // 
            this.btnCancSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancSave.Location = new System.Drawing.Point(917, 323);
            this.btnCancSave.Name = "btnCancSave";
            this.btnCancSave.Size = new System.Drawing.Size(76, 26);
            this.btnCancSave.TabIndex = 3;
            this.btnCancSave.Text = "Guardar";
            this.tipPatientsDetail.SetToolTip(this.btnCancSave, "Guardar Cancelación del Paciente");
            this.btnCancSave.UseVisualStyleBackColor = true;
            this.btnCancSave.Click += new System.EventHandler(this.btnCancSave_Click);
            // 
            // btnCancAdd
            // 
            this.btnCancAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancAdd.Location = new System.Drawing.Point(917, 13);
            this.btnCancAdd.Name = "btnCancAdd";
            this.btnCancAdd.Size = new System.Drawing.Size(76, 26);
            this.btnCancAdd.TabIndex = 0;
            this.btnCancAdd.Text = "Nueva...";
            this.tipPatientsDetail.SetToolTip(this.btnCancAdd, "Añadir Cancelación al Paciente");
            this.btnCancAdd.UseVisualStyleBackColor = true;
            this.btnCancAdd.Click += new System.EventHandler(this.btnCancAdd_Click);
            // 
            // txtCancReason
            // 
            this.txtCancReason.Location = new System.Drawing.Point(260, 327);
            this.txtCancReason.MaxLength = 500;
            this.txtCancReason.Name = "txtCancReason";
            this.txtCancReason.Size = new System.Drawing.Size(560, 21);
            this.txtCancReason.TabIndex = 2;
            // 
            // lblCancReason
            // 
            this.lblCancReason.AutoSize = true;
            this.lblCancReason.Location = new System.Drawing.Point(210, 332);
            this.lblCancReason.Name = "lblCancReason";
            this.lblCancReason.Size = new System.Drawing.Size(44, 13);
            this.lblCancReason.TabIndex = 3;
            this.lblCancReason.Text = "Motivo";
            // 
            // dtpCancDate
            // 
            this.dtpCancDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCancDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCancDate.Location = new System.Drawing.Point(54, 326);
            this.dtpCancDate.Name = "dtpCancDate";
            this.dtpCancDate.Size = new System.Drawing.Size(113, 21);
            this.dtpCancDate.TabIndex = 1;
            // 
            // lblCancDate
            // 
            this.lblCancDate.AutoSize = true;
            this.lblCancDate.Location = new System.Drawing.Point(8, 330);
            this.lblCancDate.Name = "lblCancDate";
            this.lblCancDate.Size = new System.Drawing.Size(40, 13);
            this.lblCancDate.TabIndex = 1;
            this.lblCancDate.Text = "Fecha";
            // 
            // tbpObservations
            // 
            this.tbpObservations.Controls.Add(this.btnObsCancel);
            this.tbpObservations.Controls.Add(this.btnObsSave);
            this.tbpObservations.Controls.Add(this.txtObsDescription);
            this.tbpObservations.Controls.Add(this.lblObsDescription);
            this.tbpObservations.Controls.Add(this.btnObsDelete);
            this.tbpObservations.Controls.Add(this.btnObsAdd);
            this.tbpObservations.Controls.Add(this.dgvObservations);
            this.tbpObservations.Location = new System.Drawing.Point(4, 22);
            this.tbpObservations.Name = "tbpObservations";
            this.tbpObservations.Size = new System.Drawing.Size(1001, 369);
            this.tbpObservations.TabIndex = 3;
            this.tbpObservations.Text = "Observaciones";
            this.tbpObservations.UseVisualStyleBackColor = true;
            // 
            // btnObsCancel
            // 
            this.btnObsCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObsCancel.Location = new System.Drawing.Point(835, 323);
            this.btnObsCancel.Name = "btnObsCancel";
            this.btnObsCancel.Size = new System.Drawing.Size(76, 26);
            this.btnObsCancel.TabIndex = 5;
            this.btnObsCancel.Text = "Cancelar";
            this.tipPatientsDetail.SetToolTip(this.btnObsCancel, "Cancelar añadir Observación");
            this.btnObsCancel.UseVisualStyleBackColor = true;
            this.btnObsCancel.Visible = false;
            this.btnObsCancel.Click += new System.EventHandler(this.btnObsCancel_Click);
            // 
            // btnObsSave
            // 
            this.btnObsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObsSave.Location = new System.Drawing.Point(917, 323);
            this.btnObsSave.Name = "btnObsSave";
            this.btnObsSave.Size = new System.Drawing.Size(76, 26);
            this.btnObsSave.TabIndex = 4;
            this.btnObsSave.Text = "Guardar";
            this.tipPatientsDetail.SetToolTip(this.btnObsSave, "Guardar Observación del Paciente");
            this.btnObsSave.UseVisualStyleBackColor = true;
            this.btnObsSave.Click += new System.EventHandler(this.btnObsSave_Click);
            // 
            // txtObsDescription
            // 
            this.txtObsDescription.Location = new System.Drawing.Point(87, 327);
            this.txtObsDescription.MaxLength = 200;
            this.txtObsDescription.Name = "txtObsDescription";
            this.txtObsDescription.Size = new System.Drawing.Size(721, 21);
            this.txtObsDescription.TabIndex = 3;
            // 
            // lblObsDescription
            // 
            this.lblObsDescription.AutoSize = true;
            this.lblObsDescription.Location = new System.Drawing.Point(8, 330);
            this.lblObsDescription.Name = "lblObsDescription";
            this.lblObsDescription.Size = new System.Drawing.Size(73, 13);
            this.lblObsDescription.TabIndex = 7;
            this.lblObsDescription.Text = "Descripción";
            // 
            // btnObsAdd
            // 
            this.btnObsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObsAdd.Location = new System.Drawing.Point(917, 13);
            this.btnObsAdd.Name = "btnObsAdd";
            this.btnObsAdd.Size = new System.Drawing.Size(76, 26);
            this.btnObsAdd.TabIndex = 1;
            this.btnObsAdd.Text = "Nueva...";
            this.tipPatientsDetail.SetToolTip(this.btnObsAdd, "Añadir Observación al Paciente");
            this.btnObsAdd.UseVisualStyleBackColor = true;
            this.btnObsAdd.Click += new System.EventHandler(this.btnObsAdd_Click);
            // 
            // tbpTreatments
            // 
            this.tbpTreatments.Controls.Add(this.btnTreatsDelete);
            this.tbpTreatments.Controls.Add(this.btnTreatsAdd);
            this.tbpTreatments.Controls.Add(this.dgvTreatments);
            this.tbpTreatments.Location = new System.Drawing.Point(4, 22);
            this.tbpTreatments.Name = "tbpTreatments";
            this.tbpTreatments.Size = new System.Drawing.Size(1001, 369);
            this.tbpTreatments.TabIndex = 4;
            this.tbpTreatments.Text = "Tratamientos";
            this.tbpTreatments.UseVisualStyleBackColor = true;
            // 
            // btnTreatsAdd
            // 
            this.btnTreatsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTreatsAdd.Location = new System.Drawing.Point(917, 13);
            this.btnTreatsAdd.Name = "btnTreatsAdd";
            this.btnTreatsAdd.Size = new System.Drawing.Size(76, 26);
            this.btnTreatsAdd.TabIndex = 0;
            this.btnTreatsAdd.Text = "Nuevo...";
            this.tipPatientsDetail.SetToolTip(this.btnTreatsAdd, "Añadir Tratamiento al Paciente");
            this.btnTreatsAdd.UseVisualStyleBackColor = true;
            this.btnTreatsAdd.Click += new System.EventHandler(this.btnTreatsAdd_Click);
            // 
            // errObservations
            // 
            this.errObservations.ContainerControl = this;
            // 
            // errData
            // 
            this.errData.ContainerControl = this;
            // 
            // errCancellations
            // 
            this.errCancellations.ContainerControl = this;
            // 
            // btnObsDelete
            // 
            this.btnObsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObsDelete.Location = new System.Drawing.Point(917, 45);
            this.btnObsDelete.Name = "btnObsDelete";
            this.btnObsDelete.Size = new System.Drawing.Size(76, 26);
            this.btnObsDelete.TabIndex = 2;
            this.btnObsDelete.Text = "Eliminar";
            this.tipPatientsDetail.SetToolTip(this.btnObsDelete, "Eliminar Observación seleccionada");
            this.btnObsDelete.UseVisualStyleBackColor = true;
            this.btnObsDelete.Click += new System.EventHandler(this.btnObsDelete_Click);
            // 
            // btnTreatsDelete
            // 
            this.btnTreatsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTreatsDelete.Location = new System.Drawing.Point(917, 45);
            this.btnTreatsDelete.Name = "btnTreatsDelete";
            this.btnTreatsDelete.Size = new System.Drawing.Size(76, 26);
            this.btnTreatsDelete.TabIndex = 0;
            this.btnTreatsDelete.Text = "Eliminar";
            this.tipPatientsDetail.SetToolTip(this.btnTreatsDelete, "Eliminar Tratamiento seleccionado");
            this.btnTreatsDelete.UseVisualStyleBackColor = true;
            this.btnTreatsDelete.Click += new System.EventHandler(this.btnTreatsDelete_Click);
            // 
            // dgvCancellations
            // 
            this.dgvCancellations.AllowUserToAddRows = false;
            this.dgvCancellations.AllowUserToDeleteRows = false;
            this.dgvCancellations.AllowUserToResizeRows = false;
            this.dgvCancellations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCancellations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCancellations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCancellations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCancellations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCancellations.Location = new System.Drawing.Point(8, 13);
            this.dgvCancellations.MultiSelect = false;
            this.dgvCancellations.Name = "dgvCancellations";
            this.dgvCancellations.ReadOnly = true;
            this.dgvCancellations.RowHeadersVisible = false;
            this.dgvCancellations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCancellations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCancellations.Size = new System.Drawing.Size(903, 293);
            this.dgvCancellations.TabIndex = 0;
            this.dgvCancellations.SelectionChanged += new System.EventHandler(this.dgvCancellations_SelectionChanged);
            // 
            // dgvObservations
            // 
            this.dgvObservations.AllowUserToAddRows = false;
            this.dgvObservations.AllowUserToDeleteRows = false;
            this.dgvObservations.AllowUserToResizeRows = false;
            this.dgvObservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObservations.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObservations.Location = new System.Drawing.Point(8, 13);
            this.dgvObservations.MultiSelect = false;
            this.dgvObservations.Name = "dgvObservations";
            this.dgvObservations.ReadOnly = true;
            this.dgvObservations.RowHeadersVisible = false;
            this.dgvObservations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvObservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObservations.Size = new System.Drawing.Size(903, 293);
            this.dgvObservations.TabIndex = 0;
            this.dgvObservations.SelectionChanged += new System.EventHandler(this.dgvObservations_SelectionChanged);
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.AllowUserToAddRows = false;
            this.dgvTreatments.AllowUserToDeleteRows = false;
            this.dgvTreatments.AllowUserToResizeRows = false;
            this.dgvTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreatments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreatments.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTreatments.Location = new System.Drawing.Point(8, 13);
            this.dgvTreatments.MultiSelect = false;
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.ReadOnly = true;
            this.dgvTreatments.RowHeadersVisible = false;
            this.dgvTreatments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatments.Size = new System.Drawing.Size(903, 316);
            this.dgvTreatments.TabIndex = 1;
            this.dgvTreatments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTreatments_CellMouseDoubleClick);
            this.dgvTreatments.SelectionChanged += new System.EventHandler(this.dgvTreatments_SelectionChanged);
            // 
            // frmPatientsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1009, 453);
            this.ControlBox = false;
            this.Controls.Add(this.panDetails);
            this.Controls.Add(this.panButtons);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPatientsDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha";
            this.Load += new System.EventHandler(this.frmPatientsDetail_Load);
            this.panButtons.ResumeLayout(false);
            this.panButtons.PerformLayout();
            this.panDetails.ResumeLayout(false);
            this.tabDetails.ResumeLayout(false);
            this.tbpData.ResumeLayout(false);
            this.tbpData.PerformLayout();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.tbpAddress.ResumeLayout(false);
            this.tbpAddress.PerformLayout();
            this.tbpCancellations.ResumeLayout(false);
            this.tbpCancellations.PerformLayout();
            this.tbpObservations.ResumeLayout(false);
            this.tbpObservations.PerformLayout();
            this.tbpTreatments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errObservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCancellations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancellations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Panel panDetails;
        private System.Windows.Forms.TabControl tabDetails;
        private System.Windows.Forms.TabPage tbpData;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblIdentifierValue;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblHowHeardAboutUs;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.Label lblSurname2;
        private System.Windows.Forms.Label lblSurname1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSurname1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblIdentifier;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.TextBox txtHowHeardAboutUs;
        private System.Windows.Forms.TextBox txtSurname2;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.ComboBox cboSources;
        private System.Windows.Forms.ComboBox cboPhysios;
        private System.Windows.Forms.Label lblRefPhysio;
        private System.Windows.Forms.TabPage tbpAddress;
        private System.Windows.Forms.Label lblGate;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblStair;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtStair;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.TextBox txtThoroughfare;
        private System.Windows.Forms.Label lblThoroughfare;
        private System.Windows.Forms.ComboBox cboProvinces;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPhone3;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtGate;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone3;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TabPage tbpCancellations;
        private System.Windows.Forms.ToolTip tipPatientsDetail;
        private Controls.NovaGrid dgvCancellations;
        private System.Windows.Forms.TextBox txtCancReason;
        private System.Windows.Forms.Label lblCancReason;
        private System.Windows.Forms.DateTimePicker dtpCancDate;
        private System.Windows.Forms.Label lblCancDate;
        private System.Windows.Forms.Button btnCancSave;
        private System.Windows.Forms.Button btnCancAdd;
        private System.Windows.Forms.Button btnCancCancel;
        private System.Windows.Forms.ErrorProvider errObservations;
        private System.Windows.Forms.ErrorProvider errData;
        private System.Windows.Forms.ErrorProvider errCancellations;
        private System.Windows.Forms.TabPage tbpObservations;
        private Controls.NovaGrid dgvObservations;
        private System.Windows.Forms.Button btnObsCancel;
        private System.Windows.Forms.Button btnObsSave;
        private System.Windows.Forms.TextBox txtObsDescription;
        private System.Windows.Forms.Label lblObsDescription;
        private System.Windows.Forms.Button btnObsAdd;
        private System.Windows.Forms.TabPage tbpTreatments;
        private Controls.NovaGrid dgvTreatments;
        private System.Windows.Forms.Button btnTreatsAdd;
        private System.Windows.Forms.CheckBox chkBlackList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnObsDelete;
        private System.Windows.Forms.Button btnTreatsDelete;

    }
}