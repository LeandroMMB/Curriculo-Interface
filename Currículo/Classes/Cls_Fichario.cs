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
                if (!Directory.Exists(DiretorioTxt))
                {
                    Directory.CreateDirectory(DiretorioTxt);
                }
                diretorioTxt = DiretorioTxt;

                if (!Directory.Exists(DiretorioJson))
                {
                    Directory.CreateDirectory(DiretorioJson);
                }
                diretorioJson = DiretorioJson;
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