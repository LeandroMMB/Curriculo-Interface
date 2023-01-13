using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Currículo.Classes
{
    public class Cls_Curriculo
    {
        public class Dados
        {
            public string Id { get; set; }
            public string Nome { get; set; }
            public string DataNascimento { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string CEP { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string PrimeiroEmprego { get; set; }
            public string TrabalhoRemoto { get; set; }
            public string Remuneracao { get; set; }
            public string PossuiSite { get; set; }
            public string URL { get; set; }
            public string Curso1 { get; set; }
            public string Curso2 { get; set; }
            public string Curso3 { get; set; }
            public string Curso4 { get; set; }
            public string Qualidades1 { get; set; }
            public string Qualidades2 { get; set; }
            public string Qualidades3 { get; set; }
            public string Qualidades4 { get; set; }

            public bool SalvarCurriculo(string diretorioTxt, string diretorioJson, string curriculoTxt, string idGerado, string idCurriculoSelecionado)
            {
                var F = new Cls_Fichario(diretorioTxt, diretorioJson);
                if (F.status)
                {
                    F.Salvar(idGerado, idCurriculoSelecionado, curriculoTxt, Serializar(this));
                    if (!F.status)
                    {
                        MessageBox.Show(F.mensagem);
                        return false;
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show(F.mensagem);
                    return false;
                }
            }

            public bool ApagarCurriculo(string diretorioTxt, string diretorioJson, string id)
            {
                var F = new Cls_Fichario(diretorioTxt, diretorioJson);
                if (F.status)
                {
                    F.Apagar(id);
                    if (F.status)
                    {
                        MessageBox.Show(F.mensagem);
                        return true;
                    }
                    MessageBox.Show(F.mensagem);
                    return false;
                }
                else
                {
                    MessageBox.Show(F.mensagem);
                    return false;
                }
            }

            public List<List<string>> BuscarTodosCurriculos(string diretorioTxt, string diretorioJson)
            {
                var F = new Cls_Fichario(diretorioTxt, diretorioJson);
                if (F.status)
                {
                    var lista = F.BuscarTodosCurriculosJson();
                    if (F.status)
                    {
                        var ListaBusca = new List<List<string>>();
                        for (int i = 0; i < lista.Count; i++)
                        {
                            var C = Desserializar(lista[i]);
                            ListaBusca.Add(new List<string> { C.Id, C.Nome, C.Email });
                        }
                        return ListaBusca;
                    }
                    else
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
        }

        public static Dados Desserializar(string vJson)
        {
            return JsonConvert.DeserializeObject<Dados>(vJson);
        }

        public static string Serializar(Dados pessoa)
        {
            return JsonConvert.SerializeObject(pessoa);
        }
    }
}