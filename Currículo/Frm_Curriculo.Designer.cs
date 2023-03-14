namespace Currículo
{
    partial class Frm_Curriculo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Curriculo));
            this.Lbl_TituloCurriculo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsb_NovoCurriculo = new System.Windows.Forms.ToolStripButton();
            this.Tsb_SalvarAlterar = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Deletar = new System.Windows.Forms.ToolStripButton();
            this.Tsb_AlterarSenha = new System.Windows.Forms.ToolStripButton();
            this.Cmb_Uf = new System.Windows.Forms.ComboBox();
            this.Lbl_Uf = new System.Windows.Forms.Label();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Msk_Cep = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.Lbl_Cep = new System.Windows.Forms.Label();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Msk_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_DataNascimento = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Url = new System.Windows.Forms.Label();
            this.Cmb_Site = new System.Windows.Forms.ComboBox();
            this.Txt_Url = new System.Windows.Forms.TextBox();
            this.Lbl_Site = new System.Windows.Forms.Label();
            this.Msk_Remuneracao = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Remuneracao = new System.Windows.Forms.Label();
            this.Cmb_Remoto = new System.Windows.Forms.ComboBox();
            this.Lbl_Remoto = new System.Windows.Forms.Label();
            this.Cmb_Emprego = new System.Windows.Forms.ComboBox();
            this.Lbl_Emprego = new System.Windows.Forms.Label();
            this.Lbl_OutrasInfo = new System.Windows.Forms.Label();
            this.Txt_Curso4 = new System.Windows.Forms.TextBox();
            this.Txt_Curso3 = new System.Windows.Forms.TextBox();
            this.Txt_Curso2 = new System.Windows.Forms.TextBox();
            this.Txt_Curso1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Qualidade4 = new System.Windows.Forms.TextBox();
            this.Txt_Qualidade3 = new System.Windows.Forms.TextBox();
            this.Txt_Qualidade2 = new System.Windows.Forms.TextBox();
            this.Txt_Qualidade1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Qualificacoes = new System.Windows.Forms.Label();
            this.Dg_Curriculos = new System.Windows.Forms.DataGridView();
            this.VerDados = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Curriculos)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_TituloCurriculo
            // 
            this.Lbl_TituloCurriculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_TituloCurriculo.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloCurriculo.Location = new System.Drawing.Point(0, 25);
            this.Lbl_TituloCurriculo.Name = "Lbl_TituloCurriculo";
            this.Lbl_TituloCurriculo.Size = new System.Drawing.Size(1227, 43);
            this.Lbl_TituloCurriculo.TabIndex = 0;
            this.Lbl_TituloCurriculo.Text = "Currículo";
            this.Lbl_TituloCurriculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_NovoCurriculo,
            this.Tsb_SalvarAlterar,
            this.Tsb_Deletar,
            this.Tsb_AlterarSenha});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1227, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tsb_NovoCurriculo
            // 
            this.Tsb_NovoCurriculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_NovoCurriculo.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_NovoCurriculo.Image")));
            this.Tsb_NovoCurriculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_NovoCurriculo.Name = "Tsb_NovoCurriculo";
            this.Tsb_NovoCurriculo.Size = new System.Drawing.Size(23, 22);
            this.Tsb_NovoCurriculo.Text = "Criar um novo currículo";
            this.Tsb_NovoCurriculo.Click += new System.EventHandler(this.Tsb_NovoCurriculo_Click);
            // 
            // Tsb_SalvarAlterar
            // 
            this.Tsb_SalvarAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_SalvarAlterar.Image = global::Currículo.Properties.Resources.icons8_salvar_100;
            this.Tsb_SalvarAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_SalvarAlterar.Name = "Tsb_SalvarAlterar";
            this.Tsb_SalvarAlterar.Size = new System.Drawing.Size(23, 22);
            this.Tsb_SalvarAlterar.Text = "Salvar ou alterar currículo";
            this.Tsb_SalvarAlterar.Click += new System.EventHandler(this.Tsb_SalvarAlterar_Click);
            // 
            // Tsb_Deletar
            // 
            this.Tsb_Deletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Deletar.Image = global::Currículo.Properties.Resources.icons8_excluir_100__2_;
            this.Tsb_Deletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Deletar.Name = "Tsb_Deletar";
            this.Tsb_Deletar.Size = new System.Drawing.Size(23, 22);
            this.Tsb_Deletar.Text = "Deletar currículo selecionado";
            this.Tsb_Deletar.Click += new System.EventHandler(this.Tsb_Deletar_Click);
            // 
            // Tsb_AlterarSenha
            // 
            this.Tsb_AlterarSenha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_AlterarSenha.Image = global::Currículo.Properties.Resources.icons8_chave_2_16;
            this.Tsb_AlterarSenha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_AlterarSenha.Name = "Tsb_AlterarSenha";
            this.Tsb_AlterarSenha.Size = new System.Drawing.Size(23, 22);
            this.Tsb_AlterarSenha.Text = "Alterar senha";
            this.Tsb_AlterarSenha.Click += new System.EventHandler(this.Tsb_AlterarSenha_Click);
            // 
            // Cmb_Uf
            // 
            this.Cmb_Uf.FormattingEnabled = true;
            this.Cmb_Uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.Cmb_Uf.Location = new System.Drawing.Point(442, 231);
            this.Cmb_Uf.Name = "Cmb_Uf";
            this.Cmb_Uf.Size = new System.Drawing.Size(218, 21);
            this.Cmb_Uf.TabIndex = 50;
            // 
            // Lbl_Uf
            // 
            this.Lbl_Uf.AutoSize = true;
            this.Lbl_Uf.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Uf.Location = new System.Drawing.Point(341, 231);
            this.Lbl_Uf.Name = "Lbl_Uf";
            this.Lbl_Uf.Size = new System.Drawing.Size(32, 18);
            this.Lbl_Uf.TabIndex = 49;
            this.Lbl_Uf.Text = "UF:";
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Cidade.Location = new System.Drawing.Point(21, 231);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(62, 18);
            this.Lbl_Cidade.TabIndex = 48;
            this.Lbl_Cidade.Text = "Cidade:";
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(89, 231);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(226, 20);
            this.Txt_Cidade.TabIndex = 42;
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Bairro.Location = new System.Drawing.Point(341, 195);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(56, 18);
            this.Lbl_Bairro.TabIndex = 47;
            this.Lbl_Bairro.Text = "Bairro:";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(442, 195);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(218, 20);
            this.Txt_Bairro.TabIndex = 40;
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.AutoSize = true;
            this.Lbl_Numero.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Numero.Location = new System.Drawing.Point(21, 195);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(68, 18);
            this.Lbl_Numero.TabIndex = 46;
            this.Lbl_Numero.Text = "Número:";
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Location = new System.Drawing.Point(89, 195);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(226, 20);
            this.Txt_Numero.TabIndex = 39;
            // 
            // Msk_Cep
            // 
            this.Msk_Cep.Location = new System.Drawing.Point(89, 156);
            this.Msk_Cep.Mask = "00000-000";
            this.Msk_Cep.Name = "Msk_Cep";
            this.Msk_Cep.Size = new System.Drawing.Size(100, 20);
            this.Msk_Cep.TabIndex = 36;
            this.Msk_Cep.Leave += new System.EventHandler(this.Msk_Cep_Leave);
            // 
            // Msk_Telefone
            // 
            this.Msk_Telefone.Location = new System.Drawing.Point(442, 119);
            this.Msk_Telefone.Mask = "(00)00000-0000";
            this.Msk_Telefone.Name = "Msk_Telefone";
            this.Msk_Telefone.Size = new System.Drawing.Size(100, 20);
            this.Msk_Telefone.TabIndex = 35;
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Logradouro.Location = new System.Drawing.Point(341, 156);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(95, 18);
            this.Lbl_Logradouro.TabIndex = 45;
            this.Lbl_Logradouro.Text = "Logradouro:";
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Location = new System.Drawing.Point(442, 156);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.Size = new System.Drawing.Size(218, 20);
            this.Txt_Logradouro.TabIndex = 38;
            // 
            // Lbl_Cep
            // 
            this.Lbl_Cep.AutoSize = true;
            this.Lbl_Cep.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Cep.Location = new System.Drawing.Point(21, 156);
            this.Lbl_Cep.Name = "Lbl_Cep";
            this.Lbl_Cep.Size = new System.Drawing.Size(43, 18);
            this.Lbl_Cep.TabIndex = 43;
            this.Lbl_Cep.Text = "CEP:";
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Telefone.Location = new System.Drawing.Point(341, 119);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(75, 18);
            this.Lbl_Telefone.TabIndex = 44;
            this.Lbl_Telefone.Text = "Telefone:";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Email.Location = new System.Drawing.Point(21, 119);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(50, 18);
            this.Lbl_Email.TabIndex = 41;
            this.Lbl_Email.Text = "Email:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(89, 119);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(226, 20);
            this.Txt_Email.TabIndex = 33;
            // 
            // Msk_DataNascimento
            // 
            this.Msk_DataNascimento.Location = new System.Drawing.Point(500, 81);
            this.Msk_DataNascimento.Mask = "00/00/0000";
            this.Msk_DataNascimento.Name = "Msk_DataNascimento";
            this.Msk_DataNascimento.Size = new System.Drawing.Size(81, 20);
            this.Msk_DataNascimento.TabIndex = 31;
            this.Msk_DataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // Lbl_DataNascimento
            // 
            this.Lbl_DataNascimento.AutoSize = true;
            this.Lbl_DataNascimento.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_DataNascimento.Location = new System.Drawing.Point(341, 81);
            this.Lbl_DataNascimento.Name = "Lbl_DataNascimento";
            this.Lbl_DataNascimento.Size = new System.Drawing.Size(153, 18);
            this.Lbl_DataNascimento.TabIndex = 34;
            this.Lbl_DataNascimento.Text = "Data de Nascimento:";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Nome.Location = new System.Drawing.Point(21, 81);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(53, 18);
            this.Lbl_Nome.TabIndex = 32;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(89, 81);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(226, 20);
            this.Txt_Nome.TabIndex = 30;
            // 
            // Lbl_Url
            // 
            this.Lbl_Url.AutoSize = true;
            this.Lbl_Url.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Url.Location = new System.Drawing.Point(21, 456);
            this.Lbl_Url.Name = "Lbl_Url";
            this.Lbl_Url.Size = new System.Drawing.Size(120, 18);
            this.Lbl_Url.TabIndex = 58;
            this.Lbl_Url.Text = "Url do site/blog:";
            // 
            // Cmb_Site
            // 
            this.Cmb_Site.FormattingEnabled = true;
            this.Cmb_Site.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Cmb_Site.Location = new System.Drawing.Point(373, 417);
            this.Cmb_Site.Name = "Cmb_Site";
            this.Cmb_Site.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Site.TabIndex = 54;
            this.Cmb_Site.TextChanged += new System.EventHandler(this.Cmb_Site_TextChanged);
            // 
            // Txt_Url
            // 
            this.Txt_Url.Enabled = false;
            this.Txt_Url.Location = new System.Drawing.Point(373, 454);
            this.Txt_Url.Name = "Txt_Url";
            this.Txt_Url.Size = new System.Drawing.Size(218, 20);
            this.Txt_Url.TabIndex = 55;
            // 
            // Lbl_Site
            // 
            this.Lbl_Site.AutoSize = true;
            this.Lbl_Site.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Site.Location = new System.Drawing.Point(21, 420);
            this.Lbl_Site.Name = "Lbl_Site";
            this.Lbl_Site.Size = new System.Drawing.Size(152, 18);
            this.Lbl_Site.TabIndex = 61;
            this.Lbl_Site.Text = "Possui site ou blog?";
            // 
            // Msk_Remuneracao
            // 
            this.Msk_Remuneracao.Location = new System.Drawing.Point(373, 387);
            this.Msk_Remuneracao.Mask = "$000000000.00";
            this.Msk_Remuneracao.Name = "Msk_Remuneracao";
            this.Msk_Remuneracao.Size = new System.Drawing.Size(121, 20);
            this.Msk_Remuneracao.TabIndex = 53;
            // 
            // Lbl_Remuneracao
            // 
            this.Lbl_Remuneracao.AutoSize = true;
            this.Lbl_Remuneracao.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Remuneracao.Location = new System.Drawing.Point(21, 387);
            this.Lbl_Remuneracao.Name = "Lbl_Remuneracao";
            this.Lbl_Remuneracao.Size = new System.Drawing.Size(240, 18);
            this.Lbl_Remuneracao.TabIndex = 60;
            this.Lbl_Remuneracao.Text = "Qual a remuneração pretendida?";
            // 
            // Cmb_Remoto
            // 
            this.Cmb_Remoto.FormattingEnabled = true;
            this.Cmb_Remoto.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Cmb_Remoto.Location = new System.Drawing.Point(373, 351);
            this.Cmb_Remoto.Name = "Cmb_Remoto";
            this.Cmb_Remoto.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Remoto.TabIndex = 52;
            // 
            // Lbl_Remoto
            // 
            this.Lbl_Remoto.AutoSize = true;
            this.Lbl_Remoto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Remoto.Location = new System.Drawing.Point(21, 351);
            this.Lbl_Remoto.Name = "Lbl_Remoto";
            this.Lbl_Remoto.Size = new System.Drawing.Size(256, 18);
            this.Lbl_Remoto.TabIndex = 59;
            this.Lbl_Remoto.Text = "Tem interesse no trabalho remoto?";
            // 
            // Cmb_Emprego
            // 
            this.Cmb_Emprego.FormattingEnabled = true;
            this.Cmb_Emprego.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Cmb_Emprego.Location = new System.Drawing.Point(373, 315);
            this.Cmb_Emprego.Name = "Cmb_Emprego";
            this.Cmb_Emprego.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Emprego.TabIndex = 51;
            // 
            // Lbl_Emprego
            // 
            this.Lbl_Emprego.AutoSize = true;
            this.Lbl_Emprego.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Emprego.Location = new System.Drawing.Point(21, 315);
            this.Lbl_Emprego.Name = "Lbl_Emprego";
            this.Lbl_Emprego.Size = new System.Drawing.Size(346, 18);
            this.Lbl_Emprego.TabIndex = 56;
            this.Lbl_Emprego.Text = "Está se candidatando para o primeiro emprego?";
            // 
            // Lbl_OutrasInfo
            // 
            this.Lbl_OutrasInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_OutrasInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_OutrasInfo.Location = new System.Drawing.Point(0, 264);
            this.Lbl_OutrasInfo.Name = "Lbl_OutrasInfo";
            this.Lbl_OutrasInfo.Size = new System.Drawing.Size(691, 38);
            this.Lbl_OutrasInfo.TabIndex = 57;
            this.Lbl_OutrasInfo.Text = "Outras Informações";
            this.Lbl_OutrasInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Curso4
            // 
            this.Txt_Curso4.Location = new System.Drawing.Point(344, 639);
            this.Txt_Curso4.Name = "Txt_Curso4";
            this.Txt_Curso4.Size = new System.Drawing.Size(262, 20);
            this.Txt_Curso4.TabIndex = 70;
            // 
            // Txt_Curso3
            // 
            this.Txt_Curso3.Location = new System.Drawing.Point(344, 613);
            this.Txt_Curso3.Name = "Txt_Curso3";
            this.Txt_Curso3.Size = new System.Drawing.Size(262, 20);
            this.Txt_Curso3.TabIndex = 69;
            // 
            // Txt_Curso2
            // 
            this.Txt_Curso2.Location = new System.Drawing.Point(344, 587);
            this.Txt_Curso2.Name = "Txt_Curso2";
            this.Txt_Curso2.Size = new System.Drawing.Size(262, 20);
            this.Txt_Curso2.TabIndex = 68;
            // 
            // Txt_Curso1
            // 
            this.Txt_Curso1.Location = new System.Drawing.Point(344, 561);
            this.Txt_Curso1.Name = "Txt_Curso1";
            this.Txt_Curso1.Size = new System.Drawing.Size(262, 20);
            this.Txt_Curso1.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(341, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Informe 1 ou mais cursos realizados:";
            // 
            // Txt_Qualidade4
            // 
            this.Txt_Qualidade4.Location = new System.Drawing.Point(24, 639);
            this.Txt_Qualidade4.Name = "Txt_Qualidade4";
            this.Txt_Qualidade4.Size = new System.Drawing.Size(214, 20);
            this.Txt_Qualidade4.TabIndex = 66;
            // 
            // Txt_Qualidade3
            // 
            this.Txt_Qualidade3.Location = new System.Drawing.Point(24, 613);
            this.Txt_Qualidade3.Name = "Txt_Qualidade3";
            this.Txt_Qualidade3.Size = new System.Drawing.Size(214, 20);
            this.Txt_Qualidade3.TabIndex = 65;
            // 
            // Txt_Qualidade2
            // 
            this.Txt_Qualidade2.Location = new System.Drawing.Point(24, 587);
            this.Txt_Qualidade2.Name = "Txt_Qualidade2";
            this.Txt_Qualidade2.Size = new System.Drawing.Size(214, 20);
            this.Txt_Qualidade2.TabIndex = 64;
            // 
            // Txt_Qualidade1
            // 
            this.Txt_Qualidade1.Location = new System.Drawing.Point(24, 561);
            this.Txt_Qualidade1.Name = "Txt_Qualidade1";
            this.Txt_Qualidade1.Size = new System.Drawing.Size(214, 20);
            this.Txt_Qualidade1.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "Informe 3 qualidades ou mais:";
            // 
            // Lbl_Qualificacoes
            // 
            this.Lbl_Qualificacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Lbl_Qualificacoes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Qualificacoes.Location = new System.Drawing.Point(0, 488);
            this.Lbl_Qualificacoes.Name = "Lbl_Qualificacoes";
            this.Lbl_Qualificacoes.Size = new System.Drawing.Size(691, 38);
            this.Lbl_Qualificacoes.TabIndex = 72;
            this.Lbl_Qualificacoes.Text = "Qualificações";
            this.Lbl_Qualificacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dg_Curriculos
            // 
            this.Dg_Curriculos.AllowUserToAddRows = false;
            this.Dg_Curriculos.AllowUserToDeleteRows = false;
            this.Dg_Curriculos.AllowUserToOrderColumns = true;
            this.Dg_Curriculos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.Dg_Curriculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Curriculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VerDados,
            this.Id,
            this.Nome,
            this.Email});
            this.Dg_Curriculos.Location = new System.Drawing.Point(689, 81);
            this.Dg_Curriculos.MultiSelect = false;
            this.Dg_Curriculos.Name = "Dg_Curriculos";
            this.Dg_Curriculos.ReadOnly = true;
            this.Dg_Curriculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_Curriculos.Size = new System.Drawing.Size(530, 578);
            this.Dg_Curriculos.TabIndex = 0;
            this.Dg_Curriculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Curriculos_CellClick);
            // 
            // VerDados
            // 
            this.VerDados.HeaderText = "";
            this.VerDados.Name = "VerDados";
            this.VerDados.ReadOnly = true;
            this.VerDados.Width = 80;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 250;
            // 
            // Frm_Curriculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1227, 671);
            this.Controls.Add(this.Dg_Curriculos);
            this.Controls.Add(this.Txt_Curso4);
            this.Controls.Add(this.Txt_Curso3);
            this.Controls.Add(this.Txt_Curso2);
            this.Controls.Add(this.Txt_Curso1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Qualidade4);
            this.Controls.Add(this.Txt_Qualidade3);
            this.Controls.Add(this.Txt_Qualidade2);
            this.Controls.Add(this.Txt_Qualidade1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Qualificacoes);
            this.Controls.Add(this.Lbl_Url);
            this.Controls.Add(this.Cmb_Site);
            this.Controls.Add(this.Txt_Url);
            this.Controls.Add(this.Lbl_Site);
            this.Controls.Add(this.Msk_Remuneracao);
            this.Controls.Add(this.Lbl_Remuneracao);
            this.Controls.Add(this.Cmb_Remoto);
            this.Controls.Add(this.Lbl_Remoto);
            this.Controls.Add(this.Cmb_Emprego);
            this.Controls.Add(this.Lbl_Emprego);
            this.Controls.Add(this.Lbl_OutrasInfo);
            this.Controls.Add(this.Cmb_Uf);
            this.Controls.Add(this.Lbl_Uf);
            this.Controls.Add(this.Lbl_Cidade);
            this.Controls.Add(this.Txt_Cidade);
            this.Controls.Add(this.Lbl_Bairro);
            this.Controls.Add(this.Txt_Bairro);
            this.Controls.Add(this.Lbl_Numero);
            this.Controls.Add(this.Txt_Numero);
            this.Controls.Add(this.Msk_Cep);
            this.Controls.Add(this.Msk_Telefone);
            this.Controls.Add(this.Lbl_Logradouro);
            this.Controls.Add(this.Txt_Logradouro);
            this.Controls.Add(this.Lbl_Cep);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Msk_DataNascimento);
            this.Controls.Add(this.Lbl_DataNascimento);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Lbl_TituloCurriculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Curriculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currículo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Curriculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TituloCurriculo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tsb_Deletar;
        private System.Windows.Forms.ComboBox Cmb_Uf;
        private System.Windows.Forms.Label Lbl_Uf;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.MaskedTextBox Msk_Cep;
        private System.Windows.Forms.MaskedTextBox Msk_Telefone;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.TextBox Txt_Logradouro;
        private System.Windows.Forms.Label Lbl_Cep;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.MaskedTextBox Msk_DataNascimento;
        private System.Windows.Forms.Label Lbl_DataNascimento;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label Lbl_Url;
        private System.Windows.Forms.ComboBox Cmb_Site;
        private System.Windows.Forms.TextBox Txt_Url;
        private System.Windows.Forms.Label Lbl_Site;
        private System.Windows.Forms.MaskedTextBox Msk_Remuneracao;
        private System.Windows.Forms.Label Lbl_Remuneracao;
        private System.Windows.Forms.ComboBox Cmb_Remoto;
        private System.Windows.Forms.Label Lbl_Remoto;
        private System.Windows.Forms.ComboBox Cmb_Emprego;
        private System.Windows.Forms.Label Lbl_Emprego;
        private System.Windows.Forms.Label Lbl_OutrasInfo;
        private System.Windows.Forms.TextBox Txt_Curso4;
        private System.Windows.Forms.TextBox Txt_Curso3;
        private System.Windows.Forms.TextBox Txt_Curso2;
        private System.Windows.Forms.TextBox Txt_Curso1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Qualidade4;
        private System.Windows.Forms.TextBox Txt_Qualidade3;
        private System.Windows.Forms.TextBox Txt_Qualidade2;
        private System.Windows.Forms.TextBox Txt_Qualidade1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Qualificacoes;
        private System.Windows.Forms.DataGridView Dg_Curriculos;
        private System.Windows.Forms.DataGridViewButtonColumn VerDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.ToolStripButton Tsb_SalvarAlterar;
        private System.Windows.Forms.ToolStripButton Tsb_AlterarSenha;
        private System.Windows.Forms.ToolStripButton Tsb_NovoCurriculo;
    }
}

