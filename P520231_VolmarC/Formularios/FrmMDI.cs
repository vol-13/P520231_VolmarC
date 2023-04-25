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

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            //mostar el usuario logueado
            string InfoUsuario = string.Format("{0} - {1}({2})", 
            Globales.MiUsuarioGlobal.UsuarioNombre,
            Globales.MiUsuarioGlobal.UsuarioCorreo, 
            Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolDescripcion);

            LblUsuario.Text = InfoUsuario;

            //Ocultar opciones de menu al usuario normal
            switch (Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolId)
            {
                case 1:
                    //seria admin, no se le oculta nada
                    break;

                case 2:
                    //ocultar opciones de menu al usuario normal
                    gestiónDeProductosToolStripMenuItem.Visible = false;
                    rolesDeUsuarioToolStripMenuItem.Visible = false;
                    tiposDeProveedorToolStripMenuItem.Visible = false;
                    tiposDeCompraToolStripMenuItem.Visible = false;
                    break;

            }





        }

        private void registroDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormRegistroCompra.Visible)
            {
                Globales.MiFormRegistroCompra = new FrmRegistroCompra();
                Globales.MiFormRegistroCompra.Show();
            }
        }

        private void gestiónDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionProveedor.Visible)
            {
                Globales.MiFormGestionProveedor = new FrmProveedorGestion();

                Globales.MiFormGestionProveedor.Show();
            }
        }
    }
}
