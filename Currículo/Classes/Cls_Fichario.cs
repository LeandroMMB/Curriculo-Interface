using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Currículo.Classes
{
    public class Cls_Fichario
    {
        public string diretorioTxt;
        public string diretorioJson;
        public string mensagem;
        public bool status;

        public Cls_Fichario(string DiretorioTxt, string DiretorioJson)
        {
            status = true;
            try
            {
                var id = Cls_UsuarioLogado.Id;
                var diretorioUsuarios = Cls_LoginCadastroSenha.diretorioUsuarios;

                var diretorioTxtCompleto = $@"{diretorioUsuarios}\{id}\{DiretorioTxt}";
                var diretorioJsonCompleto = $@"{diretorioUsuarios}\{id}\{DiretorioJson}";

                if (!Directory.Exists(diretorioTxtCompleto))
                {
                    Directory.CreateDirectory(diretorioTxtCompleto);
                }
                diretorioTxt = diretorioTxtCompleto;

                if (!Directory.Exists(diretorioJsonCompleto))
                {
                    Directory.CreateDirectory(diretorioJsonCompleto);
                }
                diretorioJson = diretorioJsonCompleto;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com erro: " + ex.Message;
            }
        }

        public void Salvar(string idGerado, string idCurriculoSelecionado, string curriculoTxt, string curriculoJson)
        {
            status = true;
            try
            {
                var senha = Cls_UsuarioLogado.Senha;
                curriculoTxt = Cls_Criptografia.EncriptarSenha(curriculoTxt, senha);
                curriculoJson = Cls_Criptografia.EncriptarSenha(curriculoJson, senha);

                if (idCurriculoSelecionado != "")
                {
                    File.Delete($@"{diretorioTxt}\{idCurriculoSelecionado} - Currículo.txt");
                    File.Delete($@"{diretorioJson}\{idCurriculoSelecionado} - Currículo.json");

                    File.AppendAllText($@"{diretorioTxt}\{idCurriculoSelecionado} - Currículo.txt", curriculoTxt);
                    File.AppendAllText($@"{diretorioJson}\{idCurriculoSelecionado} - Currículo.json", curriculoJson);

                    MessageBox.Show("Currículo alterado com sucesso.");
                }
                else
                {
                    File.AppendAllText($@"{diretorioTxt}\{idGerado} - Currículo.txt", curriculoTxt);
                    File.AppendAllText($@"{diretorioJson}\{idGerado} - Currículo.json", curriculoJson);

                    MessageBox.Show("Currículo salvo com sucesso.");
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao salvar currículo: " + ex.Message;
            }
        }

        public string BuscarCurriculoJson(string nome)
        {
            status = true;
            try
            {
                var curriculo = File.ReadAllText($@"{diretorioJson}\{nome} - Currículo.json");
                var senha = Cls_UsuarioLogado.Senha;

                curriculo = Cls_Criptografia.DecriptarSenha(curriculo, senha);
                return curriculo;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o currículo: " + ex.Message;
            }
            return "";
        }

        public List<string> BuscarTodosCurriculosJson()
        {
            status = true;
            var lista = new List<string>();
            try
            {
                var curriculosJson = Directory.GetFiles(diretorioJson, "*.json");
                for (int i = 0; i < curriculosJson.Length; i++)
                {
                    var conteudo = File.ReadAllText(curriculosJson[i]);

                    var senha = Cls_UsuarioLogado.Senha;
                    conteudo = Cls_Criptografia.DecriptarSenha(conteudo, senha);

                    lista.Add(conteudo);
                }
                return lista;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            return lista;
        }

        public void Apagar(string id)
        {
            status = true;
            try
            {
                if (File.Exists($@"{diretorioJson}\{id} - Currículo.json") && File.Exists($@"{diretorioTxt}\{id} - Currículo.txt"))
                {
                    File.Delete($@"{diretorioJson}\{id} - Currículo.json");
                    File.Delete($@"{diretorioTxt}\{id} - Currículo.txt");

                    mensagem = "Exclusão executada com sucesso.";
                }
                else
                {
                    status = false;
                    mensagem = $"Currículo de {id} não encontrado.";
                }
                return;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao excluir o currículo: " + ex.Message;
            }
        }
    }
}