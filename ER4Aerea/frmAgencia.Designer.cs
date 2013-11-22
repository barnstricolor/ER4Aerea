namespace ER4Aerea
{
    partial class frmAgencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgencia));
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.grdVolta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chegadadestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAssentos = new System.Windows.Forms.NumericUpDown();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dcbDestino = new System.Windows.Forms.ComboBox();
            this.dcbOrigem = new System.Windows.Forms.ComboBox();
            this.optIda = new System.Windows.Forms.RadioButton();
            this.optIdaVolta = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpChegada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPartida = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdIda = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReservar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVolta)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssentos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIda)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.88601F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.11399F));
            this.tlp.Controls.Add(this.grdVolta, 0, 1);
            this.tlp.Controls.Add(this.panel1, 0, 0);
            this.tlp.Controls.Add(this.panel2, 1, 0);
            this.tlp.Controls.Add(this.panel3, 0, 1);
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Margin = new System.Windows.Forms.Padding(4);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Size = new System.Drawing.Size(1220, 559);
            this.tlp.TabIndex = 0;
            // 
            // grdVolta
            // 
            this.grdVolta.AllowUserToAddRows = false;
            this.grdVolta.AllowUserToDeleteRows = false;
            this.grdVolta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVolta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.chegadadestino});
            this.grdVolta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVolta.Location = new System.Drawing.Point(356, 283);
            this.grdVolta.Margin = new System.Windows.Forms.Padding(4);
            this.grdVolta.MultiSelect = false;
            this.grdVolta.Name = "grdVolta";
            this.grdVolta.ReadOnly = true;
            this.grdVolta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVolta.Size = new System.Drawing.Size(860, 272);
            this.grdVolta.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Avião";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Assentos Disponíveis";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "Partida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // chegadadestino
            // 
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.chegadadestino.DefaultCellStyle = dataGridViewCellStyle3;
            this.chegadadestino.HeaderText = "Chegada";
            this.chegadadestino.Name = "chegadadestino";
            this.chegadadestino.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnReservar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAssentos);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.dcbDestino);
            this.panel1.Controls.Add(this.dcbOrigem);
            this.panel1.Controls.Add(this.optIda);
            this.panel1.Controls.Add(this.optIdaVolta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpChegada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpPartida);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 271);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Assentos";
            // 
            // txtAssentos
            // 
            this.txtAssentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssentos.Location = new System.Drawing.Point(224, 34);
            this.txtAssentos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAssentos.Name = "txtAssentos";
            this.txtAssentos.Size = new System.Drawing.Size(108, 22);
            this.txtAssentos.TabIndex = 17;
            this.txtAssentos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(12, 236);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(76, 27);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dcbDestino
            // 
            this.dcbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dcbDestino.FormattingEnabled = true;
            this.dcbDestino.Location = new System.Drawing.Point(11, 111);
            this.dcbDestino.Name = "dcbDestino";
            this.dcbDestino.Size = new System.Drawing.Size(321, 24);
            this.dcbDestino.TabIndex = 13;
            // 
            // dcbOrigem
            // 
            this.dcbOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dcbOrigem.FormattingEnabled = true;
            this.dcbOrigem.Location = new System.Drawing.Point(11, 62);
            this.dcbOrigem.Name = "dcbOrigem";
            this.dcbOrigem.Size = new System.Drawing.Size(321, 24);
            this.dcbOrigem.TabIndex = 12;
            // 
            // optIda
            // 
            this.optIda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optIda.AutoSize = true;
            this.optIda.Location = new System.Drawing.Point(224, 9);
            this.optIda.Margin = new System.Windows.Forms.Padding(4);
            this.optIda.Name = "optIda";
            this.optIda.Size = new System.Drawing.Size(108, 21);
            this.optIda.TabIndex = 11;
            this.optIda.Text = "Somente ida";
            this.optIda.UseVisualStyleBackColor = true;
            this.optIda.CheckedChanged += new System.EventHandler(this.optIda_CheckedChanged);
            // 
            // optIdaVolta
            // 
            this.optIdaVolta.AutoSize = true;
            this.optIdaVolta.Checked = true;
            this.optIdaVolta.Location = new System.Drawing.Point(15, 9);
            this.optIdaVolta.Margin = new System.Windows.Forms.Padding(4);
            this.optIdaVolta.Name = "optIdaVolta";
            this.optIdaVolta.Size = new System.Drawing.Size(94, 21);
            this.optIdaVolta.TabIndex = 10;
            this.optIdaVolta.TabStop = true;
            this.optIdaVolta.Text = "Ida e volta";
            this.optIdaVolta.UseVisualStyleBackColor = true;
            this.optIdaVolta.CheckedChanged += new System.EventHandler(this.optIdaVolta_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Volta";
            // 
            // dtpChegada
            // 
            this.dtpChegada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpChegada.Location = new System.Drawing.Point(12, 207);
            this.dtpChegada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpChegada.Name = "dtpChegada";
            this.dtpChegada.Size = new System.Drawing.Size(320, 22);
            this.dtpChegada.TabIndex = 8;
            this.dtpChegada.Value = new System.DateTime(2013, 11, 19, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ida";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origem";
            // 
            // dtpPartida
            // 
            this.dtpPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPartida.Location = new System.Drawing.Point(12, 162);
            this.dtpPartida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPartida.Name = "dtpPartida";
            this.dtpPartida.Size = new System.Drawing.Size(320, 22);
            this.dtpPartida.TabIndex = 4;
            this.dtpPartida.Value = new System.DateTime(2013, 11, 19, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.grdIda);
            this.panel2.Location = new System.Drawing.Point(356, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 271);
            this.panel2.TabIndex = 1;
            // 
            // grdIda
            // 
            this.grdIda.AllowUserToAddRows = false;
            this.grdIda.AllowUserToDeleteRows = false;
            this.grdIda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.preco,
            this.aviao,
            this.assento,
            this.partida,
            this.Chegada});
            this.grdIda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIda.Location = new System.Drawing.Point(0, 0);
            this.grdIda.Margin = new System.Windows.Forms.Padding(4);
            this.grdIda.MultiSelect = false;
            this.grdIda.Name = "grdIda";
            this.grdIda.ReadOnly = true;
            this.grdIda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdIda.Size = new System.Drawing.Size(860, 271);
            this.grdIda.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // preco
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.preco.DefaultCellStyle = dataGridViewCellStyle4;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // aviao
            // 
            this.aviao.HeaderText = "Avião";
            this.aviao.Name = "aviao";
            this.aviao.ReadOnly = true;
            // 
            // assento
            // 
            this.assento.HeaderText = "Assentos Disponíveis";
            this.assento.Name = "assento";
            this.assento.ReadOnly = true;
            // 
            // partida
            // 
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = null;
            this.partida.DefaultCellStyle = dataGridViewCellStyle5;
            this.partida.HeaderText = "Partida";
            this.partida.Name = "partida";
            this.partida.ReadOnly = true;
            // 
            // Chegada
            // 
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            this.Chegada.DefaultCellStyle = dataGridViewCellStyle6;
            this.Chegada.HeaderText = "Chegada";
            this.Chegada.Name = "Chegada";
            this.Chegada.ReadOnly = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReservar.Location = new System.Drawing.Point(256, 236);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(76, 27);
            this.btnReservar.TabIndex = 19;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(4, 283);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 272);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1222, 559);
            this.Controls.Add(this.tlp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Passagens Aéreas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.Resize += new System.EventHandler(this.frmReserva_Resize);
            this.tlp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVolta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssentos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIda)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox dcbDestino;
        public System.Windows.Forms.ComboBox dcbOrigem;
        public System.Windows.Forms.DateTimePicker dtpChegada;
        public System.Windows.Forms.DateTimePicker dtpPartida;
        public System.Windows.Forms.RadioButton optIda;
        public System.Windows.Forms.RadioButton optIdaVolta;
        public System.Windows.Forms.NumericUpDown txtAssentos;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.TableLayoutPanel tlp;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView grdIda;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView grdVolta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn chegadadestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviao;
        private System.Windows.Forms.DataGridViewTextBoxColumn assento;
        private System.Windows.Forms.DataGridViewTextBoxColumn partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chegada;
        public System.Windows.Forms.Button btnReservar;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;



    }
}