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
using System.Data.Entity;

namespace Buses_station.Forms
{
    public partial class BusEdit : Form
    {
        private BusContext context;
        public BusEdit()
        {

            InitializeComponent();
            context = new BusContext();
            NumberComboBox.DataSource = context.Buses.ToList();
        }

        private void NumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bus bus = (Bus)NumberComboBox.SelectedItem;
            ModelTextBox.Text = bus.model;
        }

        private void BusEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ifSave = MessageBox.Show("Зберегти внесенні змінни?", "Увага", MessageBoxButtons.YesNoCancel);
            if (ifSave == DialogResult.Yes)
                context.SaveChanges();
            else if (ifSave == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void ModelTextBox_TextChanged(object sender, EventArgs e)
        {
            Bus bus = (Bus)NumberComboBox.SelectedItem;
            bus.model = ModelTextBox.Text;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            context.Buses.Remove((Bus)NumberComboBox.SelectedItem);
            NumberComboBox.DataSource = context.Buses.ToList();
        }
    }
}
