namespace UserInterface
{
    partial class frmAdvancedSearch
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
            this.lblPatName = new System.Windows.Forms.Label();
            this.txtPatName = new System.Windows.Forms.TextBox();
            this.lblPatSurname1 = new System.Windows.Forms.Label();
            this.lblPatSurname2 = new System.Windows.Forms.Label();
            this.txtPatSurname1 = new System.Windows.Forms.TextBox();
            this.txtPatSurname2 = new System.Windows.Forms.TextBox();
            this.txtPatIdentification = new System.Windows.Forms.TextBox();
            this.txtPatHeardAboutUs = new System.Windows.Forms.TextBox();
            this.cboPatSources = new System.Windows.Forms.ComboBox();
            this.lblPatIdentification = new System.Windows.Forms.Label();
            this.lblPatHeardAboutUs = new System.Windows.Forms.Label();
            this.lblPatSource = new System.Windows.Forms.Label();
            this.dgvPatientsSearch = new UserInterface.Controls.NovaGrid();
            this.lblPatPhone = new System.Windows.Forms.Label();
            this.txtPatPhone = new System.Windows.Forms.TextBox();
            this.btnPatSearch = new System.Windows.Forms.Button();
            this.lblPatCount = new System.Windows.Forms.Label();
            this.tipAdvancedSearch = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPatDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatName
            // 
            this.lblPatName.AutoSize = true;
            this.lblPatName.Location = new System.Drawing.Point(106, 18);
            this.lblPatName.Name = "lblPatName";
            this.lblPatName.Size = new System.Drawing.Size(52, 13);
            this.lblPatName.TabIndex = 0;
            this.lblPatName.Text = "Nombre";
            // 
            // txtPatName
            // 
            this.txtPatName.Location = new System.Drawing.Point(175, 15);
            this.txtPatName.MaxLength = 50;
            this.txtPatName.Name = "txtPatName";
            this.txtPatName.Size = new System.Drawing.Size(435, 21);
            this.txtPatName.TabIndex = 0;
            // 
            // lblPatSurname1
            // 
            this.lblPatSurname1.AutoSize = true;
            this.lblPatSurname1.Location = new System.Drawing.Point(64, 55);
            this.lblPatSurname1.Name = "lblPatSurname1";
            this.lblPatSurname1.Size = new System.Drawing.Size(94, 13);
            this.lblPatSurname1.TabIndex = 0;
            this.lblPatSurname1.Text = "Primer Apellido";
            // 
            // lblPatSurname2
            // 
            this.lblPatSurname2.AutoSize = true;
            this.lblPatSurname2.Location = new System.Drawing.Point(52, 92);
            this.lblPatSurname2.Name = "lblPatSurname2";
            this.lblPatSurname2.Size = new System.Drawing.Size(106, 13);
            this.lblPatSurname2.TabIndex = 0;
            this.lblPatSurname2.Text = "Segundo Apellido";
            // 
            // txtPatSurname1
            // 
            this.txtPatSurname1.Location = new System.Drawing.Point(175, 52);
            this.txtPatSurname1.MaxLength = 50;
            this.txtPatSurname1.Name = "txtPatSurname1";
            this.txtPatSurname1.Size = new System.Drawing.Size(435, 21);
            this.txtPatSurname1.TabIndex = 1;
            // 
            // txtPatSurname2
            // 
            this.txtPatSurname2.Location = new System.Drawing.Point(175, 89);
            this.txtPatSurname2.MaxLength = 50;
            this.txtPatSurname2.Name = "txtPatSurname2";
            this.txtPatSurname2.Size = new System.Drawing.Size(435, 21);
            this.txtPatSurname2.TabIndex = 2;
            // 
            // txtPatIdentification
            // 
            this.txtPatIdentification.Location = new System.Drawing.Point(175, 126);
            this.txtPatIdentification.MaxLength = 20;
            this.txtPatIdentification.Name = "txtPatIdentification";
            this.txtPatIdentification.Size = new System.Drawing.Size(169, 21);
            this.txtPatIdentification.TabIndex = 3;
            // 
            // txtPatHeardAboutUs
            // 
            this.txtPatHeardAboutUs.Location = new System.Drawing.Point(175, 163);
            this.txtPatHeardAboutUs.MaxLength = 50;
            this.txtPatHeardAboutUs.Multiline = true;
            this.txtPatHeardAboutUs.Name = "txtPatHeardAboutUs";
            this.txtPatHeardAboutUs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPatHeardAboutUs.Size = new System.Drawing.Size(435, 74);
            this.txtPatHeardAboutUs.TabIndex = 5;
            // 
            // cboPatSources
            // 
            this.cboPatSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatSources.FormattingEnabled = true;
            this.cboPatSources.Location = new System.Drawing.Point(175, 253);
            this.cboPatSources.Name = "cboPatSources";
            this.cboPatSources.Size = new System.Drawing.Size(435, 21);
            this.cboPatSources.TabIndex = 6;
            // 
            // lblPatIdentification
            // 
            this.lblPatIdentification.Location = new System.Drawing.Point(37, 121);
            this.lblPatIdentification.Name = "lblPatIdentification";
            this.lblPatIdentification.Size = new System.Drawing.Size(121, 28);
            this.lblPatIdentification.TabIndex = 3;
            this.lblPatIdentification.Text = "Identificación (N.I.F., Pasaporte)";
            this.lblPatIdentification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPatHeardAboutUs
            // 
            this.lblPatHeardAboutUs.AutoSize = true;
            this.lblPatHeardAboutUs.Location = new System.Drawing.Point(34, 163);
            this.lblPatHeardAboutUs.Name = "lblPatHeardAboutUs";
            this.lblPatHeardAboutUs.Size = new System.Drawing.Size(124, 13);
            this.lblPatHeardAboutUs.TabIndex = 0;
            this.lblPatHeardAboutUs.Text = "¿Cómo nos conoció?";
            // 
            // lblPatSource
            // 
            this.lblPatSource.AutoSize = true;
            this.lblPatSource.Location = new System.Drawing.Point(113, 256);
            this.lblPatSource.Name = "lblPatSource";
            this.lblPatSource.Size = new System.Drawing.Size(45, 13);
            this.lblPatSource.TabIndex = 0;
            this.lblPatSource.Text = "Fuente";
            // 
            // dgvPatientsSearch
            // 
            this.dgvPatientsSearch.AllowUserToAddRows = false;
            this.dgvPatientsSearch.AllowUserToDeleteRows = false;
            this.dgvPatientsSearch.AllowUserToResizeRows = false;
            this.dgvPatientsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPatientsSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientsSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatientsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientsSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatientsSearch.Location = new System.Drawing.Point(37, 323);
            this.dgvPatientsSearch.MultiSelect = false;
            this.dgvPatientsSearch.Name = "dgvPatientsSearch";
            this.dgvPatientsSearch.ReadOnly = true;
            this.dgvPatientsSearch.RowHeadersVisible = false;
            this.dgvPatientsSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPatientsSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientsSearch.Size = new System.Drawing.Size(682, 277);
            this.dgvPatientsSearch.TabIndex = 9;
            // 
            // lblPatPhone
            // 
            this.lblPatPhone.AutoSize = true;
            this.lblPatPhone.Location = new System.Drawing.Point(371, 129);
            this.lblPatPhone.Name = "lblPatPhone";
            this.lblPatPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPatPhone.TabIndex = 0;
            this.lblPatPhone.Text = "Teléfono";
            // 
            // txtPatPhone
            // 
            this.txtPatPhone.Location = new System.Drawing.Point(441, 126);
            this.txtPatPhone.MaxLength = 20;
            this.txtPatPhone.Name = "txtPatPhone";
            this.txtPatPhone.Size = new System.Drawing.Size(169, 21);
            this.txtPatPhone.TabIndex = 4;
            // 
            // btnPatSearch
            // 
            this.btnPatSearch.Location = new System.Drawing.Point(633, 246);
            this.btnPatSearch.Name = "btnPatSearch";
            this.btnPatSearch.Size = new System.Drawing.Size(86, 33);
            this.btnPatSearch.TabIndex = 7;
            this.btnPatSearch.Text = "Buscar";
            this.tipAdvancedSearch.SetToolTip(this.btnPatSearch, "Búsqueda de Pacientes");
            this.btnPatSearch.UseVisualStyleBackColor = true;
            this.btnPatSearch.Click += new System.EventHandler(this.btnPatSearch_Click);
            // 
            // lblPatCount
            // 
            this.lblPatCount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatCount.Location = new System.Drawing.Point(37, 297);
            this.lblPatCount.Name = "lblPatCount";
            this.lblPatCount.Size = new System.Drawing.Size(682, 23);
            this.lblPatCount.TabIndex = 6;
            this.lblPatCount.Text = "Pacientes";
            this.lblPatCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(725, 567);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 33);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cerrar";
            this.tipAdvancedSearch.SetToolTip(this.btnClose, "Cerrar ventana");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPatDetails
            // 
            this.btnPatDetails.Enabled = false;
            this.btnPatDetails.Location = new System.Drawing.Point(725, 323);
            this.btnPatDetails.Name = "btnPatDetails";
            this.btnPatDetails.Size = new System.Drawing.Size(86, 33);
            this.btnPatDetails.TabIndex = 8;
            this.btnPatDetails.Text = "Paciente...";
            this.tipAdvancedSearch.SetToolTip(this.btnPatDetails, "Acceder a ficha del Paciente");
            this.btnPatDetails.UseVisualStyleBackColor = true;
            this.btnPatDetails.Click += new System.EventHandler(this.btnPatDetails_Click);
            // 
            // frmAdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 631);
            this.Controls.Add(this.lblPatCount);
            this.Controls.Add(this.btnPatDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPatSearch);
            this.Controls.Add(this.dgvPatientsSearch);
            this.Controls.Add(this.lblPatIdentification);
            this.Controls.Add(this.cboPatSources);
            this.Controls.Add(this.txtPatHeardAboutUs);
            this.Controls.Add(this.txtPatPhone);
            this.Controls.Add(this.txtPatIdentification);
            this.Controls.Add(this.txtPatSurname2);
            this.Controls.Add(this.txtPatSurname1);
            this.Controls.Add(this.txtPatName);
            this.Controls.Add(this.lblPatHeardAboutUs);
            this.Controls.Add(this.lblPatSource);
            this.Controls.Add(this.lblPatSurname2);
            this.Controls.Add(this.lblPatSurname1);
            this.Controls.Add(this.lblPatPhone);
            this.Controls.Add(this.lblPatName);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAdvancedSearch";
            this.Text = "Búsqueda avanzada";
            this.Load += new System.EventHandler(this.frmAdvancedSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatName;
        private System.Windows.Forms.TextBox txtPatName;
        private System.Windows.Forms.Label lblPatSurname1;
        private System.Windows.Forms.Label lblPatSurname2;
        private System.Windows.Forms.TextBox txtPatSurname1;
        private System.Windows.Forms.TextBox txtPatSurname2;
        private System.Windows.Forms.TextBox txtPatIdentification;
        private System.Windows.Forms.TextBox txtPatHeardAboutUs;
        private System.Windows.Forms.ComboBox cboPatSources;
        private System.Windows.Forms.Label lblPatIdentification;
        private System.Windows.Forms.Label lblPatHeardAboutUs;
        private System.Windows.Forms.Label lblPatSource;
        private Controls.NovaGrid dgvPatientsSearch;
        private System.Windows.Forms.Label lblPatPhone;
        private System.Windows.Forms.TextBox txtPatPhone;
        private System.Windows.Forms.Button btnPatSearch;
        private System.Windows.Forms.ToolTip tipAdvancedSearch;
        private System.Windows.Forms.Label lblPatCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPatDetails;
    }
}