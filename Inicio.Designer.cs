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
            DataGridView dgvTarea;
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            ColumnTarea = new DataGridViewTextBoxColumn();
            ColumnEspecificaciones = new DataGridViewTextBoxColumn();
            ColumnUsuario = new DataGridViewTextBoxColumn();
            btnReunion = new Button();
            btnTareas = new Button();
            btnProyectos = new Button();
            btnInicio = new Button();
            fotoUsuario = new PictureBox();
            panel1 = new Panel();
            lblNombre = new Label();
            lblNombreUsuario = new Label();
            monthCalendar = new MonthCalendar();
            comboBoxProyecto = new ComboBox();
            btnIdioma = new Button();
            panelTareaHoy = new Panel();
            labelHorario = new Label();
            labelTitle = new Label();
            dgvTarea = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).BeginInit();
            panel1.SuspendLayout();
            panelTareaHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).BeginInit();
            SuspendLayout();
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
            // btnReunion
            // 
            btnReunion.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReunion.Location = new Point(31, 535);
            btnReunion.Name = "btnReunion";
            btnReunion.Size = new Size(186, 63);
            btnReunion.TabIndex = 4;
            btnReunion.Text = "Reuniones";
            btnReunion.UseVisualStyleBackColor = true;
            // 
            // btnTareas
            // 
            btnTareas.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            btnTareas.Location = new Point(31, 456);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(186, 63);
            btnTareas.TabIndex = 3;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = true;
            // 
            // btnProyectos
            // 
            btnProyectos.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            btnProyectos.Location = new Point(31, 375);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(186, 63);
            btnProyectos.TabIndex = 2;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.Location = new Point(31, 297);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(186, 63);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // fotoUsuario
            // 
            fotoUsuario.Location = new Point(55, 54);
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
            panel1.Size = new Size(250, 673);
            panel1.TabIndex = 5;
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
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(93, 225);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(51, 24);
            lblNombreUsuario.TabIndex = 5;
            lblNombreUsuario.Text = "label1";
            // 
            // monthCalendar
            // 
            monthCalendar.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar.Location = new Point(273, 375);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 6;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
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
            // btnIdioma
            // 
            btnIdioma.Location = new Point(1181, 12);
            btnIdioma.Name = "btnIdioma";
            btnIdioma.Size = new Size(57, 29);
            btnIdioma.TabIndex = 12;
            btnIdioma.UseVisualStyleBackColor = true;
            btnIdioma.Click += btnIdioma_Click;
            // 
            // panelTareaHoy
            // 
            panelTareaHoy.BackColor = Color.FromArgb(0, 181, 200);
            panelTareaHoy.Controls.Add(labelHorario);
            panelTareaHoy.Controls.Add(labelTitle);
            panelTareaHoy.Location = new Point(788, 375);
            panelTareaHoy.Name = "panelTareaHoy";
            panelTareaHoy.Size = new Size(450, 269);
            panelTareaHoy.TabIndex = 13;
            // 
            // labelHorario
            // 
            labelHorario.AutoSize = true;
            labelHorario.Location = new Point(52, 81);
            labelHorario.Name = "labelHorario";
            labelHorario.Size = new Size(50, 20);
            labelHorario.TabIndex = 1;
            labelHorario.Text = "label1";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Playfair Display", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(189, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(85, 43);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "HOY";
            // 
            // dgvTarea
            // 
            dgvTarea.AllowUserToResizeColumns = false;
            dgvTarea.AllowUserToResizeRows = false;
            dgvTarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTarea.BackgroundColor = Color.White;
            dgvTarea.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvTarea.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTarea.ColumnHeadersHeight = 50;
            dgvTarea.Columns.AddRange(new DataGridViewColumn[] { ColumnTarea, ColumnEspecificaciones, ColumnUsuario });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTarea.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTarea.GridColor = Color.White;
            dgvTarea.Location = new Point(273, 54);
            dgvTarea.Name = "dgvTarea";
            dgvTarea.ReadOnly = true;
            dgvTarea.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvTarea.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvTarea.RowHeadersVisible = false;
            dgvTarea.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTarea.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvTarea.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTarea.RowTemplate.Height = 50;
            dgvTarea.Size = new Size(965, 281);
            dgvTarea.TabIndex = 10;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelTareaHoy);
            Controls.Add(btnIdioma);
            Controls.Add(dgvTarea);
            Controls.Add(comboBoxProyecto);
            Controls.Add(monthCalendar);
            Controls.Add(panel1);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTareaHoy.ResumeLayout(false);
            panelTareaHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).EndInit();
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
        private DataGridView dgvTarea;
        private Button btnIdioma;
        private Label lblNombreUsuario;
        private Label lblNombre;
        private DataGridViewTextBoxColumn ColumnTarea;
        private DataGridViewTextBoxColumn ColumnEspecificaciones;
        private DataGridViewTextBoxColumn ColumnUsuario;
        private Panel panelTareaHoy;
        private Label labelHorario;
        private Label labelTitle;
    }
}