using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.GUILayer.Reports
{
    public partial class frmBugReport : Form
    {
        public frmBugReport()
        {
            InitializeComponent();
        }

        private void frmBugReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Bugs' Puede moverla o quitarla según sea necesario.
            this.BugsTableAdapter.Fill(this.DataSet1.Bugs);

            this.reportViewer1.RefreshReport();
        }
    }
}
