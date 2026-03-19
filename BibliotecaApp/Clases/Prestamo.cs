using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Clases
{
    public class Prestamo
    {
        public int Id { get; set; }
        public Libro Libro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public bool Devuelto { get; set; }

        public Prestamo(int id, Libro libro, Usuario usuario)
        {
            Id = id;
            Libro = libro;
            Usuario = usuario;
            FechaPrestamo = DateTime.Now;
            Devuelto = false;
        }
    }
}
