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
    public partial class FormTareasTho1 : Form
    {
        public FormTareasTho1()
        {
            InitializeComponent();

            comboBoxEstadosTarea.Items.AddRange(new String[] {
                "Pendiente", "En Proceso", "En espera","Revisión", "Completada", "Cancelada"
            });

            comboBoxEstadosTarea.SelectedItem = "Pendiente";

            comboBoxUsuarios.Text = "Usuarios";
        }

        private void comboBoxEstadosTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
