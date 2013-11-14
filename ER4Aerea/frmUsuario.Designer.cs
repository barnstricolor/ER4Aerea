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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_USUARIOLabel;
            System.Windows.Forms.Label nOM_ENDERECOLabel;
            System.Windows.Forms.Label nOM_USUARIOLabel;
            System.Windows.Forms.Label nOM_SENHALabel;
            System.Windows.Forms.Label nUM_CPFLabel;
            System.Windows.Forms.Label nOM_LOGINLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.dataSet1 = new ER4Aerea.DataSet1();
            this.cAD_USUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_USUARIOTableAdapter = new ER4Aerea.DataSet1TableAdapters.CAD_USUARIOTableAdapter();
            this.tableAdapterManager = new ER4Aerea.DataSet1TableAdapters.TableAdapterManager();
            this.ID_USUARIO = new System.Windows.Forms.TextBox();
            this.nOM_ENDERECOTextBox = new System.Windows.Forms.TextBox();
            this.nOM_USUARIOTextBox = new System.Windows.Forms.TextBox();
            this.nOM_SENHATextBox = new System.Windows.Forms.TextBox();
            this.nUM_CPFTextBox = new System.Windows.Forms.TextBox();
            this.nOM_LOGINTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            iD_USUARIOLabel = new System.Windows.Forms.Label();
            nOM_ENDERECOLabel = new System.Windows.Forms.Label();
            nOM_USUARIOLabel = new System.Windows.Forms.Label();
            nOM_SENHALabel = new System.Windows.Forms.Label();
            nUM_CPFLabel = new System.Windows.Forms.Label();
            nOM_LOGINLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_USUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_USUARIOLabel
            // 
            iD_USUARIOLabel.AutoSize = true;
            iD_USUARIOLabel.Location = new System.Drawing.Point(12, 9);
            iD_USUARIOLabel.Name = "iD_USUARIOLabel";
            iD_USUARIOLabel.Size = new System.Drawing.Size(43, 13);
            iD_USUARIOLabel.TabIndex = 1;
            iD_USUARIOLabel.Text = "Código:";
            // 
            // nOM_ENDERECOLabel
            // 
            nOM_ENDERECOLabel.AutoSize = true;
            nOM_ENDERECOLabel.Location = new System.Drawing.Point(149, 35);
            nOM_ENDERECOLabel.Name = "nOM_ENDERECOLabel";
            nOM_ENDERECOLabel.Size = new System.Drawing.Size(56, 13);
            nOM_ENDERECOLabel.TabIndex = 3;
            nOM_ENDERECOLabel.Text = "Endereço:";
            // 
            // nOM_USUARIOLabel
            // 
            nOM_USUARIOLabel.AutoSize = true;
            nOM_USUARIOLabel.Location = new System.Drawing.Point(115, 9);
            nOM_USUARIOLabel.Name = "nOM_USUARIOLabel";
            nOM_USUARIOLabel.Size = new System.Drawing.Size(38, 13);
            nOM_USUARIOLabel.TabIndex = 5;
            nOM_USUARIOLabel.Text = "Nome:";
            // 
            // nOM_SENHALabel
            // 
            nOM_SENHALabel.AutoSize = true;
            nOM_SENHALabel.Location = new System.Drawing.Point(177, 87);
            nOM_SENHALabel.Name = "nOM_SENHALabel";
            nOM_SENHALabel.Size = new System.Drawing.Size(41, 13);
            nOM_SENHALabel.TabIndex = 7;
            nOM_SENHALabel.Text = "Senha:";
            nOM_SENHALabel.Click += new System.EventHandler(this.nOM_SENHALabel_Click);
            // 
            // nUM_CPFLabel
            // 
            nUM_CPFLabel.AutoSize = true;
            nUM_CPFLabel.Location = new System.Drawing.Point(12, 35);
            nUM_CPFLabel.Name = "nUM_CPFLabel";
            nUM_CPFLabel.Size = new System.Drawing.Size(30, 13);
            nUM_CPFLabel.TabIndex = 9;
            nUM_CPFLabel.Text = "CPF:";
            // 
            // nOM_LOGINLabel
            // 
            nOM_LOGINLabel.AutoSize = true;
            nOM_LOGINLabel.Location = new System.Drawing.Point(12, 87);
            nOM_LOGINLabel.Name = "nOM_LOGINLabel";
            nOM_LOGINLabel.Size = new System.Drawing.Size(36, 13);
            nOM_LOGINLabel.TabIndex = 11;
            nOM_LOGINLabel.Text = "Login:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(75, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 13);
            label1.TabIndex = 15;
            label1.Text = "Cidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(281, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(24, 13);
            label2.TabIndex = 17;
            label2.Text = "UF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 61);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(22, 13);
            label3.TabIndex = 18;
            label3.Text = "Nº:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAD_USUARIOBindingSource
            // 
            this.cAD_USUARIOBindingSource.DataMember = "CAD_USUARIO";
            this.cAD_USUARIOBindingSource.DataSource = this.dataSet1;
            // 
            // cAD_USUARIOTableAdapter
            // 
            this.cAD_USUARIOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CAD_USUARIOTableAdapter = this.cAD_USUARIOTableAdapter;
            this.tableAdapterManager.CAD_VOOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ER4Aerea.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ID_USUARIO
            // 
            this.ID_USUARIO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_USUARIOBindingSource, "ID_USUARIO", true));
            this.ID_USUARIO.Location = new System.Drawing.Point(57, 6);
            this.ID_USUARIO.Name = "ID_USUARIO";
            this.ID_USUARIO.Size = new System.Drawing.Size(52, 20);
            this.ID_USUARIO.TabIndex = 1;
            this.ID_USUARIO.Tag = "ID_USUARIO,N";
            // 
            // nOM_ENDERECOTextBox
            // 
            this.nOM_ENDERECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_USUARIOBindingSource, "NOM_ENDERECO", true));
            this.nOM_ENDERECOTextBox.Location = new System.Drawing.Point(211, 32);
            this.nOM_ENDERECOTextBox.Name = "nOM_ENDERECOTextBox";
            this.nOM_ENDERECOTextBox.Size = new System.Drawing.Size(126, 20);
            this.nOM_ENDERECOTextBox.TabIndex = 4;
            this.nOM_ENDERECOTextBox.Tag = "NOM_ENDERECO,C";
            // 
            // nOM_USUARIOTextBox
            // 
            this.nOM_USUARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_USUARIOBindingSource, "NOM_USUARIO", true));
            this.nOM_USUARIOTextBox.Location = new System.Drawing.Point(159, 6);
            this.nOM_USUARIOTextBox.Name = "nOM_USUARIOTextBox";
            this.nOM_USUARIOTextBox.Size = new System.Drawing.Size(178, 20);
            this.nOM_USUARIOTextBox.TabIndex = 2;
            this.nOM_USUARIOTextBox.Tag = "NOM_USUARIO,C";
            // 
            // nOM_SENHATextBox
            // 
            this.nOM_SENHATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_USUARIOBindingSource, "NOM_SENHA", true));
            this.nOM_SENHATextBox.Location = new System.Drawing.Point(224, 84);
            this.nOM_SENHATextBox.Name = "nOM_SENHATextBox";
            this.nOM_SENHATextBox.Size = new System.Drawing.Size(113, 20);
            this.nOM_SENHATextBox.TabIndex = 8;
            this.nOM_SENHATextBox.Tag = "NOM_SENHA,C";
            // 
            // nUM_CPFTextBox
            // 
            this.nUM_CPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_USUARIOBindingSource, "NUM_CPF", true));
            this.nUM_CPFTextBox.Location = new System.Drawing.Point(57, 32);
            this.nUM_CPFTextBox.MaxLength = 11;
            this.nUM_CPFTextBox.Name = "nUM_CPFTextBox";
            this.nUM_CPFTextBox.Size = new System.Drawing.Size(86, 20);
            this.nUM_CPFTextBox.TabIndex = 3;
            this.nUM_CPFTextBox.Tag = "NUM_CPF,N";
            // 
            // nOM_LOGINTextBox
            // 
            this.nOM_LOGINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_USUARIOBindingSource, "NOM_LOGIN", true));
            this.nOM_LOGINTextBox.Location = new System.Drawing.Point(57, 84);
            this.nOM_LOGINTextBox.Name = "nOM_LOGINTextBox";
            this.nOM_LOGINTextBox.Size = new System.Drawing.Size(114, 20);
            this.nOM_LOGINTextBox.TabIndex = 7;
            this.nOM_LOGINTextBox.Tag = "NOM_LOGIN,C";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_USUARIOBindingSource, "NOM_ENDERECO", true));
            this.textBox1.Location = new System.Drawing.Point(124, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Tag = "NOM_CIDADE,C";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_USUARIOBindingSource, "NOM_ENDERECO", true));
            this.textBox2.Location = new System.Drawing.Point(311, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Tag = "NOM_UF,C";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_USUARIOBindingSource, "NOM_ENDERECO", true));
            this.textBox3.Location = new System.Drawing.Point(40, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(29, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.Tag = "NUM_ENDERECO,N";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(15, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 45);
            this.panel1.TabIndex = 45;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(165, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 20);
            this.button4.TabIndex = 104;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 167);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iD_USUARIOLabel);
            this.Controls.Add(this.ID_USUARIO);
            this.Controls.Add(nOM_ENDERECOLabel);
            this.Controls.Add(this.nOM_ENDERECOTextBox);
            this.Controls.Add(nOM_USUARIOLabel);
            this.Controls.Add(this.nOM_USUARIOTextBox);
            this.Controls.Add(nOM_SENHALabel);
            this.Controls.Add(this.nOM_SENHATextBox);
            this.Controls.Add(nUM_CPFLabel);
            this.Controls.Add(this.nUM_CPFTextBox);
            this.Controls.Add(nOM_LOGINLabel);
            this.Controls.Add(this.nOM_LOGINTextBox);
            this.Name = "frmUsuario";
            this.Tag = "CAD_USUARIO";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_USUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cAD_USUARIOBindingSource;
        private DataSet1TableAdapters.CAD_USUARIOTableAdapter cAD_USUARIOTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ID_USUARIO;
        private System.Windows.Forms.TextBox nOM_ENDERECOTextBox;
        private System.Windows.Forms.TextBox nOM_USUARIOTextBox;
        private System.Windows.Forms.TextBox nOM_SENHATextBox;
        private System.Windows.Forms.TextBox nUM_CPFTextBox;
        private System.Windows.Forms.TextBox nOM_LOGINTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}