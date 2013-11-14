namespace ER4Aerea
{
    partial class frmCidade
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
            System.Windows.Forms.Label iD_CIDADELabel;
            System.Windows.Forms.Label nOM_CIDADELabel;
            System.Windows.Forms.Label nUM_CEPLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCidade));
            this.dataSet1 = new ER4Aerea.DataSet1();
            this.cAD_CIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_CIDADETableAdapter = new ER4Aerea.DataSet1TableAdapters.CAD_CIDADETableAdapter();
            this.tableAdapterManager = new ER4Aerea.DataSet1TableAdapters.TableAdapterManager();
            this.nOM_CIDADETextBox = new System.Windows.Forms.TextBox();
            this.nUM_CEPTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID_CIDADE = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iD_CIDADELabel = new System.Windows.Forms.Label();
            nOM_CIDADELabel = new System.Windows.Forms.Label();
            nUM_CEPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_CIDADELabel
            // 
            iD_CIDADELabel.AutoSize = true;
            iD_CIDADELabel.Location = new System.Drawing.Point(12, 9);
            iD_CIDADELabel.Name = "iD_CIDADELabel";
            iD_CIDADELabel.Size = new System.Drawing.Size(43, 13);
            iD_CIDADELabel.TabIndex = 1;
            iD_CIDADELabel.Text = "Código:";
            // 
            // nOM_CIDADELabel
            // 
            nOM_CIDADELabel.AutoSize = true;
            nOM_CIDADELabel.Location = new System.Drawing.Point(12, 35);
            nOM_CIDADELabel.Name = "nOM_CIDADELabel";
            nOM_CIDADELabel.Size = new System.Drawing.Size(43, 13);
            nOM_CIDADELabel.TabIndex = 3;
            nOM_CIDADELabel.Text = "Cidade:";
            // 
            // nUM_CEPLabel
            // 
            nUM_CEPLabel.AutoSize = true;
            nUM_CEPLabel.Location = new System.Drawing.Point(143, 9);
            nUM_CEPLabel.Name = "nUM_CEPLabel";
            nUM_CEPLabel.Size = new System.Drawing.Size(31, 13);
            nUM_CEPLabel.TabIndex = 5;
            nUM_CEPLabel.Text = "CEP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(208, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 13);
            label1.TabIndex = 45;
            label1.Text = "UF:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAD_CIDADEBindingSource
            // 
            this.cAD_CIDADEBindingSource.DataMember = "CAD_CIDADE";
            this.cAD_CIDADEBindingSource.DataSource = this.dataSet1;
            // 
            // cAD_CIDADETableAdapter
            // 
            this.cAD_CIDADETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAD_ASSENTOTableAdapter = null;
            this.tableAdapterManager.CAD_AVIAOTableAdapter = null;
            this.tableAdapterManager.CAD_CIDADETableAdapter = this.cAD_CIDADETableAdapter;
            this.tableAdapterManager.CAD_CLIENTETableAdapter = null;
            this.tableAdapterManager.CAD_PRECOTableAdapter = null;
            this.tableAdapterManager.CAD_PROMOCAOTableAdapter = null;
            this.tableAdapterManager.CAD_RESERVATableAdapter = null;
            this.tableAdapterManager.CAD_TRECHOTableAdapter = null;
            this.tableAdapterManager.CAD_USUARIOTableAdapter = null;
            this.tableAdapterManager.CAD_VOOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ER4Aerea.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nOM_CIDADETextBox
            // 
            this.nOM_CIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CIDADEBindingSource, "NOM_CIDADE", true));
            this.nOM_CIDADETextBox.Location = new System.Drawing.Point(56, 32);
            this.nOM_CIDADETextBox.Name = "nOM_CIDADETextBox";
            this.nOM_CIDADETextBox.Size = new System.Drawing.Size(146, 20);
            this.nOM_CIDADETextBox.TabIndex = 3;
            this.nOM_CIDADETextBox.Tag = "NOM_CIDADE,C";
            // 
            // nUM_CEPTextBox
            // 
            this.nUM_CEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CIDADEBindingSource, "NUM_CEP", true));
            this.nUM_CEPTextBox.Location = new System.Drawing.Point(180, 6);
            this.nUM_CEPTextBox.Name = "nUM_CEPTextBox";
            this.nUM_CEPTextBox.Size = new System.Drawing.Size(105, 20);
            this.nUM_CEPTextBox.TabIndex = 2;
            this.nUM_CEPTextBox.Tag = "NUM_CEP,N";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ID_CIDADE
            // 
            this.ID_CIDADE.Location = new System.Drawing.Point(61, 6);
            this.ID_CIDADE.Name = "ID_CIDADE";
            this.ID_CIDADE.Size = new System.Drawing.Size(72, 20);
            this.ID_CIDADE.TabIndex = 1;
            this.ID_CIDADE.Tag = "ID_CIDADE,N";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CIDADEBindingSource, "NUM_CEP", true));
            this.textBox1.Location = new System.Drawing.Point(238, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Tag = "NOM_UF,C";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(15, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 45);
            this.panel1.TabIndex = 47;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(165, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 160);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.ID_CIDADE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iD_CIDADELabel);
            this.Controls.Add(nOM_CIDADELabel);
            this.Controls.Add(this.nOM_CIDADETextBox);
            this.Controls.Add(nUM_CEPLabel);
            this.Controls.Add(this.nUM_CEPTextBox);
            this.Name = "frmCidade";
            this.Tag = "CAD_CIDADE";
            this.Text = "frmCidade";
            this.Load += new System.EventHandler(this.frmCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cAD_CIDADEBindingSource;
        private DataSet1TableAdapters.CAD_CIDADETableAdapter cAD_CIDADETableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nOM_CIDADETextBox;
        private System.Windows.Forms.TextBox nUM_CEPTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ID_CIDADE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}