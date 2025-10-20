namespace Beatrix_Formulario
{
    partial class BeatrixForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonLogin = new Button();
            Logo = new PictureBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            labelTitle = new Label();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 14F);
            buttonLogin.Location = new Point(317, 295);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(166, 30);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Entrar";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.None;
            Logo.BackColor = SystemColors.ButtonHighlight;
            Logo.BackgroundImage = Properties.Resources.Logo;
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Location = new Point(325, 38);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(144, 120);
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            Logo.Click += Logo_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(298, 213);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(210, 29);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Microsoft Sans Serif", 12F);
            txtContrasena.Location = new Point(298, 243);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(210, 26);
            txtContrasena.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ActiveCaptionText;
            labelTitle.Location = new Point(325, 160);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(150, 45);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "BEATRIX";
            labelTitle.Click += label1_Click;
            // 
            // BeatrixForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_;
            ClientSize = new Size(829, 398);
            Controls.Add(labelTitle);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(Logo);
            Controls.Add(buttonLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BeatrixForm";
            Text = "Beatrix";
            Load += Beatrix_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private PictureBox Logo;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label labelTitle;
        private BindingSource bindingSource1;
    }
}
