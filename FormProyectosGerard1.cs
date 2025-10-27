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
    public partial class FormProyectosGerard1 : Form
    {
        private List<Proyectos> listaDeProyectos;

        private string rutaArchivoJson = @"JSON\Proyectos.JSON";

        public FormProyectosGerard1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (FormProyectosGerard2 formCrear = new FormProyectosGerard2())
            {
                DialogResult resultado = formCrear.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReunion_Click(object sender, EventArgs e)
        {

        }

        private void btnTareas_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTarea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
