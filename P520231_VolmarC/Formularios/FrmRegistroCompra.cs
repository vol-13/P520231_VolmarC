using Logica.Models;
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
    public partial class FrmRegistroCompra : Form
    {
 

        //crear el objeto de compra local
     public Compra MiCompraLocal { get; set; }

     public DataTable ListaProductos { get; set; }
        
        public FrmRegistroCompra()
        {
            InitializeComponent();
            MiCompraLocal = new Compra();
            ListaProductos = new DataTable();

        }



        private void FrmRegistroCompra_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

            CargartiposDeCompra ();

            LimpiarForm();
            
        }

        private void CargartiposDeCompra()
        {
            DataTable dtTiposCompra = new DataTable();

            dtTiposCompra = MiCompraLocal.MiTipoCompra.Listar();

            CboxCompraTipo.ValueMember = "id";
            CboxCompraTipo.DisplayMember = "descripcion";

            CboxCompraTipo.DataSource = dtTiposCompra;

            CboxCompraTipo.SelectedIndex = -1;

        }

        private void LimpiarForm()
        {
            TxtProveedorNombre.Clear();
            TxtNotas.Clear();
            TxtTotal.Text = "0";
            TxtTotalCantidad.Text = "0";
            CboxCompraTipo.SelectedIndex = -1;

            //se debe cargar un esquema en el datatable del detalle (ListaProductos)_
            //Esto es importante para saber como se llaman los campos, que tipos de datos tienen
            //y que pueda servir de datasource del DgvLista, sin que elimine las columnas hechas en
            //tiempo de diseño


            ListaProductos = MiCompraLocal.CargarEsquemaDetalle();

            DgvLista.DataSource = ListaProductos;

        }

        private void BtnProveedorBuscar_Click(object sender, EventArgs e)
        {
            //No es necesario definirlo en los globales

            Form FormBusquedaProveedor = new FrmProveedorBuscar();

            DialogResult respuesta = FormBusquedaProveedor.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                //usamos las composiciones proveedor para extraer el valor nombre del proveedor
                TxtProveedorNombre.Text = MiCompraLocal.MiProveedor.ProveedorNombre;
               
            }



        }

        private void BtnProductoAgregar_Click(object sender, EventArgs e)
        {
            Form MiFormBusquedaItem = new FrmCompraAgregarProducto();

            DialogResult respuesta = MiFormBusquedaItem.ShowDialog();

            if (respuesta ==  DialogResult.OK)
            {
                DgvLista.DataSource = ListaProductos;

                Totalizar();
            }
        }

        private void Totalizar()
        {
            //Se usa para mostrar los totales en la parte inferior del form
            if (ListaProductos.Rows.Count > 0)
            {
                //se recorre la lista de filas del datatable del detalle y se realiza
                //las operaciones matemáticas para sumarizar
                decimal totalItems = 0;
                decimal totalMonto = 0;

                foreach (DataRow row in ListaProductos.Rows)
                {
                    totalItems += Convert.ToDecimal(row["Cantidad"]);

                    totalMonto += Convert.ToDecimal(row["PrecioVentaUnitario"]) * Convert.ToDecimal(row["Cantidad"]);

                }

                TxtTotalCantidad.Text = totalItems.ToString();

                //este formato sirve para representar un valor monetario {0:N2}
                TxtTotal.Text = string.Format("{0:C2}", totalMonto);


            }

        }

        private void BtnCrearCompra_Click(object sender, EventArgs e)
        {
            //Primero validar que se haya seleccionado un proveedor, un tipo de compra
            //que haya como minimo una linea en el detalle
            if (ValidarCompra())
            {
                //Los pasos para agregar un encabezado-detalle son
                //1. Realizar insert en el encabezado y recolectar el ID recién creado
                //Ese ID se genera a nivel de base de datos
                //2. Con ese ID + el ID del producto tenemos las dos FK para hacer el insert en la tabla de detalle

                //se agregan los datos de encabezado que hacen falta (proveedor ya estaba listo)

                MiCompraLocal.MiTipoCompra.CompraTipoID = Convert.ToInt32(CboxCompraTipo.SelectedValue);
                MiCompraLocal.CompraNotas = TxtNotas.Text.Trim();
                //como ingreso de manera rapida no tengo datos por lo que el ID será "quemado"
                MiCompraLocal.MiUsuario.UsuarioId = 4;

                TrasladoDetalleListaVisualAObjetoCompra();

                //a este punto tenemos armado completamente el objeto de compra local
                //se puede proceder a agregar
                if (MiCompraLocal.Agregar())
                {
                    MessageBox.Show("Compra creada correctamente", ":D", MessageBoxButtons.OK);

                    //crear un reporte de la compra
                    LimpiarForm();
                }



            }


        }

        private void TrasladoDetalleListaVisualAObjetoCompra()
        {
            //pasamos los datos del datatable que se usa graficamente a la List<> de la composición del objeto
            //MiCompraLocal
            foreach (DataRow fila in ListaProductos.Rows)
            {
                CompraDetalle nuevodetalle = new CompraDetalle();

                nuevodetalle.MiProducto.ProductoID = Convert.ToInt32(fila["ProductoID"]);
                nuevodetalle.Cantidad = Convert.ToDecimal(fila["Cantidad"]);
                nuevodetalle.PrecioUnitario = Convert.ToDecimal(fila["PrecioVentaUnitario"]);

                //una vez que tenemos los datos en el nuevodetalle se agrega ese objeto a la lista
                //de detalles de la compra local
                MiCompraLocal.ListaDetalles.Add(nuevodetalle);
            }
        }

        private bool ValidarCompra()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()) && CboxCompraTipo.SelectedIndex >= 0
                && ListaProductos.Rows.Count > 0)
            {
                R = true;

            }
            else
            {
                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe seleccionar un proveedor", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxCompraTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar un tipo de compra", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (ListaProductos.Rows.Count == 0)
                {
                    MessageBox.Show("Debe existir al menos una fila en el detalle", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;
        }

    }
}
