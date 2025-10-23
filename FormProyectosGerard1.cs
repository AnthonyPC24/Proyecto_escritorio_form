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
                // 2. Mostramos Form2 como un diálogo modal.
                // El código de Form1 se pausará aquí mismo
                // hasta que Form2 se cierre.
                DialogResult resultado = formCrear.ShowDialog();

                // 3. Cuando Form2 se cierra, el código continúa.
                // Comprobamos si el usuario hizo clic en "Crear".
                if (resultado == DialogResult.OK)
                {
                    // 4. Si pulsó "Crear", recuperamos el proyecto
                    // desde la propiedad pública que creamos en Form2.
                    Proyectos proyectoCreado = formCrear.NuevoProyecto;

                    // 5. (Opcional) Verificamos que no sea nulo
                    if (proyectoCreado != null)
                    {
                        // 6. Formateamos los datos para la tabla

                        // Unimos los nombres de los usuarios con una coma
                        // ej: ["Gerard", "Anna"] -> "Gerard, Anna"
                        string usuariosStr = string.Join(", ",
                            proyectoCreado.UsuariosAsignados.Select(u => u.nombreApellidos)
                        );

                        // 7. Añadimos la nueva fila al DataGridView
                        // (Asumiendo que tu tabla se llama 'dataGridView1')
                        dataGridViewTarea.Rows.Add(
                            proyectoCreado.NombreProyecto,
                            usuariosStr,
                            proyectoCreado.fechaEntrega.ToShortDateString()
                        );
                    }
                }
                // Si el resultado es 'DialogResult.Cancel',
                // simplemente no hace nada y el 'using' cierra el 'formCrear'.
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
