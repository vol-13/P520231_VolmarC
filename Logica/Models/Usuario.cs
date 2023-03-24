using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Logica.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string UsuarioCorreo { get; set; }

        public string UsuarioContrasennia { get;set; }

        public string UsuarioNombre { get; set; }

        public string UsuarioCedula { get; set; }

        public string UsuarioTelefono { get; set; }

        public string UsuarioDireccion { get; set; }

        public bool Activo { get; set; }

        //propiedad conmpuesta

       public Usuario_Rol MiRolTipo { get; set; }

        public Usuario()
        {
            MiRolTipo= new Usuario_Rol();
        }

        //Funcion y metodo

        public bool Agregar()
        {
            bool R = false;
            //código de procedimiento almacenado, DML INSERT
            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public Usuario ConsultarPorIDRetornaUsuario()
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId) );

            //datatable para capturar info del usuario
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if ( dt != null && dt.Rows.Count > 0)
            {
                //Esta consulta debe tener un registro y se crea un objeto para obtener la info
                //contenida en index 0 del dt 
                DataRow dr = dt.Rows[0];

                R.UsuarioId = Convert.ToInt32(dr["UsuarioID"]);
                R.UsuarioNombre = Convert.ToString(dr["UsuarioNombre"]);
                R.UsuarioCedula = Convert.ToString(dr["UsuarioCedula"]);
                R.UsuarioTelefono = Convert.ToString(dr["UsuarioTelefono"]);
                R.UsuarioDireccion = Convert.ToString(dr["UsuarioDireccion"]);

                R.UsuarioContrasennia = string.Empty;

                //composiciones
                R.MiRolTipo.UsuarioRolId = Convert.ToInt32(dr["UsuarioRolID"]);
                R.MiRolTipo.UsuarioRolDescripcion = Convert.ToString(dr["UsuarioRolDescripcion]);

            }

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            //en este caso el SP tiene un parametro, hay que definirlo 
            //en la lista de parametros del objeto de conexion
            MiCnn.ListaDeParametros.Add(new SqlParameter("@veractivos", true));

            R = MiCnn.EjecutarSELECT("SPUsuariosListar");

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();



            return R;
        }

        public Usuario ValidarUsuario(string pEmail, string pcontrasennia)
        {
            Usuario R= new Usuario();



            return R;
        }



    }




}

