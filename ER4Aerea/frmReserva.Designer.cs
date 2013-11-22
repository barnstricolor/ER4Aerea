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
            System.Windows.Forms.Label iD_AVIAOLabel;
            System.Windows.Forms.Label vAL_PRECOLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.txtVoo = new ER4Aerea.UCTextBox();
            this.txtAssentos = new ER4Aerea.UCTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValor = new ER4Aerea.UCTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtId = new ER4Aerea.UCTextBox();
            this.dcbCliente = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            txtAssento = new System.Windows.Forms.Label();
            iD_AVIAOLabel = new System.Windows.Forms.Label();
            vAL_PRECOLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // txtVoo
            // 
            this.txtVoo.Location = new System.Drawing.Point(91, 135);
            this.txtVoo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoo.Name = "txtVoo";
            this.txtVoo.Size = new System.Drawing.Size(79, 22);
            this.txtVoo.TabIndex = 129;
            this.txtVoo.Tag = "ID_AVIAO,N";
            // 
            // txtAssentos
            // 
            this.txtAssentos.Location = new System.Drawing.Point(91, 106);
            this.txtAssentos.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssentos.Name = "txtAssentos";
            this.txtAssentos.Size = new System.Drawing.Size(79, 22);
            this.txtAssentos.TabIndex = 127;
            this.txtAssentos.Tag = "ID_AVIAO,N";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(91, 202);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 126;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(91, 165);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 22);
            this.txtValor.TabIndex = 118;
            this.txtValor.Tag = "VAL_PRECO,N";
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
            // dcbCliente
            // 
            this.dcbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcbCliente.FormattingEnabled = true;
            this.dcbCliente.Location = new System.Drawing.Point(91, 42);
            this.dcbCliente.Name = "dcbCliente";
            this.dcbCliente.Size = new System.Drawing.Size(338, 24);
            this.dcbCliente.TabIndex = 133;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(338, 24);
            this.comboBox1.TabIndex = 134;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 246);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dcbCliente);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtVoo);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtAssentos);
            this.Controls.Add(txtAssento);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValor);
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
        public System.Windows.Forms.PictureBox pictureBox1;
        public UCTextBox txtId;
        public System.Windows.Forms.ComboBox dcbCliente;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}