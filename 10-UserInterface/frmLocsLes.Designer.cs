namespace UserInterface
{
    partial class frmLocsLes
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
            this.splLocsLes = new System.Windows.Forms.SplitContainer();
            this.grbLocations = new System.Windows.Forms.GroupBox();
            this.btnCancelLocation = new System.Windows.Forms.Button();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnRefreshLocations = new System.Windows.Forms.Button();
            this.btnNewLocation = new System.Windows.Forms.Button();
            this.grbLesions = new System.Windows.Forms.GroupBox();
            this.btnCancelLesion = new System.Windows.Forms.Button();
            this.btnSaveLesion = new System.Windows.Forms.Button();
            this.lblLesion = new System.Windows.Forms.Label();
            this.txtLesion = new System.Windows.Forms.TextBox();
            this.btnRefreshLesions = new System.Windows.Forms.Button();
            this.btnNewLesion = new System.Windows.Forms.Button();
            this.tipLocsLes = new System.Windows.Forms.ToolTip(this.components);
            this.errLocsLes = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblLocations = new System.Windows.Forms.Label();
            this.dgvLocations = new UserInterface.Controls.NovaGrid();
            this.dgvLesions = new UserInterface.Controls.NovaGrid();
            this.lblLesions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splLocsLes)).BeginInit();
            this.splLocsLes.Panel1.SuspendLayout();
            this.splLocsLes.Panel2.SuspendLayout();
            this.splLocsLes.SuspendLayout();
            this.grbLocations.SuspendLayout();
            this.grbLesions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errLocsLes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesions)).BeginInit();
            this.SuspendLayout();
            // 
            // splLocsLes
            // 
            this.splLocsLes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splLocsLes.Location = new System.Drawing.Point(0, 0);
            this.splLocsLes.Name = "splLocsLes";
            this.splLocsLes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splLocsLes.Panel1
            // 
            this.splLocsLes.Panel1.Controls.Add(this.grbLocations);
            this.splLocsLes.Panel1MinSize = 300;
            // 
            // splLocsLes.Panel2
            // 
            this.splLocsLes.Panel2.Controls.Add(this.grbLesions);
            this.splLocsLes.Panel2MinSize = 300;
            this.splLocsLes.Size = new System.Drawing.Size(1047, 664);
            this.splLocsLes.SplitterDistance = 329;
            this.splLocsLes.TabIndex = 0;
            // 
            // grbLocations
            // 
            this.grbLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLocations.BackColor = System.Drawing.Color.Gainsboro;
            this.grbLocations.Controls.Add(this.lblLocations);
            this.grbLocations.Controls.Add(this.btnCancelLocation);
            this.grbLocations.Controls.Add(this.btnSaveLocation);
            this.grbLocations.Controls.Add(this.lblLocation);
            this.grbLocations.Controls.Add(this.txtLocation);
            this.grbLocations.Controls.Add(this.btnRefreshLocations);
            this.grbLocations.Controls.Add(this.btnNewLocation);
            this.grbLocations.Controls.Add(this.dgvLocations);
            this.grbLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbLocations.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLocations.Location = new System.Drawing.Point(12, 12);
            this.grbLocations.Name = "grbLocations";
            this.grbLocations.Size = new System.Drawing.Size(1023, 307);
            this.grbLocations.TabIndex = 0;
            this.grbLocations.TabStop = false;
            // 
            // btnCancelLocation
            // 
            this.btnCancelLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelLocation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLocation.Location = new System.Drawing.Point(819, 254);
            this.btnCancelLocation.Name = "btnCancelLocation";
            this.btnCancelLocation.Size = new System.Drawing.Size(86, 33);
            this.btnCancelLocation.TabIndex = 4;
            this.btnCancelLocation.Text = "Cancelar";
            this.tipLocsLes.SetToolTip(this.btnCancelLocation, "Cancelar alta Localización");
            this.btnCancelLocation.UseVisualStyleBackColor = true;
            this.btnCancelLocation.Visible = false;
            this.btnCancelLocation.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLocation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLocation.Location = new System.Drawing.Point(931, 254);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(86, 33);
            this.btnSaveLocation.TabIndex = 3;
            this.btnSaveLocation.Text = "Guardar";
            this.tipLocsLes.SetToolTip(this.btnSaveLocation, "Guardar cambios en Localización");
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(15, 264);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 13);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLocation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(75, 261);
            this.txtLocation.MaxLength = 100;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(703, 21);
            this.txtLocation.TabIndex = 2;
            // 
            // btnRefreshLocations
            // 
            this.btnRefreshLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshLocations.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLocations.Location = new System.Drawing.Point(931, 82);
            this.btnRefreshLocations.Name = "btnRefreshLocations";
            this.btnRefreshLocations.Size = new System.Drawing.Size(86, 33);
            this.btnRefreshLocations.TabIndex = 1;
            this.btnRefreshLocations.Text = "Refrescar";
            this.tipLocsLes.SetToolTip(this.btnRefreshLocations, "Recargar Localizaciones");
            this.btnRefreshLocations.UseVisualStyleBackColor = true;
            this.btnRefreshLocations.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNewLocation
            // 
            this.btnNewLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewLocation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLocation.Location = new System.Drawing.Point(931, 43);
            this.btnNewLocation.Name = "btnNewLocation";
            this.btnNewLocation.Size = new System.Drawing.Size(86, 33);
            this.btnNewLocation.TabIndex = 0;
            this.btnNewLocation.Text = "Nueva";
            this.tipLocsLes.SetToolTip(this.btnNewLocation, "Nueva Localización");
            this.btnNewLocation.UseVisualStyleBackColor = true;
            this.btnNewLocation.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grbLesions
            // 
            this.grbLesions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLesions.BackColor = System.Drawing.Color.Gainsboro;
            this.grbLesions.Controls.Add(this.lblLesions);
            this.grbLesions.Controls.Add(this.btnCancelLesion);
            this.grbLesions.Controls.Add(this.btnSaveLesion);
            this.grbLesions.Controls.Add(this.lblLesion);
            this.grbLesions.Controls.Add(this.txtLesion);
            this.grbLesions.Controls.Add(this.btnRefreshLesions);
            this.grbLesions.Controls.Add(this.btnNewLesion);
            this.grbLesions.Controls.Add(this.dgvLesions);
            this.grbLesions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLesions.Location = new System.Drawing.Point(12, 6);
            this.grbLesions.Name = "grbLesions";
            this.grbLesions.Size = new System.Drawing.Size(1023, 313);
            this.grbLesions.TabIndex = 0;
            this.grbLesions.TabStop = false;
            // 
            // btnCancelLesion
            // 
            this.btnCancelLesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelLesion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLesion.Location = new System.Drawing.Point(819, 259);
            this.btnCancelLesion.Name = "btnCancelLesion";
            this.btnCancelLesion.Size = new System.Drawing.Size(86, 33);
            this.btnCancelLesion.TabIndex = 4;
            this.btnCancelLesion.Text = "Cancelar";
            this.tipLocsLes.SetToolTip(this.btnCancelLesion, "Cancelar alta Lesión");
            this.btnCancelLesion.UseVisualStyleBackColor = true;
            this.btnCancelLesion.Visible = false;
            this.btnCancelLesion.Click += new System.EventHandler(this.btnCancelLesion_Click);
            // 
            // btnSaveLesion
            // 
            this.btnSaveLesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLesion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLesion.Location = new System.Drawing.Point(931, 259);
            this.btnSaveLesion.Name = "btnSaveLesion";
            this.btnSaveLesion.Size = new System.Drawing.Size(86, 33);
            this.btnSaveLesion.TabIndex = 3;
            this.btnSaveLesion.Text = "Guardar";
            this.tipLocsLes.SetToolTip(this.btnSaveLesion, "Guardar cambios en Lesión");
            this.btnSaveLesion.UseVisualStyleBackColor = true;
            this.btnSaveLesion.Click += new System.EventHandler(this.btnSaveLesion_Click);
            // 
            // lblLesion
            // 
            this.lblLesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLesion.AutoSize = true;
            this.lblLesion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesion.Location = new System.Drawing.Point(15, 269);
            this.lblLesion.Name = "lblLesion";
            this.lblLesion.Size = new System.Drawing.Size(43, 13);
            this.lblLesion.TabIndex = 6;
            this.lblLesion.Text = "Lesión";
            // 
            // txtLesion
            // 
            this.txtLesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLesion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLesion.Location = new System.Drawing.Point(75, 266);
            this.txtLesion.MaxLength = 100;
            this.txtLesion.Name = "txtLesion";
            this.txtLesion.Size = new System.Drawing.Size(703, 21);
            this.txtLesion.TabIndex = 2;
            // 
            // btnRefreshLesions
            // 
            this.btnRefreshLesions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshLesions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLesions.Location = new System.Drawing.Point(931, 82);
            this.btnRefreshLesions.Name = "btnRefreshLesions";
            this.btnRefreshLesions.Size = new System.Drawing.Size(86, 33);
            this.btnRefreshLesions.TabIndex = 1;
            this.btnRefreshLesions.Text = "Refrescar";
            this.tipLocsLes.SetToolTip(this.btnRefreshLesions, "Recargar Lesiones");
            this.btnRefreshLesions.UseVisualStyleBackColor = true;
            this.btnRefreshLesions.Click += new System.EventHandler(this.btnRefreshLesions_Click);
            // 
            // btnNewLesion
            // 
            this.btnNewLesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewLesion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLesion.Location = new System.Drawing.Point(931, 43);
            this.btnNewLesion.Name = "btnNewLesion";
            this.btnNewLesion.Size = new System.Drawing.Size(86, 33);
            this.btnNewLesion.TabIndex = 0;
            this.btnNewLesion.Text = "Nueva";
            this.tipLocsLes.SetToolTip(this.btnNewLesion, "Nueva Lesión");
            this.btnNewLesion.UseVisualStyleBackColor = true;
            this.btnNewLesion.Click += new System.EventHandler(this.btnNewLesion_Click);
            // 
            // errLocsLes
            // 
            this.errLocsLes.ContainerControl = this;
            // 
            // lblLocations
            // 
            this.lblLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocations.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocations.Location = new System.Drawing.Point(6, 9);
            this.lblLocations.Name = "lblLocations";
            this.lblLocations.Size = new System.Drawing.Size(899, 21);
            this.lblLocations.TabIndex = 5;
            this.lblLocations.Text = "Localizaciones";
            this.lblLocations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLocations
            // 
            this.dgvLocations.AllowUserToAddRows = false;
            this.dgvLocations.AllowUserToDeleteRows = false;
            this.dgvLocations.AllowUserToResizeRows = false;
            this.dgvLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocations.Location = new System.Drawing.Point(6, 43);
            this.dgvLocations.MultiSelect = false;
            this.dgvLocations.Name = "dgvLocations";
            this.dgvLocations.ReadOnly = true;
            this.dgvLocations.RowHeadersVisible = false;
            this.dgvLocations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocations.Size = new System.Drawing.Size(899, 192);
            this.dgvLocations.TabIndex = 0;
            this.dgvLocations.SelectionChanged += new System.EventHandler(this.dgvLocations_SelectionChanged);
            // 
            // dgvLesions
            // 
            this.dgvLesions.AllowUserToAddRows = false;
            this.dgvLesions.AllowUserToDeleteRows = false;
            this.dgvLesions.AllowUserToResizeRows = false;
            this.dgvLesions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLesions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLesions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLesions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesions.Location = new System.Drawing.Point(6, 43);
            this.dgvLesions.MultiSelect = false;
            this.dgvLesions.Name = "dgvLesions";
            this.dgvLesions.ReadOnly = true;
            this.dgvLesions.RowHeadersVisible = false;
            this.dgvLesions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvLesions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLesions.Size = new System.Drawing.Size(899, 196);
            this.dgvLesions.TabIndex = 1;
            this.dgvLesions.SelectionChanged += new System.EventHandler(this.dgvLesions_SelectionChanged);
            // 
            // lblLesions
            // 
            this.lblLesions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLesions.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesions.Location = new System.Drawing.Point(6, 10);
            this.lblLesions.Name = "lblLesions";
            this.lblLesions.Size = new System.Drawing.Size(899, 21);
            this.lblLesions.TabIndex = 7;
            this.lblLesions.Text = "Lesiones";
            this.lblLesions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLocsLes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 664);
            this.Controls.Add(this.splLocsLes);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLocsLes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizaciones y Lesiones";
            this.Load += new System.EventHandler(this.frmLocsLes_Load);
            this.splLocsLes.Panel1.ResumeLayout(false);
            this.splLocsLes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splLocsLes)).EndInit();
            this.splLocsLes.ResumeLayout(false);
            this.grbLocations.ResumeLayout(false);
            this.grbLocations.PerformLayout();
            this.grbLesions.ResumeLayout(false);
            this.grbLesions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errLocsLes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splLocsLes;
        private System.Windows.Forms.GroupBox grbLocations;
        private Controls.NovaGrid dgvLocations;
        private System.Windows.Forms.Button btnNewLocation;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnCancelLocation;
        private System.Windows.Forms.Button btnRefreshLocations;
        private System.Windows.Forms.ToolTip tipLocsLes;
        private System.Windows.Forms.ErrorProvider errLocsLes;
        private System.Windows.Forms.GroupBox grbLesions;
        private Controls.NovaGrid dgvLesions;
        private System.Windows.Forms.Button btnRefreshLesions;
        private System.Windows.Forms.Button btnNewLesion;
        private System.Windows.Forms.Button btnCancelLesion;
        private System.Windows.Forms.Button btnSaveLesion;
        private System.Windows.Forms.Label lblLesion;
        private System.Windows.Forms.TextBox txtLesion;
        private System.Windows.Forms.Label lblLocations;
        private System.Windows.Forms.Label lblLesions;



    }
}