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
    public partial class FormTareasTho2 : Form
    {

        public Tareas NuevaTareaCreada { get; private set; }
        public FormTareasTho2()
        {
            InitializeComponent();
            comboBoxProyectoNuevaTarea.Items.Add("Proyectos");

            cargarUsuariosDesdeJson();
        }

        private void cargarUsuariosDesdeJson()
        {
            try
            {
                string rutaArchivo = Path.Combine(Application.StartupPath, "JSON", "Usuarios.json");

                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show("No se encontró el archivo de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string json = File.ReadAllText(rutaArchivo);
                var listaUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json);

                if (listaUsuarios == null || listaUsuarios.Count == 0)
                {
                    MessageBox.Show("No hay usuarios en el archivo JSON.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                comboBoxUsuariosAsignarTareas.Items.Clear();
                foreach (var usuario in listaUsuarios)
                {
                    comboBoxUsuariosAsignarTareas.Items.Add(usuario.nombreApellidos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxProyectoNuevaTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCrearNuevaTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreNuevaTarea.Text))
            {

                MessageBox.Show("Introduzca el nombre de la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (comboBoxUsuariosAsignarTareas == null)
            {
                MessageBox.Show("Seleccine un usuario");
                return;

            }

            NuevaTareaCreada = new Tareas

            {
                nombreTarea = textBoxNombreNuevaTarea.Text,
                descripcion = richTextBoxDescripcion.Text,
                fechaEntrega = dateTimePickerFechaTareaFin.Value,
                fechaInicio = dateTimePickerFechaTareaInicio.Value,
                estado = "Pendiente"
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelarTarea_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //ComboBox para seleccionar los usuarios y añadirlos a la listbox
        private void comboBoxUsuariosAsignarTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuariosAsignarTareas.SelectedItem != null)
            {
                String usuario = comboBoxUsuariosAsignarTareas.SelectedItem.ToString();

                if (!listBoxUsuarios.Items.Contains(usuario))
                {
                    listBoxUsuarios.Items.Add(usuario);
                }
                comboBoxUsuariosAsignarTareas.SelectedItem = -1;
            }

        }

        //Boton para quitar los usuarios dentro de la listbox
        private void buttonQuitarUsuario_Click(object sender, EventArgs e)
        {
            if(listBoxUsuarios.SelectedItem != null)
            {
                listBoxUsuarios.Items.Remove(listBoxUsuarios.SelectedItem);
            }
        }
    }
}
