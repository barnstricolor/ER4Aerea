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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.txtCidade2 = new UCTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtEmail = new UCTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkFeminino = new System.Windows.Forms.RadioButton();
            this.chkMasculino = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.chkReceb = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOcup = new UCTextBox();
            this.txtCel = new UCTextBox();
            this.txtTel = new UCTextBox();
            this.txtRg = new UCTextBox();
            this.txtCep = new UCTextBox();
            this.txtCpf = new UCTextBox();
            this.nome_cli = new System.Windows.Forms.Label();
            this.txtBairro = new UCTextBox();
            this.txtCidade = new UCTextBox();
            this.txtEndereco = new UCTextBox();
            this.txtNum = new UCTextBox();
            this.txtNome = new UCTextBox();
            this.num_end = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ende_cli = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRenda = new UCTextBox();
            this.chkEsp = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new UCTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCidade2
            // 
            this.txtCidade2.Enabled = false;
            this.txtCidade2.Location = new System.Drawing.Point(122, 84);
            this.txtCidade2.Name = "txtCidade2";
            this.txtCidade2.Size = new System.Drawing.Size(113, 20);
            this.txtCidade2.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 22);
            this.button4.TabIndex = 139;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(306, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Tag = "NOM_EMAIL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 137;
            this.label13.Text = "E-mail:";
            // 
            // chkFeminino
            // 
            this.chkFeminino.AutoSize = true;
            this.chkFeminino.Location = new System.Drawing.Point(452, 7);
            this.chkFeminino.Name = "chkFeminino";
            this.chkFeminino.Size = new System.Drawing.Size(67, 17);
            this.chkFeminino.TabIndex = 3;
            this.chkFeminino.TabStop = true;
            this.chkFeminino.Tag = "SEXO";
            this.chkFeminino.Text = "Feminino";
            this.chkFeminino.UseVisualStyleBackColor = true;
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Location = new System.Drawing.Point(373, 7);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(73, 17);
            this.chkMasculino.TabIndex = 2;
            this.chkMasculino.TabStop = true;
            this.chkMasculino.Tag = "SEXO";
            this.chkMasculino.Text = "Masculino";
            this.chkMasculino.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 138;
            this.label12.Text = "Sexo:";
            // 
            // chkReceb
            // 
            this.chkReceb.AutoSize = true;
            this.chkReceb.Location = new System.Drawing.Point(10, 185);
            this.chkReceb.Name = "chkReceb";
            this.chkReceb.Size = new System.Drawing.Size(223, 17);
            this.chkReceb.TabIndex = 18;
            this.chkReceb.Tag = "DESJ_NOV";
            this.chkReceb.Text = "Desejo receber novidades em meu e-mail.";
            this.chkReceb.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 135;
            this.label10.Text = "Ocupação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 133;
            this.label2.Text = "Celular:";
            // 
            // txtOcup
            // 
            this.txtOcup.Location = new System.Drawing.Point(78, 136);
            this.txtOcup.Name = "txtOcup";
            this.txtOcup.Size = new System.Drawing.Size(178, 20);
            this.txtOcup.TabIndex = 15;
            this.txtOcup.Tag = "NOM_CONTTO";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(233, 110);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(100, 20);
            this.txtCel.TabIndex = 14;
            this.txtCel.Tag = "NUM_CELULAR";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(70, 110);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 13;
            this.txtTel.Tag = "NUM_TELEFONE";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(199, 32);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(128, 20);
            this.txtRg.TabIndex = 5;
            this.txtRg.Tag = "NUM_RG";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(422, 84);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(88, 20);
            this.txtCep.TabIndex = 12;
            this.txtCep.Tag = "CAD_CEP";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(48, 32);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(113, 20);
            this.txtCpf.TabIndex = 4;
            this.txtCpf.Tag = "NUM_CPF";
            // 
            // nome_cli
            // 
            this.nome_cli.AutoSize = true;
            this.nome_cli.Location = new System.Drawing.Point(100, 8);
            this.nome_cli.Name = "nome_cli";
            this.nome_cli.Size = new System.Drawing.Size(38, 13);
            this.nome_cli.TabIndex = 127;
            this.nome_cli.Text = "Nome:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(283, 84);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(96, 20);
            this.txtBairro.TabIndex = 11;
            this.txtBairro.Tag = "NOM_BAIRRO";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(56, 84);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(60, 20);
            this.txtCidade.TabIndex = 9;
            this.txtCidade.Tag = "ID_CIDADE";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(74, 58);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(319, 20);
            this.txtEndereco.TabIndex = 7;
            this.txtEndereco.Tag = "NOM_ENDERECO";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(422, 58);
            this.txtNum.MaxLength = 5;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(88, 20);
            this.txtNum.TabIndex = 8;
            this.txtNum.Tag = "NUM_END";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(144, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Tag = "NOM_CLIENTE";
            // 
            // num_end
            // 
            this.num_end.AutoSize = true;
            this.num_end.Location = new System.Drawing.Point(399, 61);
            this.num_end.Name = "num_end";
            this.num_end.Size = new System.Drawing.Size(17, 13);
            this.num_end.TabIndex = 118;
            this.num_end.Text = "nº";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 111;
            this.label5.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "Bairro:";
            // 
            // ende_cli
            // 
            this.ende_cli.AutoSize = true;
            this.ende_cli.Location = new System.Drawing.Point(7, 61);
            this.ende_cli.Name = "ende_cli";
            this.ende_cli.Size = new System.Drawing.Size(56, 13);
            this.ende_cli.TabIndex = 106;
            this.ende_cli.Text = "Endereço:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 142;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(70, 218);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(454, 218);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(56, 19);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(10, 218);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(56, 19);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Renda:";
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(402, 31);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(108, 20);
            this.txtRenda.TabIndex = 6;
            // 
            // chkEsp
            // 
            this.chkEsp.AutoSize = true;
            this.chkEsp.Location = new System.Drawing.Point(10, 162);
            this.chkEsp.Name = "chkEsp";
            this.chkEsp.Size = new System.Drawing.Size(112, 17);
            this.chkEsp.TabIndex = 17;
            this.chkEsp.Text = "Cliente ESPECIAL";
            this.chkEsp.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 143;
            this.label9.Text = "Código:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(56, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 20);
            this.txtID.TabIndex = 0;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 249);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkEsp);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCidade2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkFeminino);
            this.Controls.Add(this.chkMasculino);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chkReceb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOcup);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.nome_cli);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.num_end);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ende_cli);
            this.Name = "frmCliente";
            this.Tag = "CAD_CLIENTE";
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Button btnSalvar;
        public UCTextBox txtCidade2;
        public System.Windows.Forms.Button button4;
        public UCTextBox txtEmail;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.RadioButton chkFeminino;
        public System.Windows.Forms.RadioButton chkMasculino;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.CheckBox chkReceb;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label2;
        public UCTextBox txtOcup;
        public UCTextBox txtCel;
        public UCTextBox txtTel;
        public UCTextBox txtRg;
        public UCTextBox txtCep;
        public UCTextBox txtCpf;
        public System.Windows.Forms.Label nome_cli;
        public UCTextBox txtBairro;
        public UCTextBox txtCidade;
        public UCTextBox txtEndereco;
        public UCTextBox txtNum;
        public UCTextBox txtNome;
        public System.Windows.Forms.Label num_end;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label ende_cli;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public UCTextBox txtRenda;
        public System.Windows.Forms.CheckBox chkEsp;
        public System.Windows.Forms.Label label9;
        public UCTextBox txtID;
    }
}