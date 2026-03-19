using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaApp.Clases;

namespace BibliotecaApp.Datos
{
    public class Biblioteca
    {
        public List<Libro> Libros { get; set; } = new List<Libro>();
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        // Metodos Libros

        public void AgregarLibro(Libro libro) => Libros.Add(libro);
        public void EliminarLibro(Libro libro) => Libros.Remove(libro);
        public void ActualizarLibro(int index, Libro libroActualizado)
        {
            Libros[index] = libroActualizado;
        }


        // Métodos Usuarios
        public void AgregarUsuario(Usuario usuario) => Usuarios.Add(usuario);
        public void EliminarUsuario(Usuario usuario) => Usuarios.Remove(usuario);
        public void ActualizarUsuario(int index, Usuario usuarioActualizado)
        {
            Usuarios[index] = usuarioActualizado;
        }

        // Métodos Préstamos
        public void RegistrarPrestamo(Prestamo prestamo) => Prestamos.Add(prestamo);
        public void DevolverPrestamo(int index)
        {
            Prestamos[index].Devuelto = true;
            Prestamos[index].Libro.Disponible = true;
        }

    }
}
