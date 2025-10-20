namespace Beatrix_Formulario
{
    partial class Inicio
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnReunion = new Button();
            btnTareas = new Button();
            btnProyectos = new Button();
            btnInicio = new Button();
            fotoUsuario = new PictureBox();
            panel1 = new Panel();
            lblNombreUsuario = new Label();
            monthCalendar = new MonthCalendar();
            comboBoxProyecto = new ComboBox();
            dataGridViewTarea = new DataGridView();
            ColumnTarea = new DataGridViewTextBoxColumn();
            ColumnEspecificaciones = new DataGridViewTextBoxColumn();
            ColumnUsuario = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnIdioma = new Button();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarea).BeginInit();
            SuspendLayout();
            // 
            // btnReunion
            // 
            btnReunion.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReunion.Location = new Point(44, 442);
            btnReunion.Name = "btnReunion";
            btnReunion.Size = new Size(155, 45);
            btnReunion.TabIndex = 4;
            btnReunion.Text = "Reuniones";
            btnReunion.UseVisualStyleBackColor = true;
            // 
            // btnTareas
            // 
            btnTareas.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            btnTareas.Location = new Point(44, 382);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(155, 45);
            btnTareas.TabIndex = 3;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = true;
            // 
            // btnProyectos
            // 
            btnProyectos.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            btnProyectos.Location = new Point(44, 322);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(155, 45);
            btnProyectos.TabIndex = 2;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.Location = new Point(44, 261);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(155, 45);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // fotoUsuario
            // 
            fotoUsuario.Location = new Point(53, 54);
            fotoUsuario.Name = "fotoUsuario";
            fotoUsuario.Size = new Size(125, 125);
            fotoUsuario.TabIndex = 1;
            fotoUsuario.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 191, 205);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Controls.Add(fotoUsuario);
            panel1.Controls.Add(btnReunion);
            panel1.Controls.Add(btnTareas);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnProyectos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 531);
            panel1.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(92, 200);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(51, 24);
            lblNombreUsuario.TabIndex = 5;
            lblNombreUsuario.Text = "label1";
            // 
            // monthCalendar
            // 
            monthCalendar.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar.Location = new Point(273, 292);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 6;
            // 
            // comboBoxProyecto
            // 
            comboBoxProyecto.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxProyecto.FormattingEnabled = true;
            comboBoxProyecto.Items.AddRange(new object[] { "Proyecto 1", "Proyecto 2", "Proyecto 3" });
            comboBoxProyecto.Location = new Point(273, 12);
            comboBoxProyecto.Name = "comboBoxProyecto";
            comboBoxProyecto.Size = new Size(151, 32);
            comboBoxProyecto.TabIndex = 7;
            comboBoxProyecto.Text = "Proyecto 1";
            comboBoxProyecto.SelectedIndexChanged += comboBoxProyecto_SelectedIndexChanged;
            // 
            // dataGridViewTarea
            // 
            dataGridViewTarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTarea.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewTarea.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTarea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarea.Columns.AddRange(new DataGridViewColumn[] { ColumnTarea, ColumnEspecificaciones, ColumnUsuario });
            dataGridViewTarea.GridColor = SystemColors.Control;
            dataGridViewTarea.Location = new Point(273, 54);
            dataGridViewTarea.Name = "dataGridViewTarea";
            dataGridViewTarea.ReadOnly = true;
            dataGridViewTarea.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTarea.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTarea.Size = new Size(651, 217);
            dataGridViewTarea.TabIndex = 10;
            // 
            // ColumnTarea
            // 
            ColumnTarea.HeaderText = "Tarea";
            ColumnTarea.MinimumWidth = 6;
            ColumnTarea.Name = "ColumnTarea";
            ColumnTarea.ReadOnly = true;
            // 
            // ColumnEspecificaciones
            // 
            ColumnEspecificaciones.HeaderText = "Especificaciones";
            ColumnEspecificaciones.MinimumWidth = 6;
            ColumnEspecificaciones.Name = "ColumnEspecificaciones";
            ColumnEspecificaciones.ReadOnly = true;
            // 
            // ColumnUsuario
            // 
            ColumnUsuario.HeaderText = "Usuario/s";
            ColumnUsuario.MinimumWidth = 6;
            ColumnUsuario.Name = "ColumnUsuario";
            ColumnUsuario.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(568, 292);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(356, 207);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // btnIdioma
            // 
            btnIdioma.Location = new Point(867, 11);
            btnIdioma.Name = "btnIdioma";
            btnIdioma.Size = new Size(57, 29);
            btnIdioma.TabIndex = 12;
            btnIdioma.UseVisualStyleBackColor = true;
            btnIdioma.Click += btnIdioma_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(0, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(86, 31);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Beatrix";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(947, 531);
            Controls.Add(btnIdioma);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridViewTarea);
            Controls.Add(comboBoxProyecto);
            Controls.Add(monthCalendar);
            Controls.Add(panel1);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarea).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnInicio;
        private PictureBox fotoUsuario;
        private Button btnReunion;
        private Button btnTareas;
        private Button btnProyectos;
        private Panel panel1;
        private MonthCalendar monthCalendar;
        private ComboBox comboBoxProyecto;
        private DataGridView dataGridViewTarea;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnIdioma;
        private DataGridViewTextBoxColumn ColumnTarea;
        private DataGridViewTextBoxColumn ColumnEspecificaciones;
        private DataGridViewTextBoxColumn ColumnUsuario;
        private Label lblNombreUsuario;
        private Label lblNombre;
    }
}