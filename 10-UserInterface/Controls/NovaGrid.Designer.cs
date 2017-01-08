using System.Windows.Forms;
using System.Drawing;
namespace UserInterface.Controls
{
    partial class NovaGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            DataGridViewCellStyle dgvColumnHeaderStyle = new DataGridViewCellStyle();
            dgvColumnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvColumnHeaderStyle.BackColor = SystemColors.Control;
            dgvColumnHeaderStyle.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dgvColumnHeaderStyle.ForeColor = SystemColors.WindowText;
            dgvColumnHeaderStyle.SelectionBackColor = SystemColors.Highlight;
            dgvColumnHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvColumnHeaderStyle.WrapMode = DataGridViewTriState.False;

            DataGridViewCellStyle dgvDefCellStyle = new DataGridViewCellStyle();
            dgvDefCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDefCellStyle.BackColor = SystemColors.Window;
            dgvDefCellStyle.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dgvDefCellStyle.ForeColor = SystemColors.WindowText;
            dgvDefCellStyle.SelectionBackColor = SystemColors.WindowText;
            dgvDefCellStyle.SelectionForeColor = SystemColors.Window;
            dgvDefCellStyle.WrapMode = DataGridViewTriState.False;

            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ColumnHeadersDefaultCellStyle = dgvColumnHeaderStyle;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DefaultCellStyle = dgvDefCellStyle;
            this.Location = new System.Drawing.Point(0, 0);
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

        #endregion
    }
}
