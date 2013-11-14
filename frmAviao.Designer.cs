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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_AVIAOLabel;
            System.Windows.Forms.Label qTD_ASSENTOLabel;
            System.Windows.Forms.Label nOM_MODELOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAviao));
            this.dataSet1 = new ER4Aerea.DataSet1();
            this.cAD_AVIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_AVIAOTableAdapter = new ER4Aerea.DataSet1TableAdapters.CAD_AVIAOTableAdapter();
            this.tableAdapterManager = new ER4Aerea.DataSet1TableAdapters.TableAdapterManager();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_AVIAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_AVIAOLabel
            // 
            iD_AVIAOLabel.AutoSize = true;
            iD_AVIAOLabel.Location = new System.Drawing.Point(12, 12);
            iD_AVIAOLabel.Name = "iD_AVIAOLabel";
            iD_AVIAOLabel.Size = new System.Drawing.Size(43, 13);
            iD_AVIAOLabel.TabIndex = 1;
            iD_AVIAOLabel.Tag = "CAD_AVIAO";
            iD_AVIAOLabel.Text = "Código:";
            // 
            // qTD_ASSENTOLabel
            // 
            qTD_ASSENTOLabel.AutoSize = true;
            qTD_ASSENTOLabel.Location = new System.Drawing.Point(12, 38);
            qTD_ASSENTOLabel.Name = "qTD_ASSENTOLabel";
            qTD_ASSENTOLabel.Size = new System.Drawing.Size(125, 13);
            qTD_ASSENTOLabel.TabIndex = 3;
            qTD_ASSENTOLabel.Text = "Quantidade de assentos:";
            // 
            // nOM_MODELOLabel
            // 
            nOM_MODELOLabel.AutoSize = true;
            nOM_MODELOLabel.Location = new System.Drawing.Point(143, 12);
            nOM_MODELOLabel.Name = "nOM_MODELOLabel";
            nOM_MODELOLabel.Size = new System.Drawing.Size(45, 13);
            nOM_MODELOLabel.TabIndex = 5;
            nOM_MODELOLabel.Text = "Modelo:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAD_AVIAOBindingSource
            // 
            this.cAD_AVIAOBindingSource.DataMember = "CAD_AVIAO";
            this.cAD_AVIAOBindingSource.DataSource = this.dataSet1;
            // 
            // cAD_AVIAOTableAdapter
            // 
            this.cAD_AVIAOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAD_ASSENTOTableAdapter = null;
            this.tableAdapterManager.CAD_AVIAOTableAdapter = this.cAD_AVIAOTableAdapter;
            this.tableAdapterManager.CAD_CIDADETableAdapter = null;
            this.tableAdapterManager.CAD_CLIENTETableAdapter = null;
            this.tableAdapterManager.CAD_PRECOTableAdapter = null;
            this.tableAdapterManager.CAD_PROMOCAOTableAdapter = null;
            this.tableAdapterManager.CAD_RESERVATableAdapter = null;
            this.tableAdapterManager.CAD_TRECHOTableAdapter = null;
            this.tableAdapterManager.CAD_USUARIOTableAdapter = null;
            this.tableAdapterManager.CAD_VOOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ER4Aerea.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ID_AVIAO
            // 
            this.ID_AVIAO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_AVIAOBindingSource, "ID_AVIAO", true));
            this.ID_AVIAO.Location = new System.Drawing.Point(61, 9);
            this.ID_AVIAO.Name = "ID_AVIAO";
            this.ID_AVIAO.Size = new System.Drawing.Size(76, 20);
            this.ID_AVIAO.TabIndex = 1;
            this.ID_AVIAO.Tag = "ID_AVIAO,N";
            // 
            // qTD_ASSENTOTextBox
            // 
            this.qTD_ASSENTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_AVIAOBindingSource, "QTD_ASSENTO", true));
            this.qTD_ASSENTOTextBox.Location = new System.Drawing.Point(143, 35);
            this.qTD_ASSENTOTextBox.Name = "qTD_ASSENTOTextBox";
            this.qTD_ASSENTOTextBox.Size = new System.Drawing.Size(65, 20);
            this.qTD_ASSENTOTextBox.TabIndex = 3;
            this.qTD_ASSENTOTextBox.Tag = "QTD_ASSENTO,N";
            // 
            // nOM_MODELOTextBox
            // 
            this.nOM_MODELOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_AVIAOBindingSource, "NOM_MODELO", true));
            this.nOM_MODELOTextBox.Location = new System.Drawing.Point(194, 9);
            this.nOM_MODELOTextBox.Name = "nOM_MODELOTextBox";
            this.nOM_MODELOTextBox.Size = new System.Drawing.Size(119, 20);
            this.nOM_MODELOTextBox.TabIndex = 2;
            this.nOM_MODELOTextBox.Tag = "NOM_MODELO,C";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 97);
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
            this.panel1.Location = new System.Drawing.Point(12, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 45);
            this.panel1.TabIndex = 42;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAviao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 165);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iD_AVIAOLabel);
            this.Controls.Add(this.ID_AVIAO);
            this.Controls.Add(qTD_ASSENTOLabel);
            this.Controls.Add(this.qTD_ASSENTOTextBox);
            this.Controls.Add(nOM_MODELOLabel);
            this.Controls.Add(this.nOM_MODELOTextBox);
            this.Name = "frmAviao";
            this.Tag = "CAD_AVIAO";
            this.Text = "frmAviao";
            this.Load += new System.EventHandler(this.frmAviao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_AVIAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cAD_AVIAOBindingSource;
        private DataSet1TableAdapters.CAD_AVIAOTableAdapter cAD_AVIAOTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
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