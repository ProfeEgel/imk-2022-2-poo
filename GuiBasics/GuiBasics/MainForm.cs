using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiBasics
{
    public partial class MainForm : Form
    {
        private int counter;

        private List<CheckBox> checkboxes;

        private List<RadioButton> radioButtons;

        public MainForm()
        {
            InitializeComponent();

            counter = 0;
            txtTest.Text = "Click(s) = 0";

            checkboxes = new List<CheckBox>()
            {
                chkRojo, chkAzul, chkVerde, chkAmarillo, chkCyan, chkMagenta
            };

            radioButtons = new List<RadioButton>()
            {
                radRojo, radAmarillo
            };
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se presionó el botón \"TEST\"");
            //txtTest.Text = "Se presionó el botón \"TEST\"";

            txtTest.Text = $"Click(s) = {++counter}";
        }

        private void chkDouble_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkRojo_CheckedChanged(object sender, EventArgs e)
        {
            List<string> activos = new List<string>();
            checkboxes.ForEach(chk =>
            {
                if (chk.Checked)
                {
                    activos.Add(chk.Text);
                }
            });

            txtColors.Text = String.Join("+", activos);
        }

        private void radRojo_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            radioButtons[0] = rb;

            txtColors2.Text = $"{radioButtons[0].Text}+{radioButtons[1].Text}";
        }

        private void radAmarillo_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            radioButtons[1] = rb;

            txtColors2.Text = $"{radioButtons[0].Text}+{radioButtons[1].Text}";
        }
    }
}
