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
    public partial class FormTareasTho2 : Form
    {
        public FormTareasTho2()
        {
            InitializeComponent();
            comboBoxProyectoNuevaTarea.Items.Add("Proyectos");
            comboBoxUsuariosAsignarTareas.Items.Add("Usuarios");
        }

     
        private void comboBoxProyectoNuevaTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
