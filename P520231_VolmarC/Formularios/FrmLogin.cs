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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

      

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //Cierra la app
            Application.Exit();
        }

        private void BtnVerContrasenia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasenia.UseSystemPasswordChar = false;
        }

        private void BtnVerContrasenia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasenia.UseSystemPasswordChar = true;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // Validar que se haya digitado un usuario y contraseña
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtContrasenia.Text.Trim()))
            {

                string usuario = TxtEmail.Text.Trim();
                string contrasennia = TxtContrasenia.Text.Trim();

                //validar que los datos digitados sean correctos
                //En caso de que la validacion sea correcta, aplicamos los valores
                Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ValidarUsuario(usuario, contrasennia);

                if (Globales.MiUsuarioGlobal.UsuarioId > 0)
                {
                    //si la validacion es correcta el id será mayor a cero

                    Globales.MiFormPrincipal.Show();

                    this.Hide();


                }

                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectas...", "Error de validación", MessageBoxButtons.OK);

                    TxtContrasenia.Focus();
                    TxtContrasenia.SelectAll();

                }


            }
            else
            {
                MessageBox.Show("Faltan datos requeridos", "Error de validación", MessageBoxButtons.OK);

            }


            
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //Al presionar cierta combinación de teclas el botón de ingreso directo aparece
            if (e.Shift && e.Alt && e.KeyCode == Keys.A) 
            {
                //si presionamos shit + a
                BtnIngresoDirecto.Visible = true;

            }
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.MiFormPrincipal.Show();

            this.Hide();
        }
    }
}
