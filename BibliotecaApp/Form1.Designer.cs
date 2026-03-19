namespace BibliotecaApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabLibros = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnActualizarLibro = new System.Windows.Forms.Button();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabPrestamos = new System.Windows.Forms.TabPage();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.tabGraficos = new System.Windows.Forms.TabPage();
            this.chartLibrosPrestados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabControlPrincipal.SuspendLayout();
            this.tabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.tabGraficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibrosPrestados)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlPrincipal
            // 
            this.TabControlPrincipal.Controls.Add(this.tabLibros);
            this.TabControlPrincipal.Controls.Add(this.tabUsuarios);
            this.TabControlPrincipal.Controls.Add(this.tabPrestamos);
            this.TabControlPrincipal.Controls.Add(this.tabGraficos);
            this.TabControlPrincipal.Location = new System.Drawing.Point(12, 12);
            this.TabControlPrincipal.Name = "TabControlPrincipal";
            this.TabControlPrincipal.SelectedIndex = 0;
            this.TabControlPrincipal.Size = new System.Drawing.Size(776, 426);
            this.TabControlPrincipal.TabIndex = 0;
            // 
            // tabLibros
            // 
            this.tabLibros.Controls.Add(this.label3);
            this.tabLibros.Controls.Add(this.txtAnio);
            this.tabLibros.Controls.Add(this.dgvLibros);
            this.tabLibros.Controls.Add(this.btnActualizarLibro);
            this.tabLibros.Controls.Add(this.btnEliminarLibro);
            this.tabLibros.Controls.Add(this.btnAgregarLibro);
            this.tabLibros.Controls.Add(this.label2);
            this.tabLibros.Controls.Add(this.label1);
            this.tabLibros.Controls.Add(this.txtAutor);
            this.tabLibros.Controls.Add(this.txtTitulo);
            this.tabLibros.Location = new System.Drawing.Point(4, 22);
            this.tabLibros.Name = "tabLibros";
            this.tabLibros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibros.Size = new System.Drawing.Size(768, 400);
            this.tabLibros.TabIndex = 0;
            this.tabLibros.Text = "Libros";
            this.tabLibros.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(126, 120);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(189, 20);
            this.txtAnio.TabIndex = 8;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(42, 230);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(683, 150);
            this.dgvLibros.TabIndex = 7;
            // 
            // btnActualizarLibro
            // 
            this.btnActualizarLibro.Location = new System.Drawing.Point(638, 170);
            this.btnActualizarLibro.Name = "btnActualizarLibro";
            this.btnActualizarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarLibro.TabIndex = 6;
            this.btnActualizarLibro.Text = "Actualizar";
            this.btnActualizarLibro.UseVisualStyleBackColor = true;
            this.btnActualizarLibro.Click += new System.EventHandler(this.btnActualizarLibro_Click);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(345, 170);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLibro.TabIndex = 5;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(42, 170);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarLibro.TabIndex = 4;
            this.btnAgregarLibro.Text = "Agregar";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo:";
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutor.Location = new System.Drawing.Point(126, 72);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(189, 20);
            this.txtAutor.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(126, 28);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(189, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.dgvUsuarios);
            this.tabUsuarios.Controls.Add(this.btnActualizarUsuario);
            this.tabUsuarios.Controls.Add(this.btnEliminarUsuario);
            this.tabUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.tabUsuarios.Controls.Add(this.label5);
            this.tabUsuarios.Controls.Add(this.label4);
            this.tabUsuarios.Controls.Add(this.txtCorreo);
            this.tabUsuarios.Controls.Add(this.txtNombre);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(768, 400);
            this.tabUsuarios.TabIndex = 1;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(52, 235);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(670, 150);
            this.dgvUsuarios.TabIndex = 7;
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Location = new System.Drawing.Point(647, 177);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarUsuario.TabIndex = 6;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(347, 177);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 5;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(52, 177);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUsuario.TabIndex = 4;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(139, 94);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(162, 20);
            this.txtCorreo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // tabPrestamos
            // 
            this.tabPrestamos.Controls.Add(this.dgvPrestamos);
            this.tabPrestamos.Controls.Add(this.btnDevolver);
            this.tabPrestamos.Controls.Add(this.btnPrestar);
            this.tabPrestamos.Controls.Add(this.label7);
            this.tabPrestamos.Controls.Add(this.label6);
            this.tabPrestamos.Controls.Add(this.cmbUsuarios);
            this.tabPrestamos.Controls.Add(this.cmbLibros);
            this.tabPrestamos.Location = new System.Drawing.Point(4, 22);
            this.tabPrestamos.Name = "tabPrestamos";
            this.tabPrestamos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrestamos.Size = new System.Drawing.Size(768, 400);
            this.tabPrestamos.TabIndex = 2;
            this.tabPrestamos.Text = "Prestamos";
            this.tabPrestamos.UseVisualStyleBackColor = true;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(53, 240);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(692, 150);
            this.dgvPrestamos.TabIndex = 6;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(475, 179);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 5;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnPrestar
            // 
            this.btnPrestar.Location = new System.Drawing.Point(237, 179);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(75, 23);
            this.btnPrestar.TabIndex = 4;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Usuarios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Libros";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(145, 90);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(167, 21);
            this.cmbUsuarios.TabIndex = 1;
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(145, 34);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(167, 21);
            this.cmbLibros.TabIndex = 0;
            // 
            // tabGraficos
            // 
            this.tabGraficos.Controls.Add(this.chartLibrosPrestados);
            this.tabGraficos.Location = new System.Drawing.Point(4, 22);
            this.tabGraficos.Name = "tabGraficos";
            this.tabGraficos.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraficos.Size = new System.Drawing.Size(768, 400);
            this.tabGraficos.TabIndex = 3;
            this.tabGraficos.Text = "Gráficos de libros mas prestados";
            this.tabGraficos.UseVisualStyleBackColor = true;
            // 
            // chartLibrosPrestados
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLibrosPrestados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLibrosPrestados.Legends.Add(legend1);
            this.chartLibrosPrestados.Location = new System.Drawing.Point(46, 34);
            this.chartLibrosPrestados.Name = "chartLibrosPrestados";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLibrosPrestados.Series.Add(series1);
            this.chartLibrosPrestados.Size = new System.Drawing.Size(627, 317);
            this.chartLibrosPrestados.TabIndex = 0;
            this.chartLibrosPrestados.Text = "Libros mas prestados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControlPrincipal);
            this.Name = "Form1";
            this.Text = "Sistema de Biblioteca";
            this.TabControlPrincipal.ResumeLayout(false);
            this.tabLibros.ResumeLayout(false);
            this.tabLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabPrestamos.ResumeLayout(false);
            this.tabPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.tabGraficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLibrosPrestados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlPrincipal;
        private System.Windows.Forms.TabPage tabLibros;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TabPage tabPrestamos;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnActualizarLibro;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.TabPage tabGraficos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibrosPrestados;
    }
}

