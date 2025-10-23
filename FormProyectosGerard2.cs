using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chkUsuarios.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un 'Usuario'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proyectos proyectoTemporal = new Proyectos
            {
                NombreProyecto = txtNombre.Text,
                fechaInicio = DateTime.Now,
                fechaEntrega = monthCalendar.SelectionStart

            };



            foreach (object itemMarcado in chkUsuarios.CheckedItems)
            {
                // 2. Convierte el 'item' de nuevo a un objeto 'Usuarios'
                Usuarios usuarioSeleccionado = (Usuarios)itemMarcado;

                // 3. Añádelo a la lista del proyecto
                proyectoTemporal.UsuariosAsignados.Add(usuarioSeleccionado);
            }

            // --- D. Guardar y Cerrar ---
            this.NuevoProyecto = proyectoTemporal;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // --- CÓDIGO DEL BOTÓN "CANCELAR" ---
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormProyectosGerard2_Load_1(object sender, EventArgs e)
        {
            MessageBox.Show("¡El evento LOAD se está ejecutando!");
            // Define la ruta de tu archivo de usuarios
            string rutaUsuariosJson = @"JSON\Usuarios.JSON";

            if (File.Exists(rutaUsuariosJson))
            {
                try
                {
                    // 1. Leer el texto del archivo
                    string json = File.ReadAllText(rutaUsuariosJson);

                    // 2. Convertir el JSON en una lista de objetos 'Usuarios'
                    List<Usuarios> listaTotalUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json);

                    // 3. Rellenar el CheckedListBox
                    // (Limpia la lista por si acaso)
                    comboBox1.Items.Clear();

                    foreach (Usuarios user in listaTotalUsuarios)
                    {
                        // Añadimos el OBJETO 'Usuarios' completo.
                        // Gracias al método 'ToString()' que sobrescribiste en la
                        // clase 'Usuarios', el control mostrará 'nombreApellidos'.
                        comboBox1.Items.Add(user);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los usuarios: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo 'Usuarios.JSON'.");
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) {
                String usuario = comboBox1.SelectedItem.ToString();

                if (!listBoxUsuarios.Items.Contains(usuario)) {
                    listBoxUsuarios.Items.Add(usuario);
                 }
                comboBox1.SelectedItem = -1;
            }
        }
    }
}
