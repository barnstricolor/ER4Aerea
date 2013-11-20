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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoo));
            System.Windows.Forms.Label Chegada;
            this.dtpPartida = new System.Windows.Forms.DateTimePicker();
            this.txtId = new UCTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAviao = new UCTextBox();
            this.txtPreco = new UCTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtOrigem = new UCTextBox();
            this.txtDestino = new UCTextBox();
            this.dtpChegada = new System.Windows.Forms.DateTimePicker();
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
            dAT_PARTIDALabel.Location = new System.Drawing.Point(16, 75);
            dAT_PARTIDALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dAT_PARTIDALabel.Name = "dAT_PARTIDALabel";
            dAT_PARTIDALabel.Size = new System.Drawing.Size(53, 17);
            dAT_PARTIDALabel.TabIndex = 5;
            dAT_PARTIDALabel.Text = "Partida";
            // 
            // iD_AVIAOLabel
            // 
            iD_AVIAOLabel.AutoSize = true;
            iD_AVIAOLabel.Location = new System.Drawing.Point(16, 43);
            iD_AVIAOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_AVIAOLabel.Name = "iD_AVIAOLabel";
            iD_AVIAOLabel.Size = new System.Drawing.Size(73, 17);
            iD_AVIAOLabel.TabIndex = 7;
            iD_AVIAOLabel.Text = "Aeronave:";
            // 
            // vAL_PRECOLabel
            // 
            vAL_PRECOLabel.AutoSize = true;
            vAL_PRECOLabel.Location = new System.Drawing.Point(46, 194);
            vAL_PRECOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vAL_PRECOLabel.Name = "vAL_PRECOLabel";
            vAL_PRECOLabel.Size = new System.Drawing.Size(45, 17);
            vAL_PRECOLabel.TabIndex = 13;
            vAL_PRECOLabel.Text = "Valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 133);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 17);
            label1.TabIndex = 113;
            label1.Text = "Origem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 163);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 17);
            label2.TabIndex = 115;
            label2.Text = "Destino\r\n";
            // 
            // dtpPartida
            // 
            this.dtpPartida.Location = new System.Drawing.Point(99, 69);
            this.dtpPartida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPartida.Name = "dtpPartida";
            this.dtpPartida.Size = new System.Drawing.Size(291, 22);
            this.dtpPartida.TabIndex = 5;
            this.dtpPartida.Tag = "DAT_PARTIDA,D";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(519, 231);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(88, 22);
            this.txtId.TabIndex = 1;
            this.txtId.Tag = "ID_VOO,N";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtAviao
            // 
            this.txtAviao.Location = new System.Drawing.Point(99, 39);
            this.txtAviao.Margin = new System.Windows.Forms.Padding(4);
            this.txtAviao.Name = "txtAviao";
            this.txtAviao.Size = new System.Drawing.Size(79, 22);
            this.txtAviao.TabIndex = 3;
            this.txtAviao.Tag = "ID_AVIAO,N";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(99, 189);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(79, 22);
            this.txtPreco.TabIndex = 4;
            this.txtPreco.Tag = "VAL_PRECO,N";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(99, 230);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 111;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(614, 230);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 110;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(18, 230);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 109;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(99, 129);
            this.txtOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(79, 22);
            this.txtOrigem.TabIndex = 112;
            this.txtOrigem.Tag = "ID_AVIAO,N";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(99, 159);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(79, 22);
            this.txtDestino.TabIndex = 114;
            this.txtDestino.Tag = "ID_AVIAO,N";
            // 
            // Chegada
            // 
            Chegada.AutoSize = true;
            Chegada.Location = new System.Drawing.Point(16, 105);
            Chegada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Chegada.Name = "Chegada";
            Chegada.Size = new System.Drawing.Size(53, 17);
            Chegada.TabIndex = 116;
            Chegada.Text = "Partida";
            // 
            // dtpChegada
            // 
            this.dtpChegada.Location = new System.Drawing.Point(99, 99);
            this.dtpChegada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpChegada.Name = "dtpChegada";
            this.dtpChegada.Size = new System.Drawing.Size(291, 22);
            this.dtpChegada.TabIndex = 117;
            this.dtpChegada.Tag = "DAT_PARTIDA,D";
            // 
            // frmVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 269);
            this.Controls.Add(Chegada);
            this.Controls.Add(this.dtpChegada);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtAviao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(dAT_PARTIDALabel);
            this.Controls.Add(this.dtpPartida);
            this.Controls.Add(iD_AVIAOLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(vAL_PRECOLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        public UCTextBox txtAviao;
        public UCTextBox txtPreco;
        public UCTextBox txtOrigem;
        public UCTextBox txtDestino;
        public System.Windows.Forms.DateTimePicker dtpChegada;

    }
}