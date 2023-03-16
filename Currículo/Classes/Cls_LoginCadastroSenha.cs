using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currículo.Classes
{
    public class Cls_LoginCadastroSenha
    {
        readonly static string diretorioCriptografia = "UsuariosCrypto.txt";

        public static bool SalvarDados(string usuario, string senha)
        {
            try
            {
                var usuarioCripto = Cls_Criptografia.EncriptarUsuario(usuario);
                var senhaCripto = Cls_Criptografia.EncriptarSenha(senha, senha);

                if (File.Exists(diretorioCriptografia))
                {
                    var arquivo = File.ReadAllText(diretorioCriptografia);

                    if (arquivo.Contains($"\n{usuarioCripto};"))
                    {
                        MessageBox.Show("Usuário já existente.", "Currículo");
                        return false;
                    }
                }

                File.AppendAllText(diretorioCriptografia, "\n" + usuarioCripto + ";" + senhaCripto);

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
                if (File.Exists(diretorioCriptografia))
                {
                    var arquivo = File.ReadAllText(diretorioCriptografia).Split('\n');

                    foreach (var item in arquivo)
                    {
                        if (item != "")
                        {
                            var usuarioCripto = item.Split(';')[0];
                            var usuarioBD = Cls_Criptografia.EncriptarUsuario(usuario);

                            var senhaCripto = item.Split(';')[1];
                            var senhaBD = Cls_Criptografia.DecriptarSenha(senhaCripto, senha);
                            if (senhaBD == "false") continue;


                            if (usuarioCripto == usuarioBD && senha == senhaBD)
                            {
                                new Cls_UsuarioLogado(usuario, senha, senhaCripto);
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

        public static bool AlterarSenha(string usuario, string senhaAntiga, string senhaAntigaCripto, string senhaNova)
        {
            try
            {
                var arquivo = File.ReadAllText(diretorioCriptografia);

                var usuarioCripto = Cls_Criptografia.EncriptarUsuario(usuario);
                var senhaCripto = Cls_Criptografia.DecriptarSenha(senhaAntigaCripto, senhaAntiga);
                var senhaNovaCripto = Cls_Criptografia.EncriptarSenha(senhaNova, senhaNova);

                var linha = arquivo.IndexOf($"\n{usuarioCripto};{senhaAntigaCripto}");

                arquivo = arquivo.Remove(linha, usuarioCripto.Length + senhaAntigaCripto.Length + 2);
                arquivo += $"\n{usuarioCripto};{senhaNovaCripto}";

                File.WriteAllText(diretorioCriptografia, arquivo);
                MessageBox.Show("Senha alterada com sucesso.", "Currículo");

                new Cls_UsuarioLogado(usuario, senhaNova, senhaNovaCripto);
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
