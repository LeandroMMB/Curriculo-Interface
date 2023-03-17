using Currículo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currículo
{
    public partial class Frm_AlterarSenha : Form
    {
        private readonly string id;
        private readonly string usuario;
        private readonly string senha;
        private readonly string senhaCripto;

        public Frm_AlterarSenha(string Id, string Usuario, string Senha, string SenhaCripto)
        {
            id = Id;
            usuario = Usuario;
            senha = Senha;
            senhaCripto = SenhaCripto;
            InitializeComponent();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (Txt_Senha.Text.Trim() == "")
            {
                Lbl_DigiteSenha.Text = "Digite uma senha";
            }
            else
            {
                Lbl_DigiteSenha.Text = "";
            }
            if (Txt_Confirmar.Text.Trim() == "" && Txt_Senha.Text.Trim() != "")
            {
                Lbl_DigiteConfirmar.Text = "Confirme sua senha";
            }
            else
            {
                Lbl_DigiteConfirmar.Text = "";
            }

            if (Txt_Senha.Text.Trim() != "" && Txt_Confirmar.Text.Trim() != "")
            {
                if (Txt_Senha.Text == Txt_Confirmar.Text)
                {
                    if (Txt_Senha.Text != senha)
                    {
                        if (Cls_LoginCadastroSenha.AlterarSenha(id, usuario, senha, senhaCripto, Txt_Senha.Text))
                        {
                            Close();
                        }
                    }
                    else
                    {
                        Lbl_DigiteConfirmar.Text = "Sua nova senha não pode ser igual a antiga";
                    }
                }
                else
                {
                    Lbl_DigiteConfirmar.Text = "As senhas não são iguais. Tente novamente";
                }
            }
        }

        private void Cb_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (!Cb_MostrarSenha.Checked)
            {
                Txt_Senha.PasswordChar = '*';
                Txt_Confirmar.PasswordChar = '*';
            }
            else
            {
                Txt_Senha.PasswordChar = '\0';
                Txt_Confirmar.PasswordChar = '\0';
            }
        }

        private void Lbl_VoltarCurriculo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Txt_Confirmar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Salvar_Click(sender, e);
            }
        }
    }
}
