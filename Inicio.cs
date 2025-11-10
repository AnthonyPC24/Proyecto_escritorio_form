//using Beatrix_Formulario.ClasesTareas;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;
//using System.Windows.Forms;



//namespace Beatrix_Formulario
//{
//    public partial class Inicio : Form
//    {
//        private List<Reunion> reuniones = new List<Reunion>();
//        public Inicio()
//        {
//            InitializeComponent();


//        }

//        private void Inicio_Load(object sender, EventArgs e)
//        {
//            string tareasPath = Path.Combine(Application.StartupPath, "JSON", "Proyectos.json");
//            string reunionesPath = Path.Combine(Application.StartupPath, "JSON", "Reuniones.json");

            
//            if (File.Exists(tareasPath))
//            {
//                LoadJsonToTarea(tareasPath, dgvTarea);
//            }
//            else
//            {
//                MessageBox.Show($"No se encontró el archivo tareas ：{tareasPath}");
//            }

          
//            if (File.Exists(reunionesPath))
//            {
//                string jsonString = ReadJsonString(reunionesPath);

//                if (!string.IsNullOrEmpty(jsonString))
//                {
//                    try
//                    {
//                        var options = new JsonSerializerOptions
//                        {
//                            PropertyNameCaseInsensitive = true
//                        };
//                        reuniones = JsonSerializer.Deserialize<List<Reunion>>(jsonString, options);
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show("Error al cargar las reuniones: " + ex.Message);
//                    }
//                }
//            }
//            else
//            {
//                MessageBox.Show($"No se encontró el archivo de reuniones.：{reunionesPath}");
//            }

//            ShowReuniones(DateTime.Today);
//        }



//        //comboBox de proyecto 
//        private void comboBoxProyecto_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }


//        //button de cambiar idioma
//        private void btnIdioma_Click(object sender, EventArgs e)
//        {

//        }

//        // evento de 
//        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
//        {
//            ShowReuniones(e.Start);
//        }

//        private string ReadJsonString(string jsonPath)
//        {
//            if (!File.Exists(jsonPath))
//            {
//                MessageBox.Show("Archivo JSON no encontrado: " + jsonPath);
//                return null;
//            }

//            try
//            {
//                return File.ReadAllText(jsonPath).Trim();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error al leer JSON: " + ex.Message);
//                return null;
//            }
//        }

//        //cargar los datos de tareas
//        private void LoadJsonToTarea(string jsonPath, DataGridView dgv)
//        {
//            string jsonString = ReadJsonString(jsonPath);
//            if (string.IsNullOrEmpty(jsonString)) return;

//            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
//            List<Proyectos> proyectos = JsonSerializer.Deserialize<List<Proyectos>>(jsonString, options);

//            if (proyectos == null || proyectos.Count == 0)
//            {
//                MessageBox.Show("No se encontraron proyectos en el archivo JSON.");
//                return;
//            }

//            dgv.Rows.Clear();

//            foreach (var proyecto in proyectos)
//            {
//                if (proyecto.Tareas == null) continue;

//                foreach (var tarea in proyecto.Tareas)
//                {
//                    string usuarios = (tarea.usuariosAsignados != null && tarea.usuariosAsignados.Count > 0)
//                        ? string.Join(", ", tarea.usuariosAsignados.Select(u => u.nombreUsuario))
//                        : "(Sin usuarios)";

//                    dgv.Rows.Add(tarea.nombreTarea, tarea.descripcion, usuarios);
//                }
//            }
//        }



//        private void ShowReuniones(DateTime fechaSeleccionada)
//        {
//            if (reuniones == null || reuniones.Count == 0)
//            {
//                dgvReuniones.Rows.Clear();
//                return;
//            }

//            var reunionesDelDia = reuniones
//                .Where(r => r.fechaHora.Date == fechaSeleccionada.Date)
//                .OrderBy(r => r.fechaHora)
//                .ToList();

//            dgvReuniones.Rows.Clear(); 

//            if (reunionesDelDia.Count == 0)
//            {
//                return;
//            }

//            foreach (var r in reunionesDelDia)
//            {
//                string usuarios = (r.usuariosReuniones != null && r.usuariosReuniones.Count > 0)
//                    ? string.Join(", ", r.usuariosReuniones)
//                    : "(Sin participantes)";

//                dgvReuniones.Rows.Add(
//                    r.titulo,
//                    r.fechaHora.ToString("yyyy-MM-dd HH:mm"),
//                    usuarios,
//                    r.descripcion
//                );
//            }

//            dgvReuniones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//        }



//    }
//}