using System.Windows.Forms;

namespace P520231_VolmarC
{
    public static class Globales
    {
        //Estas propiedades al pertenecer a una clase static se auto instancian
        //Y se puede obtener acceso a ellas en la globalidad de la aplicación.
        public static Form MiFormPrincipal = new Formularios.FrmMDI();
    }
}
