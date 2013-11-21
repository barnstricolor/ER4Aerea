namespace ER4Aerea
{
    partial class frmAviao
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
            System.Windows.Forms.Label qTD_ASSENTOLabel;
            System.Windows.Forms.Label nOM_MODELOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAviao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtId = new ER4Aerea.UCTextBox();
            this.txtAssento = new ER4Aerea.UCTextBox();
            this.txtModelo = new ER4Aerea.UCTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            qTD_ASSENTOLabel = new System.Windows.Forms.Label();
            nOM_MODELOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // qTD_ASSENTOLabel
            // 
            qTD_ASSENTOLabel.AutoSize = true;
            qTD_ASSENTOLabel.Location = new System.Drawing.Point(34, 70);
            qTD_ASSENTOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qTD_ASSENTOLabel.Name = "qTD_ASSENTOLabel";
            qTD_ASSENTOLabel.Size = new System.Drawing.Size(167, 17);
            qTD_ASSENTOLabel.TabIndex = 46;
            qTD_ASSENTOLabel.Text = "Quantidade de assentos:";
            // 
            // nOM_MODELOLabel
            // 
            nOM_MODELOLabel.AutoSize = true;
            nOM_MODELOLabel.Location = new System.Drawing.Point(209, 38);
            nOM_MODELOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOM_MODELOLabel.Name = "nOM_MODELOLabel";
            nOM_MODELOLabel.Size = new System.Drawing.Size(58, 17);
            nOM_MODELOLabel.TabIndex = 48;
            nOM_MODELOLabel.Text = "Modelo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(98, 33);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 44;
            this.txtId.Tag = "ID_AVIAO,N";
            // 
            // txtAssento
            // 
            this.txtAssento.Location = new System.Drawing.Point(209, 66);
            this.txtAssento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssento.Name = "txtAssento";
            this.txtAssento.Size = new System.Drawing.Size(85, 22);
            this.txtAssento.TabIndex = 47;
            this.txtAssento.Tag = "N";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(277, 34);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(157, 22);
            this.txtModelo.TabIndex = 45;
            this.txtModelo.Tag = "NOM_MODELO,C";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(99, 215);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 52;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(621, 215);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 51;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(18, 215);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmAviao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 250);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(qTD_ASSENTOLabel);
            this.Controls.Add(this.txtAssento);
            this.Controls.Add(nOM_MODELOLabel);
            this.Controls.Add(this.txtModelo);
            this.Name = "frmAviao";
            this.Text = "frmAviao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Button btnSalvar;
        public UCTextBox txtId;
        public UCTextBox txtAssento;
        public UCTextBox txtModelo;
    }
}