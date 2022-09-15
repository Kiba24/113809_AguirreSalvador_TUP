using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio1._1U2.AccesoDatos;
using Ejercicio1._1U2.Servicios.Interfaces;
using Ejercicio1._1U2.Servicios;

namespace Ejercicio1._1U2.Disenio
{
    public partial class NuevaCarrera : Form
    {
        DataAccess oDA = new DataAccess();
        HelperSingleton gestorDAO = HelperSingleton.obtenerInstancia();
        Carrera carrera;
        List<Dominio.Parametro> lparametros = new List<Dominio.Parametro>();
        List<DetalleCarrera> ldetalles = new List<DetalleCarrera>();

        private IService _service;

        public NuevaCarrera()
        {
            InitializeComponent();
            CargarCombo();

            carrera = new Carrera();
            _service = new ServiceFactoryImp().CrearService();

        }

        private void NuevaCarrera_Load(object sender, EventArgs e)
        {

        }

        private void lblCarreras_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarCombo()
        {
            DataTable dt = gestorDAO.consultarDB("msp_consultarAsignaturas");
            cbMaterias.DataSource = dt;
            cbMaterias.ValueMember = dt.Columns[0].ColumnName;
            cbMaterias.DisplayMember = dt.Columns[1].ColumnName;
        }



        #region botones

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregarDetalle_Click(object sender, EventArgs e)
        {
            Asignatura a = new Asignatura();
            a.id_asignatura = Convert.ToInt32(cbMaterias.SelectedValue);
            a.nombre = cbMaterias.Text;
            int cuatri = 0;
            if (RbtSemestre1.Checked) cuatri = 1;
            if (RbtSemestre2.Checked) cuatri = 2;

            DetalleCarrera dt = new DetalleCarrera();
            dt.estado = "A";
            dt.asignatura = a;
            dt.cuatrimestre = cuatri;
            dt.aniocursado = Convert.ToInt32( TxtAnioCursa.Text);

            carrera.AgregarDetalle(dt);
            ldetalles.Add(dt);

            CargarLista(ldetalles);
        }

        private void BtnAgregarCarrera_Click(object sender, EventArgs e)
        {
            carrera.nombre = TxtNombreCarrera.Text;
            if (gestorDAO.NuevaCarrera(carrera))
            {
                MessageBox.Show("CARRERA AGREGADA CON EXITO!", "EXITO");
            }
            else MessageBox.Show("No se puedo agregar la carrera!", "Error");

        }

        #endregion


        private void CargarLista(List<DetalleCarrera> ldetallesMostrar)
        {
            DataGridDetalles.Rows.Clear();
                
            for (int i = 0; i < ldetalles.Count; i++)
            {
                DataGridDetalles.Rows.Add(ldetallesMostrar[i].id, ldetallesMostrar[i].aniocursado, ldetallesMostrar[i].cuatrimestre,
                           ldetallesMostrar[i].asignatura.nombre);
            }

        }

        private void Separator_Click(object sender, EventArgs e)
        {

        }
    }
}
