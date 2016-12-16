namespace UserInterface
{
    partial class frmSourcesNotes
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
            this.splSourcesNotes = new System.Windows.Forms.SplitContainer();
            this.grbSources = new System.Windows.Forms.GroupBox();
            this.btnCancelSource = new System.Windows.Forms.Button();
            this.btnSaveSource = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnRefreshSources = new System.Windows.Forms.Button();
            this.btnNewSource = new System.Windows.Forms.Button();
            this.grbNotes = new System.Windows.Forms.GroupBox();
            this.txtNoteDesc = new System.Windows.Forms.TextBox();
            this.dtpNoteDate = new System.Windows.Forms.DateTimePicker();
            this.lblNoteDesc = new System.Windows.Forms.Label();
            this.lblNoteDate = new System.Windows.Forms.Label();
            this.btnCancelNote = new System.Windows.Forms.Button();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.btnRefreshNotes = new System.Windows.Forms.Button();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.tipSourcesNotes = new System.Windows.Forms.ToolTip(this.components);
            this.errSources = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNotes = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvSources = new UserInterface.Controls.NovaGrid();
            this.dgvNotes = new UserInterface.Controls.NovaGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splSourcesNotes)).BeginInit();
            this.splSourcesNotes.Panel1.SuspendLayout();
            this.splSourcesNotes.Panel2.SuspendLayout();
            this.splSourcesNotes.SuspendLayout();
            this.grbSources.SuspendLayout();
            this.grbNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // splSourcesNotes
            // 
            this.splSourcesNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splSourcesNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splSourcesNotes.Location = new System.Drawing.Point(0, 0);
            this.splSourcesNotes.Name = "splSourcesNotes";
            this.splSourcesNotes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splSourcesNotes.Panel1
            // 
            this.splSourcesNotes.Panel1.Controls.Add(this.grbSources);
            // 
            // splSourcesNotes.Panel2
            // 
            this.splSourcesNotes.Panel2.Controls.Add(this.grbNotes);
            this.splSourcesNotes.Size = new System.Drawing.Size(822, 666);
            this.splSourcesNotes.SplitterDistance = 394;
            this.splSourcesNotes.SplitterWidth = 5;
            this.splSourcesNotes.TabIndex = 0;
            // 
            // grbSources
            // 
            this.grbSources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSources.Controls.Add(this.btnCancelSource);
            this.grbSources.Controls.Add(this.btnSaveSource);
            this.grbSources.Controls.Add(this.lblSource);
            this.grbSources.Controls.Add(this.txtSource);
            this.grbSources.Controls.Add(this.btnRefreshSources);
            this.grbSources.Controls.Add(this.btnNewSource);
            this.grbSources.Controls.Add(this.dgvSources);
            this.grbSources.Location = new System.Drawing.Point(12, 12);
            this.grbSources.Name = "grbSources";
            this.grbSources.Size = new System.Drawing.Size(794, 366);
            this.grbSources.TabIndex = 0;
            this.grbSources.TabStop = false;
            this.grbSources.Text = "Fuentes";
            this.grbSources.Paint += new System.Windows.Forms.PaintEventHandler(this.grbSources_Paint);
            // 
            // btnCancelSource
            // 
            this.btnCancelSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSource.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSource.Location = new System.Drawing.Point(600, 319);
            this.btnCancelSource.Name = "btnCancelSource";
            this.btnCancelSource.Size = new System.Drawing.Size(86, 33);
            this.btnCancelSource.TabIndex = 7;
            this.btnCancelSource.Text = "Cancelar";
            this.tipSourcesNotes.SetToolTip(this.btnCancelSource, "Cancelar alta Fuente");
            this.btnCancelSource.UseVisualStyleBackColor = true;
            this.btnCancelSource.Visible = false;
            this.btnCancelSource.Click += new System.EventHandler(this.btnCancelSource_Click);
            // 
            // btnSaveSource
            // 
            this.btnSaveSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSource.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSource.Location = new System.Drawing.Point(702, 319);
            this.btnSaveSource.Name = "btnSaveSource";
            this.btnSaveSource.Size = new System.Drawing.Size(86, 33);
            this.btnSaveSource.TabIndex = 6;
            this.btnSaveSource.Text = "Guardar";
            this.tipSourcesNotes.SetToolTip(this.btnSaveSource, "Guardar cambios en Fuente");
            this.btnSaveSource.UseVisualStyleBackColor = true;
            this.btnSaveSource.Click += new System.EventHandler(this.btnSaveSource_Click);
            // 
            // lblSource
            // 
            this.lblSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(6, 329);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(45, 13);
            this.lblSource.TabIndex = 5;
            this.lblSource.Text = "Fuente";
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(57, 326);
            this.txtSource.MaxLength = 100;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(526, 21);
            this.txtSource.TabIndex = 4;
            // 
            // btnRefreshSources
            // 
            this.btnRefreshSources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshSources.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSources.Location = new System.Drawing.Point(702, 59);
            this.btnRefreshSources.Name = "btnRefreshSources";
            this.btnRefreshSources.Size = new System.Drawing.Size(86, 33);
            this.btnRefreshSources.TabIndex = 3;
            this.btnRefreshSources.Text = "Refrescar";
            this.tipSourcesNotes.SetToolTip(this.btnRefreshSources, "Recargar Fuentes");
            this.btnRefreshSources.UseVisualStyleBackColor = true;
            this.btnRefreshSources.Click += new System.EventHandler(this.btnRefreshSources_Click);
            // 
            // btnNewSource
            // 
            this.btnNewSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewSource.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSource.Location = new System.Drawing.Point(702, 20);
            this.btnNewSource.Name = "btnNewSource";
            this.btnNewSource.Size = new System.Drawing.Size(86, 33);
            this.btnNewSource.TabIndex = 2;
            this.btnNewSource.Text = "Nueva";
            this.tipSourcesNotes.SetToolTip(this.btnNewSource, "Añadir Fuente");
            this.btnNewSource.UseVisualStyleBackColor = true;
            this.btnNewSource.Click += new System.EventHandler(this.btnNewSource_Click);
            // 
            // grbNotes
            // 
            this.grbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNotes.Controls.Add(this.txtNoteDesc);
            this.grbNotes.Controls.Add(this.dtpNoteDate);
            this.grbNotes.Controls.Add(this.lblNoteDesc);
            this.grbNotes.Controls.Add(this.lblNoteDate);
            this.grbNotes.Controls.Add(this.btnCancelNote);
            this.grbNotes.Controls.Add(this.btnSaveNote);
            this.grbNotes.Controls.Add(this.btnRefreshNotes);
            this.grbNotes.Controls.Add(this.btnDeleteNote);
            this.grbNotes.Controls.Add(this.btnAddNote);
            this.grbNotes.Controls.Add(this.dgvNotes);
            this.grbNotes.Location = new System.Drawing.Point(12, 3);
            this.grbNotes.Name = "grbNotes";
            this.grbNotes.Size = new System.Drawing.Size(794, 247);
            this.grbNotes.TabIndex = 0;
            this.grbNotes.TabStop = false;
            this.grbNotes.Text = "Notas";
            this.grbNotes.Paint += new System.Windows.Forms.PaintEventHandler(this.grbNotes_Paint);
            // 
            // txtNoteDesc
            // 
            this.txtNoteDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoteDesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteDesc.Location = new System.Drawing.Point(254, 208);
            this.txtNoteDesc.MaxLength = 100;
            this.txtNoteDesc.Multiline = true;
            this.txtNoteDesc.Name = "txtNoteDesc";
            this.txtNoteDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoteDesc.Size = new System.Drawing.Size(340, 33);
            this.txtNoteDesc.TabIndex = 5;
            // 
            // dtpNoteDate
            // 
            this.dtpNoteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpNoteDate.CustomFormat = "dd/MM/yyyy";
            this.dtpNoteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNoteDate.Location = new System.Drawing.Point(52, 212);
            this.dtpNoteDate.Name = "dtpNoteDate";
            this.dtpNoteDate.Size = new System.Drawing.Size(108, 21);
            this.dtpNoteDate.TabIndex = 4;
            // 
            // lblNoteDesc
            // 
            this.lblNoteDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoteDesc.AutoSize = true;
            this.lblNoteDesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteDesc.Location = new System.Drawing.Point(175, 218);
            this.lblNoteDesc.Name = "lblNoteDesc";
            this.lblNoteDesc.Size = new System.Drawing.Size(73, 13);
            this.lblNoteDesc.TabIndex = 6;
            this.lblNoteDesc.Text = "Descripción";
            // 
            // lblNoteDate
            // 
            this.lblNoteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoteDate.AutoSize = true;
            this.lblNoteDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteDate.Location = new System.Drawing.Point(6, 218);
            this.lblNoteDate.Name = "lblNoteDate";
            this.lblNoteDate.Size = new System.Drawing.Size(40, 13);
            this.lblNoteDate.TabIndex = 6;
            this.lblNoteDate.Text = "Fecha";
            // 
            // btnCancelNote
            // 
            this.btnCancelNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelNote.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNote.Location = new System.Drawing.Point(600, 208);
            this.btnCancelNote.Name = "btnCancelNote";
            this.btnCancelNote.Size = new System.Drawing.Size(86, 33);
            this.btnCancelNote.TabIndex = 7;
            this.btnCancelNote.Text = "Cancelar";
            this.tipSourcesNotes.SetToolTip(this.btnCancelNote, "Cancelar alta Nota");
            this.btnCancelNote.UseVisualStyleBackColor = true;
            this.btnCancelNote.Click += new System.EventHandler(this.btnCancelNote_Click);
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNote.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNote.Location = new System.Drawing.Point(702, 208);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(86, 33);
            this.btnSaveNote.TabIndex = 6;
            this.btnSaveNote.Text = "Guardar";
            this.tipSourcesNotes.SetToolTip(this.btnSaveNote, "Guardar Nota");
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // btnRefreshNotes
            // 
            this.btnRefreshNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshNotes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshNotes.Location = new System.Drawing.Point(702, 98);
            this.btnRefreshNotes.Name = "btnRefreshNotes";
            this.btnRefreshNotes.Size = new System.Drawing.Size(86, 33);
            this.btnRefreshNotes.TabIndex = 3;
            this.btnRefreshNotes.Text = "Refrescar";
            this.tipSourcesNotes.SetToolTip(this.btnRefreshNotes, "Recargar Notas");
            this.btnRefreshNotes.UseVisualStyleBackColor = true;
            this.btnRefreshNotes.Click += new System.EventHandler(this.btnRefreshNotes_Click);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteNote.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNote.Location = new System.Drawing.Point(702, 59);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(86, 33);
            this.btnDeleteNote.TabIndex = 2;
            this.btnDeleteNote.Text = "Eliminar";
            this.tipSourcesNotes.SetToolTip(this.btnDeleteNote, "Eliminar Nota");
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNote.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.Location = new System.Drawing.Point(702, 20);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(86, 33);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Nueva";
            this.tipSourcesNotes.SetToolTip(this.btnAddNote, "Añadir Nota");
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // errSources
            // 
            this.errSources.ContainerControl = this;
            // 
            // errNotes
            // 
            this.errNotes.ContainerControl = this;
            // 
            // dgvSources
            // 
            this.dgvSources.AllowUserToAddRows = false;
            this.dgvSources.AllowUserToDeleteRows = false;
            this.dgvSources.AllowUserToResizeRows = false;
            this.dgvSources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSources.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSources.Location = new System.Drawing.Point(6, 20);
            this.dgvSources.MultiSelect = false;
            this.dgvSources.Name = "dgvSources";
            this.dgvSources.ReadOnly = true;
            this.dgvSources.RowHeadersVisible = false;
            this.dgvSources.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvSources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSources.Size = new System.Drawing.Size(680, 278);
            this.dgvSources.TabIndex = 1;
            this.dgvSources.SelectionChanged += new System.EventHandler(this.dgvSources_SelectionChanged);
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.AllowUserToResizeRows = false;
            this.dgvNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(6, 20);
            this.dgvNotes.MultiSelect = false;
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.RowHeadersVisible = false;
            this.dgvNotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(680, 173);
            this.dgvNotes.TabIndex = 0;
            this.dgvNotes.SelectionChanged += new System.EventHandler(this.dgvNotes_SelectionChanged);
            // 
            // frmSourcesNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 666);
            this.Controls.Add(this.splSourcesNotes);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSourcesNotes";
            this.Text = "Fuentes y Notas";
            this.Load += new System.EventHandler(this.frmSourcesNotes_Load);
            this.splSourcesNotes.Panel1.ResumeLayout(false);
            this.splSourcesNotes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splSourcesNotes)).EndInit();
            this.splSourcesNotes.ResumeLayout(false);
            this.grbSources.ResumeLayout(false);
            this.grbSources.PerformLayout();
            this.grbNotes.ResumeLayout(false);
            this.grbNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splSourcesNotes;
        private System.Windows.Forms.GroupBox grbSources;
        private Controls.NovaGrid dgvSources;
        private System.Windows.Forms.Button btnRefreshSources;
        private System.Windows.Forms.Button btnNewSource;
        private System.Windows.Forms.ToolTip tipSourcesNotes;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnCancelSource;
        private System.Windows.Forms.Button btnSaveSource;
        private System.Windows.Forms.ErrorProvider errSources;
        private System.Windows.Forms.GroupBox grbNotes;
        private Controls.NovaGrid dgvNotes;
        private System.Windows.Forms.TextBox txtNoteDesc;
        private System.Windows.Forms.DateTimePicker dtpNoteDate;
        private System.Windows.Forms.Label lblNoteDesc;
        private System.Windows.Forms.Label lblNoteDate;
        private System.Windows.Forms.Button btnCancelNote;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.Button btnRefreshNotes;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.ErrorProvider errNotes;
    }
}