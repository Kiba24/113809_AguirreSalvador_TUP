using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana8FRONT.Disenio
{
    public partial class HUB : Form
    {
        public HUB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarCarreras consultar = new ConsultarCarreras();
            consultar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevaCarrera nuevaCar = new NuevaCarrera();
            nuevaCar.ShowDialog();
        }
    }
}
