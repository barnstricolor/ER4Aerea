namespace ER4Aerea
{
    partial class frmUsuario
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
            System.Windows.Forms.Label nOM_ENDERECOLabel;
            System.Windows.Forms.Label nOM_USUARIOLabel;
            System.Windows.Forms.Label nOM_SENHALabel;
            System.Windows.Forms.Label nUM_CPFLabel;
            System.Windows.Forms.Label nOM_LOGINLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.txtId = new ER4Aerea.UCTextBox();
            this.txtEndereco = new ER4Aerea.UCTextBox();
            this.txtNome = new ER4Aerea.UCTextBox();
            this.txtSenha = new ER4Aerea.UCTextBox();
            this.txtCpf = new ER4Aerea.UCTextBox();
            this.txtLogin = new ER4Aerea.UCTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNumero = new ER4Aerea.UCTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dcbCidade = new System.Windows.Forms.ComboBox();
            nOM_ENDERECOLabel = new System.Windows.Forms.Label();
            nOM_USUARIOLabel = new System.Windows.Forms.Label();
            nOM_SENHALabel = new System.Windows.Forms.Label();
            nUM_CPFLabel = new System.Windows.Forms.Label();
            nOM_LOGINLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nOM_ENDERECOLabel
            // 
            nOM_ENDERECOLabel.AutoSize = true;
            nOM_ENDERECOLabel.Location = new System.Drawing.Point(199, 43);
            nOM_ENDERECOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOM_ENDERECOLabel.Name = "nOM_ENDERECOLabel";
            nOM_ENDERECOLabel.Size = new System.Drawing.Size(73, 17);
            nOM_ENDERECOLabel.TabIndex = 3;
            nOM_ENDERECOLabel.Tag = "";
            nOM_ENDERECOLabel.Text = "Endereço:";
            // 
            // nOM_USUARIOLabel
            // 
            nOM_USUARIOLabel.AutoSize = true;
            nOM_USUARIOLabel.Location = new System.Drawing.Point(16, 10);
            nOM_USUARIOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOM_USUARIOLabel.Name = "nOM_USUARIOLabel";
            nOM_USUARIOLabel.Size = new System.Drawing.Size(49, 17);
            nOM_USUARIOLabel.TabIndex = 5;
            nOM_USUARIOLabel.Tag = "";
            nOM_USUARIOLabel.Text = "Nome:";
            // 
            // nOM_SENHALabel
            // 
            nOM_SENHALabel.AutoSize = true;
            nOM_SENHALabel.Location = new System.Drawing.Point(236, 107);
            nOM_SENHALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOM_SENHALabel.Name = "nOM_SENHALabel";
            nOM_SENHALabel.Size = new System.Drawing.Size(53, 17);
            nOM_SENHALabel.TabIndex = 7;
            nOM_SENHALabel.Tag = "";
            nOM_SENHALabel.Text = "Senha:";
            // 
            // nUM_CPFLabel
            // 
            nUM_CPFLabel.AutoSize = true;
            nUM_CPFLabel.Location = new System.Drawing.Point(16, 43);
            nUM_CPFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nUM_CPFLabel.Name = "nUM_CPFLabel";
            nUM_CPFLabel.Size = new System.Drawing.Size(38, 17);
            nUM_CPFLabel.TabIndex = 9;
            nUM_CPFLabel.Tag = "";
            nUM_CPFLabel.Text = "CPF:";
            // 
            // nOM_LOGINLabel
            // 
            nOM_LOGINLabel.AutoSize = true;
            nOM_LOGINLabel.Location = new System.Drawing.Point(16, 107);
            nOM_LOGINLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOM_LOGINLabel.Name = "nOM_LOGINLabel";
            nOM_LOGINLabel.Size = new System.Drawing.Size(47, 17);
            nOM_LOGINLabel.TabIndex = 11;
            nOM_LOGINLabel.Tag = "";
            nOM_LOGINLabel.Text = "Login:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(139, 74);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 17);
            label1.TabIndex = 15;
            label1.Tag = "";
            label1.Text = "Cidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 72);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 17);
            label3.TabIndex = 18;
            label3.Tag = "";
            label3.Text = "Nº:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(503, 207);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(68, 22);
            this.txtId.TabIndex = 1;
            this.txtId.Tag = "";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(281, 39);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(167, 22);
            this.txtEndereco.TabIndex = 2;
            this.txtEndereco.Tag = "";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 7);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.Tag = "";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(299, 103);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(149, 22);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.Tag = "";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(76, 39);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(113, 22);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.Tag = "N";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(76, 103);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(151, 22);
            this.txtLogin.TabIndex = 5;
            this.txtLogin.Tag = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(76, 69);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(37, 22);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.Tag = "N";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(93, 206);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Tag = "";
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(578, 206);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Tag = "";
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 206);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Tag = "";
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dcbCidade
            // 
            this.dcbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcbCidade.FormattingEnabled = true;
            this.dcbCidade.Location = new System.Drawing.Point(202, 68);
            this.dcbCidade.Name = "dcbCidade";
            this.dcbCidade.Size = new System.Drawing.Size(248, 24);
            this.dcbCidade.TabIndex = 4;
            this.dcbCidade.Tag = "";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 241);
            this.Controls.Add(this.dcbCidade);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(nOM_ENDERECOLabel);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(nOM_USUARIOLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(nOM_SENHALabel);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(nUM_CPFLabel);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(nOM_LOGINLabel);
            this.Controls.Add(this.txtLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuario";
            this.Tag = "CAD_USUARIO";
            this.Text = "frmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Button btnSalvar;
        public UCTextBox txtId;
        public UCTextBox txtEndereco;
        public UCTextBox txtNome;
        public UCTextBox txtSenha;
        public UCTextBox txtCpf;
        public UCTextBox txtLogin;
        public System.Windows.Forms.PictureBox pictureBox1;
        public UCTextBox txtNumero;
        public System.Windows.Forms.ComboBox dcbCidade;
    }
}