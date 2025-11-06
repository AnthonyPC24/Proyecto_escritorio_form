namespace Beatrix_Formulario
{
    partial class FormProyectosGerard1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProyectosGerard1));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnReunion = new Button();
            btnTareas = new Button();
            btnInicio = new Button();
            btnProyectos = new Button();
            btnBuscar = new Button();
            txtBuscarProyecto = new TextBox();
            button2 = new Button();
            dataGridViewTarea = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ColumnUsuario = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarea).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 191, 205);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnReunion);
            panel1.Controls.Add(btnTareas);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnProyectos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 681);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(23, 93);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 156);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnReunion
            // 
            btnReunion.BackColor = Color.FromArgb(41, 191, 205);
            btnReunion.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReunion.ForeColor = SystemColors.ButtonHighlight;
            btnReunion.Location = new Point(12, 437);
            btnReunion.Margin = new Padding(3, 2, 3, 2);
            btnReunion.Name = "btnReunion";
            btnReunion.Size = new Size(186, 53);
            btnReunion.TabIndex = 4;
            btnReunion.Text = "Reuniones";
            btnReunion.UseVisualStyleBackColor = false;
            btnReunion.Click += btnReunion_Click;
            // 
            // btnTareas
            // 
            btnTareas.BackColor = Color.FromArgb(41, 191, 205);
            btnTareas.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTareas.ForeColor = Color.White;
            btnTareas.Location = new Point(12, 380);
            btnTareas.Margin = new Padding(3, 2, 3, 2);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(186, 53);
            btnTareas.TabIndex = 3;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = false;
            btnTareas.Click += btnTareas_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(41, 191, 205);
            btnInicio.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(12, 266);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(186, 53);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.BackColor = Color.FromArgb(41, 191, 205);
            btnProyectos.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProyectos.ForeColor = Color.White;
            btnProyectos.Location = new Point(12, 323);
            btnProyectos.Margin = new Padding(3, 2, 3, 2);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(186, 53);
            btnProyectos.TabIndex = 2;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = true;
            btnProyectos.Click += btnProyectos_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 191, 205);
            button1.ForeColor = Color.White;
            button1.Location = new Point(457, 21);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(92, 31);
            button1.TabIndex = 8;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(266, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 191, 205);
            label1.Location = new Point(266, 93);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 11;
            label1.Text = "+ Crear Proyeto";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(1176, 16);
            button2.Name = "button2";
            button2.Size = new Size(35, 29);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTarea
            // 
            dataGridViewTarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTarea.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewTarea.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTarea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarea.Columns.AddRange(new DataGridViewColumn[] { Column1, ColumnUsuario, Column2 });
            dataGridViewTarea.GridColor = SystemColors.Control;
            dataGridViewTarea.Location = new Point(266, 145);
            dataGridViewTarea.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTarea.Name = "dataGridViewTarea";
            dataGridViewTarea.ReadOnly = true;
            dataGridViewTarea.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTarea.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTarea.Size = new Size(973, 345);
            dataGridViewTarea.TabIndex = 18;
            dataGridViewTarea.CellContentClick += dataGridViewTarea_CellContentClick;
            dataGridViewTarea.SelectionChanged += dataGridViewTarea_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // ColumnUsuario
            // 
            ColumnUsuario.HeaderText = "Usuario/s";
            ColumnUsuario.MinimumWidth = 6;
            ColumnUsuario.Name = "ColumnUsuario";
            ColumnUsuario.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha de Entrega";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(457, 97);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(128, 32);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 191, 205);
            button4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(266, 97);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(172, 32);
            button4.TabIndex = 19;
            button4.Text = "+ Crear Proyecto";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // FormProyectosGerard1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(button4);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridViewTarea);
            Controls.Add(button2);
            Controls.Add(txtBuscarProyecto);
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Name = "FormProyectosGerard1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProyectosGerard1";
            Load += FormProyectosGerard1_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnReunion;
        private Button btnTareas;
        private Button btnInicio;
        private Button btnProyectos;
        private Button btnBuscar;
        private TextBox txtBuscarProyecto;
        private Button button2;
        private DataGridView dataGridViewTarea;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColumnUsuario;
        private DataGridViewTextBoxColumn Column2;
        private Button btnEliminar;
        private Button button4;
    }
}