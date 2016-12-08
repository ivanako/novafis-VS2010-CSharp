using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterface.Controls
{
    public partial class NovaGridOld : UserControl
    {
        public NovaGridOld()
        {
            InitializeComponent();
        }

        public object DataSource
        {
            get { return dgvNovafis.DataSource; }
            set { dgvNovafis.DataSource = value; }
        }

        public DataGridViewColumnCollection Columns
        {
            get { return dgvNovafis.Columns; }
            //set { dgvNovafis.Columns = value; }
        }
    }
}
