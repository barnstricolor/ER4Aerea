namespace ER4Aerea
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.dataSet1 = new ER4Aerea.DataSet1();
            this.cAD_CLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_CLIENTETableAdapter = new ER4Aerea.DataSet1TableAdapters.CAD_CLIENTETableAdapter();
            this.tableAdapterManager = new ER4Aerea.DataSet1TableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.email_cli = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.receive_em = new System.Windows.Forms.CheckBox();
            this.fax_cli = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cont_cli = new System.Windows.Forms.TextBox();
            this.ncont_cli = new System.Windows.Forms.TextBox();
            this.cel_cli = new System.Windows.Forms.TextBox();
            this.fixo_cli = new System.Windows.Forms.TextBox();
            this.dta_nasc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rg_cli = new System.Windows.Forms.TextBox();
            this.cep_cli = new System.Windows.Forms.TextBox();
            this.cpf_cli = new System.Windows.Forms.TextBox();
            this.nome_cli = new System.Windows.Forms.Label();
            this.bai_cli = new System.Windows.Forms.TextBox();
            this.ID_CLIENTE = new System.Windows.Forms.TextBox();
            this.cid_cli = new System.Windows.Forms.TextBox();
            this.end_cli = new System.Windows.Forms.TextBox();
            this.nEnd_cli = new System.Windows.Forms.TextBox();
            this.nom_cli = new System.Windows.Forms.TextBox();
            this.num_end = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ende_cli = new System.Windows.Forms.Label();
            this.cod_cli = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CLIENTEBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAD_CLIENTEBindingSource
            // 
            this.cAD_CLIENTEBindingSource.DataMember = "CAD_CLIENTE";
            this.cAD_CLIENTEBindingSource.DataSource = this.dataSet1;
            // 
            // cAD_CLIENTETableAdapter
            // 
            this.cAD_CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAD_ASSENTOTableAdapter = null;
            this.tableAdapterManager.CAD_AVIAOTableAdapter = null;
            this.tableAdapterManager.CAD_CIDADETableAdapter = null;
            this.tableAdapterManager.CAD_CLIENTETableAdapter = this.cAD_CLIENTETableAdapter;
            this.tableAdapterManager.CAD_PRECOTableAdapter = null;
            this.tableAdapterManager.CAD_PROMOCAOTableAdapter = null;
            this.tableAdapterManager.CAD_RESERVATableAdapter = null;
            this.tableAdapterManager.CAD_TRECHOTableAdapter = null;
            this.tableAdapterManager.CAD_USUARIOTableAdapter = null;
            this.tableAdapterManager.CAD_VOOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ER4Aerea.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(114, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(92, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 22);
            this.button4.TabIndex = 139;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // email_cli
            // 
            this.email_cli.Location = new System.Drawing.Point(56, 162);
            this.email_cli.Name = "email_cli";
            this.email_cli.Size = new System.Drawing.Size(320, 20);
            this.email_cli.TabIndex = 19;
            this.email_cli.Tag = "NOM_EMAIL,C";
            this.email_cli.TextChanged += new System.EventHandler(this.email_cli_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 137;
            this.label13.Text = "E-mail:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 138;
            this.label12.Text = "Sexo:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // receive_em
            // 
            this.receive_em.AutoSize = true;
            this.receive_em.Location = new System.Drawing.Point(12, 201);
            this.receive_em.Name = "receive_em";
            this.receive_em.Size = new System.Drawing.Size(223, 17);
            this.receive_em.TabIndex = 20;
            this.receive_em.Tag = "";
            this.receive_em.Text = "Desejo receber novidades em meu e-mail.";
            this.receive_em.UseVisualStyleBackColor = true;
            this.receive_em.CheckedChanged += new System.EventHandler(this.receive_em_CheckedChanged);
            // 
            // fax_cli
            // 
            this.fax_cli.Location = new System.Drawing.Point(373, 110);
            this.fax_cli.Name = "fax_cli";
            this.fax_cli.Size = new System.Drawing.Size(137, 20);
            this.fax_cli.TabIndex = 16;
            this.fax_cli.Tag = "NUM_FAX,C";
            this.fax_cli.TextChanged += new System.EventHandler(this.fax_cli_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 136;
            this.label11.Text = "Fax:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 135;
            this.label10.Text = "Nome do contato:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 134;
            this.label9.Text = "Contato:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 133;
            this.label2.Text = "Celular:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cont_cli
            // 
            this.cont_cli.Location = new System.Drawing.Point(382, 136);
            this.cont_cli.Name = "cont_cli";
            this.cont_cli.Size = new System.Drawing.Size(128, 20);
            this.cont_cli.TabIndex = 18;
            this.cont_cli.Tag = "TEL_CONTATO,C";
            this.cont_cli.TextChanged += new System.EventHandler(this.cont_cli_TextChanged);
            // 
            // ncont_cli
            // 
            this.ncont_cli.Location = new System.Drawing.Point(110, 136);
            this.ncont_cli.Name = "ncont_cli";
            this.ncont_cli.Size = new System.Drawing.Size(212, 20);
            this.ncont_cli.TabIndex = 17;
            this.ncont_cli.Tag = "NOM_CONTATO,C";
            this.ncont_cli.TextChanged += new System.EventHandler(this.ncont_cli_TextChanged);
            // 
            // cel_cli
            // 
            this.cel_cli.Location = new System.Drawing.Point(233, 110);
            this.cel_cli.Name = "cel_cli";
            this.cel_cli.Size = new System.Drawing.Size(100, 20);
            this.cel_cli.TabIndex = 15;
            this.cel_cli.Tag = "NUM_CELULAR,C";
            this.cel_cli.TextChanged += new System.EventHandler(this.cel_cli_TextChanged);
            // 
            // fixo_cli
            // 
            this.fixo_cli.Location = new System.Drawing.Point(70, 110);
            this.fixo_cli.Name = "fixo_cli";
            this.fixo_cli.Size = new System.Drawing.Size(100, 20);
            this.fixo_cli.TabIndex = 14;
            this.fixo_cli.Tag = "NUM_TELEFONE,C";
            this.fixo_cli.TextChanged += new System.EventHandler(this.fixo_cli_TextChanged);
            // 
            // dta_nasc
            // 
            this.dta_nasc.Location = new System.Drawing.Point(444, 32);
            this.dta_nasc.Name = "dta_nasc";
            this.dta_nasc.Size = new System.Drawing.Size(66, 20);
            this.dta_nasc.TabIndex = 7;
            this.dta_nasc.Tag = "DTA_NASCIMENTO,D";
            this.dta_nasc.TextChanged += new System.EventHandler(this.dta_nasc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Data de nascimento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rg_cli
            // 
            this.rg_cli.Location = new System.Drawing.Point(199, 32);
            this.rg_cli.Name = "rg_cli";
            this.rg_cli.Size = new System.Drawing.Size(128, 20);
            this.rg_cli.TabIndex = 6;
            this.rg_cli.Tag = "NUM_RG,C";
            this.rg_cli.TextChanged += new System.EventHandler(this.rg_cli_TextChanged);
            // 
            // cep_cli
            // 
            this.cep_cli.Location = new System.Drawing.Point(422, 84);
            this.cep_cli.Name = "cep_cli";
            this.cep_cli.Size = new System.Drawing.Size(88, 20);
            this.cep_cli.TabIndex = 13;
            this.cep_cli.Tag = "CAD_CEP,C";
            this.cep_cli.TextChanged += new System.EventHandler(this.cep_cli_TextChanged);
            // 
            // cpf_cli
            // 
            this.cpf_cli.Location = new System.Drawing.Point(48, 32);
            this.cpf_cli.MaxLength = 11;
            this.cpf_cli.Name = "cpf_cli";
            this.cpf_cli.Size = new System.Drawing.Size(113, 20);
            this.cpf_cli.TabIndex = 5;
            this.cpf_cli.Tag = "NUM_CPF,N";
            this.cpf_cli.TextChanged += new System.EventHandler(this.cpf_cli_TextChanged);
            // 
            // nome_cli
            // 
            this.nome_cli.AutoSize = true;
            this.nome_cli.Location = new System.Drawing.Point(116, 9);
            this.nome_cli.Name = "nome_cli";
            this.nome_cli.Size = new System.Drawing.Size(38, 13);
            this.nome_cli.TabIndex = 127;
            this.nome_cli.Text = "Nome:";
            this.nome_cli.Click += new System.EventHandler(this.nome_cli_Click);
            // 
            // bai_cli
            // 
            this.bai_cli.Location = new System.Drawing.Point(283, 84);
            this.bai_cli.Name = "bai_cli";
            this.bai_cli.Size = new System.Drawing.Size(96, 20);
            this.bai_cli.TabIndex = 12;
            this.bai_cli.Tag = "NOM_BAIRRO,C";
            this.bai_cli.TextChanged += new System.EventHandler(this.bai_cli_TextChanged);
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.Enabled = false;
            this.ID_CLIENTE.Location = new System.Drawing.Point(61, 6);
            this.ID_CLIENTE.MaxLength = 6;
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.Size = new System.Drawing.Size(48, 20);
            this.ID_CLIENTE.TabIndex = 1;
            this.ID_CLIENTE.Tag = "ID_CLIENTE,N";
            this.ID_CLIENTE.TextChanged += new System.EventHandler(this.cod_cli1_TextChanged_1);
            // 
            // cid_cli
            // 
            this.cid_cli.Location = new System.Drawing.Point(56, 84);
            this.cid_cli.Name = "cid_cli";
            this.cid_cli.Size = new System.Drawing.Size(60, 20);
            this.cid_cli.TabIndex = 10;
            this.cid_cli.Tag = "ID_CIDADE,N";
            this.cid_cli.TextChanged += new System.EventHandler(this.cid_cli_TextChanged);
            // 
            // end_cli
            // 
            this.end_cli.Location = new System.Drawing.Point(74, 58);
            this.end_cli.Name = "end_cli";
            this.end_cli.Size = new System.Drawing.Size(319, 20);
            this.end_cli.TabIndex = 8;
            this.end_cli.Tag = "NOM_ENDERECO,C";
            this.end_cli.TextChanged += new System.EventHandler(this.end_cli_TextChanged);
            // 
            // nEnd_cli
            // 
            this.nEnd_cli.Location = new System.Drawing.Point(422, 58);
            this.nEnd_cli.MaxLength = 5;
            this.nEnd_cli.Name = "nEnd_cli";
            this.nEnd_cli.Size = new System.Drawing.Size(88, 20);
            this.nEnd_cli.TabIndex = 9;
            this.nEnd_cli.Tag = "NUM_END,N";
            this.nEnd_cli.TextChanged += new System.EventHandler(this.nEnd_cli_TextChanged);
            // 
            // nom_cli
            // 
            this.nom_cli.Location = new System.Drawing.Point(160, 6);
            this.nom_cli.Name = "nom_cli";
            this.nom_cli.Size = new System.Drawing.Size(173, 20);
            this.nom_cli.TabIndex = 2;
            this.nom_cli.Tag = "NOM_CLIENTE,C";
            this.nom_cli.TextChanged += new System.EventHandler(this.nom_cli_TextChanged);
            // 
            // num_end
            // 
            this.num_end.AutoSize = true;
            this.num_end.Location = new System.Drawing.Point(399, 61);
            this.num_end.Name = "num_end";
            this.num_end.Size = new System.Drawing.Size(17, 13);
            this.num_end.TabIndex = 118;
            this.num_end.Text = "nº";
            this.num_end.Click += new System.EventHandler(this.num_end_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Cidade:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "CEP:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "CPF:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 111;
            this.label5.Text = "RG:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Telefone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "Bairro:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // ende_cli
            // 
            this.ende_cli.AutoSize = true;
            this.ende_cli.Location = new System.Drawing.Point(12, 61);
            this.ende_cli.Name = "ende_cli";
            this.ende_cli.Size = new System.Drawing.Size(56, 13);
            this.ende_cli.TabIndex = 106;
            this.ende_cli.Text = "Endereço:";
            this.ende_cli.Click += new System.EventHandler(this.ende_cli_Click_1);
            // 
            // cod_cli
            // 
            this.cod_cli.AutoSize = true;
            this.cod_cli.Location = new System.Drawing.Point(12, 9);
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.Size = new System.Drawing.Size(43, 13);
            this.cod_cli.TabIndex = 103;
            this.cod_cli.Text = "Código:";
            this.cod_cli.Click += new System.EventHandler(this.cod_cli_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 45);
            this.panel1.TabIndex = 141;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(98, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(3, 16);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 21;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 142;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBox1.Location = new System.Drawing.Point(379, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 143;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 277);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.email_cli);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.receive_em);
            this.Controls.Add(this.fax_cli);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cont_cli);
            this.Controls.Add(this.ncont_cli);
            this.Controls.Add(this.cel_cli);
            this.Controls.Add(this.fixo_cli);
            this.Controls.Add(this.dta_nasc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rg_cli);
            this.Controls.Add(this.cep_cli);
            this.Controls.Add(this.cpf_cli);
            this.Controls.Add(this.nome_cli);
            this.Controls.Add(this.bai_cli);
            this.Controls.Add(this.ID_CLIENTE);
            this.Controls.Add(this.cid_cli);
            this.Controls.Add(this.end_cli);
            this.Controls.Add(this.nEnd_cli);
            this.Controls.Add(this.nom_cli);
            this.Controls.Add(this.num_end);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ende_cli);
            this.Controls.Add(this.cod_cli);
            this.Name = "frmCliente";
            this.Tag = "CAD_CLIENTE";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CLIENTEBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cAD_CLIENTEBindingSource;
        private DataSet1TableAdapters.CAD_CLIENTETableAdapter cAD_CLIENTETableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox email_cli;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox receive_em;
        private System.Windows.Forms.TextBox fax_cli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cont_cli;
        private System.Windows.Forms.TextBox ncont_cli;
        private System.Windows.Forms.TextBox cel_cli;
        private System.Windows.Forms.TextBox fixo_cli;
        private System.Windows.Forms.TextBox dta_nasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rg_cli;
        private System.Windows.Forms.TextBox cep_cli;
        private System.Windows.Forms.TextBox cpf_cli;
        private System.Windows.Forms.Label nome_cli;
        private System.Windows.Forms.TextBox bai_cli;
        private System.Windows.Forms.TextBox ID_CLIENTE;
        private System.Windows.Forms.TextBox cid_cli;
        private System.Windows.Forms.TextBox end_cli;
        private System.Windows.Forms.TextBox nEnd_cli;
        private System.Windows.Forms.TextBox nom_cli;
        private System.Windows.Forms.Label num_end;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ende_cli;
        private System.Windows.Forms.Label cod_cli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}