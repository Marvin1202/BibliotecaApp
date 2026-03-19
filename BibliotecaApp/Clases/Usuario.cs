using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Clases
{
    public class Usuario : Persona
    {
    
        public string Email { get; set; }

        public Usuario(int id, string nombre, string email)
            : base(id, nombre)
        {
           
            Email = email;
        }
    }
}
