namespace Currículo
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Lbl_TituloLogin = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            this.Lbl_CriarConta = new System.Windows.Forms.Label();
            this.Cb_MostrarSenha = new System.Windows.Forms.CheckBox();
            this.Lbl_DigiteUsuario = new System.Windows.Forms.Label();
            this.Lbl_DigiteSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_TituloLogin
            // 
            this.Lbl_TituloLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_TituloLogin.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloLogin.Location = new System.Drawing.Point(0, 0);
            this.Lbl_TituloLogin.Name = "Lbl_TituloLogin";
            this.Lbl_TituloLogin.Size = new System.Drawing.Size(511, 46);
            this.Lbl_TituloLogin.TabIndex = 1;
            this.Lbl_TituloLogin.Text = "Login";
            this.Lbl_TituloLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Usuario.Location = new System.Drawing.Point(25, 79);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(67, 18);
            this.Lbl_Usuario.TabIndex = 2;
            this.Lbl_Usuario.Text = "Usuário:";
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Senha.Location = new System.Drawing.Point(25, 132);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(57, 18);
            this.Lbl_Senha.TabIndex = 3;
            this.Lbl_Senha.Text = "Senha:";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(98, 77);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(385, 20);
            this.Txt_Usuario.TabIndex = 1;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(98, 130);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(385, 20);
            this.Txt_Senha.TabIndex = 2;
            this.Txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyDown);
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Entrar.Location = new System.Drawing.Point(383, 219);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(100, 37);
            this.Btn_Entrar.TabIndex = 5;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = false;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // Lbl_CriarConta
            // 
            this.Lbl_CriarConta.AutoSize = true;
            this.Lbl_CriarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_CriarConta.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CriarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_CriarConta.Location = new System.Drawing.Point(25, 228);
            this.Lbl_CriarConta.Name = "Lbl_CriarConta";
            this.Lbl_CriarConta.Size = new System.Drawing.Size(86, 17);
            this.Lbl_CriarConta.TabIndex = 4;
            this.Lbl_CriarConta.Text = "Criar conta";
            this.Lbl_CriarConta.Click += new System.EventHandler(this.Lbl_CriarConta_Click);
            // 
            // Cb_MostrarSenha
            // 
            this.Cb_MostrarSenha.AutoSize = true;
            this.Cb_MostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cb_MostrarSenha.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Cb_MostrarSenha.Location = new System.Drawing.Point(28, 180);
            this.Cb_MostrarSenha.Name = "Cb_MostrarSenha";
            this.Cb_MostrarSenha.Size = new System.Drawing.Size(129, 22);
            this.Cb_MostrarSenha.TabIndex = 3;
            this.Cb_MostrarSenha.Text = "Mostrar senha";
            this.Cb_MostrarSenha.UseVisualStyleBackColor = true;
            this.Cb_MostrarSenha.CheckedChanged += new System.EventHandler(this.Cb_MostrarSenha_CheckedChanged);
            // 
            // Lbl_DigiteUsuario
            // 
            this.Lbl_DigiteUsuario.AutoSize = true;
            this.Lbl_DigiteUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_DigiteUsuario.Location = new System.Drawing.Point(95, 100);
            this.Lbl_DigiteUsuario.Name = "Lbl_DigiteUsuario";
            this.Lbl_DigiteUsuario.Size = new System.Drawing.Size(0, 15);
            this.Lbl_DigiteUsuario.TabIndex = 6;
            // 
            // Lbl_DigiteSenha
            // 
            this.Lbl_DigiteSenha.AutoSize = true;
            this.Lbl_DigiteSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_DigiteSenha.Location = new System.Drawing.Point(95, 153);
            this.Lbl_DigiteSenha.Name = "Lbl_DigiteSenha";
            this.Lbl_DigiteSenha.Size = new System.Drawing.Size(0, 15);
            this.Lbl_DigiteSenha.TabIndex = 7;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(511, 281);
            this.Controls.Add(this.Lbl_DigiteSenha);
            this.Controls.Add(this.Lbl_DigiteUsuario);
            this.Controls.Add(this.Cb_MostrarSenha);
            this.Controls.Add(this.Lbl_CriarConta);
            this.Controls.Add(this.Btn_Entrar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_TituloLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TituloLogin;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Button Btn_Entrar;
        private System.Windows.Forms.Label Lbl_CriarConta;
        private System.Windows.Forms.CheckBox Cb_MostrarSenha;
        private System.Windows.Forms.Label Lbl_DigiteUsuario;
        private System.Windows.Forms.Label Lbl_DigiteSenha;
    }
}