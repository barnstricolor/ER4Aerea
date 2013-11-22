namespace ER4Aerea
{
    partial class frmVoo
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
            System.Windows.Forms.Label dAT_PARTIDALabel;
            System.Windows.Forms.Label iD_AVIAOLabel;
            System.Windows.Forms.Label vAL_PRECOLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label Chegada;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoo));
            this.dtpPartida = new System.Windows.Forms.DateTimePicker();
            this.txtId = new ER4Aerea.UCTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPreco = new ER4Aerea.UCTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpChegada = new System.Windows.Forms.DateTimePicker();
            this.dcbOrigem = new System.Windows.Forms.ComboBox();
            this.dcbDestino = new System.Windows.Forms.ComboBox();
            this.dcbAviao = new System.Windows.Forms.ComboBox();
            this.chkPromocao = new System.Windows.Forms.CheckBox();
            dAT_PARTIDALabel = new System.Windows.Forms.Label();
            iD_AVIAOLabel = new System.Windows.Forms.Label();
            vAL_PRECOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            Chegada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dAT_PARTIDALabel
            // 
            dAT_PARTIDALabel.AutoSize = true;
            dAT_PARTIDALabel.Location = new System.Drawing.Point(29, 61);
            dAT_PARTIDALabel.Name = "dAT_PARTIDALabel";
            dAT_PARTIDALabel.Size = new System.Drawing.Size(40, 13);
            dAT_PARTIDALabel.TabIndex = 5;
            dAT_PARTIDALabel.Text = "Partida";
            // 
            // iD_AVIAOLabel
            // 
            iD_AVIAOLabel.AutoSize = true;
            iD_AVIAOLabel.Location = new System.Drawing.Point(15, 37);
            iD_AVIAOLabel.Name = "iD_AVIAOLabel";
            iD_AVIAOLabel.Size = new System.Drawing.Size(56, 13);
            iD_AVIAOLabel.TabIndex = 7;
            iD_AVIAOLabel.Text = "Aeronave:";
            // 
            // vAL_PRECOLabel
            // 
            vAL_PRECOLabel.AutoSize = true;
            vAL_PRECOLabel.Location = new System.Drawing.Point(35, 160);
            vAL_PRECOLabel.Name = "vAL_PRECOLabel";
            vAL_PRECOLabel.Size = new System.Drawing.Size(34, 13);
            vAL_PRECOLabel.TabIndex = 13;
            vAL_PRECOLabel.Text = "Valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 108);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 13);
            label1.TabIndex = 113;
            label1.Text = "Origem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 132);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 13);
            label2.TabIndex = 115;
            label2.Text = "Destino\r\n";
            // 
            // Chegada
            // 
            Chegada.AutoSize = true;
            Chegada.Location = new System.Drawing.Point(21, 84);
            Chegada.Name = "Chegada";
            Chegada.Size = new System.Drawing.Size(50, 13);
            Chegada.TabIndex = 116;
            Chegada.Text = "Chegada";
            // 
            // dtpPartida
            // 
            this.dtpPartida.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpPartida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPartida.Location = new System.Drawing.Point(74, 60);
            this.dtpPartida.Name = "dtpPartida";
            this.dtpPartida.ShowUpDown = true;
            this.dtpPartida.Size = new System.Drawing.Size(219, 20);
            this.dtpPartida.TabIndex = 1;
            this.dtpPartida.Tag = "1";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(389, 188);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(67, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Tag = "ID_VOO,N";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(74, 158);
            this.txtPreco.MaxLength = 20;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(60, 20);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.Tag = "D";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(74, 187);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(460, 187);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(56, 19);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(14, 187);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(56, 19);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpChegada
            // 
            this.dtpChegada.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpChegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChegada.Location = new System.Drawing.Point(74, 84);
            this.dtpChegada.Name = "dtpChegada";
            this.dtpChegada.Size = new System.Drawing.Size(219, 20);
            this.dtpChegada.TabIndex = 2;
            this.dtpChegada.Tag = "2";
            // 
            // dcbOrigem
            // 
            this.dcbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcbOrigem.FormattingEnabled = true;
            this.dcbOrigem.Location = new System.Drawing.Point(74, 108);
            this.dcbOrigem.Margin = new System.Windows.Forms.Padding(2);
            this.dcbOrigem.Name = "dcbOrigem";
            this.dcbOrigem.Size = new System.Drawing.Size(219, 21);
            this.dcbOrigem.TabIndex = 3;
            // 
            // dcbDestino
            // 
            this.dcbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcbDestino.FormattingEnabled = true;
            this.dcbDestino.Location = new System.Drawing.Point(74, 132);
            this.dcbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.dcbDestino.Name = "dcbDestino";
            this.dcbDestino.Size = new System.Drawing.Size(219, 21);
            this.dcbDestino.TabIndex = 4;
            // 
            // dcbAviao
            // 
            this.dcbAviao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcbAviao.FormattingEnabled = true;
            this.dcbAviao.Location = new System.Drawing.Point(74, 35);
            this.dcbAviao.Margin = new System.Windows.Forms.Padding(2);
            this.dcbAviao.Name = "dcbAviao";
            this.dcbAviao.Size = new System.Drawing.Size(219, 21);
            this.dcbAviao.TabIndex = 0;
            this.dcbAviao.Tag = "";
            // 
            // chkPromocao
            // 
            this.chkPromocao.AutoSize = true;
            this.chkPromocao.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPromocao.Location = new System.Drawing.Point(222, 158);
            this.chkPromocao.Name = "chkPromocao";
            this.chkPromocao.Size = new System.Drawing.Size(74, 17);
            this.chkPromocao.TabIndex = 6;
            this.chkPromocao.Tag = "";
            this.chkPromocao.Text = "Promoção";
            this.chkPromocao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPromocao.UseVisualStyleBackColor = true;
            // 
            // frmVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 219);
            this.Controls.Add(this.chkPromocao);
            this.Controls.Add(this.dcbAviao);
            this.Controls.Add(this.dcbDestino);
            this.Controls.Add(this.dcbOrigem);
            this.Controls.Add(Chegada);
            this.Controls.Add(this.dtpChegada);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(dAT_PARTIDALabel);
            this.Controls.Add(this.dtpPartida);
            this.Controls.Add(iD_AVIAOLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(vAL_PRECOLabel);
            this.Name = "frmVoo";
            this.Tag = "CAD_VOO";
            this.Text = "frmVoo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.DateTimePicker dtpPartida;
        public UCTextBox txtId;
        public System.Windows.Forms.PictureBox pictureBox1;
        public UCTextBox txtPreco;
        public System.Windows.Forms.DateTimePicker dtpChegada;
        public System.Windows.Forms.ComboBox dcbOrigem;
        public System.Windows.Forms.ComboBox dcbDestino;
        public System.Windows.Forms.ComboBox dcbAviao;
        public System.Windows.Forms.CheckBox chkPromocao;

    }
}