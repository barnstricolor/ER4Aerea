namespace ER4Aerea
{
    partial class frmPreco
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
            System.Windows.Forms.Label dAT_PRECOLabel;
            System.Windows.Forms.Label vAL_PRECOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreco));
            this.dataSet1 = new ER4Aerea.DataSet1();
            this.cAD_PRECOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_PRECOTableAdapter = new ER4Aerea.DataSet1TableAdapters.CAD_PRECOTableAdapter();
            this.tableAdapterManager = new ER4Aerea.DataSet1TableAdapters.TableAdapterManager();
            this.dAT_PRECODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vAL_PRECOTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cid_cli = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            iD_TRECHOLabel = new System.Windows.Forms.Label();
            dAT_PRECOLabel = new System.Windows.Forms.Label();
            vAL_PRECOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_PRECOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_TRECHOLabel
            // 
            iD_TRECHOLabel.AutoSize = true;
            iD_TRECHOLabel.Location = new System.Drawing.Point(12, 9);
            iD_TRECHOLabel.Name = "iD_TRECHOLabel";
            iD_TRECHOLabel.Size = new System.Drawing.Size(91, 13);
            iD_TRECHOLabel.TabIndex = 1;
            iD_TRECHOLabel.Text = "Código do trecho:";
            // 
            // dAT_PRECOLabel
            // 
            dAT_PRECOLabel.AutoSize = true;
            dAT_PRECOLabel.Location = new System.Drawing.Point(12, 35);
            dAT_PRECOLabel.Name = "dAT_PRECOLabel";
            dAT_PRECOLabel.Size = new System.Drawing.Size(33, 13);
            dAT_PRECOLabel.TabIndex = 3;
            dAT_PRECOLabel.Text = "Data:";
            // 
            // vAL_PRECOLabel
            // 
            vAL_PRECOLabel.AutoSize = true;
            vAL_PRECOLabel.Location = new System.Drawing.Point(175, 9);
            vAL_PRECOLabel.Name = "vAL_PRECOLabel";
            vAL_PRECOLabel.Size = new System.Drawing.Size(34, 13);
            vAL_PRECOLabel.TabIndex = 5;
            vAL_PRECOLabel.Text = "Valor:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAD_PRECOBindingSource
            // 
            this.cAD_PRECOBindingSource.DataMember = "CAD_PRECO";
            this.cAD_PRECOBindingSource.DataSource = this.dataSet1;
            // 
            // cAD_PRECOTableAdapter
            // 
            this.cAD_PRECOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAD_ASSENTOTableAdapter = null;
            this.tableAdapterManager.CAD_AVIAOTableAdapter = null;
            this.tableAdapterManager.CAD_CIDADETableAdapter = null;
            this.tableAdapterManager.CAD_CLIENTETableAdapter = null;
            this.tableAdapterManager.CAD_PRECOTableAdapter = this.cAD_PRECOTableAdapter;
            this.tableAdapterManager.CAD_PROMOCAOTableAdapter = null;
            this.tableAdapterManager.CAD_RESERVATableAdapter = null;
            this.tableAdapterManager.CAD_TRECHOTableAdapter = null;
            this.tableAdapterManager.CAD_USUARIOTableAdapter = null;
            this.tableAdapterManager.CAD_VOOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ER4Aerea.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dAT_PRECODateTimePicker
            // 
            this.dAT_PRECODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cAD_PRECOBindingSource, "DAT_PRECO", true));
            this.dAT_PRECODateTimePicker.Location = new System.Drawing.Point(45, 32);
            this.dAT_PRECODateTimePicker.Name = "dAT_PRECODateTimePicker";
            this.dAT_PRECODateTimePicker.Size = new System.Drawing.Size(251, 20);
            this.dAT_PRECODateTimePicker.TabIndex = 3;
            this.dAT_PRECODateTimePicker.Tag = "DAT_PRECO,D";
            // 
            // vAL_PRECOTextBox
            // 
            this.vAL_PRECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_PRECOBindingSource, "VAL_PRECO", true));
            this.vAL_PRECOTextBox.Location = new System.Drawing.Point(215, 6);
            this.vAL_PRECOTextBox.Name = "vAL_PRECOTextBox";
            this.vAL_PRECOTextBox.Size = new System.Drawing.Size(81, 20);
            this.vAL_PRECOTextBox.TabIndex = 2;
            this.vAL_PRECOTextBox.Tag = "VAL_PRECO,N";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(302, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cid_cli
            // 
            this.cid_cli.Location = new System.Drawing.Point(109, 6);
            this.cid_cli.Name = "cid_cli";
            this.cid_cli.Size = new System.Drawing.Size(60, 20);
            this.cid_cli.TabIndex = 1;
            this.cid_cli.Tag = "ID_TRECHO,N";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(15, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 45);
            this.panel1.TabIndex = 43;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(145, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 20);
            this.button4.TabIndex = 102;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 165);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cid_cli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iD_TRECHOLabel);
            this.Controls.Add(dAT_PRECOLabel);
            this.Controls.Add(this.dAT_PRECODateTimePicker);
            this.Controls.Add(vAL_PRECOLabel);
            this.Controls.Add(this.vAL_PRECOTextBox);
            this.Name = "frmPreco";
            this.Tag = "CAD_PRECO";
            this.Text = "frmPreco";
            this.Load += new System.EventHandler(this.frmPreco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_PRECOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cAD_PRECOBindingSource;
        private DataSet1TableAdapters.CAD_PRECOTableAdapter cAD_PRECOTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dAT_PRECODateTimePicker;
        private System.Windows.Forms.TextBox vAL_PRECOTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cid_cli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}