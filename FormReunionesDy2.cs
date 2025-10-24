using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beatrix_Formulario.ClasesTareas;

namespace Beatrix_Formulario
{
    public partial class FormReunionesDy2 : Form
    {
        public FormReunionesDy2()
        {
            InitializeComponent();
            this.Load += FormReunionesDy2_Load;
        }

        private void FormReunionesDy2_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaArchivo = Path.Combine(Application.StartupPath, "JSON", "Usuarios.json");

                if (File.Exists(rutaArchivo))
                {
                    string json = File.ReadAllText(rutaArchivo);

                    // Deserializa la lista de usuarios
                    List<Usuarios> listaUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json);

                    // Asigna la lista al CheckedListBox
                    checkedListBoxParticipantes.DataSource = listaUsuarios;
                    checkedListBoxParticipantes.DisplayMember = "nombreApellidos";
                    checkedListBoxParticipantes.ValueMember = "email";
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo Usuarios.json", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            // Obtiene todos los participantes seleccionados
            List<string> participantesSeleccionados = new List<string>();

            foreach (var item in checkedListBoxParticipantes.CheckedItems)
            {
                if (item is Usuarios usuario)
                    participantesSeleccionados.Add(usuario.nombreApellidos);
            }

            // Crea la nueva reunión
            Reunion nuevaReunion = new Reunion
            {
                titulo = textBoxAsunto.Text,
                fechaHora = dateTimePickerFechaHoraNuevaReunion.Value,
                usuariosReuniones = participantesSeleccionados,
                descripcion = richTextBoxInformacion.Text
            };
            
            string rutaBase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GitHub", "Proyecto_escritorio_form", "JSON");
            string rutaArchivo = Path.Combine(rutaBase, "Reuniones.json");

            try
            {
                List<Reunion> listaReuniones = new List<Reunion>();

                // Si el archivo existe, carga las reuniones previas
                if (File.Exists(rutaArchivo))
                {
                    string jsonExistente = File.ReadAllText(rutaArchivo);
                    listaReuniones = JsonSerializer.Deserialize<List<Reunion>>(jsonExistente);
                }

                // Agrega la nueva reunión
                listaReuniones.Add(nuevaReunion);

                // Guarda todo nuevamente
                string nuevoJson = JsonSerializer.Serialize(listaReuniones, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, nuevoJson);

                MessageBox.Show("Reunión creada y guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la reunión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
