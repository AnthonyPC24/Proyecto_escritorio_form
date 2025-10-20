namespace Beatrix_Formulario
{
    partial class FormTareasTho2
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
            groupBoxNuevaTarea = new GroupBox();
            labelDescripcionNuevaTarea = new Label();
            richTextBox1 = new RichTextBox();
            comboBoxUsuariosAsignarTareas = new ComboBox();
            dateTimePickerFechaTareaFin = new DateTimePicker();
            dateTimePickerFechaTareaInicio = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            textBoxNombreNuevaTarea = new TextBox();
            label1 = new Label();
            comboBoxProyectoNuevaTarea = new ComboBox();
            buttonCrearNuevaTarea = new Button();
            buttonCancelarTarea = new Button();
            groupBoxNuevaTarea.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxNuevaTarea
            // 
            groupBoxNuevaTarea.Controls.Add(labelDescripcionNuevaTarea);
            groupBoxNuevaTarea.Controls.Add(richTextBox1);
            groupBoxNuevaTarea.Controls.Add(comboBoxUsuariosAsignarTareas);
            groupBoxNuevaTarea.Controls.Add(dateTimePickerFechaTareaFin);
            groupBoxNuevaTarea.Controls.Add(dateTimePickerFechaTareaInicio);
            groupBoxNuevaTarea.Controls.Add(label3);
            groupBoxNuevaTarea.Controls.Add(label2);
            groupBoxNuevaTarea.Controls.Add(textBoxNombreNuevaTarea);
            groupBoxNuevaTarea.Location = new Point(12, 95);
            groupBoxNuevaTarea.Name = "groupBoxNuevaTarea";
            groupBoxNuevaTarea.Size = new Size(475, 258);
            groupBoxNuevaTarea.TabIndex = 4;
            groupBoxNuevaTarea.TabStop = false;
            // 
            // labelDescripcionNuevaTarea
            // 
            labelDescripcionNuevaTarea.AutoSize = true;
            labelDescripcionNuevaTarea.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            labelDescripcionNuevaTarea.Location = new Point(20, 141);
            labelDescripcionNuevaTarea.Name = "labelDescripcionNuevaTarea";
            labelDescripcionNuevaTarea.Size = new Size(80, 18);
            labelDescripcionNuevaTarea.TabIndex = 9;
            labelDescripcionNuevaTarea.Text = "Descripción";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            richTextBox1.Location = new Point(20, 165);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(434, 65);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // comboBoxUsuariosAsignarTareas
            // 
            comboBoxUsuariosAsignarTareas.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            comboBoxUsuariosAsignarTareas.FormattingEnabled = true;
            comboBoxUsuariosAsignarTareas.Location = new Point(20, 54);
            comboBoxUsuariosAsignarTareas.Name = "comboBoxUsuariosAsignarTareas";
            comboBoxUsuariosAsignarTareas.Size = new Size(166, 26);
            comboBoxUsuariosAsignarTareas.TabIndex = 7;
            // 
            // dateTimePickerFechaTareaFin
            // 
            dateTimePickerFechaTareaFin.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            dateTimePickerFechaTareaFin.Location = new Point(245, 108);
            dateTimePickerFechaTareaFin.Name = "dateTimePickerFechaTareaFin";
            dateTimePickerFechaTareaFin.Size = new Size(209, 22);
            dateTimePickerFechaTareaFin.TabIndex = 4;
            // 
            // dateTimePickerFechaTareaInicio
            // 
            dateTimePickerFechaTareaInicio.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            dateTimePickerFechaTareaInicio.Location = new Point(20, 108);
            dateTimePickerFechaTareaInicio.Name = "dateTimePickerFechaTareaInicio";
            dateTimePickerFechaTareaInicio.Size = new Size(209, 22);
            dateTimePickerFechaTareaInicio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            label3.Location = new Point(245, 85);
            label3.Name = "label3";
            label3.Size = new Size(124, 18);
            label3.TabIndex = 2;
            label3.Text = "Fecha de finalizado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            label2.Location = new Point(20, 86);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 1;
            label2.Text = "Fecha de inicio";
            // 
            // textBoxNombreNuevaTarea
            // 
            textBoxNombreNuevaTarea.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            textBoxNombreNuevaTarea.Location = new Point(20, 22);
            textBoxNombreNuevaTarea.Name = "textBoxNombreNuevaTarea";
            textBoxNombreNuevaTarea.PlaceholderText = "Nombre de la tarea";
            textBoxNombreNuevaTarea.Size = new Size(166, 22);
            textBoxNombreNuevaTarea.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat ExtraBold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 42);
            label1.TabIndex = 6;
            label1.Text = "Nueva Tarea";
            // 
            // comboBoxProyectoNuevaTarea
            // 
            comboBoxProyectoNuevaTarea.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxProyectoNuevaTarea.FormattingEnabled = true;
            comboBoxProyectoNuevaTarea.Location = new Point(12, 66);
            comboBoxProyectoNuevaTarea.Name = "comboBoxProyectoNuevaTarea";
            comboBoxProyectoNuevaTarea.Size = new Size(186, 26);
            comboBoxProyectoNuevaTarea.TabIndex = 1;
            comboBoxProyectoNuevaTarea.SelectedIndexChanged += comboBoxProyectoNuevaTarea_SelectedIndexChanged;
            // 
            // buttonCrearNuevaTarea
            // 
            buttonCrearNuevaTarea.BackColor = Color.White;
            buttonCrearNuevaTarea.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            buttonCrearNuevaTarea.Location = new Point(409, 359);
            buttonCrearNuevaTarea.Name = "buttonCrearNuevaTarea";
            buttonCrearNuevaTarea.Size = new Size(75, 23);
            buttonCrearNuevaTarea.TabIndex = 7;
            buttonCrearNuevaTarea.Text = "Crear";
            buttonCrearNuevaTarea.UseVisualStyleBackColor = false;
            // 
            // buttonCancelarTarea
            // 
            buttonCancelarTarea.BackColor = Color.White;
            buttonCancelarTarea.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            buttonCancelarTarea.Location = new Point(328, 359);
            buttonCancelarTarea.Name = "buttonCancelarTarea";
            buttonCancelarTarea.Size = new Size(75, 23);
            buttonCancelarTarea.TabIndex = 8;
            buttonCancelarTarea.Text = "Cancelar";
            buttonCancelarTarea.UseVisualStyleBackColor = false;
            // 
            // FormTareasTho2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 191, 225);
            ClientSize = new Size(496, 390);
            Controls.Add(buttonCancelarTarea);
            Controls.Add(buttonCrearNuevaTarea);
            Controls.Add(comboBoxProyectoNuevaTarea);
            Controls.Add(label1);
            Controls.Add(groupBoxNuevaTarea);
            Name = "FormTareasTho2";
            Text = "NuevaTarea";
            groupBoxNuevaTarea.ResumeLayout(false);
            groupBoxNuevaTarea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBoxNuevaTarea;
        private Label label1;
        private TextBox textBoxNombreNuevaTarea;
        private ComboBox comboBoxProyectoNuevaTarea;
        private DateTimePicker dateTimePickerFechaTareaInicio;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxUsuariosAsignarTareas;
        private DateTimePicker dateTimePickerFechaTareaFin;
        private Label labelDescripcionNuevaTarea;
        private RichTextBox richTextBox1;
        private Button buttonCrearNuevaTarea;
        private Button buttonCancelarTarea;
    }
}