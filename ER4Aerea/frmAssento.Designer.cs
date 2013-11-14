namespace ER4Aerea
{
    partial class frmAssento
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
            System.Windows.Forms.Label iD_RESERVALabel;
            System.Windows.Forms.Label iD_ASSENTOLabel;
            System.Windows.Forms.Label iD_VOOLabel;
            System.Windows.Forms.Label nOM_OCUPANTELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssento));
            this.dataSet1 = new ER4Aerea.DataSet1();
            this.cAD_ASSENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_ASSENTOTableAdapter = new ER4Aerea.DataSet1TableAdapters.CAD_ASSENTOTableAdapter();
            this.tableAdapterManager = new ER4Aerea.DataSet1TableAdapters.TableAdapterManager();
            this.ID_ASSENTO = new System.Windows.Forms.TextBox();
            this.iD_VOOTextBox = new System.Windows.Forms.TextBox();
            this.nOM_OCUPANTETextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iD_AVIAOTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            iD_RESERVALabel = new System.Windows.Forms.Label();
            iD_ASSENTOLabel = new System.Windows.Forms.Label();
            iD_VOOLabel = new System.Windows.Forms.Label();
            nOM_OCUPANTELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_ASSENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_RESERVALabel
            // 
            iD_RESERVALabel.AutoSize = true;
            iD_RESERVALabel.Location = new System.Drawing.Point(12, 12);
            iD_RESERVALabel.Name = "iD_RESERVALabel";
            iD_RESERVALabel.Size = new System.Drawing.Size(43, 13);
            iD_RESERVALabel.TabIndex = 1;
            iD_RESERVALabel.Text = "Código:";
            // 
            // iD_ASSENTOLabel
            // 
            iD_ASSENTOLabel.AutoSize = true;
            iD_ASSENTOLabel.Location = new System.Drawing.Point(174, 12);
            iD_ASSENTOLabel.Name = "iD_ASSENTOLabel";
            iD_ASSENTOLabel.Size = new System.Drawing.Size(102, 13);
            iD_ASSENTOLabel.TabIndex = 3;
            iD_ASSENTOLabel.Text = "Número do assento:";
            // 
            // iD_VOOLabel
            // 
            iD_VOOLabel.AutoSize = true;
            iD_VOOLabel.Location = new System.Drawing.Point(12, 64);
            iD_VOOLabel.Name = "iD_VOOLabel";
            iD_VOOLabel.Size = new System.Drawing.Size(80, 13);
            iD_VOOLabel.TabIndex = 5;
            iD_VOOLabel.Text = "Código do Vôo:";
            // 
            // nOM_OCUPANTELabel
            // 
            nOM_OCUPANTELabel.AutoSize = true;
            nOM_OCUPANTELabel.Location = new System.Drawing.Point(12, 38);
            nOM_OCUPANTELabel.Name = "nOM_OCUPANTELabel";
            nOM_OCUPANTELabel.Size = new System.Drawing.Size(101, 13);
            nOM_OCUPANTELabel.TabIndex = 7;
            nOM_OCUPANTELabel.Text = "Nome do ocupante:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAD_ASSENTOBindingSource
            // 
            this.cAD_ASSENTOBindingSource.DataMember = "CAD_ASSENTO";
            this.cAD_ASSENTOBindingSource.DataSource = this.dataSet1;
            // 
            // cAD_ASSENTOTableAdapter
            // 
            this.cAD_ASSENTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAD_ASSENTOTableAdapter = this.cAD_ASSENTOTableAdapter;
            this.tableAdapterManager.CAD_AVIAOTableAdapter = null;
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
            // ID_ASSENTO
            // 
            this.ID_ASSENTO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_ASSENTOBindingSource, "ID_RESERVA", true));
            this.ID_ASSENTO.Location = new System.Drawing.Point(61, 9);
            this.ID_ASSENTO.Name = "ID_ASSENTO";
            this.ID_ASSENTO.Size = new System.Drawing.Size(86, 20);
            this.ID_ASSENTO.TabIndex = 1;
            this.ID_ASSENTO.Tag = "ID_RESERVA,N";
            // 
            // iD_VOOTextBox
            // 
            this.iD_VOOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_ASSENTOBindingSource, "ID_VOO", true));
            this.iD_VOOTextBox.Location = new System.Drawing.Point(117, 61);
            this.iD_VOOTextBox.Name = "iD_VOOTextBox";
            this.iD_VOOTextBox.Size = new System.Drawing.Size(60, 20);
            this.iD_VOOTextBox.TabIndex = 4;
            this.iD_VOOTextBox.Tag = "ID_VOO,N";
            // 
            // nOM_OCUPANTETextBox
            // 
            this.nOM_OCUPANTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_ASSENTOBindingSource, "NOM_OCUPANTE", true));
            this.nOM_OCUPANTETextBox.Location = new System.Drawing.Point(117, 35);
            this.nOM_OCUPANTETextBox.Name = "nOM_OCUPANTETextBox";
            this.nOM_OCUPANTETextBox.Size = new System.Drawing.Size(225, 20);
            this.nOM_OCUPANTETextBox.TabIndex = 3;
            this.nOM_OCUPANTETextBox.Tag = "NOM_CLIENTE,C";
            this.nOM_OCUPANTETextBox.TextChanged += new System.EventHandler(this.nOM_OCUPANTETextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 45);
            this.panel1.TabIndex = 41;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(165, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            // iD_AVIAOTextBox
            // 
            this.iD_AVIAOTextBox.Location = new System.Drawing.Point(282, 9);
            this.iD_AVIAOTextBox.Name = "iD_AVIAOTextBox";
            this.iD_AVIAOTextBox.Size = new System.Drawing.Size(60, 20);
            this.iD_AVIAOTextBox.TabIndex = 2;
            this.iD_AVIAOTextBox.Tag = "ID_ASSENTO,N";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 20);
            this.button4.TabIndex = 44;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(318, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 20);
            this.button5.TabIndex = 45;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(152, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 20);
            this.button6.TabIndex = 46;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // frmAssento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 191);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.iD_AVIAOTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iD_RESERVALabel);
            this.Controls.Add(this.ID_ASSENTO);
            this.Controls.Add(iD_ASSENTOLabel);
            this.Controls.Add(iD_VOOLabel);
            this.Controls.Add(this.iD_VOOTextBox);
            this.Controls.Add(nOM_OCUPANTELabel);
            this.Controls.Add(this.nOM_OCUPANTETextBox);
            this.Name = "frmAssento";
            this.Tag = "CAD_ASSENTO";
            this.Text = "frmAssento";
            this.Load += new System.EventHandler(this.frmAssento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_ASSENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cAD_ASSENTOBindingSource;
        private DataSet1TableAdapters.CAD_ASSENTOTableAdapter cAD_ASSENTOTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ID_ASSENTO;
        private System.Windows.Forms.TextBox iD_VOOTextBox;
        private System.Windows.Forms.TextBox nOM_OCUPANTETextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox iD_AVIAOTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}