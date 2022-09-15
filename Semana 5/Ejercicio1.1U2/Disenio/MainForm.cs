using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1._1U2
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsListado1.DTListado' table. You can move, or remove it, as needed.
            this.dTListadoTableAdapter.Fill(this.dsListado1.DTListado);
           

           

         
        }

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disenio.NuevaCarrera FormNueva  = new Disenio.NuevaCarrera();
            FormNueva.ShowDialog();
            FormNueva.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void nuevaAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disenio.NuevaAsignatura formAsignatura = new Disenio.NuevaAsignatura();
            formAsignatura.ShowDialog();
            formAsignatura.Dispose();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disenio.ConsultarCarreras cform = new Disenio.ConsultarCarreras();
            cform.ShowDialog();
            cform.Dispose();
        }

 

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Disenio.FrmReporteAgrupado frmReporteAg = new Disenio.FrmReporteAgrupado();
            frmReporteAg.ShowDialog();
            frmReporteAg.Dispose();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Disenio.ReporteSimple frmReportSimple = new Disenio.ReporteSimple();
            frmReportSimple.ShowDialog();
            frmReportSimple.Dispose();

            
        }
    }
}
