using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beatrix_Formulario
{
    public partial class FormProyectosGerard2 : Form
    {
        public FormProyectosGerard2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detiene la ejecución
            }
            if (cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un 'Usuario'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detiene la ejecución
            }
        }
    }
}
