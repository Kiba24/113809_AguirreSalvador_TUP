using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecetasSLN.Servicios.Implementaciones;
using RecetasSLN.datos;
using RecetasSLN.dominio;

namespace RecetasSLN.presentación
{
    public partial class FrmAltaRecetas : Form
    {
        int contadorDetalles = 0;
        RecetaServiceIMP servicioReceta = new RecetaServiceIMP();
        Receta r;

        public FrmAltaRecetas()
        {
            InitializeComponent();
            //r.ldetalles.Clear();
        }

        private void FrmAltaRecetas_Load(object sender, EventArgs e)
        {
            contadorDetalles = 0;
            lblReceta.Text = servicioReceta.ProximaReceta().ToString();
            CargarCombo();
            r = new Receta();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (ValidarDetalle())
            {
                 
            DetalleReceta detalle = new DetalleReceta();
            Ingrediente ingred = new Ingrediente();
            detalle.cantidad = Convert.ToInt32(NumCantidad.Value);
            ingred.id = Convert.ToInt32(CbIngrediente.SelectedValue);
            ingred.nombre = CbIngrediente.Text;
            detalle.ingrediente = ingred;

            r.AgregarDetalle(detalle);
            contadorDetalles += Convert.ToInt32(NumCantidad.Value);
            lblTotalIng.Text=contadorDetalles.ToString();
            CargarLista();
            }
           

        }


        #region MetodosPropios

        private void CargarCombo()
        {
            DataTable tabla = helperDAO.ObtenerInstancia().consultaSQL("SP_CONSULTAR_INGREDIENTES");
            CbIngrediente.DataSource = tabla;
            CbIngrediente.DisplayMember = tabla.Columns[1].ColumnName;
            CbIngrediente.ValueMember = tabla.Columns[0].ColumnName;

            DataTable tabla2 = helperDAO.ObtenerInstancia().consultaSQL("SP_CONSULTAR_TIPOS");
            cbReceta.DataSource = tabla2;
            cbReceta.DisplayMember = tabla2.Columns[1].ColumnName;
            cbReceta.ValueMember = tabla2.Columns[0].ColumnName;
        }

        private void CargarLista()
        {
            dgvIngredientes.Rows.Clear();

            for (int i = 0; i < r.ldetalles.Count; i++)
            {
                dgvIngredientes.Rows.Add( r.ldetalles[i].ingrediente.nombre, r.ldetalles[i].cantidad);
            }
        }

        private bool ValidarDetalle()
        {
            bool result = true;

            if (Convert.ToInt32(NumCantidad.Value) < 1)
            {
                result = false;
                MessageBox.Show("ERROR! Debe ingresar una cantidad mayor a 0","ERROR"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            if (CbIngrediente.SelectedIndex < 0)
            {
                result = false;
                MessageBox.Show("ERROR", "ERROR! Debe seleccionar un ingrediente");

            }

            return result;
        }


        private bool ValidarReceta()
        {
            bool result = true;
            if (contadorDetalles < 3)
            {
                result = false;
                MessageBox.Show("ERROR! Se ha olvidado de algun ingrediente?", "ERROR"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtChef.Text == String.Empty)
            {
                result = false;
                MessageBox.Show("ERROR! Debe ingresar un CHEF", "ERROR"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtNombre.Text == String.Empty)
            {
                result = false;
                MessageBox.Show("ERROR! Debe ingresar un NOMBRE", "ERROR"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            return result;
        }
        #endregion

        private void LimpiarCampos()
        {
            txtChef.Text = "";
            txtNombre.Text = "";
            cbReceta.SelectedIndex = 0;
            CbIngrediente.SelectedIndex = 0;
            NumCantidad.Value = 0;
            dgvIngredientes.Rows.Clear();
            lblReceta.Text = servicioReceta.ProximaReceta().ToString();
            contadorDetalles = 0;
            lblTotalIng.Text = contadorDetalles.ToString();
            txtNombre.Focus();
            
        }

        private void NumCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Salir"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarReceta())
            {
                
                r.nombre = txtNombre.Text;
                r.Chef = txtChef.Text;
                r.TipoReceta = Convert.ToInt32(cbReceta.SelectedValue);

                servicioReceta.NuevaReceta(r);

                MessageBox.Show("Receta Agregada Correctamente", "ENHORABUENA"
                   , MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void lblReceta_Click(object sender, EventArgs e)
        {

        }

        private void CbIngrediente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
