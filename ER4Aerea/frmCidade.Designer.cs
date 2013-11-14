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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCidade));
            System.Windows.Forms.Label iD_CIDADELabel;
            System.Windows.Forms.Label nOM_CIDADELabel;
            System.Windows.Forms.Label nUM_CEPLabel;
            this.dataSet1 = new ER4Aerea.DataSet1();
            this.cAD_CIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_CIDADETableAdapter = new ER4Aerea.DataSet1TableAdapters.CAD_CIDADETableAdapter();
            this.tableAdapterManager = new ER4Aerea.DataSet1TableAdapters.TableAdapterManager();
            this.cAD_CIDADEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cAD_CIDADEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CIDADETextBox = new System.Windows.Forms.TextBox();
            this.nOM_CIDADETextBox = new System.Windows.Forms.TextBox();
            this.nUM_CEPTextBox = new System.Windows.Forms.TextBox();
            iD_CIDADELabel = new System.Windows.Forms.Label();
            nOM_CIDADELabel = new System.Windows.Forms.Label();
            nUM_CEPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CIDADEBindingNavigator)).BeginInit();
            this.cAD_CIDADEBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // cAD_CIDADEBindingNavigator
            // 
            this.cAD_CIDADEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cAD_CIDADEBindingNavigator.BindingSource = this.cAD_CIDADEBindingSource;
            this.cAD_CIDADEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cAD_CIDADEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cAD_CIDADEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cAD_CIDADEBindingNavigatorSaveItem});
            this.cAD_CIDADEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cAD_CIDADEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cAD_CIDADEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cAD_CIDADEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cAD_CIDADEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cAD_CIDADEBindingNavigator.Name = "cAD_CIDADEBindingNavigator";
            this.cAD_CIDADEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cAD_CIDADEBindingNavigator.Size = new System.Drawing.Size(289, 25);
            this.cAD_CIDADEBindingNavigator.TabIndex = 0;
            this.cAD_CIDADEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cAD_CIDADEBindingNavigatorSaveItem
            // 
            this.cAD_CIDADEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cAD_CIDADEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cAD_CIDADEBindingNavigatorSaveItem.Image")));
            this.cAD_CIDADEBindingNavigatorSaveItem.Name = "cAD_CIDADEBindingNavigatorSaveItem";
            this.cAD_CIDADEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cAD_CIDADEBindingNavigatorSaveItem.Text = "Save Data";
            this.cAD_CIDADEBindingNavigatorSaveItem.Click += new System.EventHandler(this.cAD_CIDADEBindingNavigatorSaveItem_Click);
            // 
            // iD_CIDADELabel
            // 
            iD_CIDADELabel.AutoSize = true;
            iD_CIDADELabel.Location = new System.Drawing.Point(85, 129);
            iD_CIDADELabel.Name = "iD_CIDADELabel";
            iD_CIDADELabel.Size = new System.Drawing.Size(64, 13);
            iD_CIDADELabel.TabIndex = 1;
            iD_CIDADELabel.Text = "ID CIDADE:";
            // 
            // iD_CIDADETextBox
            // 
            this.iD_CIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CIDADEBindingSource, "ID_CIDADE", true));
            this.iD_CIDADETextBox.Location = new System.Drawing.Point(169, 126);
            this.iD_CIDADETextBox.Name = "iD_CIDADETextBox";
            this.iD_CIDADETextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_CIDADETextBox.TabIndex = 2;
            // 
            // nOM_CIDADELabel
            // 
            nOM_CIDADELabel.AutoSize = true;
            nOM_CIDADELabel.Location = new System.Drawing.Point(85, 155);
            nOM_CIDADELabel.Name = "nOM_CIDADELabel";
            nOM_CIDADELabel.Size = new System.Drawing.Size(78, 13);
            nOM_CIDADELabel.TabIndex = 3;
            nOM_CIDADELabel.Text = "NOM CIDADE:";
            // 
            // nOM_CIDADETextBox
            // 
            this.nOM_CIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CIDADEBindingSource, "NOM_CIDADE", true));
            this.nOM_CIDADETextBox.Location = new System.Drawing.Point(169, 152);
            this.nOM_CIDADETextBox.Name = "nOM_CIDADETextBox";
            this.nOM_CIDADETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOM_CIDADETextBox.TabIndex = 4;
            // 
            // nUM_CEPLabel
            // 
            nUM_CEPLabel.AutoSize = true;
            nUM_CEPLabel.Location = new System.Drawing.Point(85, 181);
            nUM_CEPLabel.Name = "nUM_CEPLabel";
            nUM_CEPLabel.Size = new System.Drawing.Size(59, 13);
            nUM_CEPLabel.TabIndex = 5;
            nUM_CEPLabel.Text = "NUM CEP:";
            // 
            // nUM_CEPTextBox
            // 
            this.nUM_CEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CIDADEBindingSource, "NUM_CEP", true));
            this.nUM_CEPTextBox.Location = new System.Drawing.Point(169, 178);
            this.nUM_CEPTextBox.Name = "nUM_CEPTextBox";
            this.nUM_CEPTextBox.Size = new System.Drawing.Size(100, 20);
            this.nUM_CEPTextBox.TabIndex = 6;
            // 
            // frmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 261);
            this.Controls.Add(iD_CIDADELabel);
            this.Controls.Add(this.iD_CIDADETextBox);
            this.Controls.Add(nOM_CIDADELabel);
            this.Controls.Add(this.nOM_CIDADETextBox);
            this.Controls.Add(nUM_CEPLabel);
            this.Controls.Add(this.nUM_CEPTextBox);
            this.Controls.Add(this.cAD_CIDADEBindingNavigator);
            this.Name = "frmCidade";
            this.Text = "frmCidade";
            this.Load += new System.EventHandler(this.frmCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CIDADEBindingNavigator)).EndInit();
            this.cAD_CIDADEBindingNavigator.ResumeLayout(false);
            this.cAD_CIDADEBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cAD_CIDADEBindingSource;
        private DataSet1TableAdapters.CAD_CIDADETableAdapter cAD_CIDADETableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cAD_CIDADEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cAD_CIDADEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CIDADETextBox;
        private System.Windows.Forms.TextBox nOM_CIDADETextBox;
        private System.Windows.Forms.TextBox nUM_CEPTextBox;
    }
}