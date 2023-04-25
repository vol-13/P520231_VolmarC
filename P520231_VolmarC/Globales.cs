using System.Windows.Forms;

namespace P520231_VolmarC
{
    public static class Globales
    {
        //Estas propiedades al pertenecer a una clase static se auto instancian
        //Y se puede obtener acceso a ellas en la globalidad de la aplicación.
        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsario = new Formularios.FrmUsuariosGestion();

        public static Formularios.FrmProveedorGestion MiFormGestionProveedor = new Formularios.FrmProveedorGestion();



        //Debemos tener un obj de tipo usuario que permita almacenar los datos del usario que se haya logeado
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();



        public static Formularios.FrmRegistroCompra MiFormRegistroCompra = new Formularios.FrmRegistroCompra();






    }
}
