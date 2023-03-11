using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario_Rol
    {
		public int UsuarioRolId { get; set; }

		//private int usuarioRolID;
		//public int UsuarioRolID
		//{
		//	get { return usuarioRolID; }
		//	set { usuarioRolID = value; }
		//}

		public string UsuarioRolDescripcion { get;set; }

		public DataTable Listar(){
			
			DataTable R = new DataTable();
			
			Services.Conexion MiCnn = new Services.Conexion();

			R = MiCnn.EjecutarSELECT("SPUsuarioRolListar");

			return R;
		}







	}
}
