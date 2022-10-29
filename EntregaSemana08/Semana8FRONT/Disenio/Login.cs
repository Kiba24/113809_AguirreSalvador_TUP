using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Semana8dll.Dominio;
using Semana8FRONT.Client;

namespace Semana8FRONT.Disenio
{
    public partial class Login : Form
    {
        Usuario logUser;
        public Login()
        {
            InitializeComponent();
            logUser = new Usuario();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            logUser.pass = txtContrasena.Text;
            logUser.user = txtUsuario.Text;
            if (await getUsuariosAsync())
            {

                HUB hub = new HUB();
                this.Hide();
                hub.Show();
            }
            else MessageBox.Show("Error, Usuario Incorrecto", "ERROR!");
        }

        public async Task<bool> getUsuariosAsync()
        {
            string url = "https://localhost:7286/users";
            string? data = await ClienteSingleton.GetInstancia().getDetallesAsync(url);
            List<Usuario> listU = JsonConvert.DeserializeObject<List<Usuario>>(data);

            foreach (Usuario dr in listU)
            {
                if (dr.pass == logUser.pass && dr.user == logUser.user)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
