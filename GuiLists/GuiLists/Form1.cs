using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiLists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // #1 Items - strings
            // SelectedIndex => OK
            // SelectedItem  => OK (string)
            // SelectedValue => N/A
            cmbPatients.Items.Add("Ricardo");
            cmbPatients.Items.Add("Elizabeth");
            cmbPatients.Items.Add("Lorenzo");
            cmbPatients.Items.Add("Martha");
            cmbPatients.SelectedIndex = 0;
        }

        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIndex.Text = $"{cmbPatients.SelectedIndex}";
            txtItem.Text = $"{cmbPatients.SelectedItem}";
            txtValue.Text = $"{cmbPatients.SelectedValue}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // #1
            cmbPatients.Items.Add("dummy-patient");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // #1
            cmbPatients.Items.RemoveAt(0);
        }
    }
}
