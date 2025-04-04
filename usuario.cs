using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loggin
{
    internal class usuario
    {
        private static List<usuario> usuarios = new List<usuario> 
        { 
        new usuario{NameUsuario = "Admin", Contraseña = "1111"},
        new usuario{NameUsuario = "Moderador", Contraseña = "2222"},
        new usuario{NameUsuario = "Junior", Contraseña = "3333"}
        };

        public usuario() { }

        public List<usuario> ObtenerUsuario()
        { 
            return usuarios; 
        }

        public string NameUsuario { get; set; }
        public string Contraseña { get; set;}
        
    }
}
