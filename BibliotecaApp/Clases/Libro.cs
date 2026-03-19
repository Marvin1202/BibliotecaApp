using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaApp.Clases
{
    public class Libro
    {
        public int Id {  get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public int Anio { get; set; }
        public bool Disponible { get; set; }

        public Libro(int id, string titulo, string autor, int anio)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Disponible = true; // esto me ayuda que al crearlo aparezca como disponible
            Anio = anio;    
        }

    }
}
