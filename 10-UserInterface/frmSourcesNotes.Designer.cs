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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splSourcesNotes = new System.Windows.Forms.SplitContainer();
            this.grbSources = new System.Windows.Forms.GroupBox();
            this.dgvSources = new UserInterface.Controls.NovaGrid();
            this.btnRefreshSources = new System.Windows.Forms.Button();
            this.btnNewSource = new System.Windows.Forms.Button();
            this.tipSourcesNotes = new System.Windows.Forms.ToolTip(this.components);
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnCancelSource = new System.Windows.Forms.Button();
            this.btnSaveSource = new System.Windows.Forms.Button();
            this.errSourcesNotes = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splSourcesNotes)).BeginInit();
            this.splSourcesNotes.Panel1.SuspendLayout();
            this.splSourcesNotes.SuspendLayout();
            this.grbSources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSourcesNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // splSourcesNotes
            // 
            this.splSourcesNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splSourcesNotes.Location = new System.Drawing.Point(0, 0);
            this.splSourcesNotes.Name = "splSourcesNotes";
            this.splSourcesNotes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splSourcesNotes.Panel1
            // 
            this.splSourcesNotes.Panel1.Controls.Add(this.grbSources);
            this.splSourcesNotes.Size = new System.Drawing.Size(822, 543);
            this.splSourcesNotes.SplitterDistance = 322;
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
            this.grbSources.Size = new System.Drawing.Size(798, 298);
            this.grbSources.TabIndex = 0;
            this.grbSources.TabStop = false;
            this.grbSources.Text = "Fuentes";
            this.grbSources.Paint += new System.Windows.Forms.PaintEventHandler(this.grbSources_Paint);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSources.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSources.Location = new System.Drawing.Point(6, 20);
            this.dgvSources.MultiSelect = false;
            this.dgvSources.Name = "dgvSources";
            this.dgvSources.ReadOnly = true;
            this.dgvSources.RowHeadersVisible = false;
            this.dgvSources.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvSources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSources.Size = new System.Drawing.Size(684, 210);
            this.dgvSources.TabIndex = 1;
            this.dgvSources.SelectionChanged += new System.EventHandler(this.dgvSources_SelectionChanged);
            // 
            // btnRefreshSources
            // 
            this.btnRefreshSources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshSources.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSources.Location = new System.Drawing.Point(706, 59);
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
            this.btnNewSource.Location = new System.Drawing.Point(706, 20);
            this.btnNewSource.Name = "btnNewSource";
            this.btnNewSource.Size = new System.Drawing.Size(86, 33);
            this.btnNewSource.TabIndex = 2;
            this.btnNewSource.Text = "Nueva";
            this.tipSourcesNotes.SetToolTip(this.btnNewSource, "Añadir Fuente");
            this.btnNewSource.UseVisualStyleBackColor = true;
            this.btnNewSource.Click += new System.EventHandler(this.btnNewSource_Click);
            // 
            // lblSource
            // 
            this.lblSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(6, 261);
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
            this.txtSource.Location = new System.Drawing.Point(57, 258);
            this.txtSource.MaxLength = 100;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(530, 21);
            this.txtSource.TabIndex = 4;
            // 
            // btnCancelSource
            // 
            this.btnCancelSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSource.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSource.Location = new System.Drawing.Point(604, 251);
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
            this.btnSaveSource.Location = new System.Drawing.Point(706, 251);
            this.btnSaveSource.Name = "btnSaveSource";
            this.btnSaveSource.Size = new System.Drawing.Size(86, 33);
            this.btnSaveSource.TabIndex = 6;
            this.btnSaveSource.Text = "Guardar";
            this.tipSourcesNotes.SetToolTip(this.btnSaveSource, "Guardar cambios en Fuente");
            this.btnSaveSource.UseVisualStyleBackColor = true;
            this.btnSaveSource.Click += new System.EventHandler(this.btnSaveSource_Click);
            // 
            // errSourcesNotes
            // 
            this.errSourcesNotes.ContainerControl = this;
            // 
            // frmSourcesNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 543);
            this.Controls.Add(this.splSourcesNotes);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSourcesNotes";
            this.Text = "Fuentes y Notas";
            this.Load += new System.EventHandler(this.frmSourcesNotes_Load);
            this.splSourcesNotes.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splSourcesNotes)).EndInit();
            this.splSourcesNotes.ResumeLayout(false);
            this.grbSources.ResumeLayout(false);
            this.grbSources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSourcesNotes)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errSourcesNotes;
    }
}