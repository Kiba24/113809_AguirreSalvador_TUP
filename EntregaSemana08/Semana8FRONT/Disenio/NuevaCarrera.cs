using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semana8dll.AccesoDatos;
using Semana8dll.Dominio;
using Semana8dll.Servicios.Interfaces;
using Semana8dll.Servicios.Implementaciones;
using Semana8FRONT.Client;
using Newtonsoft.Json;

namespace Semana8FRONT.Disenio
{
    public partial class NuevaCarrera : Form
    {
        Carrera carrera;
        List<Parametro> lparametros = new List<Parametro>();
        List<DetalleCarrera> ldetalles = new List<DetalleCarrera>();
        private ICarreraService carreraService;


        public NuevaCarrera()
        {
            InitializeComponent();

            carrera = new Carrera();
            carreraService = new CarreraService();
        }

        private void NuevaCarrera_Load(object sender, EventArgs e)
        {
            CargarComboAsync();

        }

        private void lblCarreras_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void CargarComboAsync()
        {
            string url = "https://localhost:7286/asignaturas";
            var data = await ClienteSingleton.GetInstancia().GetCarrerasAsync(url);
            List<Asignatura> list = JsonConvert.DeserializeObject<List<Asignatura>>(data);

            cbMaterias.DataSource = list;
            cbMaterias.DisplayMember = "nombre";
            cbMaterias.ValueMember = "id_asignatura";
        }

        private async Task<bool> CargarCarreraAsync(Carrera c)
        {
            try
            {
                string url = "https://localhost:7286/carreras";
                string jsonObject = JsonConvert.SerializeObject(c);

                var result = await ClienteSingleton.GetInstancia().PostAsync(url, jsonObject);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
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

        private async void BtnAgregarCarrera_Click(object sender, EventArgs e)
        {
            carrera.nombre = TxtNombreCarrera.Text;
            if (await CargarCarreraAsync(carrera))
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
