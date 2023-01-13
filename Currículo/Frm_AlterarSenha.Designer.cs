namespace Currículo
{
    partial class Frm_AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AlterarSenha));
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Confirmar = new System.Windows.Forms.TextBox();
            this.Lbl_Confirmar = new System.Windows.Forms.Label();
            this.Lbl_TituloAlterarSenha = new System.Windows.Forms.Label();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Cb_MostrarSenha = new System.Windows.Forms.CheckBox();
            this.Lbl_VoltarCurriculo = new System.Windows.Forms.Label();
            this.Lbl_DigiteSenha = new System.Windows.Forms.Label();
            this.Lbl_DigiteConfirmar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(126, 77);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(356, 20);
            this.Txt_Senha.TabIndex = 1;
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Senha.Location = new System.Drawing.Point(24, 79);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(96, 18);
            this.Lbl_Senha.TabIndex = 5;
            this.Lbl_Senha.Text = "Senha nova:";
            // 
            // Txt_Confirmar
            // 
            this.Txt_Confirmar.Location = new System.Drawing.Point(126, 130);
            this.Txt_Confirmar.Name = "Txt_Confirmar";
            this.Txt_Confirmar.PasswordChar = '*';
            this.Txt_Confirmar.Size = new System.Drawing.Size(356, 20);
            this.Txt_Confirmar.TabIndex = 2;
            this.Txt_Confirmar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Confirmar_KeyDown);
            // 
            // Lbl_Confirmar
            // 
            this.Lbl_Confirmar.AutoSize = true;
            this.Lbl_Confirmar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Confirmar.Location = new System.Drawing.Point(24, 132);
            this.Lbl_Confirmar.Name = "Lbl_Confirmar";
            this.Lbl_Confirmar.Size = new System.Drawing.Size(82, 18);
            this.Lbl_Confirmar.TabIndex = 7;
            this.Lbl_Confirmar.Text = "Confirmar:";
            // 
            // Lbl_TituloAlterarSenha
            // 
            this.Lbl_TituloAlterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_TituloAlterarSenha.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloAlterarSenha.Location = new System.Drawing.Point(0, 0);
            this.Lbl_TituloAlterarSenha.Name = "Lbl_TituloAlterarSenha";
            this.Lbl_TituloAlterarSenha.Size = new System.Drawing.Size(511, 46);
            this.Lbl_TituloAlterarSenha.TabIndex = 8;
            this.Lbl_TituloAlterarSenha.Text = "Alterar Senha";
            this.Lbl_TituloAlterarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(382, 217);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(100, 37);
            this.Btn_Salvar.TabIndex = 4;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Cb_MostrarSenha
            // 
            this.Cb_MostrarSenha.AutoSize = true;
            this.Cb_MostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cb_MostrarSenha.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Cb_MostrarSenha.Location = new System.Drawing.Point(27, 180);
            this.Cb_MostrarSenha.Name = "Cb_MostrarSenha";
            this.Cb_MostrarSenha.Size = new System.Drawing.Size(129, 22);
            this.Cb_MostrarSenha.TabIndex = 3;
            this.Cb_MostrarSenha.Text = "Mostrar senha";
            this.Cb_MostrarSenha.UseVisualStyleBackColor = true;
            this.Cb_MostrarSenha.CheckedChanged += new System.EventHandler(this.Cb_MostrarSenha_CheckedChanged);
            // 
            // Lbl_VoltarCurriculo
            // 
            this.Lbl_VoltarCurriculo.AutoSize = true;
            this.Lbl_VoltarCurriculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_VoltarCurriculo.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Lbl_VoltarCurriculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_VoltarCurriculo.Location = new System.Drawing.Point(24, 226);
            this.Lbl_VoltarCurriculo.Name = "Lbl_VoltarCurriculo";
            this.Lbl_VoltarCurriculo.Size = new System.Drawing.Size(164, 17);
            this.Lbl_VoltarCurriculo.TabIndex = 11;
            this.Lbl_VoltarCurriculo.Text = "Voltar para o currículo";
            this.Lbl_VoltarCurriculo.Click += new System.EventHandler(this.Lbl_VoltarCurriculo_Click);
            // 
            // Lbl_DigiteSenha
            // 
            this.Lbl_DigiteSenha.AutoSize = true;
            this.Lbl_DigiteSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_DigiteSenha.Location = new System.Drawing.Point(123, 100);
            this.Lbl_DigiteSenha.Name = "Lbl_DigiteSenha";
            this.Lbl_DigiteSenha.Size = new System.Drawing.Size(0, 15);
            this.Lbl_DigiteSenha.TabIndex = 13;
            // 
            // Lbl_DigiteConfirmar
            // 
            this.Lbl_DigiteConfirmar.AutoSize = true;
            this.Lbl_DigiteConfirmar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_DigiteConfirmar.Location = new System.Drawing.Point(123, 153);
            this.Lbl_DigiteConfirmar.Name = "Lbl_DigiteConfirmar";
            this.Lbl_DigiteConfirmar.Size = new System.Drawing.Size(0, 15);
            this.Lbl_DigiteConfirmar.TabIndex = 14;
            // 
            // Frm_AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(511, 281);
            this.Controls.Add(this.Lbl_DigiteConfirmar);
            this.Controls.Add(this.Lbl_DigiteSenha);
            this.Controls.Add(this.Lbl_VoltarCurriculo);
            this.Controls.Add(this.Cb_MostrarSenha);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Lbl_TituloAlterarSenha);
            this.Controls.Add(this.Txt_Confirmar);
            this.Controls.Add(this.Lbl_Confirmar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Lbl_Senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.TextBox Txt_Confirmar;
        private System.Windows.Forms.Label Lbl_Confirmar;
        private System.Windows.Forms.Label Lbl_TituloAlterarSenha;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.CheckBox Cb_MostrarSenha;
        private System.Windows.Forms.Label Lbl_VoltarCurriculo;
        private System.Windows.Forms.Label Lbl_DigiteSenha;
        private System.Windows.Forms.Label Lbl_DigiteConfirmar;
    }
}