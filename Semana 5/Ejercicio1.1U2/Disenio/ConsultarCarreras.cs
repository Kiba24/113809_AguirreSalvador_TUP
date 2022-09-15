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


namespace Ejercicio1._1U2.Disenio
{
    public partial class ConsultarCarreras : Form
    {
        List<DetalleCarrera> ldetallesActivos = new List<DetalleCarrera>();
        List<DetalleCarrera> ldetallesInactivos = new List<DetalleCarrera>();
        DataAccess oDA = new DataAccess();
        HelperSingleton gestorDao = HelperSingleton.obtenerInstancia();
        int pointer;
        bool finishedFirst;

        public ConsultarCarreras()
        {
            InitializeComponent();
        }

        private void ConsultarCarreras_Load(object sender, EventArgs e)
        {
            finishedFirst = false;
            CargarCombo();
            CargarLista();
            //CbCarreras.selected;
            pointer = 0;     
            CbCarreras.SelectedIndex = -1;


        }


        #region misMetodos
        private void CargarLista()
        {
            ldetallesInactivos.Clear();
            ldetallesActivos.Clear();
            DataGridCarreras.Rows.Clear();

            //oDA.ReadDB("msp_consultarDetalles", CbCarreras.SelectedIndex,"@id_carrera");
 
            DataTable tabla = gestorDao.CargarDetalles("msp_consultarDetalles", Convert.ToInt32(CbCarreras.SelectedValue) , "@id_carrera"); 
 
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


        private void CargarCombo()
        {
            DataTable tabla = gestorDao.consultarDB("msp_consultarCarreras");
            CbCarreras.DataSource = tabla;
            CbCarreras.ValueMember = tabla.Columns[0].ColumnName;
            CbCarreras.DisplayMember = tabla.Columns[1].ColumnName;  
        }



        #endregion


        #region botones

        private void CbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (finishedFirst == true)
            {
                CargarLista();
            }
        }


        private void DataGridCarreras_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridCarreras.CurrentCell.ColumnIndex == 4)
            {
                int idIndex = Convert.ToInt32(DataGridCarreras.CurrentRow.Cells[0].Value);
                gestorDao.BajaLogica("bajaMateria", idIndex);
                DataGridCarreras.Rows.Remove(DataGridCarreras.CurrentRow);
                MessageBox.Show(idIndex.ToString());
                MessageBox.Show("Baja dada con exito");
                CargarLista();
            }
        }

        private void ChckDeshabilitadas_CheckedChanged_1(object sender, EventArgs e)
        {
            DataGridCarreras.Rows.Clear();
            CargarLista();
        }

 
        

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            pointer = 1;
            CargarLista();
        }

        private void BtnMostrarTodo_Click(object sender, EventArgs e)
        {
            pointer = 0;
            CargarLista();
        }

        private void lblCarreras_Click(object sender, EventArgs e)
        {
            
        }




        #endregion

 
    }
}
