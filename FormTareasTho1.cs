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
    public partial class FormTareasTho1 : Form
    {
        public FormTareasTho1()
        {
            InitializeComponent();

            comboBoxEstadosTarea.Items.AddRange(new String[] {
                "Pendiente", "En proceso", "En espera","Revisión", "Completada", "Cancelada"
            });

            comboBoxEstadosTarea.SelectedItem = "Pendiente";

            comboBoxUsuarios.Text = "Usuarios";
        }

        private void comboBoxEstadosTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonNuevaTarea_Click(object sender, EventArgs e)
        {
            FormTareasTho2 nuevaTarea = new FormTareasTho2();

            if (nuevaTarea.ShowDialog() == DialogResult.OK)
            {
                Tareas tareaCreada = nuevaTarea.NuevaTareaCreada;
                comboBoxTareas.Items.Add(tareaCreada.nombreTarea);
                MessageBox.Show($"Tarea '{tareaCreada.nombreTarea}' creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void comboBoxTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
