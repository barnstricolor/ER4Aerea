namespace ER4Aerea
{
    partial class frmTrecho
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
            System.Windows.Forms.Label iD_TRECHOLabel;
            System.Windows.Forms.Label iD_ORIGEMLabel;
            System.Windows.Forms.Label iD_DESTINOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrecho));
            this.dataSet1 = new ER4Aerea.DataSet1();
            this.cAD_TRECHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_TRECHOTableAdapter = new ER4Aerea.DataSet1TableAdapters.CAD_TRECHOTableAdapter();
            this.tableAdapterManager = new ER4Aerea.DataSet1TableAdapters.TableAdapterManager();
            this.ID_TRECHO = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cid_cli = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            iD_TRECHOLabel = new System.Windows.Forms.Label();
            iD_ORIGEMLabel = new System.Windows.Forms.Label();
            iD_DESTINOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_TRECHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_TRECHOLabel
            // 
            iD_TRECHOLabel.AutoSize = true;
            iD_TRECHOLabel.Location = new System.Drawing.Point(12, 9);
            iD_TRECHOLabel.Name = "iD_TRECHOLabel";
            iD_TRECHOLabel.Size = new System.Drawing.Size(43, 13);
            iD_TRECHOLabel.TabIndex = 1;
            iD_TRECHOLabel.Text = "Código:";
            // 
            // iD_ORIGEMLabel
            // 
            iD_ORIGEMLabel.AutoSize = true;
            iD_ORIGEMLabel.Location = new System.Drawing.Point(12, 35);
            iD_ORIGEMLabel.Name = "iD_ORIGEMLabel";
            iD_ORIGEMLabel.Size = new System.Drawing.Size(43, 13);
            iD_ORIGEMLabel.TabIndex = 3;
            iD_ORIGEMLabel.Text = "Origem:";
            // 
            // iD_DESTINOLabel
            // 
            iD_DESTINOLabel.AutoSize = true;
            iD_DESTINOLabel.Location = new System.Drawing.Point(12, 61);
            iD_DESTINOLabel.Name = "iD_DESTINOLabel";
            iD_DESTINOLabel.Size = new System.Drawing.Size(46, 13);
            iD_DESTINOLabel.TabIndex = 5;
            iD_DESTINOLabel.Text = "Destino:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAD_TRECHOBindingSource
            // 
            this.cAD_TRECHOBindingSource.DataMember = "CAD_TRECHO";
            this.cAD_TRECHOBindingSource.DataSource = this.dataSet1;
            // 
            // cAD_TRECHOTableAdapter
            // 
            this.cAD_TRECHOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAD_ASSENTOTableAdapter = null;
            this.tableAdapterManager.CAD_AVIAOTableAdapter = null;
            this.tableAdapterManager.CAD_CIDADETableAdapter = null;
            this.tableAdapterManager.CAD_CLIENTETableAdapter = null;
            this.tableAdapterManager.CAD_PRECOTableAdapter = null;
            this.tableAdapterManager.CAD_PROMOCAOTableAdapter = null;
            this.tableAdapterManager.CAD_RESERVATableAdapter = null;
            this.tableAdapterManager.CAD_TRECHOTableAdapter = this.cAD_TRECHOTableAdapter;
            this.tableAdapterManager.CAD_USUARIOTableAdapter = null;
            this.tableAdapterManager.CAD_VOOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ER4Aerea.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ID_TRECHO
            // 
            this.ID_TRECHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_TRECHOBindingSource, "ID_TRECHO", true));
            this.ID_TRECHO.Location = new System.Drawing.Point(61, 6);
            this.ID_TRECHO.Name = "ID_TRECHO";
            this.ID_TRECHO.Size = new System.Drawing.Size(44, 20);
            this.ID_TRECHO.TabIndex = 1;
            this.ID_TRECHO.Tag = "ID_TRECHO,N";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cid_cli
            // 
            this.cid_cli.Location = new System.Drawing.Point(61, 32);
            this.cid_cli.Name = "cid_cli";
            this.cid_cli.Size = new System.Drawing.Size(60, 20);
            this.cid_cli.TabIndex = 2;
            this.cid_cli.Tag = "ID_ORIGEM,N";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 105;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "ID_DESTINO,N";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 107;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 45);
            this.panel1.TabIndex = 108;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(165, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Gravar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(84, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Localizar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmTrecho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 168);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cid_cli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iD_TRECHOLabel);
            this.Controls.Add(this.ID_TRECHO);
            this.Controls.Add(iD_ORIGEMLabel);
            this.Controls.Add(iD_DESTINOLabel);
            this.Name = "frmTrecho";
            this.Tag = "CAD_TRECHO";
            this.Text = "frmTrecho";
            this.Load += new System.EventHandler(this.frmTrecho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_TRECHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cAD_TRECHOBindingSource;
        private DataSet1TableAdapters.CAD_TRECHOTableAdapter cAD_TRECHOTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ID_TRECHO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cid_cli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}