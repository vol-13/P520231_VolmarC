using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace P520231_VolmarC.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {

        //objeto local para usuario
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        //Lista local de usuarios que se visualizan en el datagridview
        private DataTable ListaUsuarios { get; set; }
        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //definimos el padre mdi
            MdiParent = Globales.MiFormPrincipal;

            CargarListaRoles();

            CargarListaDeUsuarios();
        }

        private void CargarListaDeUsuarios()
        {
            //resetear la lista de usuarios haciendo reintstancia del objeto
            ListaUsuarios = new DataTable();

            if (CboxVerActivos.Checked)
            {
                ListaUsuarios = MiUsuarioLocal.ListarActivos();
            }
            else
            {
                ListaUsuarios = MiUsuarioLocal.ListarInactivos();
            }

            DgLista.DataSource = ListaUsuarios;


        }


        private void CargarListaRoles()
        {
            Logica.Models.Usuario_Rol MiRol = new Logica.Models.Usuario_Rol();

            DataTable dt = new DataTable();

            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember = "Descrip";
                CbRolesUsuario.DataSource = dt;
                CbRolesUsuario.SelectedIndex = -1;
            }
        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando seleccionemos una fila del datagrid se debe cargar la info de dicho usuario
            //en el usuario local y luego dibujar esa info en los controles graficos

            if (DgLista.SelectedRows.Count == 1)
            {
                //TO DO: limpiar el forms

                //De la coleccion de filas seleccionadas, se selecciona la fila en indice 0, la primera
                DataGridViewRow MiFila = DgLista.SelectedRows[0];

                //necesito el valor ID del usuario para realizar la consulta
                //Asi llenar el objeto del usuario local
                int IdUsuario = Convert.ToInt32(MiFila.Cells["CUsuarioID"].Value);

                //no asumir riesgos se reinstancia el usuario local
                MiUsuarioLocal = new Logica.Models.Usuario();

                //le agregamos el valor obtenido por la fila del usuario local
                MiUsuarioLocal.UsuarioId = IdUsuario;

                //una vez que tengo el objeto loca con el id, puedo consultar el usario y llenar los campos
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();

                //validamos que el usuario local tenga datos

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioId > 0)
                {
                    //si carga correctamente, se llenan los controles
                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioId);

                    TxtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;

                    TxtCedula.Text = MiUsuarioLocal.UsuarioCedula;

                    TxtUsuarioTelefono.Text = MiUsuarioLocal.UsuarioTelefono;

                    TxtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;

                    TxtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;

                    //Combox
                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRolId;

                    //TO DO


                }



            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            TxtUsuarioID.Clear();
            TxtUsuarioNombre.Clear();
            TxtCedula.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioCorreo.Clear();
            txtUsuarioContrasennia.Clear();

            CbRolesUsuario.SelectedIndex = -1;

            TxtUsuarioDireccion.Clear();

        }

        private bool ValidarDatosDigitados()
        {
            //Evalua que se haya digitado los campos de texto en el formulario
            bool R = false;

            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) && !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()) && !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(txtUsuarioContrasennia.Text.Trim()) && CbRolesUsuario.SelectedIndex > -1)
            {
                R = true;
            }
            else
            {
                //Que pasa cuando algo falta?
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el usuario", "Eror de validación", MessageBoxButtons.OK);
                    TxtUsuarioNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cédula para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un número de teléfono para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtUsuarioTelefono.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtUsuarioContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una contraseña para el usuario", "Error de validación", MessageBoxButtons.OK);
                    txtUsuarioContrasennia.Focus();
                    return false;
                }

                if (CbRolesUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol para el usuario", "Error de validación", MessageBoxButtons.OK);
                    CbRolesUsuario.Focus();
                    return false;
                }





            }

            return R;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {



                //estas variables almacenan el resultado de las consultas por correo y cedula

                bool CedulaOk;
                bool EmailOk;

                //Paso 1.1 y 1.2
                MiUsuarioLocal = new Logica.Models.Usuario();



                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.UsuarioContrasennia = txtUsuarioContrasennia.Text.Trim();
                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();
                //composicion del rol
                MiUsuarioLocal.MiRolTipo.UsuarioRolId = Convert.ToInt32(CbRolesUsuario.SelectedValue);

                //Realizar consulta de email y cedula
                //Paso 1.3 y 1.3.6
                CedulaOk = MiUsuarioLocal.ConsultarPorCedula();

                //paso 1.4 y 1.4.6
                EmailOk = MiUsuarioLocal.ConsultarPorEmail();

                //paso 1.5
                if (CedulaOk == false && EmailOk == false)
                {
                    //se puede agregar el usuario ya que no existe un usuario con la cedula y correo ingresado

                    //se le solicita al usuario si desea agregar o no el usuario
                    string msg = string.Format("¿Está seguro que desea agregar al usuario {0}?", MiUsuarioLocal.UsuarioNombre);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Usuario guardado correctamente", ":D", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaDeUsuarios();

                        }
                        else
                        {
                            MessageBox.Show("El Usuario no guardó correctamente", ":(", MessageBoxButtons.OK);
                        }

                    }


                }
                else
                {
                    //indicar al usuario si falla alguna consulta
                    if (CedulaOk)
                    {
                        MessageBox.Show("Ya existe un usuario con la cédula digitada", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }

                    if (EmailOk)
                    {
                        MessageBox.Show("Ya existe un usuario con el correo digitado", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }


                }

            }


        }
    }
}
