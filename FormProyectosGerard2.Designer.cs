namespace Beatrix_Formulario
{
    partial class FormProyectosGerard2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProyectosGerard2));
            button2 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            btnCrear = new Button();
            label4 = new Label();
            monthCalendar = new MonthCalendar();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtUsuarios = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(1181, 24);
            button2.Name = "button2";
            button2.Size = new Size(35, 29);
            button2.TabIndex = 26;
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsuarios);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(monthCalendar);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(122, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 291);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            button3.Location = new Point(415, 240);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(316, 240);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(340, 19);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 7;
            label4.Text = "Duracion del Proyecto";
            label4.Click += label4_Click;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(307, 48);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 6;
            monthCalendar.DateChanged += monthCalendar1_DateChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(95, 169);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(147, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 172);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 111);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 51);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat ExtraBold", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(291, 23);
            label5.Name = "label5";
            label5.Size = new Size(223, 38);
            label5.TabIndex = 28;
            label5.Text = "Nuevo Proyecto";
            // 
            // txtUsuarios
            // 
            txtUsuarios.Location = new Point(95, 108);
            txtUsuarios.Name = "txtUsuarios";
            txtUsuarios.Size = new Size(147, 23);
            txtUsuarios.TabIndex = 10;
            // 
            // FormProyectosGerard2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 191, 205);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Name = "FormProyectosGerard2";
            Text = "FormProyectosGerard2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private MonthCalendar monthCalendar;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label3;
        private Button button3;
        private Button btnCrear;
        private Label label5;
        private TextBox txtUsuarios;
    }
}