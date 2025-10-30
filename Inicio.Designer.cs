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
            DataGridView dataGridViewTarea;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            dataGridViewTarea = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).BeginInit();
            panel1.SuspendLayout();
            panelTareaHoy.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTarea
            // 
            dataGridViewTarea.AllowUserToDeleteRows = false;
            dataGridViewTarea.AllowUserToResizeColumns = false;
            dataGridViewTarea.AllowUserToResizeRows = false;
            dataGridViewTarea.BackgroundColor = Color.White;
            dataGridViewTarea.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewTarea.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTarea.ColumnHeadersHeight = 50;
            dataGridViewTarea.Columns.AddRange(new DataGridViewColumn[] { ColumnTarea, ColumnEspecificaciones, ColumnUsuario });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTarea.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTarea.GridColor = Color.White;
            dataGridViewTarea.Location = new Point(273, 54);
            dataGridViewTarea.Name = "dataGridViewTarea";
            dataGridViewTarea.ReadOnly = true;
            dataGridViewTarea.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTarea.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTarea.RowHeadersVisible = false;
            dataGridViewTarea.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTarea.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTarea.Size = new Size(965, 281);
            dataGridViewTarea.TabIndex = 10;
            // 
            // ColumnTarea
            // 
            ColumnTarea.HeaderText = "Tarea";
            ColumnTarea.MinimumWidth = 6;
            ColumnTarea.Name = "ColumnTarea";
            ColumnTarea.ReadOnly = true;
            ColumnTarea.Width = 321;
            // 
            // ColumnEspecificaciones
            // 
            ColumnEspecificaciones.HeaderText = "Especificaciones";
            ColumnEspecificaciones.MinimumWidth = 6;
            ColumnEspecificaciones.Name = "ColumnEspecificaciones";
            ColumnEspecificaciones.ReadOnly = true;
            ColumnEspecificaciones.Width = 321;
            // 
            // ColumnUsuario
            // 
            ColumnUsuario.HeaderText = "Usuario/s";
            ColumnUsuario.MinimumWidth = 6;
            ColumnUsuario.Name = "ColumnUsuario";
            ColumnUsuario.ReadOnly = true;
            ColumnUsuario.Width = 321;
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
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelTareaHoy);
            Controls.Add(btnIdioma);
            Controls.Add(dataGridViewTarea);
            Controls.Add(comboBoxProyecto);
            Controls.Add(monthCalendar);
            Controls.Add(panel1);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarea).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTareaHoy.ResumeLayout(false);
            panelTareaHoy.PerformLayout();
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