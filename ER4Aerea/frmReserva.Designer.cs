namespace ER4Aerea
{
    partial class frmReserva
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label txtAssento;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            System.Windows.Forms.Label iD_AVIAOLabel;
            System.Windows.Forms.Label vAL_PRECOLabel;
            System.Windows.Forms.Label label3;
            this.txtVoo = new UCTextBox();
            this.txtAssentos = new UCTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValor = new UCTextBox();
            this.txtCliente = new UCTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtId = new UCTextBox();
            this.txtUsuario = new UCTextBox();
            label2 = new System.Windows.Forms.Label();
            txtAssento = new System.Windows.Forms.Label();
            iD_AVIAOLabel = new System.Windows.Forms.Label();
            vAL_PRECOLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVoo
            // 
            this.txtVoo.Location = new System.Drawing.Point(91, 131);
            this.txtVoo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoo.Name = "txtVoo";
            this.txtVoo.Size = new System.Drawing.Size(79, 22);
            this.txtVoo.TabIndex = 129;
            this.txtVoo.Tag = "ID_AVIAO,N";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(8, 135);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(73, 17);
            label2.TabIndex = 130;
            label2.Text = "Voo";
            // 
            // txtAssentos
            // 
            this.txtAssentos.Location = new System.Drawing.Point(91, 101);
            this.txtAssentos.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssentos.Name = "txtAssentos";
            this.txtAssentos.Size = new System.Drawing.Size(79, 22);
            this.txtAssentos.TabIndex = 127;
            this.txtAssentos.Tag = "ID_AVIAO,N";
            // 
            // txtAssento
            // 
            txtAssento.Location = new System.Drawing.Point(8, 105);
            txtAssento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtAssento.Name = "txtAssento";
            txtAssento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtAssento.Size = new System.Drawing.Size(73, 17);
            txtAssento.TabIndex = 128;
            txtAssento.Text = "Assentos";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(91, 202);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 126;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(613, 202);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 125;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(10, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 124;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(91, 161);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 22);
            this.txtValor.TabIndex = 118;
            this.txtValor.Tag = "VAL_PRECO,N";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(91, 41);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(79, 22);
            this.txtCliente.TabIndex = 117;
            this.txtCliente.Tag = "ID_AVIAO,N";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // iD_AVIAOLabel
            // 
            iD_AVIAOLabel.Location = new System.Drawing.Point(8, 45);
            iD_AVIAOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_AVIAOLabel.Name = "iD_AVIAOLabel";
            iD_AVIAOLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            iD_AVIAOLabel.Size = new System.Drawing.Size(73, 17);
            iD_AVIAOLabel.TabIndex = 121;
            iD_AVIAOLabel.Text = "Cliente";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(518, 203);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(88, 22);
            this.txtId.TabIndex = 116;
            this.txtId.Tag = "ID_VOO,N";
            // 
            // vAL_PRECOLabel
            // 
            vAL_PRECOLabel.Location = new System.Drawing.Point(8, 166);
            vAL_PRECOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vAL_PRECOLabel.Name = "vAL_PRECOLabel";
            vAL_PRECOLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            vAL_PRECOLabel.Size = new System.Drawing.Size(73, 17);
            vAL_PRECOLabel.TabIndex = 122;
            vAL_PRECOLabel.Text = "Valor";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(91, 71);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(79, 22);
            this.txtUsuario.TabIndex = 131;
            this.txtUsuario.Tag = "ID_AVIAO,N";
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(8, 75);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(73, 17);
            label3.TabIndex = 132;
            label3.Text = "Usuario";
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 246);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtVoo);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtAssentos);
            this.Controls.Add(txtAssento);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iD_AVIAOLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(vAL_PRECOLabel);
            this.Name = "frmReserva";
            this.Text = "frmReserva";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public UCTextBox txtVoo;
        public UCTextBox txtAssentos;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Button btnSalvar;
        public UCTextBox txtValor;
        public UCTextBox txtCliente;
        public System.Windows.Forms.PictureBox pictureBox1;
        public UCTextBox txtId;
        public UCTextBox txtUsuario;
    }
}