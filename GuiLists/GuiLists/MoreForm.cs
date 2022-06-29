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
    public partial class MoreForm : Form
    {
        public MoreForm(string texto1)
        {
            InitializeComponent();

            txtIn.Text = texto1;
        }

        public string OutputText => txtOut.Text;
    }
}
