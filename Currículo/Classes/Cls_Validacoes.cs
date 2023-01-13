using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currículo.Classes
{
    public class Cls_Validacoes
    {
        public static bool ValidarId(string id, string diretorioJson)
        {
            if (File.Exists($@"{diretorioJson}\{id} - Currículo.json") && id.Length != 6)
            {
                return false;
            }
            return true;
        }

        public static bool ValidarNome(string nome)
        {
            if (nome != "")
            {
                if (nome.Length >= 3)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Nome deve conter mais de 3 caracteres.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Nome é obrigatório.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarEmail(string email)
        {
            if (email != "")
            {
                if (email.IndexOf('@') >= 5 && (email.IndexOf('.', email.IndexOf('@')) - email.IndexOf('@')) > 2)
                {
                    if (email.IndexOf('@') != -1 && email.IndexOf('.', email.IndexOf('@')) != -1 && !email.EndsWith("."))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Email inválido.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Email inválido.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Email é obrigatório.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarTelefone(string telefone)
        {
            if (telefone.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "")
            {
                if (telefone.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length == 11)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Telefone deve conter 11 números.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Telefone é obrigatório.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarCEP(string cep)
        {
            if (cep.Replace(".", "").Replace("-", "").Trim() != "")
            {
                if (cep.Replace(".", "").Replace("-", "").Trim().Length == 8)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("CEP deve conter 8 números.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("CEP é obrigatório.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarLogradouro(string logradouro)
        {
            if (logradouro != "")
            {
                if (logradouro.Length <= 100)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Logradouro deve conter até 100 caracteres.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Logradouro é obrigatório.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarNumero(string numero)
        {
            if (numero != "")
            {
                if (uint.TryParse(numero, out _))
                {
                    if (numero.Length <= 10)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Número deve conter até 10 números.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Número só deve conter números.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Número é obrigatório.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarBairro(string numero)
        {
            if (numero != "")
            {
                if (numero.Length <= 80)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Bairro deve conter até 80 caracteres.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Bairro é obrigatório.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarCidade(string cidade)
        {
            if (cidade != "")
            {
                if (cidade.Length <= 80)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Cidade deve conter até 80 caracteres.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Cidade é obrigatório.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarUF(string uf)
        {
            if (uf != "")
            {
                if (uf.Length == 2)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("UF deve conter 2 caracteres.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("UF é obrigatório.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarBlog(string url, string blogHabilitado)
        {
            if (blogHabilitado == "Sim")
            {
                if (url != "")
                {
                    if (url.StartsWith("https://") || url.StartsWith("http://"))
                    {
                        if (url.EndsWith(".com") || url.EndsWith(".com.br"))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("URL incompleta. Falta '.com' ou '.com.br'.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("URL incompleta. Falta 'https://' ou 'http://'.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Digite a URL do site/blog.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (blogHabilitado == "Não")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Possui site ou blog é obrigatório.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidarQualificacoes(string qualidade1, string qualidade2, string qualidade3)
        {
            if (qualidade1 != "" && qualidade2 != "" && qualidade3 != "")
            {
                return true;
            }
            MessageBox.Show("São necessárias pelo menos 3 qualidades.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public static bool ValidarCursos(string curso)
        {
            if (curso != "")
            {
                return true;
            }
            MessageBox.Show("É necessário pelo menos 1 curso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}