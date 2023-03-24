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

            if(CboxVerActivos.Checked)
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

            if (dt != null && dt.Rows.Count > 0 )
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember= "Descrip";
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

            if(DgLista.SelectedRows.Count == 1)
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

                if(MiUsuarioLocal != null && MiUsuarioLocal.UsuarioId > 0) 
                {
                    //si carga correctamente, se llenan los controles
                    TxtUsuarioID.Text = Convert.ToString (MiUsuarioLocal.UsuarioId);

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
    }
}
