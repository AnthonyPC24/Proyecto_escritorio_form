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
    public partial class FormTareasTho1 : Form
    {
        private List<Proyectos> listaProyectos = new List<Proyectos>();

        public FormTareasTho1()
        {
            InitializeComponent();

            comboBoxUsuarios.Text = "Usuarios";

            cargarProyectosDesdeJson();
        }

        private void cargarProyectosDesdeJson()
        {
            try
            {
                string rutaArchivoProyectos = System.IO.Path.Combine(Application.StartupPath, "JSON", "Proyectos.json");

                if (!File.Exists(rutaArchivoProyectos))
                {
                    MessageBox.Show("No se encontró el archivo de proyectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jsonProyectos = File.ReadAllText(rutaArchivoProyectos);
                listaProyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonProyectos);

                if (listaProyectos == null || listaProyectos.Count == 0)
                {
                    MessageBox.Show("No hay proyectos en el archivo JSON.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                comboBoxProyectos.Items.Clear();
                foreach (var proyectos in listaProyectos)
                {
                    comboBoxProyectos.Items.Add(proyectos.NombreProyecto);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxEstadosTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonNuevaTarea_Click(object sender, EventArgs e)
        {
            FormTareasTho2 nuevaTareaForm = new FormTareasTho2();

            if (nuevaTareaForm.ShowDialog() == DialogResult.OK)
            {
                string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(nombreProyecto))
                {
                    MessageBox.Show("Seleccione un proyecto para añadir la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);

                if (proyecto == null)
                {
                    MessageBox.Show("No se encontró el proyecto en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (proyecto.Tareas == null)
                    proyecto.Tareas = new List<Tareas>();

                proyecto.Tareas.Add(nuevaTareaForm.NuevaTareaCreada);

                string rutaArchivo = Path.Combine(Application.StartupPath, "JSON", "Proyectos.json");
                string jsonActualizado = JsonSerializer.Serialize(listaProyectos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, jsonActualizado);

                comboBoxTareas.Items.Add(nuevaTareaForm.NuevaTareaCreada.nombreTarea);

                MessageBox.Show("Tarea añadida al proyecto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nombreProyecto = comboBoxProyectos.SelectedItem?.ToString();
            string nombreTarea = comboBoxTareas.SelectedItem?.ToString();

            if (nombreProyecto == null || nombreTarea == null) return;

            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == nombreProyecto);
            if (proyecto == null) return;

            Tareas tarea = proyecto.Tareas.FirstOrDefault(t => t.nombreTarea == nombreTarea);
            if (tarea == null) return;

            // Mostrar detalles de la tarea
            textBoxNombreTarea.Text = tarea.nombreTarea;
            dateTimePickerFechaInicio.Value = tarea.fechaInicio;
            dateTimePickerFechaEntrega.Value = tarea.fechaEntrega;
            comboBoxEstadosTarea.Text = tarea.estado;

            comboBoxUsuarios.Items.Clear();

            foreach (var usuario in tarea.usuariosAsignados)
            {
                comboBoxUsuarios.Items.Add(usuario.nombreUsuario);
            }

            if (tarea.usuariosAsignados.Count > 0)
            {
                comboBoxUsuarios.SelectedIndex = 0;
            }

            richTextBoxDescripcionTare.Text = tarea.descripcion;


        }

        private void comboBoxProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTareas.Items.Clear();

            string proyectoSeleccionado = comboBoxProyectos.SelectedItem?.ToString();

            if (proyectoSeleccionado == null)
            {
                return;
            }

            Proyectos proyecto = listaProyectos.FirstOrDefault(p => p.NombreProyecto == proyectoSeleccionado);
            if (proyecto != null)
            {
                foreach (var tarea in proyecto.Tareas)
                {
                    comboBoxTareas.Items.Add(tarea.nombreTarea);
                }
            }
        }
        private void buttonInicioForm1Tareas_Click(object sender, EventArgs e)
        {
            Inicio inicioForm = new Inicio();
            inicioForm.Show();
            this.Hide();
        }

        private void buttonProyetos1Tareas_Click(object sender, EventArgs e)
        {
            FormProyectosGerard1 formProyectosGerard1 = new FormProyectosGerard1();
            formProyectosGerard1.Show();
            this.Hide();
        }

        private void buttonReuniones1Tareas_Click(object sender, EventArgs e)
        {
            FormReunionesDy1 formReunionesDy1 = new FormReunionesDy1();
            formReunionesDy1.Show();
            this.Hide();
        }


        // --- Buscar proyecto por nombre ---
        private void buttonBuscarNombreProyecto_Click(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxBuscarNombreProyecto.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Por favor, ingresa un nombre de proyecto para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Buscar el proyecto que contenga el texto ingresado (insensible a mayúsculas)
            Proyectos proyectoEncontrado = listaProyectos.FirstOrDefault(p =>
                p.NombreProyecto != null &&
                p.NombreProyecto.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0);

            if (proyectoEncontrado == null)
            {
                MessageBox.Show("No se encontró ningún proyecto con ese nombre.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Limpiar comboBoxTareas para evitar duplicados
            comboBoxTareas.Items.Clear();

            // Desactivar evento temporalmente para evitar duplicación al cambiar el SelectedItem
            comboBoxProyectos.SelectedIndexChanged -= comboBoxProyectos_SelectedIndexChanged;
            comboBoxProyectos.SelectedItem = proyectoEncontrado.NombreProyecto;
            comboBoxProyectos.SelectedIndexChanged += comboBoxProyectos_SelectedIndexChanged;

            // Cargar las tareas del proyecto encontrado
            if (proyectoEncontrado.Tareas != null && proyectoEncontrado.Tareas.Count > 0)
            {
                foreach (var tarea in proyectoEncontrado.Tareas)
                {
                    comboBoxTareas.Items.Add(tarea.nombreTarea);
                }

                comboBoxTareas.SelectedIndex = 0; // Selecciona la primera tarea por defecto

                // Mostrar detalles de la primera tarea en el groupBox
                Tareas primeraTarea = proyectoEncontrado.Tareas[0];
                textBoxNombreTarea.Text = primeraTarea.nombreTarea;
                dateTimePickerFechaInicio.Value = primeraTarea.fechaInicio;
                dateTimePickerFechaEntrega.Value = primeraTarea.fechaEntrega;
                comboBoxEstadosTarea.Text = primeraTarea.estado;

                comboBoxUsuarios.Items.Clear();
                foreach (var usuario in primeraTarea.usuariosAsignados)
                {
                    comboBoxUsuarios.Items.Add(usuario.nombreUsuario);
                }

                if (primeraTarea.usuariosAsignados.Count > 0)
                    comboBoxUsuarios.SelectedIndex = 0;

                richTextBoxDescripcionTare.Text = primeraTarea.descripcion;
            }
            else
            {
                MessageBox.Show("El proyecto no tiene tareas registradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBoxSubtareas_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxSubTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
