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
    public partial class FrmReporteAgrupado : Form
    {

        DataAccess oDA = new DataAccess();
        AccesoDatos.HelperSingleton gestorDAO = AccesoDatos.HelperSingleton.obtenerInstancia();
        public FrmReporteAgrupado()
        {
            InitializeComponent();
        }

        private void FrmReporteAgrupado_Load(object sender, EventArgs e)
        {
            
            CargarReporte();

 
            this.reportViewer1.RefreshReport();
        }

        private void CargarReporte()
        {
            DataTable tabla = gestorDAO.consultarDB("msp_AsignaturasCuenta");
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSAgrupado", tabla));
            this.reportViewer1.RefreshReport();
        }
    }
}
