namespace Currículo
{
    partial class Frm_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro));
            this.Lbl_TituloCriarConta = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Confirmar = new System.Windows.Forms.TextBox();
            this.Lbl_Confirmar = new System.Windows.Forms.Label();
            this.Cb_MostrarSenha = new System.Windows.Forms.CheckBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Lbl_LoginEmVezDisso = new System.Windows.Forms.Label();
            this.Lbl_DigiteUsuario = new System.Windows.Forms.Label();
            this.Lbl_DigiteSenha = new System.Windows.Forms.Label();
            this.Lbl_DigiteConfirmar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_TituloCriarConta
            // 
            this.Lbl_TituloCriarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_TituloCriarConta.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloCriarConta.Location = new System.Drawing.Point(0, 0);
            this.Lbl_TituloCriarConta.Name = "Lbl_TituloCriarConta";
            this.Lbl_TituloCriarConta.Size = new System.Drawing.Size(548, 53);
            this.Lbl_TituloCriarConta.TabIndex = 2;
            this.Lbl_TituloCriarConta.Text = "Criar sua Conta";
            this.Lbl_TituloCriarConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(102, 87);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(407, 20);
            this.Txt_Usuario.TabIndex = 1;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Usuario.Location = new System.Drawing.Point(29, 89);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(67, 18);
            this.Lbl_Usuario.TabIndex = 5;
            this.Lbl_Usuario.Text = "Usuário:";
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(102, 140);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(154, 20);
            this.Txt_Senha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Senha:";
            // 
            // Txt_Confirmar
            // 
            this.Txt_Confirmar.Location = new System.Drawing.Point(355, 140);
            this.Txt_Confirmar.Name = "Txt_Confirmar";
            this.Txt_Confirmar.PasswordChar = '*';
            this.Txt_Confirmar.Size = new System.Drawing.Size(154, 20);
            this.Txt_Confirmar.TabIndex = 3;
            this.Txt_Confirmar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Confirmar_KeyDown);
            // 
            // Lbl_Confirmar
            // 
            this.Lbl_Confirmar.AutoSize = true;
            this.Lbl_Confirmar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Confirmar.Location = new System.Drawing.Point(267, 140);
            this.Lbl_Confirmar.Name = "Lbl_Confirmar";
            this.Lbl_Confirmar.Size = new System.Drawing.Size(82, 18);
            this.Lbl_Confirmar.TabIndex = 9;
            this.Lbl_Confirmar.Text = "Confirmar:";
            // 
            // Cb_MostrarSenha
            // 
            this.Cb_MostrarSenha.AutoSize = true;
            this.Cb_MostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cb_MostrarSenha.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Cb_MostrarSenha.Location = new System.Drawing.Point(32, 190);
            this.Cb_MostrarSenha.Name = "Cb_MostrarSenha";
            this.Cb_MostrarSenha.Size = new System.Drawing.Size(129, 22);
            this.Cb_MostrarSenha.TabIndex = 4;
            this.Cb_MostrarSenha.Text = "Mostrar senha";
            this.Cb_MostrarSenha.UseVisualStyleBackColor = true;
            this.Cb_MostrarSenha.CheckedChanged += new System.EventHandler(this.Cb_MostrarSenha_CheckedChanged);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(409, 232);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(100, 37);
            this.Btn_Salvar.TabIndex = 6;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Lbl_LoginEmVezDisso
            // 
            this.Lbl_LoginEmVezDisso.AutoSize = true;
            this.Lbl_LoginEmVezDisso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_LoginEmVezDisso.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Lbl_LoginEmVezDisso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_LoginEmVezDisso.Location = new System.Drawing.Point(29, 241);
            this.Lbl_LoginEmVezDisso.Name = "Lbl_LoginEmVezDisso";
            this.Lbl_LoginEmVezDisso.Size = new System.Drawing.Size(180, 17);
            this.Lbl_LoginEmVezDisso.TabIndex = 5;
            this.Lbl_LoginEmVezDisso.Text = "Fazer login em vez disso";
            this.Lbl_LoginEmVezDisso.Click += new System.EventHandler(this.Lbl_LoginEmVezDisso_Click);
            // 
            // Lbl_DigiteUsuario
            // 
            this.Lbl_DigiteUsuario.AutoSize = true;
            this.Lbl_DigiteUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_DigiteUsuario.Location = new System.Drawing.Point(99, 110);
            this.Lbl_DigiteUsuario.Name = "Lbl_DigiteUsuario";
            this.Lbl_DigiteUsuario.Size = new System.Drawing.Size(0, 15);
            this.Lbl_DigiteUsuario.TabIndex = 10;
            // 
            // Lbl_DigiteSenha
            // 
            this.Lbl_DigiteSenha.AutoSize = true;
            this.Lbl_DigiteSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_DigiteSenha.Location = new System.Drawing.Point(99, 163);
            this.Lbl_DigiteSenha.Name = "Lbl_DigiteSenha";
            this.Lbl_DigiteSenha.Size = new System.Drawing.Size(0, 15);
            this.Lbl_DigiteSenha.TabIndex = 11;
            // 
            // Lbl_DigiteConfirmar
            // 
            this.Lbl_DigiteConfirmar.AutoSize = true;
            this.Lbl_DigiteConfirmar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_DigiteConfirmar.Location = new System.Drawing.Point(352, 163);
            this.Lbl_DigiteConfirmar.Name = "Lbl_DigiteConfirmar";
            this.Lbl_DigiteConfirmar.Size = new System.Drawing.Size(0, 15);
            this.Lbl_DigiteConfirmar.TabIndex = 12;
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(548, 297);
            this.Controls.Add(this.Lbl_DigiteConfirmar);
            this.Controls.Add(this.Lbl_DigiteSenha);
            this.Controls.Add(this.Lbl_DigiteUsuario);
            this.Controls.Add(this.Lbl_LoginEmVezDisso);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Cb_MostrarSenha);
            this.Controls.Add(this.Txt_Confirmar);
            this.Controls.Add(this.Lbl_Confirmar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_TituloCriarConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TituloCriarConta;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Confirmar;
        private System.Windows.Forms.Label Lbl_Confirmar;
        private System.Windows.Forms.CheckBox Cb_MostrarSenha;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Label Lbl_LoginEmVezDisso;
        private System.Windows.Forms.Label Lbl_DigiteUsuario;
        private System.Windows.Forms.Label Lbl_DigiteSenha;
        private System.Windows.Forms.Label Lbl_DigiteConfirmar;
    }
}