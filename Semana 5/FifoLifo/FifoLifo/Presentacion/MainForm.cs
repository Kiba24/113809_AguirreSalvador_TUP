using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FifoLifo.Implementaciones;
using FifoLifo.Interfaces;

namespace FifoLifo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Cola ocola = new Cola();
        Pila opila = new Pila();
        int ultimo;

        private void MainForm_Load(object sender, EventArgs e)
        {
            ultimo = 0;
        }


        // COLA

        private void btnAddCola_Click(object sender, EventArgs e)
        {
            ocola.Añadir(txtAdd.Text, ultimo);
            lstCOLA.Items.Add(txtAdd.Text);
        }

        private void BtnElimCola_Click_1(object sender, EventArgs e)
        {
            ocola.Extraer(ultimo);
            lstCOLA.Items.RemoveAt(ultimo);
        }

        private void BtnElimCola_Click(object sender, EventArgs e)
        {
            
        }

        // PILA
        private void btnAddPila_Click(object sender, EventArgs e)
        {
            opila.Añadir(txtAdd.Text, ultimo);
            ultimo++;
            lstPila.Items.Add(txtAdd.Text);
        }

        private void ElimPila_Click(object sender, EventArgs e)
        {
            opila.Extraer(ultimo);
            lstPila.Items.RemoveAt(ultimo-1);
            ultimo--;
        }


    }
}
