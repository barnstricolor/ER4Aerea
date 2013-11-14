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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label qTD_PASSAGEIROSLabel;
            System.Windows.Forms.Label dAT_CHEGADALabel;
            System.Windows.Forms.Label dAT_PARTIDALabel;
            System.Windows.Forms.Label iD_AVIAOLabel;
            System.Windows.Forms.Label iD_VOOLabel;
            System.Windows.Forms.Label iD_TRECHOLabel;
            System.Windows.Forms.Label vAL_PRECOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoo));
            this.dataSet1 = new ER4Aerea.DataSet1();
            this.cAD_VOOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_VOOTableAdapter = new ER4Aerea.DataSet1TableAdapters.CAD_VOOTableAdapter();
            this.tableAdapterManager = new ER4Aerea.DataSet1TableAdapters.TableAdapterManager();
            this.qTD_PASSAGEIROSTextBox = new System.Windows.Forms.TextBox();
            this.dAT_CHEGADADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dAT_PARTIDADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ID_VOO = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cid_cli = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            qTD_PASSAGEIROSLabel = new System.Windows.Forms.Label();
            dAT_CHEGADALabel = new System.Windows.Forms.Label();
            dAT_PARTIDALabel = new System.Windows.Forms.Label();
            iD_AVIAOLabel = new System.Windows.Forms.Label();
            iD_VOOLabel = new System.Windows.Forms.Label();
            iD_TRECHOLabel = new System.Windows.Forms.Label();
            vAL_PRECOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_VOOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qTD_PASSAGEIROSLabel
            // 
            qTD_PASSAGEIROSLabel.AutoSize = true;
            qTD_PASSAGEIROSLabel.Location = new System.Drawing.Point(12, 113);
            qTD_PASSAGEIROSLabel.Name = "qTD_PASSAGEIROSLabel";
            qTD_PASSAGEIROSLabel.Size = new System.Drawing.Size(139, 13);
            qTD_PASSAGEIROSLabel.TabIndex = 1;
            qTD_PASSAGEIROSLabel.Text = "Quantidade de passageiros:";
            // 
            // dAT_CHEGADALabel
            // 
            dAT_CHEGADALabel.AutoSize = true;
            dAT_CHEGADALabel.Location = new System.Drawing.Point(12, 90);
            dAT_CHEGADALabel.Name = "dAT_CHEGADALabel";
            dAT_CHEGADALabel.Size = new System.Drawing.Size(93, 13);
            dAT_CHEGADALabel.TabIndex = 3;
            dAT_CHEGADALabel.Text = "Data de chegada:";
            // 
            // dAT_PARTIDALabel
            // 
            dAT_PARTIDALabel.AutoSize = true;
            dAT_PARTIDALabel.Location = new System.Drawing.Point(12, 64);
            dAT_PARTIDALabel.Name = "dAT_PARTIDALabel";
            dAT_PARTIDALabel.Size = new System.Drawing.Size(83, 13);
            dAT_PARTIDALabel.TabIndex = 5;
            dAT_PARTIDALabel.Text = "Data de partida:";
            // 
            // iD_AVIAOLabel
            // 
            iD_AVIAOLabel.AutoSize = true;
            iD_AVIAOLabel.Location = new System.Drawing.Point(12, 35);
            iD_AVIAOLabel.Name = "iD_AVIAOLabel";
            iD_AVIAOLabel.Size = new System.Drawing.Size(56, 13);
            iD_AVIAOLabel.TabIndex = 7;
            iD_AVIAOLabel.Text = "Aeronave:";
            // 
            // iD_VOOLabel
            // 
            iD_VOOLabel.AutoSize = true;
            iD_VOOLabel.Location = new System.Drawing.Point(12, 9);
            iD_VOOLabel.Name = "iD_VOOLabel";
            iD_VOOLabel.Size = new System.Drawing.Size(79, 13);
            iD_VOOLabel.TabIndex = 9;
            iD_VOOLabel.Text = "Código do vôo:";
            // 
            // iD_TRECHOLabel
            // 
            iD_TRECHOLabel.AutoSize = true;
            iD_TRECHOLabel.Location = new System.Drawing.Point(170, 9);
            iD_TRECHOLabel.Name = "iD_TRECHOLabel";
            iD_TRECHOLabel.Size = new System.Drawing.Size(91, 13);
            iD_TRECHOLabel.TabIndex = 11;
            iD_TRECHOLabel.Text = "Código do trecho:";
            // 
            // vAL_PRECOLabel
            // 
            vAL_PRECOLabel.AutoSize = true;
            vAL_PRECOLabel.Location = new System.Drawing.Point(140, 36);
            vAL_PRECOLabel.Name = "vAL_PRECOLabel";
            vAL_PRECOLabel.Size = new System.Drawing.Size(34, 13);
            vAL_PRECOLabel.TabIndex = 13;
            vAL_PRECOLabel.Text = "Valor:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAD_VOOBindingSource
            // 
            this.cAD_VOOBindingSource.DataMember = "CAD_VOO";
            this.cAD_VOOBindingSource.DataSource = this.dataSet1;
            // 
            // cAD_VOOTableAdapter
            // 
            this.cAD_VOOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CAD_TRECHOTableAdapter = null;
            this.tableAdapterManager.CAD_USUARIOTableAdapter = null;
            this.tableAdapterManager.CAD_VOOTableAdapter = this.cAD_VOOTableAdapter;
            this.tableAdapterManager.UpdateOrder = ER4Aerea.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qTD_PASSAGEIROSTextBox
            // 
            this.qTD_PASSAGEIROSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_VOOBindingSource, "QTD_PASSAGEIROS", true));
            this.qTD_PASSAGEIROSTextBox.Location = new System.Drawing.Point(157, 110);
            this.qTD_PASSAGEIROSTextBox.Name = "qTD_PASSAGEIROSTextBox";
            this.qTD_PASSAGEIROSTextBox.Size = new System.Drawing.Size(62, 20);
            this.qTD_PASSAGEIROSTextBox.TabIndex = 7;
            this.qTD_PASSAGEIROSTextBox.Tag = "QTD_PASSAGEIROS,N";
            this.qTD_PASSAGEIROSTextBox.TextChanged += new System.EventHandler(this.qTD_PASSAGEIROSTextBox_TextChanged);
            // 
            // dAT_CHEGADADateTimePicker
            // 
            this.dAT_CHEGADADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cAD_VOOBindingSource, "DAT_CHEGADA", true));
            this.dAT_CHEGADADateTimePicker.Location = new System.Drawing.Point(108, 84);
            this.dAT_CHEGADADateTimePicker.Name = "dAT_CHEGADADateTimePicker";
            this.dAT_CHEGADADateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.dAT_CHEGADADateTimePicker.TabIndex = 6;
            this.dAT_CHEGADADateTimePicker.Tag = "DAT_CHEGADA,D";
            // 
            // dAT_PARTIDADateTimePicker
            // 
            this.dAT_PARTIDADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cAD_VOOBindingSource, "DAT_PARTIDA", true));
            this.dAT_PARTIDADateTimePicker.Location = new System.Drawing.Point(108, 58);
            this.dAT_PARTIDADateTimePicker.Name = "dAT_PARTIDADateTimePicker";
            this.dAT_PARTIDADateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.dAT_PARTIDADateTimePicker.TabIndex = 5;
            this.dAT_PARTIDADateTimePicker.Tag = "DAT_PARTIDA,D";
            // 
            // ID_VOO
            // 
            this.ID_VOO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_VOOBindingSource, "ID_VOO", true));
            this.ID_VOO.Location = new System.Drawing.Point(97, 6);
            this.ID_VOO.Name = "ID_VOO";
            this.ID_VOO.Size = new System.Drawing.Size(67, 20);
            this.ID_VOO.TabIndex = 1;
            this.ID_VOO.Tag = "ID_VOO,N";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cid_cli
            // 
            this.cid_cli.Location = new System.Drawing.Point(267, 6);
            this.cid_cli.Name = "cid_cli";
            this.cid_cli.Size = new System.Drawing.Size(60, 20);
            this.cid_cli.TabIndex = 2;
            this.cid_cli.Tag = "ID_TRECHO,N";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(303, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 20);
            this.button4.TabIndex = 104;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "ID_AVIAO,N";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 106;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Tag = "VAL_PRECO,N";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 108;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(12, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 45);
            this.panel1.TabIndex = 109;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(165, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Gravar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(246, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(84, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Localizar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // frmVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 186);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cid_cli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(qTD_PASSAGEIROSLabel);
            this.Controls.Add(this.qTD_PASSAGEIROSTextBox);
            this.Controls.Add(dAT_CHEGADALabel);
            this.Controls.Add(this.dAT_CHEGADADateTimePicker);
            this.Controls.Add(dAT_PARTIDALabel);
            this.Controls.Add(this.dAT_PARTIDADateTimePicker);
            this.Controls.Add(iD_AVIAOLabel);
            this.Controls.Add(iD_VOOLabel);
            this.Controls.Add(this.ID_VOO);
            this.Controls.Add(iD_TRECHOLabel);
            this.Controls.Add(vAL_PRECOLabel);
            this.Name = "frmVoo";
            this.Tag = "CAD_VOO";
            this.Text = "frmVoo";
            this.Load += new System.EventHandler(this.frmVoo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_VOOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cAD_VOOBindingSource;
        private DataSet1TableAdapters.CAD_VOOTableAdapter cAD_VOOTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox qTD_PASSAGEIROSTextBox;
        private System.Windows.Forms.DateTimePicker dAT_CHEGADADateTimePicker;
        private System.Windows.Forms.DateTimePicker dAT_PARTIDADateTimePicker;
        private System.Windows.Forms.TextBox ID_VOO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cid_cli;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}