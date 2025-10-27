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
            LoadJsonToTarea(jsonPath, dataGridViewTarea);

        }


        //comboBox de proyecto 
        private void comboBoxProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //button de cambiar idioma
        private void btnIdioma_Click(object sender, EventArgs e)
        {

        }

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
                string jsonString = File.ReadAllText(jsonPath);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                Proyectos proyecto = JsonSerializer.Deserialize<Proyectos>(jsonString, options);

                if (proyecto == null || proyecto.Tareas == null || proyecto.Tareas.Count == 0)
                {
                    MessageBox.Show("No se encontraron tareas en el archivo JSON.");
                    return;
                }

                

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar JSON: " + ex.Message);
            }
        }


    }
}
