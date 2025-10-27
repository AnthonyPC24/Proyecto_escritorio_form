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

// --- PASO 1: Añade estos 'using' ---
using System.IO;                  // Para leer/escribir archivos
using System.Text.Json;           // Para procesar JSON

namespace Beatrix_Formulario
{
    public partial class FormProyectosGerard1 : Form
    {
        private List<Proyectos> listaDeProyectos;
        private string rutaArchivoJson = @"JSON\Proyectos.JSON";

        public FormProyectosGerard1()
        {
            InitializeComponent();
        }

        // --- PASO 2: Conecta el evento 'Load' ---
        //
        // CÓMO HACERLO:
        // 1. Ve al diseñador de Form1.
        // 2. Haz clic en una parte VACÍA del formulario.
        // 3. Ve a la ventana 'Propiedades' (abajo a la derecha).
        // 4. Haz clic en el icono del rayo (⚡) (Eventos).
        // 5. Busca el evento 'Load' y haz DOBLE CLIC en él.
        // 6. Visual Studio creará el método de abajo. Pega este código dentro.
        //
        private void FormProyectosGerard1_Load_1(object sender, EventArgs e)
        {
            CargarProyectosDesdeJson();
        }

        // --- PASO 3: Código ACTUALIZADO para "+ Crear Proyecto" ---
        // (Tu método se llama label1_Click)
        private void label1_Click(object sender, EventArgs e)
        {
            using (FormProyectosGerard2 formCrear = new FormProyectosGerard2())
            {
                DialogResult resultado = formCrear.ShowDialog();

                // --- ¡AÑADE ESTA LÓGICA! ---
                // Comprueba si el usuario hizo clic en "Crear" en Form2
                if (resultado == DialogResult.OK)
                {
                    // 1. Añadir el nuevo proyecto a nuestra lista
                    // (Form2 ya lo guardó en el JSON, así que
                    //  podríamos simplemente recargar el JSON)
                    CargarProyectosDesdeJson();

                    // Opcionalmente, si Form2 NO guardara en el JSON:
                    // Proyectos proyectoCreado = formCrear.NuevoProyecto;
                    // if (proyectoCreado != null)
                    // {
                    //    listaDeProyectos.Add(proyectoCreado);
                    //    AgregarFilaAGrid(proyectoCreado);
                    //    GuardarProyectosEnJson();
                    // }
                }
            }
        }

        // --- PASO 4: Añade estos nuevos métodos ---

        /// <summary>
        /// Carga el archivo JSON y rellena la lista 'listaDeProyectos'
        /// </summary>
        private void CargarProyectosDesdeJson()
        {
            if (File.Exists(rutaArchivoJson))
            {
                try
                {
                    string json = File.ReadAllText(rutaArchivoJson);
                    if (string.IsNullOrWhiteSpace(json))
                    {
                        listaDeProyectos = new List<Proyectos>();
                    }
                    else
                    {
                        listaDeProyectos = JsonSerializer.Deserialize<List<Proyectos>>(json);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo JSON: {ex.Message}");
                    listaDeProyectos = new List<Proyectos>();
                }
            }
            else
            {
                // Si el archivo no existe, empezamos con una lista vacía
                listaDeProyectos = new List<Proyectos>();
            }

            // Ahora, rellena el DataGridView con la lista cargada
            RefrescarDataGridView();
        }

        /// <summary>
        /// Guarda la 'listaDeProyectos' actual en el archivo JSON
        /// (Es útil si Form2 no guardara directamente)
        /// </summary>
        private void GuardarProyectosEnJson()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(listaDeProyectos, options);
                File.WriteAllText(rutaArchivoJson, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en el archivo JSON: {ex.Message}");
            }
        }

        /// <summary>
        /// Borra el DataGridView y lo rellena con la 'listaDeProyectos'
        /// </summary>
        private void RefrescarDataGridView()
        {
            // ¡Asegúrate de que tu DataGridView se llama 'dataGridViewTarea'!
            dataGridViewTarea.Rows.Clear();

            if (listaDeProyectos == null) return;

            foreach (Proyectos proyecto in listaDeProyectos)
            {
                AgregarFilaAGrid(proyecto);
            }
        }

        /// <summary>
        /// Método ayudante para añadir una fila al DataGridView
        /// </summary>
        private void AgregarFilaAGrid(Proyectos proyecto)
        {
            string usuariosStr = "N/A";

            // Comprobación para evitar error si 'UsuariosAsignados' es null
            if (proyecto.UsuariosAsignados != null)
            {
                // Formatea la lista de usuarios (ej: "Gerard, Anna")
                // Nota: Esto solo funcionará si los objetos 'Usuarios'
                // en tu JSON tienen la propiedad 'nombreApellidos'.
                usuariosStr = string.Join(", ",
                    proyecto.UsuariosAsignados.Select(u => u.nombreApellidos)
                );
            }

            // Añade la fila
            dataGridViewTarea.Rows.Add(
                proyecto.NombreProyecto,
                usuariosStr,
                proyecto.fechaEntrega.ToShortDateString()
            );
        }


        // --- Tus otros métodos (déjalos como están) ---

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void btnReunion_Click(object sender, EventArgs e) { }
        private void btnTareas_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void dataGridViewTarea_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        
    }
}