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
using static System.Windows.Forms.DataFormats;

namespace Beatrix_Formulario
{

    public partial class FormReunionesDy1 : Form
    {
        public FormReunionesDy1()
        {
            InitializeComponent();
            CargarReuniones();
        }

        private void panelBarraOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelParaHoy_Paint(object sender, PaintEventArgs e)
        {
            Color turquesa = Color.FromArgb(41, 195, 205);
            int grosor = 2;

            Rectangle rect = panelParaHoy.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (Pen pen = new Pen(turquesa, grosor))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void labelCrearReunion_Click(object sender, EventArgs e)
        {
            FormReunionesDy2 formReunionesDy2 = new FormReunionesDy2();

            formReunionesDy2.ReunionCreada += (s, ev) =>
            {
                CargarReuniones();
                CargarReunionesDataGrid();
            };

            formReunionesDy2.ShowDialog();
        }

        private void FormReunionesLista_Load(object sender, EventArgs e)
        {
            CargarReunionesDataGrid();
        }

        private void CargarReunionesDataGrid()
        {
            try
            {
                string rutaProyecto = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string rutaArchivo = Path.Combine(rutaProyecto, "JSON", "Reuniones.json");

                if (File.Exists(rutaArchivo))
                {
                    string json = File.ReadAllText(rutaArchivo);
                    List<Reunion> listaReuniones = JsonSerializer.Deserialize<List<Reunion>>(json);

                    var reunionesFormateadas = listaReuniones.Select(r => new
                    {
                        Tarea = r.titulo,
                        Especificaciones = r.descripcion,
                        Usuarios = string.Join(", ", r.usuariosReuniones),
                        Fecha = r.fechaHora.ToString("dd/MM/yyyy HH:mm")
                    }).ToList();

                    dataGridViewTarea.DataSource = reunionesFormateadas;
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo Reuniones.json.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las reuniones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarReuniones()
        {
            string rutaJson = Path.Combine(Application.StartupPath, @"..\..\..\JSON\Reuniones.json");

            if (!File.Exists(rutaJson))
            {
                MessageBox.Show("No se encontró el archivo Reuniones.json");
                return;
            }

            string json = File.ReadAllText(rutaJson);
            List<Reunion> reuniones;

            try
            {
                reuniones = JsonSerializer.Deserialize<List<Reunion>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el JSON: " + ex.Message);
                return;
            }

            if (reuniones == null || reuniones.Count == 0)
            {

                panelReunion1.Visible = false;
                panelReunion2.Visible = false;
                panelReunion3.Visible = false;
                return;
            }


            var proximasTres = reuniones
             .OrderBy(r => Math.Abs((r.fechaHora - DateTime.Now).TotalMinutes)) // diferencia en minutos
             .Take(3)
             .ToList();


            Label[] labelsTitulo = { labelReunionPanel1, labelReunionPanel2, labelReunionPanel3 };
            Label[] labelsParticipantes = { labelNombresReunion1, labelNombresReunion2, labelNombresReunion3 };
            Label[] labelsDescripcion = { labelInformaciónDeLaReunion1, labelInformaciónDeLaReunion2, labelInformaciónDeLaReunion3 };
            Label[] labelsHora = { labelHoraReunion1, labelHoraReunion2, labelHoraReunion3 };


            Panel[] paneles = { panelReunion1, panelReunion2, panelReunion3 };


            for (int i = 0; i < paneles.Length; i++)
            {
                if (i < proximasTres.Count)
                {
                    var reunion = proximasTres[i];
                    paneles[i].Visible = true;

                    labelsTitulo[i].Text = reunion.titulo;
                    labelsTitulo[i].AutoEllipsis = false;
                    labelsTitulo[i].TextAlign = ContentAlignment.TopLeft;
                    labelsTitulo[i].Font = new Font("Arial", 11, FontStyle.Bold);
                    labelsTitulo[i].ForeColor = Color.White;
                    labelsTitulo[i].UseCompatibleTextRendering = true;
                    labelsParticipantes[i].Text = string.Join(", ", reunion.usuariosReuniones);
                    labelsDescripcion[i].Text = reunion.descripcion;
                    labelsHora[i].Text = reunion.fechaHora.ToString("dd/MM/yyyy HH:mm");
                }
                else
                {

                    paneles[i].Visible = false;
                }
            }
        }

        private void buttonInicioForm1Tareas_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void buttonProyetos1Tareas_Click(object sender, EventArgs e)
        {
            FormProyectosGerard1 formProyectosGerard1 = new FormProyectosGerard1();
            formProyectosGerard1.Show();
            this.Hide();
        }

        private void buttonTareas1Tareas_Click(object sender, EventArgs e)
        {
            FormTareasTho1 formTareasTho1 = new FormTareasTho1();
            formTareasTho1.Show();
            this.Hide();
        }
    }
}