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
        public FrmUsuariosGestion()
        {
            InitializeComponent();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //definimos el padre mdi
            MdiParent = Globales.MiFormPrincipal;

            CargarListaRoles();
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


    }
}
