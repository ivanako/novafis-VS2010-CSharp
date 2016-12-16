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
            initNotes();
        }


        #region SOURCES
            private Maintenance srcOperation;
            private Source selSource;


            private void grbSources_Paint(object sender, PaintEventArgs e)
            {
                paintGroupBoxBorder((GroupBox)sender, e.Graphics);
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

                errSources.SetError(txtSource, string.Empty);

                if (string.IsNullOrWhiteSpace(txtSource.Text))
                {
                    errSources.SetError(txtSource, "Proporcionar Fuente");
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

        #region NOTES
            private Maintenance noteOperation;
            private Note selNote;

            private void grbNotes_Paint(object sender, PaintEventArgs e)
            {
                paintGroupBoxBorder((GroupBox)sender, e.Graphics);
            }

            private void dgvNotes_SelectionChanged(object sender, EventArgs e)
            {
                foreach (DataGridViewRow note in dgvNotes.SelectedRows)
                {
                    this.selNote.Identifier = Convert.ToInt32(note.Cells["Identifier"].Value);
                    this.selNote.Date = Convert.ToDateTime(note.Cells["Date"].Value);
                    this.selNote.Description = note.Cells["Description"].Value.ToString();
                }
            }

            private void btnAddNote_Click(object sender, EventArgs e)
            {
                noteOperation = Maintenance.Create;

                dgvNotes.Enabled = false;

                resetNote();

                btnCancelNote.Visible = true;
            }
            private void btnDeleteNote_Click(object sender, EventArgs e)
            {
                noteOperation = Maintenance.Delete;

                deleteNote();
            }
            private void btnRefreshNotes_Click(object sender, EventArgs e)
            {
                List<Note> lstNotes = NoteBL.findAllNotes();

                populateNoteGrid(lstNotes);
            }

            private void btnSaveNote_Click(object sender, EventArgs e)
            {
                bool isOK = checkNoteFields();

                if (isOK)
                {
                    saveNote();
                }
            }
            private void btnCancelNote_Click(object sender, EventArgs e)
            {
                dgvNotes.Enabled = true;
                btnCancelNote.Visible = false;
                dgvNotes.CurrentRow.Selected = false;
                dgvNotes.CurrentRow.Selected = true;
            }

            private void initNotes()
            {
                noteOperation = Maintenance.Edit;

                this.selNote = new Note();

                List<Note> lstNotes = NoteBL.findAllNotes();

                populateNoteGrid(lstNotes);

                bindNoteControls();
            }
            private void populateNoteGrid(List<Note> lstNotes)
            {
                SortableBindingList<Note> sblNotes = new SortableBindingList<Note>(lstNotes);

                dgvNotes.DataSource = sblNotes;

                dgvNotes.Columns["Identifier"].Visible = false;
            }
            private void bindNoteControls()
            {
                BindingSource bs = new BindingSource(this.selNote, null);

                dtpNoteDate.DataBindings.Add("Value", bs, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
                txtNoteDesc.DataBindings.Add("Text", bs, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            private void resetNote()
            {
                dtpNoteDate.Value = DateTime.Today;
                txtNoteDesc.Text = string.Empty;
            }

            private bool checkNoteFields()
            {
                bool isOK = true;

                errNotes.SetError(txtNoteDesc, string.Empty);

                if (string.IsNullOrWhiteSpace(txtNoteDesc.Text))
                {
                    errNotes.SetError(txtNoteDesc, "Proporcionar Nota");
                    isOK = false;
                }

                return isOK;
            }

            private void saveNote()
            {
                Note note = new Note()
                {
                    Date = dtpNoteDate.Value,
                    Description = txtNoteDesc.Text.Trim()
                };


                if (noteOperation.Equals(Maintenance.Edit))
                {
                    note.Identifier = this.selNote.Identifier;
                }

                List<Note> lstNotes = NoteBL.saveNote(note);

                populateNoteGrid(lstNotes);

                if (noteOperation.Equals(Maintenance.Create))
                {
                    dgvNotes.Enabled = true;
                    btnCancelNote.Visible = false;
                    noteOperation = Maintenance.Edit;
                }
            }

            private void deleteNote()
            {
                if (dgvNotes.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("¿Eliminar la Nota seleccionada?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) 
                        == DialogResult.Yes)
                    {
                        List<Note> lstNotes = NoteBL.deleteNote(this.selNote.Identifier);

                        populateNoteGrid(lstNotes);
                    }
                }
            }
        #endregion




        private void paintGroupBoxBorder(GroupBox grb, Graphics grbGraphics)
        {
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

        

        

        

        

        

        

    }
}
