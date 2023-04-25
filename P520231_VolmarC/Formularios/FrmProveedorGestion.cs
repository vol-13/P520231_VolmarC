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
    public partial class FrmProveedorGestion : Form
    {

        private Logica.Models.Proveedor MiProveedorLocal { get; set; }

        private DataTable ListaProveedores { get; set; }    
        public FrmProveedorGestion()
        {
            InitializeComponent();
            MiProveedorLocal = new Logica.Models.Proveedor();
            ListaProveedores = new DataTable();
        }

      

        private void FrmProveedorGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

            CargarListaTiposProveedores();

            CargarListaDeProveedores();
        }

         private void CargarListaDeProveedores()
         {

             ListaProveedores = new DataTable();


             ListaProveedores = MiProveedorLocal.Listar();

             DgvListaProveedor.DataSource = ListaProveedores;

         }

        private void CargarListaTiposProveedores()
        {
            Logica.Models.TipoProveedor MiRol = new Logica.Models.TipoProveedor();

            DataTable dt = new DataTable();

            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbTipoProveedor.ValueMember = "ID";
                CbTipoProveedor.DisplayMember = "Descrip";
                CbTipoProveedor.DataSource = dt;
                CbTipoProveedor.SelectedIndex = -1;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            DgvListaProveedor.ClearSelection();

            BtnAgregar.Enabled = true;

        }

        private void LimpiarFormulario()
        {
            TxtProveedorCedula.Clear();
            TxtProveedorDireccion.Clear();
            TxtProveedorEmail.Clear();
            TxtProveedorNombre.Clear();
            TxtProveedorNotas.Clear();
            TxtProveedorID.Clear();
         
            CbTipoProveedor.SelectedIndex = -1;


        }

        private void DgvListaProveedor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaProveedor.ClearSelection();
        }

        private void DgvListaProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaProveedor.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                
                DataGridViewRow MiFila = DgvListaProveedor.SelectedRows[0];

                
                int IdProveedor = Convert.ToInt32(MiFila.Cells["CProveedorID"].Value);

                MiProveedorLocal = new Logica.Models.Proveedor();
                
                MiProveedorLocal.ProveedorID = IdProveedor;

                MiProveedorLocal = MiProveedorLocal.ConsultarPorIDRetornaProveedor();

              

                if (MiProveedorLocal != null && MiProveedorLocal.ProveedorID > 0)
                {
                   
                    TxtProveedorID.Text = Convert.ToString(MiProveedorLocal.ProveedorID);

                    TxtProveedorNombre.Text = MiProveedorLocal.ProveedorNombre;

                    TxtProveedorCedula.Text = MiProveedorLocal.ProveedorCedula;

                    TxtProveedorNotas.Text = MiProveedorLocal.ProveedorNotas;

                    TxtProveedorEmail.Text = MiProveedorLocal.ProveedorEmail;

                    TxtProveedorDireccion.Text = MiProveedorLocal.ProveedorDireccion;

                   
                    CbTipoProveedor.SelectedValue = MiProveedorLocal.MiTipoProveedor.ProveedorTipo;

                    BtnAgregar.Enabled = false;

                }

            }
        }

        private bool ValidarDatosDigitados()
        {
            //Evalua que se haya digitado los campos de texto en el formulario
            bool R = true;


                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el proveedor", "Error de validación", MessageBoxButtons.OK);
                    TxtProveedorNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cédula para el proveedor", "Error de validación", MessageBoxButtons.OK);
                    TxtProveedorCedula.Focus();
                    return false;
          
                }

                if (CbTipoProveedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un el tipo de proveedor", "Error de validación", MessageBoxButtons.OK);
                    CbTipoProveedor.Focus();
                    return false;
                }

            return R;

        }

        private void TxtProveedorNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);

        }

        private void TxtProveedorCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);

        }

        private void TxtProveedorEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);

        }

        private void TxtProveedorDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);

        }

        private void TxtProveedorNotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                bool CedulaOk;
                bool Email;

                MiProveedorLocal = new Logica.Models.Proveedor();

                MiProveedorLocal.ProveedorNombre = TxtProveedorNombre.Text.Trim();
                MiProveedorLocal.ProveedorCedula = TxtProveedorCedula.Text.Trim();
                MiProveedorLocal.ProveedorEmail = TxtProveedorEmail.Text.Trim();
                MiProveedorLocal.ProveedorDireccion = TxtProveedorDireccion.Text.Trim();
                MiProveedorLocal.ProveedorNotas = TxtProveedorNotas.Text.Trim();

                MiProveedorLocal.MiTipoProveedor.ProveedorTipo = Convert.ToInt32(CbTipoProveedor.SelectedValue);

                CedulaOk = MiProveedorLocal.ConsultarPorCedula();
                Email = MiProveedorLocal.ConsultarPorEmail();

                if (CedulaOk == false && Email == false)
                {
                    string msg = string.Format("¿Está seguro que desea agregar al proveedor {0}?", MiProveedorLocal.ProveedorNombre);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiProveedorLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Proveedor guardado correctamente", ":D", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaDeProveedores();

                        }
                        else
                        {
                            MessageBox.Show("El Proveedor no guardó correctamente", ":(", MessageBoxButtons.OK);

                        }


                    }
                }
                else
                {
                    if (CedulaOk)
                    {
                        MessageBox.Show("Ya existe un Proveedor con la cédula digitada", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }

                    if (Email)
                    {
                        MessageBox.Show("Ya existe un Proveedor con el correo digitado", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }

                }
            }
        }

        private void TxtProveedorEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtProveedorEmail.Text.Trim()))
            {
                if (!Validaciones.ValidarEmail(TxtProveedorEmail.Text.Trim()))
                {
                    MessageBox.Show("El formato del correo electrónico es incorrecto", "Error de la validación", MessageBoxButtons.OK);
                    TxtProveedorEmail.Focus();
                }
            }
        }

        private void TxtProveedorEmail_Enter(object sender, EventArgs e)
        {
              if (!string.IsNullOrEmpty(TxtProveedorEmail.Text.Trim()))
              {
                    TxtProveedorEmail.SelectAll();
              }
          
        }
    }
}
