using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currículo.Classes
{
    public class Cls_LoginCadastroSenha
    {
        readonly static string diretorio = "Usuarios.txt";

        public static bool SalvarDados(string usuario, string senha)
        {
            try
            {
                if (File.Exists(diretorio))
                {
                    var arquivo = File.ReadAllText(diretorio);
                    if (arquivo.Contains($"\n{usuario};"))
                    {
                        MessageBox.Show("Usuário já existente.", "Currículo");
                        return false;
                    }
                }

                File.AppendAllText(diretorio, $"\n{usuario};{senha}");

                MessageBox.Show("Conta salva com sucesso.", "Currículo");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar conta: " + ex.Message, "Currículo");
                return false;
            }
        }

        public static bool ValidarLogin(string usuario, string senha)
        {
            try
            {
                if (File.Exists(diretorio))
                {
                    var arquivo = File.ReadAllText(diretorio).Split('\n');

                    foreach (var item in arquivo)
                    {
                        if (item != "")
                        {
                            var user = item.Split(';')[0];
                            var password = item.Split(';')[1];

                            if (user == usuario && password == senha)
                            {
                                new Cls_UsuarioLogado(usuario, senha);
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao validar login: " + ex.Message, "Currículo");
                return false;
            }
        }

        public static bool AlterarSenha(string usuario, string senhaAntiga, string senhaNova)
        {
            try
            {
                var arquivo = File.ReadAllText(diretorio);
                var linha = arquivo.IndexOf($"\n{usuario};{senhaAntiga}");

                arquivo = arquivo.Remove(linha, usuario.Length + senhaAntiga.Length + 2);
                arquivo += $"\n{usuario};{senhaNova}";

                File.WriteAllText(diretorio, arquivo);
                MessageBox.Show("Senha alterada com sucesso.", "Currículo");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar senha: " + ex.Message, "Currículo");
                return false;
            }
        }
    }
}
