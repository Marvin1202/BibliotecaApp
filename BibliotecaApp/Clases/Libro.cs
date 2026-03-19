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
        public bool Dispoible { get; set; }

        public Libro(int id, string titulo, string autor)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Dispoible = true; // al crearlo nos aparece como disponible 

        }

    }
}
