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
            System.Windows.Forms.Label iD_AVIAOLabel;
            System.Windows.Forms.Label qTD_ASSENTOLabel;
            System.Windows.Forms.Label nOM_MODELOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAviao));
            this.ID_AVIAO = new System.Windows.Forms.TextBox();
            this.qTD_ASSENTOTextBox = new System.Windows.Forms.TextBox();
            this.nOM_MODELOTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iD_AVIAOLabel = new System.Windows.Forms.Label();
            qTD_ASSENTOLabel = new System.Windows.Forms.Label();
            nOM_MODELOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_AVIAOLabel
            // 
            iD_AVIAOLabel.AutoSize = true;
            iD_AVIAOLabel.Location = new System.Drawing.Point(16, 15);
            iD_AVIAOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_AVIAOLabel.Name = "iD_AVIAOLabel";
            iD_AVIAOLabel.Size = new System.Drawing.Size(56, 17);
            iD_AVIAOLabel.TabIndex = 1;
            iD_AVIAOLabel.Tag = "CAD_AVIAO";
            iD_AVIAOLabel.Text = "Código:";
            // 
            // qTD_ASSENTOLabel
            // 
            qTD_ASSENTOLabel.AutoSize = true;
            qTD_ASSENTOLabel.Location = new System.Drawing.Point(16, 47);
            qTD_ASSENTOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qTD_ASSENTOLabel.Name = "qTD_ASSENTOLabel";
            qTD_ASSENTOLabel.Size = new System.Drawing.Size(167, 17);
            qTD_ASSENTOLabel.TabIndex = 3;
            qTD_ASSENTOLabel.Text = "Quantidade de assentos:";
            // 
            // nOM_MODELOLabel
            // 
            nOM_MODELOLabel.AutoSize = true;
            nOM_MODELOLabel.Location = new System.Drawing.Point(191, 15);
            nOM_MODELOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOM_MODELOLabel.Name = "nOM_MODELOLabel";
            nOM_MODELOLabel.Size = new System.Drawing.Size(58, 17);
            nOM_MODELOLabel.TabIndex = 5;
            nOM_MODELOLabel.Text = "Modelo:";
            // 
            // ID_AVIAO
            // 
            this.ID_AVIAO.Location = new System.Drawing.Point(81, 11);
            this.ID_AVIAO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ID_AVIAO.Name = "ID_AVIAO";
            this.ID_AVIAO.Size = new System.Drawing.Size(100, 22);
            this.ID_AVIAO.TabIndex = 1;
            this.ID_AVIAO.Tag = "ID_AVIAO,N";
            // 
            // qTD_ASSENTOTextBox
            // 
            this.qTD_ASSENTOTextBox.Location = new System.Drawing.Point(191, 43);
            this.qTD_ASSENTOTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qTD_ASSENTOTextBox.Name = "qTD_ASSENTOTextBox";
            this.qTD_ASSENTOTextBox.Size = new System.Drawing.Size(85, 22);
            this.qTD_ASSENTOTextBox.TabIndex = 3;
            this.qTD_ASSENTOTextBox.Tag = "QTD_ASSENTO,N";
            // 
            // nOM_MODELOTextBox
            // 
            this.nOM_MODELOTextBox.Location = new System.Drawing.Point(259, 11);
            this.nOM_MODELOTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nOM_MODELOTextBox.Name = "nOM_MODELOTextBox";
            this.nOM_MODELOTextBox.Size = new System.Drawing.Size(157, 22);
            this.nOM_MODELOTextBox.TabIndex = 2;
            this.nOM_MODELOTextBox.Tag = "NOM_MODELO,C";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(16, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 55);
            this.panel1.TabIndex = 42;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(220, 20);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(328, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAviao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 203);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iD_AVIAOLabel);
            this.Controls.Add(this.ID_AVIAO);
            this.Controls.Add(qTD_ASSENTOLabel);
            this.Controls.Add(this.qTD_ASSENTOTextBox);
            this.Controls.Add(nOM_MODELOLabel);
            this.Controls.Add(this.nOM_MODELOTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAviao";
            this.Tag = "CAD_AVIAO";
            this.Text = "frmAviao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_AVIAO;
        private System.Windows.Forms.TextBox qTD_ASSENTOTextBox;
        private System.Windows.Forms.TextBox nOM_MODELOTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}