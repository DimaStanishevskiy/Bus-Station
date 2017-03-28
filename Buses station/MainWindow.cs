using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buses_station.Class;
using Buses_station.Forms;

namespace Buses_station
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void автобусиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new BusEdit();
            form.MdiParent = this;
            form.Show();
        }
    }
}
