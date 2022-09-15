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
using Ejercicio1._1U2.Dominio;
namespace Ejercicio1._1U2.Disenio
{
    public partial class NuevaAsignatura : Form
    {

        DataAccess oDA = new DataAccess();
        HelperSingleton gestorDAO = HelperSingleton.obtenerInstancia();
        List<Dominio.Parametro> lparametros = new List<Dominio.Parametro>();

        public NuevaAsignatura()
        {
            InitializeComponent();
        }

        private void NuevaAsignatura_Load(object sender, EventArgs e)
        {
           
           
        }

        private void BtnAgregarAsign_Click(object sender, EventArgs e)
        {
            
            lparametros.Clear();
            lparametros.Add(new Dominio.Parametro("@nombreAsignatura", TextMateria.Text));
            gestorDAO.AgregarNuevo("msp_nuevaAsignatura", lparametros);
        }
    }
}
