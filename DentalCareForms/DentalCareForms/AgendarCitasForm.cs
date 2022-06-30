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
    public partial class AgendarCitasForm : Form
    {
        private Agenda agenda;

        public AgendarCitasForm(Agenda agenda)
        {
            InitializeComponent();

            this.agenda = agenda;

            cmbPatients.DisplayMember = "FullName";
            cmbPatients.ValueMember = "Id";
            cmbPatients.DataSource = agenda.GetPatients();
        }

        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!agenda.HasPendingAppointment((int)cmbPatients.SelectedValue))
            {
                lblWarning.Visible = false;

                cmbDays.Enabled = true;
                cmbTimes.Enabled = true;
                
                cmbDays.DisplayMember = "Name";
                cmbDays.ValueMember = "Id";
                cmbDays.DataSource = agenda.GetAvailableDays();
            }
            else
            {
                lblWarning.Visible = true;

                cmbDays.DataSource = null;
                cmbTimes.DataSource = null;
                cmbDays.Enabled = false;
                cmbTimes.Enabled = false;
            }
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDays.DataSource != null)
            {
                cmbTimes.DisplayMember = "Description";
                cmbTimes.ValueMember = "Id";
                cmbTimes.DataSource = agenda.GetAvailableScheduleTimesByDay((int)cmbDays.SelectedValue);
            }
        }

        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Confirma la cita con los datos actuales?", "Confirmación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            switch (res)
            {
                case DialogResult.Yes:
                    agenda.ScheduleAppointment((int)cmbPatients.SelectedValue,
                                       (int)cmbDays.SelectedValue,
                                       (int)cmbTimes.SelectedValue);

                    MessageBox.Show("¡Se agendó la cita correctamente!", "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    Close();
                    break;

                case DialogResult.No:
                    break;
            }
        }
    }
}
