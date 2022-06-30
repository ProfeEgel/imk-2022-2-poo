using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalCare;

namespace DentalCareForms
{
    public partial class MainForm : Form
    {
        private Agenda agenda;

        public MainForm()
        {
            InitializeComponent();

            agenda = new Agenda();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendarCitasForm dlg = new AgendarCitasForm(agenda);
            dlg.ShowDialog();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
