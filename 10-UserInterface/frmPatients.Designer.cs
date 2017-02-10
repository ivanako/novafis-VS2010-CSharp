namespace UserInterface
{
    partial class frmPatients
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
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.chkDeleted = new System.Windows.Forms.CheckBox();
            this.chkBlackList = new System.Windows.Forms.CheckBox();
            this.lblFilterSurname1 = new System.Windows.Forms.Label();
            this.txtFilterSurname1 = new System.Windows.Forms.TextBox();
            this.lblFilterSurname2 = new System.Windows.Forms.Label();
            this.txtFilterSurname2 = new System.Windows.Forms.TextBox();
            this.lblFilterName = new System.Windows.Forms.Label();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.tipPatients = new System.Windows.Forms.ToolTip(this.components);
            this.btnModify = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.grbNavigator = new System.Windows.Forms.GroupBox();
            this.lblPageCurrent = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblPageOf = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.dgvPatients = new UserInterface.Controls.NovaGrid();
            this.grbFilter.SuspendLayout();
            this.grbNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFilter
            // 
            this.grbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFilter.BackColor = System.Drawing.SystemColors.Control;
            this.grbFilter.Controls.Add(this.chkDeleted);
            this.grbFilter.Controls.Add(this.chkBlackList);
            this.grbFilter.Controls.Add(this.lblFilterSurname1);
            this.grbFilter.Controls.Add(this.txtFilterSurname1);
            this.grbFilter.Controls.Add(this.lblFilterSurname2);
            this.grbFilter.Controls.Add(this.txtFilterSurname2);
            this.grbFilter.Controls.Add(this.lblFilterName);
            this.grbFilter.Controls.Add(this.txtFilterName);
            this.grbFilter.Location = new System.Drawing.Point(14, 12);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(1204, 83);
            this.grbFilter.TabIndex = 0;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filtro";
            this.grbFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.grbFilter_Paint);
            // 
            // chkDeleted
            // 
            this.chkDeleted.AutoSize = true;
            this.chkDeleted.BackColor = System.Drawing.Color.Red;
            this.chkDeleted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDeleted.ForeColor = System.Drawing.Color.White;
            this.chkDeleted.Location = new System.Drawing.Point(1067, 32);
            this.chkDeleted.Name = "chkDeleted";
            this.chkDeleted.Size = new System.Drawing.Size(81, 17);
            this.chkDeleted.TabIndex = 3;
            this.chkDeleted.Text = "Eliminado";
            this.chkDeleted.UseVisualStyleBackColor = false;
            this.chkDeleted.CheckedChanged += new System.EventHandler(this.chkDeleted_CheckedChanged);
            // 
            // chkBlackList
            // 
            this.chkBlackList.AutoSize = true;
            this.chkBlackList.BackColor = System.Drawing.Color.White;
            this.chkBlackList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBlackList.ForeColor = System.Drawing.Color.Red;
            this.chkBlackList.Location = new System.Drawing.Point(956, 32);
            this.chkBlackList.Name = "chkBlackList";
            this.chkBlackList.Size = new System.Drawing.Size(89, 17);
            this.chkBlackList.TabIndex = 3;
            this.chkBlackList.Text = "Lista negra";
            this.chkBlackList.UseVisualStyleBackColor = false;
            this.chkBlackList.CheckedChanged += new System.EventHandler(this.chkBlackList_CheckedChanged);
            // 
            // lblFilterSurname1
            // 
            this.lblFilterSurname1.AutoSize = true;
            this.lblFilterSurname1.Location = new System.Drawing.Point(279, 33);
            this.lblFilterSurname1.Name = "lblFilterSurname1";
            this.lblFilterSurname1.Size = new System.Drawing.Size(94, 13);
            this.lblFilterSurname1.TabIndex = 5;
            this.lblFilterSurname1.Text = "Primer Apellido";
            // 
            // txtFilterSurname1
            // 
            this.txtFilterSurname1.Location = new System.Drawing.Point(379, 30);
            this.txtFilterSurname1.MaxLength = 50;
            this.txtFilterSurname1.Name = "txtFilterSurname1";
            this.txtFilterSurname1.Size = new System.Drawing.Size(200, 21);
            this.txtFilterSurname1.TabIndex = 1;
            this.txtFilterSurname1.TextChanged += new System.EventHandler(this.txtFilterSurname1_TextChanged);
            // 
            // lblFilterSurname2
            // 
            this.lblFilterSurname2.AutoSize = true;
            this.lblFilterSurname2.Location = new System.Drawing.Point(594, 33);
            this.lblFilterSurname2.Name = "lblFilterSurname2";
            this.lblFilterSurname2.Size = new System.Drawing.Size(106, 13);
            this.lblFilterSurname2.TabIndex = 3;
            this.lblFilterSurname2.Text = "Segundo Apellido";
            // 
            // txtFilterSurname2
            // 
            this.txtFilterSurname2.Location = new System.Drawing.Point(706, 30);
            this.txtFilterSurname2.MaxLength = 50;
            this.txtFilterSurname2.Name = "txtFilterSurname2";
            this.txtFilterSurname2.Size = new System.Drawing.Size(200, 21);
            this.txtFilterSurname2.TabIndex = 2;
            this.txtFilterSurname2.TextChanged += new System.EventHandler(this.txtFilterSurname2_TextChanged);
            // 
            // lblFilterName
            // 
            this.lblFilterName.AutoSize = true;
            this.lblFilterName.Location = new System.Drawing.Point(6, 33);
            this.lblFilterName.Name = "lblFilterName";
            this.lblFilterName.Size = new System.Drawing.Size(52, 13);
            this.lblFilterName.TabIndex = 1;
            this.lblFilterName.Text = "Nombre";
            // 
            // txtFilterName
            // 
            this.txtFilterName.Location = new System.Drawing.Point(64, 30);
            this.txtFilterName.MaxLength = 50;
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(200, 21);
            this.txtFilterName.TabIndex = 0;
            this.txtFilterName.TextChanged += new System.EventHandler(this.txtFilterName_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(1126, 123);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 33);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo...";
            this.tipPatients.SetToolTip(this.btnNew, "Añadir Paciente");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(1126, 162);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(86, 33);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modificar...";
            this.tipPatients.SetToolTip(this.btnModify, "Modificar Paciente");
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLast.Location = new System.Drawing.Point(380, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(51, 32);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>";
            this.tipPatients.SetToolTip(this.btnLast, "última página");
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Location = new System.Drawing.Point(325, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 32);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.tipPatients.SetToolTip(this.btnNext, "Página siguiente");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.Location = new System.Drawing.Point(88, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(51, 32);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.tipPatients.SetToolTip(this.btnPrevious, "Página anterior");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.Location = new System.Drawing.Point(31, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(51, 32);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.tipPatients.SetToolTip(this.btnFirst, "Primera página");
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1126, 579);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cerrar";
            this.tipPatients.SetToolTip(this.btnClose, "Cerrar ventana");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1126, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.tipPatients.SetToolTip(this.btnDelete, "Eliminar Paciente");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(1126, 240);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(86, 33);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Recargar";
            this.tipPatients.SetToolTip(this.btnReload, "Recargar Pacientes");
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // grbNavigator
            // 
            this.grbNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbNavigator.Controls.Add(this.lblPageCurrent);
            this.grbNavigator.Controls.Add(this.lblPageCount);
            this.grbNavigator.Controls.Add(this.lblPageOf);
            this.grbNavigator.Controls.Add(this.lblPage);
            this.grbNavigator.Controls.Add(this.btnLast);
            this.grbNavigator.Controls.Add(this.btnNext);
            this.grbNavigator.Controls.Add(this.btnPrevious);
            this.grbNavigator.Controls.Add(this.btnFirst);
            this.grbNavigator.Location = new System.Drawing.Point(65, 618);
            this.grbNavigator.Name = "grbNavigator";
            this.grbNavigator.Size = new System.Drawing.Size(470, 40);
            this.grbNavigator.TabIndex = 6;
            this.grbNavigator.TabStop = false;
            // 
            // lblPageCurrent
            // 
            this.lblPageCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPageCurrent.AutoSize = true;
            this.lblPageCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPageCurrent.Location = new System.Drawing.Point(205, 15);
            this.lblPageCurrent.Name = "lblPageCurrent";
            this.lblPageCurrent.Size = new System.Drawing.Size(28, 13);
            this.lblPageCurrent.TabIndex = 13;
            this.lblPageCurrent.Text = "000";
            this.lblPageCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPageCount
            // 
            this.lblPageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(266, 15);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(28, 13);
            this.lblPageCount.TabIndex = 10;
            this.lblPageCount.Text = "888";
            this.lblPageCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPageOf
            // 
            this.lblPageOf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPageOf.AutoSize = true;
            this.lblPageOf.Location = new System.Drawing.Point(239, 15);
            this.lblPageOf.Name = "lblPageOf";
            this.lblPageOf.Size = new System.Drawing.Size(21, 13);
            this.lblPageOf.TabIndex = 11;
            this.lblPageOf.Text = "de";
            this.lblPageOf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(154, 15);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(45, 13);
            this.lblPage.TabIndex = 12;
            this.lblPage.Text = "Página";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AllowUserToResizeRows = false;
            this.dgvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatients.Location = new System.Drawing.Point(14, 123);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersVisible = false;
            this.dgvPatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1106, 489);
            this.dgvPatients.TabIndex = 1;
            this.dgvPatients.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPatients_CellFormatting);
            this.dgvPatients.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPatients_CellMouseDoubleClick);
            this.dgvPatients.SelectionChanged += new System.EventHandler(this.dgvPatients_SelectionChanged);
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 662);
            this.Controls.Add(this.grbNavigator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.grbFilter);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPatients";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.frmPatients_Load);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            this.grbNavigator.ResumeLayout(false);
            this.grbNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.Label lblFilterSurname1;
        private System.Windows.Forms.TextBox txtFilterSurname1;
        private System.Windows.Forms.Label lblFilterSurname2;
        private System.Windows.Forms.TextBox txtFilterSurname2;
        private System.Windows.Forms.Label lblFilterName;
        private System.Windows.Forms.TextBox txtFilterName;
        private Controls.NovaGrid dgvPatients;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ToolTip tipPatients;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.GroupBox grbNavigator;
        private System.Windows.Forms.Label lblPageCurrent;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblPageOf;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.CheckBox chkBlackList;
        private System.Windows.Forms.CheckBox chkDeleted;
    }
}