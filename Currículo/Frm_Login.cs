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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Lbl_CriarConta_Click(object sender, EventArgs e)
        {
            Hide();
            var F = new Frm_Cadastro();
            F.ShowDialog();

            Txt_Usuario.Text = "";
            Txt_Senha.Text = "";
            Lbl_DigiteUsuario.Text = "";
            Lbl_DigiteSenha.Text = "";
            Show();
            Txt_Usuario.Focus();
            Cb_MostrarSenha.Checked = false;
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            if (Txt_Usuario.Text.Trim() == "")
            {
                Lbl_DigiteUsuario.Text = "Digite um nome de usuário";
            }
            else
            {
                Lbl_DigiteUsuario.Text = "";
            }
            if (Txt_Senha.Text.Trim() == "")
            {
                Lbl_DigiteSenha.Text = "Digite uma senha";
            }
            else
            {
                Lbl_DigiteSenha.Text = "";
            }

            if (Txt_Usuario.Text.Trim() != "" && Txt_Senha.Text.Trim() != "")
            {
                if (Cls_LoginCadastroSenha.ValidarLogin(Txt_Usuario.Text, Txt_Senha.Text))
                {
                    Hide();
                    var F = new Frm_Curriculo();
                    F.ShowDialog();

                    Txt_Usuario.Text = "";
                    Txt_Senha.Text = "";
                    Lbl_DigiteUsuario.Text = "";
                    Lbl_DigiteSenha.Text = "";
                    Show();
                    Txt_Usuario.Focus();
                    Cb_MostrarSenha.Checked = false;
                }
                else
                {
                    Lbl_DigiteSenha.Text = "Usuário ou senha incorretos";
                }
            }
        }

        private void Cb_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (!Cb_MostrarSenha.Checked)
            {
                Txt_Senha.PasswordChar = '*';
            }
            else
            {
                Txt_Senha.PasswordChar = '\0';
            }
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Entrar_Click(sender, e);
            }
        }
    }
}
