using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana8dll.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string user { get; set; }
        public string pass { get; set; }    

        public Usuario()
        {
            user = "";
            pass = "";
        }

        public Usuario(int id, string user, string pass)
        {
            this.Id = id;
            this.user = user;
            this.pass = pass;   
        }
    }
}
