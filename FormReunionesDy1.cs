using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Beatrix_Formulario
{
    public partial class FormReunionesDy1 : Form
    {
        public FormReunionesDy1()
        {
            InitializeComponent();
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
            formReunionesDy2.Show();
        }
    }
} 
