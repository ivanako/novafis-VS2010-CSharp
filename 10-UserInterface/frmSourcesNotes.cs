using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Objects;
using BusinessLayer;

namespace UserInterface
{
    public partial class frmSourcesNotes : Form
    {
        public frmSourcesNotes()
        {
            InitializeComponent();
        }


        private void frmSourcesNotes_Load(object sender, EventArgs e)
        {
            initSources();
        }


        #region SOURCES
            private Maintenance srcOperation;
            private Source selSource;


            private void grbSources_Paint(object sender, PaintEventArgs e)
            {
                GroupBox grb = (GroupBox)sender;
                Graphics grbGraphics = e.Graphics;

                Brush textBrush = new SolidBrush(Color.Black);
                Brush borderBrush = new SolidBrush(Color.Blue);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = grbGraphics.MeasureString(grb.Text, grb.Font);
                Rectangle rect = new Rectangle(grb.ClientRectangle.X,
                                               grb.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               grb.ClientRectangle.Width - 1,
                                               grb.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                grbGraphics.Clear(this.BackColor);

                // Draw text
                grbGraphics.DrawString(grb.Text, grb.Font, textBrush, grb.Padding.Left, 0);

                // Drawing Border
                //Left
                grbGraphics.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                grbGraphics.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                grbGraphics.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                grbGraphics.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + grb.Padding.Left, rect.Y));
                //Top2
                grbGraphics.DrawLine(borderPen, new Point(rect.X + grb.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }

            private void dgvSources_SelectionChanged(object sender, EventArgs e)
            {
                foreach (DataGridViewRow src in dgvSources.SelectedRows)
                {
                    selSource.Identifier = Convert.ToInt32(src.Cells["Identifier"].Value);
                    selSource.Description = src.Cells["Description"].Value.ToString();
                }
            }

            private void btnNewSource_Click(object sender, EventArgs e)
            {
                srcOperation = Maintenance.Create;

                dgvSources.Enabled = false;

                resetSource();

                btnCancelSource.Visible = true;
            }

            private void btnRefreshSources_Click(object sender, EventArgs e)
            {
                List<Source> lstSources = SourceBL.findAllSources();

                populateSourceGrid(lstSources);
            }

            private void btnSaveSource_Click(object sender, EventArgs e)
            {
                bool isOK = checkSourceFields();

                if (isOK)
                {
                    saveSource();
                }
            }

            private void btnCancelSource_Click(object sender, EventArgs e)
            {
                dgvSources.Enabled = true;
                btnCancelSource.Visible = false;
                dgvSources.CurrentRow.Selected = false;
                dgvSources.CurrentRow.Selected = true;
            }



            private void initSources()
            {
                srcOperation = Maintenance.Edit;

                this.selSource = new Source();

                List<Source> lstSources = SourceBL.findAllSources();

                populateSourceGrid(lstSources);

                bindSourceControls();
            }

            private void populateSourceGrid(List<Source> lstSources)
            {
                SortableBindingList<Source> sblSources = new SortableBindingList<Source>(lstSources);

                dgvSources.DataSource = sblSources;

                dgvSources.Columns["Identifier"].Visible = false;
            }

            private void bindSourceControls()
            {
                BindingSource bs = new BindingSource(selSource, null);

                txtSource.DataBindings.Add("Text", bs, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            private void resetSource()
            {
                txtSource.Text = string.Empty;
            }

            private bool checkSourceFields()
            {
                bool isOK = true;

                errSourcesNotes.SetError(txtSource, string.Empty);

                if (string.IsNullOrWhiteSpace(txtSource.Text))
                {
                    errSourcesNotes.SetError(txtSource, "Proporcionar Fuente");
                    isOK = false;
                }

                return isOK;
            }

            private void saveSource()
            {
                Source src = new Source()
                {
                    Description = txtSource.Text.Trim(),
                };


                if (srcOperation.Equals(Maintenance.Edit))
                {
                    src.Identifier = selSource.Identifier;
                }

                List<Source> lstSources = SourceBL.saveSource(src);

                populateSourceGrid(lstSources);

                if (srcOperation.Equals(Maintenance.Create))
                {
                    dgvSources.Enabled = true;
                    btnCancelSource.Visible = false;
                    srcOperation = Maintenance.Edit;
                }
            }
        #endregion

            



        
    }
}
