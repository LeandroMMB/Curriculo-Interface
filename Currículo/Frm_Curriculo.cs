using Currículo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currículo
{
    public partial class Frm_Curriculo : Form
    {
        readonly string diretorioTxt = "Curriculos";
        readonly string diretorioJson = "CurriculosJson";
        string idGerado;
        string idCurriculoSelecionado = "";

        public Frm_Curriculo()
        {
            InitializeComponent();

            AtualizarGrid();
        }

        private void Tsb_SalvarAlterar_Click(object sender, EventArgs e)
        {
            //Validação e Salvar
            if (Cls_Validacoes.ValidarNome(Txt_Nome.Text) && Cls_Validacoes.ValidarEmail(Txt_Email.Text) && Cls_Validacoes.ValidarTelefone(Msk_Telefone.Text)
                && Cls_Validacoes.ValidarCEP(Msk_Cep.Text) && Cls_Validacoes.ValidarLogradouro(Txt_Logradouro.Text) && Cls_Validacoes.ValidarNumero(Txt_Numero.Text)
                && Cls_Validacoes.ValidarBairro(Txt_Bairro.Text) && Cls_Validacoes.ValidarCidade(Txt_Cidade.Text) && Cls_Validacoes.ValidarUF(Cmb_Uf.Text)
                && Cls_Validacoes.ValidarBlog(Txt_Url.Text, Cmb_Site.Text) && Cls_Validacoes.ValidarQualificacoes(Txt_Qualidade1.Text, Txt_Qualidade2.Text, Txt_Qualidade3.Text)
                && Cls_Validacoes.ValidarCursos(Txt_Curso1.Text))
            {
                #region "Colocar as informações numa string"
                string arquivo = $"Nome: {Txt_Nome.Text}\n" +
                                 $"Data de Nascimento: {Msk_DataNascimento.Text}\n" +
                                 $"Email: {Txt_Email.Text.ToLower()}\n" +
                                 $"Telefone: {Msk_Telefone.Text}\n" +
                                 $"Logradouro: {Txt_Logradouro.Text}\n" +
                                 $"Número: {Txt_Numero.Text}\n" +
                                 $"CEP: {Msk_Cep.Text}\n" +
                                 $"Bairro: {Txt_Bairro.Text}\n" +
                                 $"Cidade: {Txt_Cidade.Text}\n" +
                                 $"UF: {Cmb_Uf.Text.ToUpper()}\n" +
                                 $"Primeiro Emprego: {Cmb_Emprego.Text}\n" +
                                 $"Interesse em Trabalho Remoto: {Cmb_Remoto.Text}\n" +
                                 $"Remuneração Pretendida: {Msk_Remuneracao.Text}\n" +
                                 $"Possui site ou blog: {Cmb_Site.Text}\n" +
                                 $"\tURL: {Txt_Url.Text}\n" +
                                 $"Cursos:\n" +
                                 $"\t{Txt_Curso1.Text}\n";

                if (Txt_Curso2.Text != "")
                {
                    arquivo += $"\t{Txt_Curso2.Text}\n";
                }
                if (Txt_Curso3.Text != "")
                {
                    arquivo += $"\t{Txt_Curso3.Text}\n";
                }
                if (Txt_Curso4.Text != "")
                {
                    arquivo += $"\t{Txt_Curso4.Text}\n";
                }

                arquivo += $"Qualidades:\n" +
                    $"\t{Txt_Qualidade1.Text}\n" +
                    $"\t{Txt_Qualidade2.Text}\n" +
                    $"\t{Txt_Qualidade3.Text}\n";

                if (Txt_Qualidade4.Text != "")
                {
                    arquivo += $"\t{Txt_Qualidade4.Text}\n";
                }
                #endregion

                var C = LerCurriculo();

                if (idCurriculoSelecionado != "")
                {
                    C.Id = idCurriculoSelecionado;
                }
                else
                {
                    var random = new Random();
                    bool idVerificado;
                    do
                    {
                        idGerado = random.Next(999999).ToString();
                        idVerificado = Cls_Validacoes.ValidarId(idGerado, diretorioJson);
                    } while (!idVerificado);

                    C.Id = idGerado;
                }

                if (C.SalvarCurriculo(diretorioTxt, diretorioJson, arquivo, idGerado, idCurriculoSelecionado))
                {
                    AtualizarGrid();
                    LimparCurriculo();
                }
            }
        }

        private void Tsb_Limpar_Click(object sender, EventArgs e)
        {
            LimparCurriculo();
        }

        private void Tsb_Deletar_Click(object sender, EventArgs e)
        {
            if (idCurriculoSelecionado != "")
            {
                if (MessageBox.Show("Você deseja realmente apagar o currículo?", "Cadastro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var C = new Cls_Curriculo.Dados();
                    C.ApagarCurriculo(diretorioTxt, diretorioJson, idCurriculoSelecionado);

                    LimparCurriculo();
                    AtualizarGrid();
                }
                return;
            }
            MessageBox.Show("Nenhum currículo selecionado.", "Cadastro");
        }

        private void Cmb_Site_TextChanged(object sender, EventArgs e)
        {
            if (Cmb_Site.Text != "Sim")
            {
                Txt_Url.Text = "";
                Txt_Url.Enabled = false;
            }
            else
            {
                Txt_Url.Enabled = true;
            }
        }

        private void Dg_Curriculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var C = new Cls_Fichario(diretorioTxt, diretorioJson);
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                var nome = Dg_Curriculos.Rows[e.RowIndex].Cells[1].Value.ToString();
                var curriculoJson = C.BuscarCurriculoJson(nome);
                var dados = Cls_Curriculo.Desserializar(curriculoJson);

                if (dados != null)
                {
                    EscreverCurriculo(dados);
                    idCurriculoSelecionado = dados.Id;
                    return;
                }
                MessageBox.Show($"Erro ao buscar currículo de {nome}.", "Currículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AtualizarGrid();
            }
        }

        private void Msk_Cep_Leave(object sender, EventArgs e)
        {
            var vCep = Msk_Cep.Text.Replace("-", "");
            if (vCep.Length == 8)
            {
                var cepJson = Cls_Cep.GeraJSONCEP(vCep);
                var CEP = Cls_Cep.DesSerializedClassUnit(cepJson);
                if (CEP.Uf != null)
                {
                    Txt_Logradouro.Text = CEP.Logradouro;
                    Txt_Bairro.Text = CEP.Bairro;
                    Txt_Cidade.Text = CEP.Localidade;

                    for (int i = 0; i < Cmb_Uf.Items.Count; i++)
                    {
                        var posicao = Cmb_Uf.Items[i].ToString().IndexOf(CEP.Uf);
                        if (posicao == 0)
                        {
                            Cmb_Uf.SelectedIndex = i;
                            return;
                        }
                    }
                }
            }
        }

        private void Tsb_AlterarSenha_Click(object sender, EventArgs e)
        {
            Hide();
            var F = new Frm_AlterarSenha(Cls_UsuarioLogado.Usuario, Cls_UsuarioLogado.Senha);
            F.ShowDialog();
            Show();
        }

        void AtualizarGrid()
        {
            var C = new Cls_Curriculo.Dados();
            var lista = C.BuscarTodosCurriculos(diretorioTxt, diretorioJson);

            Dg_Curriculos.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(Dg_Curriculos);
                row.Cells[0].Value = "Ver Dados";
                row.Cells[1].Value = lista[i][0].ToString();
                row.Cells[2].Value = lista[i][1].ToString();
                row.Cells[3].Value = lista[i][2].ToString();
                Dg_Curriculos.Rows.Add(row);
            }
        }

        void LimparCurriculo()
        {
            idCurriculoSelecionado = "";
            Txt_Nome.Text = "";
            Msk_DataNascimento.Text = "";
            Txt_Email.Text = "";
            Msk_Telefone.Text = "";
            Msk_Cep.Text = "";
            Txt_Logradouro.Text = "";
            Txt_Numero.Text = "";
            Txt_Bairro.Text = "";
            Txt_Cidade.Text = "";
            Cmb_Uf.SelectedIndex = -1;
            Cmb_Emprego.SelectedIndex = -1;
            Cmb_Remoto.SelectedIndex = -1;
            Msk_Remuneracao.Text = "";
            Cmb_Site.SelectedIndex = -1;
            Txt_Url.Text = "";
            Txt_Qualidade1.Text = "";
            Txt_Qualidade2.Text = "";
            Txt_Qualidade3.Text = "";
            Txt_Qualidade4.Text = "";
            Txt_Curso1.Text = "";
            Txt_Curso2.Text = "";
            Txt_Curso3.Text = "";
            Txt_Curso4.Text = "";
        }

        Cls_Curriculo.Dados LerCurriculo()
        {
            var P = new Cls_Curriculo.Dados
            {
                Nome = Txt_Nome.Text,
                DataNascimento = Msk_DataNascimento.Text,
                Email = Txt_Email.Text,
                Telefone = Msk_Telefone.Text,
                Logradouro = Txt_Logradouro.Text,
                Numero = Txt_Numero.Text,
                CEP = Msk_Cep.Text,
                Bairro = Txt_Bairro.Text,
                Cidade = Txt_Cidade.Text,
                UF = Cmb_Uf.Text,
                PrimeiroEmprego = Cmb_Emprego.Text,
                TrabalhoRemoto = Cmb_Remoto.Text,
                Remuneracao = Msk_Remuneracao.Text,
                PossuiSite = Cmb_Site.Text,
                URL = Txt_Url.Text,
                Curso1 = Txt_Curso1.Text,
                Curso2 = Txt_Curso2.Text,
                Curso3 = Txt_Curso3.Text,
                Curso4 = Txt_Curso4.Text,
                Qualidades1 = Txt_Qualidade1.Text,
                Qualidades2 = Txt_Qualidade2.Text,
                Qualidades3 = Txt_Qualidade3.Text,
                Qualidades4 = Txt_Qualidade4.Text
            };

            return P;
        }

        void EscreverCurriculo(Cls_Curriculo.Dados C)
        {
            Txt_Nome.Text = C.Nome;
            Msk_DataNascimento.Text = C.DataNascimento;
            Txt_Email.Text = C.Email;
            Msk_Telefone.Text = C.Telefone;
            Msk_Cep.Text = C.CEP;
            Txt_Logradouro.Text = C.Logradouro;
            Txt_Numero.Text = C.Numero;
            Txt_Bairro.Text = C.Bairro;
            Txt_Cidade.Text = C.Cidade;
            Cmb_Uf.Text = C.UF;
            Cmb_Emprego.Text = C.PrimeiroEmprego;
            Cmb_Remoto.Text = C.TrabalhoRemoto;
            Msk_Remuneracao.Text = C.Remuneracao;
            Cmb_Site.Text = C.PossuiSite;
            Txt_Url.Text = C.URL;
            Txt_Qualidade1.Text = C.Qualidades1;
            Txt_Qualidade2.Text = C.Qualidades2;
            Txt_Qualidade3.Text = C.Qualidades3;
            Txt_Qualidade4.Text = C.Qualidades4;
            Txt_Curso1.Text = C.Curso1;
            Txt_Curso2.Text = C.Curso2;
            Txt_Curso3.Text = C.Curso3;
            Txt_Curso4.Text = C.Curso4;
        }
    }
}