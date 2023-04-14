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

            ActivarAgregar();
        }

        private void CargarListaDeUsuarios()
        {

            //resetear la lista de usuarios haciendo reintstancia del objeto
            ListaUsuarios = new DataTable();

            //si en el cuadro de texto de búsqueda hay más de 3 caracteres se filtra la lista
            string filtroBusqueda = "";
            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim()) && txtBuscar.Text.Count() >= 3)
            {

                filtroBusqueda = txtBuscar.Text.Trim();

            }


            if (CboxVerActivos.Checked)
            { 
                ListaUsuarios = MiUsuarioLocal.ListarActivos(filtroBusqueda);
            }
            else
            {
                ListaUsuarios = MiUsuarioLocal.ListarInactivos(filtroBusqueda);
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
                LimpiarFormulario();

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

                    ActivarEditarEliminar();

                }

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            DgLista.ClearSelection();

            ActivarAgregar();
        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnEliminar.Enabled = true;
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

        private bool ValidarDatosDigitados(bool OmitirPassword = false)
        {
            //Evalua que se haya digitado los campos de texto en el formulario
            bool R = false;

            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                
                CbRolesUsuario.SelectedIndex > -1)
            {

                if (OmitirPassword)
                {
                    //(Editar)si el password se omite entonces ya pasó la evaluacion a este punto, retorna true
                    R = true;
                }
                else 
                {
                    //(Para agregar)en caso de haya que evaluar la contraseña se debe agregar otra condicion
                    if (!string.IsNullOrEmpty(txtUsuarioContrasennia.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        //en caso en el que haga falta la contraseña
                        MessageBox.Show("Debe digitar una contraseña para el usuario", "Error de validación", MessageBoxButtons.OK);
                        txtUsuarioContrasennia.Focus();
                        return false;
                    }
                }

                
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(ValidarDatosDigitados(true))
            {
                //No es necesario capturar el ID desde el cuadro de texto, ya que al consultarlo (cuando seleccionamos
                //el usuario del datagrid, ya tenemos datos en el id) Este ID no puede ser modificado
                // los demas atributos sí
                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();

                //como el cuadro de texto de la contraseña tiene un caracter en blanco
                //puedo asignar sin problema el valor del cuadro de texto al atributo, en el SP se evalua
                //si tiene o no datos
                MiUsuarioLocal.UsuarioContrasennia = txtUsuarioContrasennia.Text.Trim();
                MiUsuarioLocal.MiRolTipo.UsuarioRolId = Convert.ToInt32(CbRolesUsuario.SelectedValue);
                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                //Segun el diagrama de casos de uso expandido y secuencia normal para un CRUD (editar)
                //es habitual consultar por el ID el item que se va modificar para asegurarse que
                //el laspo entre lo que se seleccionó el usuario y se modificaron los datos en patalla
                //aun exista el registro en la base de datos. (existe una posibilidad de que ya no exista debido a que
                //en entornos donde hayan muchos usuarios trabanjando en el sistema algun otro este modificando el mismo
                //registro, esto se llama concurrencia)

                if (MiUsuarioLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea modificar el usuario?", "???",
                                                                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                    if(respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Editar())
                        {
                            MessageBox.Show("El usuario ha sido modificado correctamente", ":D", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeUsuarios();
                        }


                    }



                }

            }



        }

        private void TxtUsuarioCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(MiUsuarioLocal.UsuarioId > 0 && MiUsuarioLocal.ConsultarPorID())
            {

                //tomando en cuenta que puedo estar viendo los usuarios activos o inactivos este botón podría servir
                //para activar o desactivar los usuarios
                //El check box de la parte superior del form me sirve para identificar esta acción

                if (CboxVerActivos.Checked)
                {
                    //Desactivar usuario
                    DialogResult r = MessageBox.Show("¿Está seguro que desea eliminar el usuario?","???",MessageBoxButtons.YesNo
                        ,MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Eliminar())
                        {
                            MessageBox.Show("El usuario ha sido eliminado satisfactoriamente", ":D", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeUsuarios();
                        }

                    }

                }
                else
                {
                    //Activar usuario tarea
                    DialogResult r = MessageBox.Show("¿Está seguro que desea activar el usuario?", "???", MessageBoxButtons.YesNo
                     , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Activar())
                        {
                            MessageBox.Show("El usuario ha sido activado satisfactoriamente", ":D", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeUsuarios();
                        }

                    }

                }



            }


        }

        private void TxtUsuarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void TxtUsuarioTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void txtUsuarioContrasennia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtUsuarioCorreo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
            {
                if (!Validaciones.ValidarEmail(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("El formato del correo electrónico es incorrecto", "Error de la validación", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                }
            }
        }

        private void TxtUsuarioCorreo_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
            {
                TxtUsuarioCorreo.SelectAll();
            }
        }

        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDeUsuarios();

            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "ELIMINAR";
            }
            else
            {
                BtnEliminar.Text = "ACTIVAR";
            } 

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            CargarListaDeUsuarios();

        }
    }
}
