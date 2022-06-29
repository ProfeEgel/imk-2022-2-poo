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
            //cmbPatients.Items.Add("Ricardo");
            //cmbPatients.Items.Add("Elizabeth");
            //cmbPatients.Items.Add("Lorenzo");
            //cmbPatients.Items.Add("Martha");
            //cmbPatients.SelectedIndex = 0;

            // #2 Items - objetos
            // SelectedIndex => OK
            // SelectedItem  => OK (objeto)
            // SelectedValue => N/A
            //cmbPatients.Items.Add(new Persona("Ricardo", "Martinez", 45));
            //cmbPatients.Items.Add(new Persona("Elizabeth", "Gnome", 30));
            //cmbPatients.Items.Add(new Persona("Lorenzo", "Lopez", 16));
            //cmbPatients.Items.Add(new Persona("Martha", "Macias", 29));
            //cmbPatients.DisplayMember = "FullName";
            //cmbPatients.SelectedIndex = 0;

            // #3 List - strings
            // SelectedIndex => OK
            // SelectedItem  => OK (string)
            // SelectedValue => OK (string)
            //List<string> data = new List<string>();
            //data.Add("Ricardo");
            //data.Add("Elizabeth");
            //data.Add("Lorenzo");
            //data.Add("Martha");
            //cmbPatients.DataSource = data;

            // #4 List - objetos
            // SelectedIndex => OK
            // SelectedItem  => OK (objeto)
            // SelectedValue => OK (personalizable)
            //List<Persona> data = new List<Persona>();
            //data.Add(new Persona("Ricardo", "Martinez", 45));
            //data.Add(new Persona("Elizabeth", "Gnome", 30));
            //data.Add(new Persona("Lorenzo", "Lopez", 16));
            //data.Add(new Persona("Martha", "Macias", 29));
            //cmbPatients.DisplayMember = "FullName";
            //cmbPatients.ValueMember = "Age";
            //cmbPatients.DataSource = data;

            // #5 List - objetos
            // SelectedIndex => OK
            // SelectedItem  => OK (objeto)
            // SelectedValue => OK (personalizable)
            BindingList<Persona> data = new BindingList<Persona>();
            data.Add(new Persona("Ricardo", "Martinez", 45));
            data.Add(new Persona("Elizabeth", "Gnome", 30));
            data.Add(new Persona("Lorenzo", "Lopez", 16));
            data.Add(new Persona("Martha", "Macias", 29));
            cmbPatients.DisplayMember = "FullName";
            cmbPatients.ValueMember = "Age";
            cmbPatients.DataSource = data;

            lstPatients.DisplayMember = "FullName";
            lstPatients.ValueMember = "Age";
            lstPatients.DataSource = data;
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
            //cmbPatients.Items.Add("dummy-patient");

            // #2
            //cmbPatients.Items.Add(new Persona("dummy", "patient", 57));

            // #5
            BindingList<Persona> data = (BindingList<Persona>)cmbPatients.DataSource;
            data.Add(new Persona("dummy", "patient", 57));
            data.ResetBindings();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // #1, #2
            //cmbPatients.Items.RemoveAt(0);}

            // #5
            BindingList<Persona> data = (BindingList<Persona>)cmbPatients.DataSource;
            data.RemoveAt(0);
            data.ResetBindings(); // update visual control (combo-box)
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esto es un mensaje...",
                                               "Aviso",
                                               MessageBoxButtons.YesNoCancel,
                                               MessageBoxIcon.Stop,
                                               MessageBoxDefaultButton.Button3);

            switch (res)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Se seleccionó YES");
                    break;

                case DialogResult.No:
                    MessageBox.Show("Se seleccionó NO");
                    break;

                case DialogResult.Cancel:
                //default:
                    break;
            }
        }

        private void otroMoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoreForm dlg = new MoreForm("Hola");
            dlg.ShowDialog();

            MessageBox.Show(dlg.OutputText);
        }
    }

    class Persona
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public string FullName => $"{LastName}, {FirstName}";

        public Persona(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
