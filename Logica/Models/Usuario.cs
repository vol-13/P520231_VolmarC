using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        Usuario_Rol MiRolTipo { get; set; }

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

            return R;
        }

        public Usuario ValidarUsuario(string pEmail, string pcontrasennia)
        {
            Usuario R= new Usuario();



            return R;
        }



    }




}

