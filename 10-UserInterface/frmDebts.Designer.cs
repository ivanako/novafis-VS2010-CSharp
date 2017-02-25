namespace UserInterface
{
    partial class frmDebts
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
            this.tipDebts = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDebtDate = new System.Windows.Forms.Label();
            this.dtpDebtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDebtDefaulterCount = new System.Windows.Forms.Label();
            this.dgvDefaulters = new UserInterface.Controls.NovaGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefaulters)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(563, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.tipDebts.SetToolTip(this.btnClose, "Cerrar ventana");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDebtDate
            // 
            this.lblDebtDate.AutoSize = true;
            this.lblDebtDate.Location = new System.Drawing.Point(12, 15);
            this.lblDebtDate.Name = "lblDebtDate";
            this.lblDebtDate.Size = new System.Drawing.Size(40, 13);
            this.lblDebtDate.TabIndex = 0;
            this.lblDebtDate.Text = "Fecha";
            // 
            // dtpDebtDate
            // 
            this.dtpDebtDate.CustomFormat = "dd/MM/yyy";
            this.dtpDebtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDebtDate.Location = new System.Drawing.Point(71, 12);
            this.dtpDebtDate.Name = "dtpDebtDate";
            this.dtpDebtDate.Size = new System.Drawing.Size(113, 21);
            this.dtpDebtDate.TabIndex = 0;
            this.dtpDebtDate.ValueChanged += new System.EventHandler(this.dtpDebtDate_ValueChanged);
            // 
            // lblDebtDefaulterCount
            // 
            this.lblDebtDefaulterCount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebtDefaulterCount.Location = new System.Drawing.Point(205, 13);
            this.lblDebtDefaulterCount.Name = "lblDebtDefaulterCount";
            this.lblDebtDefaulterCount.Size = new System.Drawing.Size(342, 23);
            this.lblDebtDefaulterCount.TabIndex = 7;
            this.lblDebtDefaulterCount.Text = "Morosos";
            this.lblDebtDefaulterCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDefaulters
            // 
            this.dgvDefaulters.AllowUserToAddRows = false;
            this.dgvDefaulters.AllowUserToDeleteRows = false;
            this.dgvDefaulters.AllowUserToResizeRows = false;
            this.dgvDefaulters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDefaulters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDefaulters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDefaulters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDefaulters.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDefaulters.Location = new System.Drawing.Point(15, 55);
            this.dgvDefaulters.MultiSelect = false;
            this.dgvDefaulters.Name = "dgvDefaulters";
            this.dgvDefaulters.ReadOnly = true;
            this.dgvDefaulters.RowHeadersVisible = false;
            this.dgvDefaulters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDefaulters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDefaulters.Size = new System.Drawing.Size(532, 307);
            this.dgvDefaulters.TabIndex = 1;
            // 
            // frmDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(675, 374);
            this.Controls.Add(this.lblDebtDefaulterCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDefaulters);
            this.Controls.Add(this.dtpDebtDate);
            this.Controls.Add(this.lblDebtDate);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmDebts";
            this.ShowInTaskbar = false;
            this.Text = "Deudas pendientes";
            this.Load += new System.EventHandler(this.frmDebts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefaulters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip tipDebts;
        private System.Windows.Forms.Label lblDebtDate;
        private System.Windows.Forms.DateTimePicker dtpDebtDate;
        private Controls.NovaGrid dgvDefaulters;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDebtDefaulterCount;
    }
}