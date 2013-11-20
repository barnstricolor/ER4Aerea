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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.txtId = new ER4Aerea.UCTextBox();
            this.nOM_ENDERECOTextBox = new ER4Aerea.UCTextBox();
            this.txtNome = new ER4Aerea.UCTextBox();
            this.txtSenha = new ER4Aerea.UCTextBox();
            this.nUM_CPFTextBox = new ER4Aerea.UCTextBox();
            this.txtLogin = new ER4Aerea.UCTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new ER4Aerea.UCTextBox();
            this.textBox2 = new ER4Aerea.UCTextBox();
            this.textBox3 = new ER4Aerea.UCTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            nOM_ENDERECOLabel = new System.Windows.Forms.Label();
            nOM_USUARIOLabel = new System.Windows.Forms.Label();
            nOM_SENHALabel = new System.Windows.Forms.Label();
            nUM_CPFLabel = new System.Windows.Forms.Label();
            nOM_LOGINLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
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
            nOM_LOGINLabel.Text = "Login:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(100, 75);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 17);
            label1.TabIndex = 15;
            label1.Text = "Cidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(375, 75);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 17);
            label2.TabIndex = 17;
            label2.Text = "UF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 75);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 17);
            label3.TabIndex = 18;
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
            this.txtId.Tag = "ID_USUARIO,N";
            // 
            // nOM_ENDERECOTextBox
            // 
            this.nOM_ENDERECOTextBox.Location = new System.Drawing.Point(281, 39);
            this.nOM_ENDERECOTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nOM_ENDERECOTextBox.Name = "nOM_ENDERECOTextBox";
            this.nOM_ENDERECOTextBox.Size = new System.Drawing.Size(167, 22);
            this.nOM_ENDERECOTextBox.TabIndex = 4;
            this.nOM_ENDERECOTextBox.Tag = "NOM_ENDERECO,C";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 7);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.Tag = "NOM_USUARIO,C";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(299, 103);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(149, 22);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.Tag = "";
            // 
            // nUM_CPFTextBox
            // 
            this.nUM_CPFTextBox.Location = new System.Drawing.Point(76, 39);
            this.nUM_CPFTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nUM_CPFTextBox.MaxLength = 11;
            this.nUM_CPFTextBox.Name = "nUM_CPFTextBox";
            this.nUM_CPFTextBox.Size = new System.Drawing.Size(113, 22);
            this.nUM_CPFTextBox.TabIndex = 3;
            this.nUM_CPFTextBox.Tag = "NUM_CPF,N";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(76, 103);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(151, 22);
            this.txtLogin.TabIndex = 7;
            this.txtLogin.Tag = "NOM_LOGIN,C";
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Tag = "NOM_CIDADE,C";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(415, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Tag = "NOM_UF,C";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 71);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 22);
            this.textBox3.TabIndex = 19;
            this.textBox3.Tag = "NUM_ENDERECO,N";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(335, 71);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 25);
            this.button4.TabIndex = 104;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(93, 206);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(578, 206);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 106;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 206);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 105;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 241);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(nOM_ENDERECOLabel);
            this.Controls.Add(this.nOM_ENDERECOTextBox);
            this.Controls.Add(nOM_USUARIOLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(nOM_SENHALabel);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(nUM_CPFLabel);
            this.Controls.Add(this.nUM_CPFTextBox);
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
        public UCTextBox nOM_ENDERECOTextBox;
        public UCTextBox txtNome;
        public UCTextBox txtSenha;
        public UCTextBox nUM_CPFTextBox;
        public UCTextBox txtLogin;
        public System.Windows.Forms.PictureBox pictureBox1;
        public UCTextBox textBox1;
        public UCTextBox textBox2;
        public UCTextBox textBox3;
        public System.Windows.Forms.Button button4;
    }
}