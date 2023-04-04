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
            
            //paso 1.6.1 y 1.6.2
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo",this.UsuarioCorreo));

            //EncriptarContraseña
            Crytpo Micrytpo = new Crytpo();
            string ContrasenniaEncriptada = Micrytpo.EncriptarEnUnSentido(this.UsuarioContrasennia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.UsuarioNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.UsuarioTelefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.UsuarioDireccion));

            //normalmente los foreing key tiene composiciones
            //se debe extraer el valor del objeto compuesto MiRolTipo
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.UsuarioRolId));

            //pasos 1.6.3 y 1.6.4
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioAgregar");

            //Paso 1.6.5
            if(resultado > 0) 
            {
                R = true;
            }

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));
            //EncriptarContraseña
            Crytpo Micrytpo = new Crytpo();
            string ContrasenniaEncriptada = Micrytpo.EncriptarEnUnSentido(this.UsuarioContrasennia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.UsuarioNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.UsuarioTelefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.UsuarioDireccion));

            //normalmente los foreing key tiene composiciones
            //se debe extraer el valor del objeto compuesto MiRolTipo
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.UsuarioRolId));
        
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));

            //pasos 1.6.3 y 1.6.4
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioModificar");

            //Paso 1.6.5
            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioDesactivar");

            if(respuesta > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioActivar");

            if (respuesta > 0)
            {
                R = true;
            }

            return R;
        }

        

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));

            //datatable para capturar info del usuario
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;

            }

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
                R.UsuarioCorreo = Convert.ToString(dr["UsuarioCorreo"]);
                R.UsuarioTelefono = Convert.ToString(dr["UsuarioTelefono"]);
                R.UsuarioDireccion = Convert.ToString(dr["UsuarioDireccion"]);

                R.UsuarioContrasennia = string.Empty;

                //composiciones
                R.MiRolTipo.UsuarioRolId = Convert.ToInt32(dr["UsuarioRolID"]);
                R.MiRolTipo.UsuarioRolDescripcion = Convert.ToString(dr["UsuarioRolDescripcion"]);

            }

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            //paso 1.3.1 y 1.3.2
            Conexion MiCnn = new Conexion();

            //parametros
            MiCnn.ListaDeParametros.Add(new SqlParameter("@cedula", this.UsuarioCedula));

           DataTable consulta = new DataTable();
            //Paso 1.3.3 y 1.3.4
            consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorCedula");

            //Paso 1.3.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            //Paso 1.4.1 y 1.4.2
            Conexion MiCnn = new Conexion();

            //parametros
            MiCnn.ListaDeParametros.Add(new SqlParameter("@correo", this.UsuarioCorreo));

            DataTable consulta = new DataTable();
            //Paso 1.4.3 y 1.4.4
            consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorEmail");

            //Paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            //en este caso el SP tiene un parametro, hay que definirlo 
            //en la lista de parametros del objeto de conexion
            MiCnn.ListaDeParametros.Add(new SqlParameter("@verActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@filtroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPUsuariosListar");

            return R;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            //en este caso el SP tiene un parametro, hay que definirlo 
            //en la lista de parametros del objeto de conexion
            MiCnn.ListaDeParametros.Add(new SqlParameter("@verActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@filtroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPUsuariosListar");


            return R;
        }

        public Usuario ValidarUsuario(string pEmail, string pcontrasennia)
        {
            Usuario R= new Usuario();



            return R;
        }



    }




}

