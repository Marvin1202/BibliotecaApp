using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaApp.Clases;
using BibliotecaApp.Datos;


namespace BibliotecaApp
{
   
    public partial class Form1 : Form
    {
        // Instancia de la "base de datos"
        Biblioteca biblioteca = new Biblioteca();

        // Contadores para generar IDs únicos
        int contadorLibros = 1;
        int contadorUsuarios = 1;
        int contadorPrestamos = 1;

        public Form1()
        {
            InitializeComponent();   // Para inciar todo lo de la interfaz
            InicializarGrids();      // Para iniciar lo de los dgv
        }

        private void InicializarGrids()
        {
            // Configuración de columnas para dgvLibros
            dgvLibros.Columns.Add("Id", "ID");
            dgvLibros.Columns.Add("Titulo", "Título");
            dgvLibros.Columns.Add("Autor", "Autor");
            dgvLibros.Columns.Add("Anio", "Año");
            dgvLibros.Columns.Add("Disponible", "Disponible");

            // Configuración de columnas para dgvUsuarios
            dgvUsuarios.Columns.Add("Id", "ID");
            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns.Add("Correo", "Correo");

            // Configuración de columnas para dgvPrestamos
            dgvPrestamos.Columns.Add("Id", "ID");
            dgvPrestamos.Columns.Add("Libro", "Libro");
            dgvPrestamos.Columns.Add("Usuario", "Usuario");
            dgvPrestamos.Columns.Add("Fecha", "Fecha");
            dgvPrestamos.Columns.Add("Devuelto", "Devuelto");
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitulo.Text) ||
                string.IsNullOrEmpty(txtAutor.Text) ||
                string.IsNullOrEmpty(txtAnio.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show("El año debe ser numérico");
                return;
            }

            Libro libro = new Libro(contadorLibros++, txtTitulo.Text, txtAutor.Text, anio);
            biblioteca.AgregarLibro(libro);

            dgvLibros.Rows.Add(libro.Id, libro.Titulo, libro.Autor, libro.Anio, libro.Disponible);
            cmbLibros.Items.Add(libro.Titulo);

            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
        }

        // ELIMINAR LIBRO
        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0) return;

            int index = dgvLibros.SelectedRows[0].Index;
            Libro libro = biblioteca.Libros[index];

            biblioteca.EliminarLibro(libro);
            dgvLibros.Rows.RemoveAt(index);
            cmbLibros.Items.Remove(libro.Titulo);
        }

        // ACTUALIZAR LIBRO
        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0) return;

            int index = dgvLibros.SelectedRows[0].Index;
            Libro libro = biblioteca.Libros[index];

            if (!string.IsNullOrEmpty(txtTitulo.Text)) libro.Titulo = txtTitulo.Text;
            if (!string.IsNullOrEmpty(txtAutor.Text)) libro.Autor = txtAutor.Text;
            if (int.TryParse(txtAnio.Text, out int anio)) libro.Anio = anio;

            biblioteca.ActualizarLibro(index, libro);

            dgvLibros.Rows[index].SetValues(libro.Id, libro.Titulo, libro.Autor, libro.Anio, libro.Disponible);
            cmbLibros.Items[index] = libro.Titulo;

            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
        }

        // AGREGAR USUARIO
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            Usuario usuario = new Usuario(contadorUsuarios++, txtNombre.Text, txtCorreo.Text);
            biblioteca.AgregarUsuario(usuario);

            dgvUsuarios.Rows.Add(usuario.Id, usuario.Nombre, usuario.Email);
            cmbUsuarios.Items.Add(usuario.Nombre);

            txtNombre.Clear();
            txtCorreo.Clear();
        }

        // ELIMINAR USUARIO
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0) return;

            int index = dgvUsuarios.SelectedRows[0].Index;
            Usuario usuario = biblioteca.Usuarios[index];

            biblioteca.EliminarUsuario(usuario);
            dgvUsuarios.Rows.RemoveAt(index);
            cmbUsuarios.Items.Remove(usuario.Nombre);
        }

        // ACTUALIZAR USUARIO
        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0) return;

            int index = dgvUsuarios.SelectedRows[0].Index;
            Usuario usuario = biblioteca.Usuarios[index];

            if (!string.IsNullOrEmpty(txtNombre.Text)) usuario.Nombre = txtNombre.Text;
            if (!string.IsNullOrEmpty(txtCorreo.Text)) usuario.Email = txtCorreo.Text;

            biblioteca.ActualizarUsuario(index, usuario);

            dgvUsuarios.Rows[index].SetValues(usuario.Id, usuario.Nombre, usuario.Email);
            cmbUsuarios.Items[index] = usuario.Nombre;

            txtNombre.Clear();
            txtCorreo.Clear();
        }

        // PRESTAR LIBRO
        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (cmbLibros.SelectedIndex == -1 || cmbUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione libro y usuario");
                return;
            }

            Libro libro = biblioteca.Libros[cmbLibros.SelectedIndex];
            Usuario usuario = biblioteca.Usuarios[cmbUsuarios.SelectedIndex];

            if (!libro.Disponible)
            {
                MessageBox.Show("Libro no disponible");
                return;
            }

            libro.Disponible = false;

            Prestamo prestamo = new Prestamo(contadorPrestamos++, libro, usuario);
            biblioteca.RegistrarPrestamo(prestamo);

            dgvPrestamos.Rows.Add(prestamo.Id, libro.Titulo, usuario.Nombre, prestamo.FechaPrestamo, prestamo.Devuelto);
            cmbLibros.Items[cmbLibros.SelectedIndex] += " (Prestado)";
        }

        // DEVOLVER LIBRO
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count == 0) return;

            int index = dgvPrestamos.SelectedRows[0].Index;
            Prestamo prestamo = biblioteca.Prestamos[index];

            prestamo.Devuelto = true;
            prestamo.Libro.Disponible = true;

            dgvPrestamos.Rows[index].SetValues(prestamo.Id, prestamo.Libro.Titulo, prestamo.Usuario.Nombre, prestamo.FechaPrestamo, prestamo.Devuelto);

            int libroIndex = biblioteca.Libros.IndexOf(prestamo.Libro);
            cmbLibros.Items[libroIndex] = prestamo.Libro.Titulo;
        }

    }
}
