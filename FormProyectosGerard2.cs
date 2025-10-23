using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beatrix_Formulario.ClasesTareas;

namespace Beatrix_Formulario
{
    public partial class FormProyectosGerard2 : Form
    {

        public Proyectos NuevoProyecto { get; private set; }
        public FormProyectosGerard2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUsuarios.Text))
            {
                MessageBox.Show("Debe seleccionar un 'Usuario'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proyectos proyectoTemporal = new Proyectos
            {
                // Asignamos los datos del formulario a la instancia
                NombreProyecto = txtNombre.Text,
                fechaInicio = DateTime.Now, // Fecha de creación
                fechaEntrega = monthCalendar.SelectionStart // Fecha del calendario

                // La propiedad 'Tareas' ya se inicializa sola como una lista vacía
            };

            string[] nombresDeUsuarios = txtUsuarios.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string nombre in nombresDeUsuarios)
            {
                // 3. Crea un nuevo objeto 'Usuarios' para cada nombre
                Usuarios nuevoUsuario = new Usuarios
                {
                    // Usamos Trim() para quitar espacios en blanco (ej: " Anna" -> "Anna")
                    nombreApellidos = nombre.Trim()

                    // Las otras propiedades de Usuarios (email, rol, etc.)
                    // quedarán con sus valores por defecto (null o 0)
                };

                // 4. Añade el nuevo usuario a la lista del proyecto
                proyectoTemporal.UsuariosAsignados.Add(nuevoUsuario);
            }

            this.NuevoProyecto = proyectoTemporal;

            // 2. Le decimos a Form1 que todo salió "OK"
            this.DialogResult = DialogResult.OK;

            // 3. Cerramos este formulario (Form2)
            this.Close();
        }
    }
}
