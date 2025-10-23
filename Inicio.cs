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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            LoadJsonToTarea();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

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
        private void LoadJsonToTarea()
        {
            string jsonPath = "JSON\\Proyectos.json";
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("El archivo JSON no encontrado");
                return;
            }

            string json = File.ReadAllText(jsonPath);

        }


    }
}
