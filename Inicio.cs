using Beatrix_Formulario.ClasesTareas;
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



namespace Beatrix_Formulario
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();


        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            string jsonPath = @"D:\GIT\Proyecto_escritorio_form\JSON\Proyectos.json";

            if (dgvTarea == null)
            {
                MessageBox.Show("DataGridView no está inicializado");
                return;
            }

            LoadJsonToTarea(jsonPath, dgvTarea);
        }


        //comboBox de proyecto 
        private void comboBoxProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //button de cambiar idioma
        private void btnIdioma_Click(object sender, EventArgs e)
        {

        }

        // evento de 
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        //cargar los datos de tareas
        private void LoadJsonToTarea(string jsonPath, DataGridView dgv)
        {
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Archivo JSON no encontrado: " + jsonPath);
                return;
            }

            try
            {
                string jsonString = File.ReadAllText(jsonPath).Trim();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<Proyectos> proyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonString, options);

                if (proyectos == null || proyectos.Count == 0)
                {
                    MessageBox.Show("No se encontraron proyectos en el archivo JSON.");
                    return;
                }


                dgv.Rows.Clear();

                foreach (var proyecto in proyectos)
                {
                    if (proyecto.Tareas == null) continue;

                    foreach (var tarea in proyecto.Tareas)
                    {
                        string usuarios = "";
                        if (tarea.usuariosAsignados != null && tarea.usuariosAsignados.Count > 0)
                        {
                            usuarios = string.Join(", ", tarea.usuariosAsignados.Select(u => u.nombreUsuario));
                        }

                        dgv.Rows.Add(
                            tarea.nombreTarea,
                            tarea.descripcion,
                            usuarios
                        );
                    }
                }

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar JSON: " + ex.Message);
            }
        }


    }
}
