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
    public partial class FormTareasTho2 : Form
    {
        public Tareas NuevaTareaCreada { get; private set; }
        public FormTareasTho2()
        {
            InitializeComponent();
            comboBoxProyectoNuevaTarea.Items.Add("Proyectos");

            comboBoxUsuariosAsignarTareas.Items.Add("pedro");
            comboBoxUsuariosAsignarTareas.Items.Add("maria");
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

        private void buttonQuitarUsuario_Click(object sender, EventArgs e)
        {
            if(listBoxUsuarios.SelectedItem != null)
            {
                listBoxUsuarios.Items.Remove(listBoxUsuarios.SelectedItem);
            }
        }
    }
}
