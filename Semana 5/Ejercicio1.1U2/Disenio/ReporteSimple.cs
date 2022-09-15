using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1._1U2.Disenio
{
    public partial class ReporteSimple : Form
    {
        public ReporteSimple()
        {
            InitializeComponent();
        }

        private void ReporteSimple_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsListado.DTListado' table. You can move, or remove it, as needed.
            this.dTListadoTableAdapter.Fill(this.dsListado.DTListado);

            this.reportViewer1.RefreshReport();
        }
    }
}
