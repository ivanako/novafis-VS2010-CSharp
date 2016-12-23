namespace UserInterface
{
    partial class mdiContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain_Patients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain_Physios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccesories = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccesories_Locs_Les = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccesories_Sources_Notes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain_Appointments = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain,
            this.mnuAccesories});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMain
            // 
            this.mnuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain_Patients,
            this.mnuMain_Physios,
            this.mnuMain_Appointments});
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(65, 20);
            this.mnuMain.Text = "Principal";
            // 
            // mnuMain_Patients
            // 
            this.mnuMain_Patients.Name = "mnuMain_Patients";
            this.mnuMain_Patients.Size = new System.Drawing.Size(162, 22);
            this.mnuMain_Patients.Text = "Pacientes...";
            this.mnuMain_Patients.Click += new System.EventHandler(this.mnuMain_Patients_Click);
            // 
            // mnuMain_Physios
            // 
            this.mnuMain_Physios.Name = "mnuMain_Physios";
            this.mnuMain_Physios.Size = new System.Drawing.Size(162, 22);
            this.mnuMain_Physios.Text = "Fisioterapeutas...";
            this.mnuMain_Physios.Click += new System.EventHandler(this.mnuMain_Physios_Click);
            // 
            // mnuAccesories
            // 
            this.mnuAccesories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAccesories_Locs_Les,
            this.mnuAccesories_Sources_Notes});
            this.mnuAccesories.Name = "mnuAccesories";
            this.mnuAccesories.Size = new System.Drawing.Size(76, 20);
            this.mnuAccesories.Text = "Accesorios";
            // 
            // mnuAccesories_Locs_Les
            // 
            this.mnuAccesories_Locs_Les.Name = "mnuAccesories_Locs_Les";
            this.mnuAccesories_Locs_Les.Size = new System.Drawing.Size(216, 22);
            this.mnuAccesories_Locs_Les.Text = "Localizaciones y Lesiones...";
            this.mnuAccesories_Locs_Les.Click += new System.EventHandler(this.mnuAccesories_Locs_Les_Click);
            // 
            // mnuAccesories_Sources_Notes
            // 
            this.mnuAccesories_Sources_Notes.Name = "mnuAccesories_Sources_Notes";
            this.mnuAccesories_Sources_Notes.Size = new System.Drawing.Size(216, 22);
            this.mnuAccesories_Sources_Notes.Text = "Fuentes y Notas...";
            this.mnuAccesories_Sources_Notes.Click += new System.EventHandler(this.mnuAccesories_Sources_Notes_Click);
            // 
            // mnuMain_Appointments
            // 
            this.mnuMain_Appointments.Name = "mnuMain_Appointments";
            this.mnuMain_Appointments.Size = new System.Drawing.Size(162, 22);
            this.mnuMain_Appointments.Text = "Citas...";
            this.mnuMain_Appointments.Click += new System.EventHandler(this.mnuMain_Appointments_Click);
            // 
            // mdiContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 375);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mdiContainer";
            this.Text = "NOVAFIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiContainer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMain_Physios;
        private System.Windows.Forms.ToolStripMenuItem mnuAccesories;
        private System.Windows.Forms.ToolStripMenuItem mnuAccesories_Locs_Les;
        private System.Windows.Forms.ToolStripMenuItem mnuMain_Patients;
        private System.Windows.Forms.ToolStripMenuItem mnuAccesories_Sources_Notes;
        private System.Windows.Forms.ToolStripMenuItem mnuMain_Appointments;
    }
}