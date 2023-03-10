using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_VolmarC.Formularios
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //control para que el formulario de gestion se muestre una vez
            if (!Globales.MiFormGestionUsario.Visible)
            {
                Globales.MiFormGestionUsario = new FrmUsuariosGestion();

                Globales.MiFormGestionUsario.Show();
            }
        }
    }
}
