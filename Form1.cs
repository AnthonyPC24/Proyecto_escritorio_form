namespace Beatrix_Formulario
{
    public partial class BeatrixForm : Form
    {
        public BeatrixForm()
        {
            InitializeComponent();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Form inicio = new Form();
            inicio.ShowDialog();
        }

        private void Beatrix_Load(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {
           

        }
    }
}
