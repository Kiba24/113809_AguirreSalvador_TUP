using System.Data;
using Semana8dll.Dominio;
using Semana8dll.Servicios;
using Semana8dll.Servicios.Interfaces;
using Semana8dll.Servicios.Implementaciones;
using Semana8FRONT.Client;
using Newtonsoft.Json;

namespace Semana8FRONT.Disenio
{
    public partial class ConsultarCarreras : Form
    {
        List<DetalleCarrera> ldetallesActivos = new List<DetalleCarrera>();
        List<DetalleCarrera> ldetallesInactivos = new List<DetalleCarrera>();

        private ICarreraService carreraService;
        int pointer;
        bool finishedFirst;

        public ConsultarCarreras()
        {
            InitializeComponent();
            carreraService = new CarreraService();
        }

        private async void ConsultarCarreras_Load(object sender, EventArgs e)
        {
            finishedFirst = false;
            //CargarCombo();
            await cargarComboAsync();
            //CargarLista();
            await CargarListaAsync();
            //CbCarreras.selected;
            pointer = 0;     
            CbCarreras.SelectedIndex = 0;
        }

        public async Task CargarListaAsync()
        {
            string url = "https://localhost:7286/detalles?id=" + CbCarreras.SelectedValue.ToString() ;
            var data = await ClienteSingleton.GetInstancia().getDetallesAsync(url);
            List<DetalleCarrera> list = JsonConvert.DeserializeObject<List<DetalleCarrera>>(data);

            DataGridCarreras.Rows.Clear();
            foreach (DetalleCarrera det in list)
            {
                if (det.estado == "A")
                {
                    DataGridCarreras.Rows.Add(det.id, det.aniocursado.ToString(), det.cuatrimestre, det.asignatura.nombre.ToString());
                }
                
            }
            finishedFirst = true;

        }
        
        public async Task cargarComboAsync()
        {
            string url = "https://localhost:7286/carreras";
            var data = await ClienteSingleton.GetInstancia().GetCarrerasAsync(url);
            List<Carrera> list = JsonConvert.DeserializeObject<List<Carrera>>(data);

            CbCarreras.DataSource = list;
            CbCarreras.ValueMember = "id";
            CbCarreras.DisplayMember = "Nombre";
        }

        #region misMetodos


        private void CargarLista()
        {
            ldetallesInactivos.Clear();
            ldetallesActivos.Clear();
            DataGridCarreras.Rows.Clear();

            //oDA.ReadDB("msp_consultarDetalles", CbCarreras.SelectedIndex,"@id_carrera");
            
            DataTable tabla = carreraService.Detalles((int)CbCarreras.SelectedValue);
 
            //Cargo la tabla
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Asignatura a = new Asignatura();
                DetalleCarrera d = new DetalleCarrera();

                d.id = Convert.ToInt32(tabla.Rows[i][0]);
                d.aniocursado = Convert.ToInt32(tabla.Rows[i][1]);
                d.cuatrimestre = Convert.ToInt32(tabla.Rows[i][2]);
                a.nombre = tabla.Rows[i][3].ToString();
                d.asignatura = a;
                d.estado = tabla.Rows[i][4].ToString();


                if (d.estado == "A")
                {
                    ldetallesActivos.Add(d);
                }

                else
                {
                    ldetallesInactivos.Add(d);
                }
            }

            


            if (!ChckDeshabilitadas.Checked)
            {
                DataGridCarreras.Columns[4].Visible = true;
                for (int i = 0; i < ldetallesActivos.Count; i++)
                {
                    //lstCarreras.Items.Add(lcarreras[i].mostrarCarrera());
                    DataGridCarreras.ForeColor = Color.Black;
                    DataGridCarreras.Rows.Add(ldetallesActivos[i].id, ldetallesActivos[i].aniocursado, ldetallesActivos[i].cuatrimestre,
                           ldetallesActivos[i].asignatura.nombre);
                }

            }
            else
            {
                DataGridCarreras.Columns[4].Visible = false;

                for (int b = 0; b < ldetallesInactivos.Count; b++)
                {
                    DataGridCarreras.ForeColor = Color.Gray;
                    DataGridCarreras.Rows.Add(ldetallesInactivos[b].id, ldetallesInactivos[b].aniocursado, ldetallesInactivos[b].cuatrimestre,
                           ldetallesInactivos[b].asignatura.nombre);
                }
            }            
            pointer = 0;
            finishedFirst = true;
        }



        #endregion


        #region botones

        private async void CbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (finishedFirst == true)
            {
                await CargarListaAsync();
            }
        }


        private async void DataGridCarreras_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridCarreras.CurrentCell.ColumnIndex == 4)
            {
                int idIndex = Convert.ToInt32(DataGridCarreras.CurrentRow.Cells[0].Value);
                carreraService.BajaLogica("bajaMateria", idIndex);
                DataGridCarreras.Rows.Remove(DataGridCarreras.CurrentRow);
                MessageBox.Show(idIndex.ToString());
                MessageBox.Show("Baja dada con exito");
                await CargarListaAsync();
            }
        }

        private void ChckDeshabilitadas_CheckedChanged_1(object sender, EventArgs e)
        {
            DataGridCarreras.Rows.Clear();
            CargarListaAsync();
        }

 
        

        private async void BtnMostrar_Click(object sender, EventArgs e)
        {
            pointer = 1;
            CargarListaAsync();
        }

        private async void BtnMostrarTodo_Click(object sender, EventArgs e)
        {
            pointer = 0;
            await CargarListaAsync();
        }

        private void lblCarreras_Click(object sender, EventArgs e)
        {
            
        }




        #endregion

 
    }
}
