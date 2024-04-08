
namespace _307_Coursework
{
    partial class Form1
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
            System.Windows.Forms.Label assetIDLabel;
            System.Windows.Forms.Label systemNameLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label iPAddressLabel;
            System.Windows.Forms.Label manufacturerLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label operatingSystemLabel;
            this.connectionBox = new System.Windows.Forms.CheckBox();
            this.assetsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.assetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssql2003115DataSet = new _307_Coursework.mssql2003115DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.assetIDTextBox = new System.Windows.Forms.TextBox();
            this.systemNameTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.iPAddressTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.assetsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatingSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.dgvWMI = new System.Windows.Forms.DataGridView();
            this.infoButton = new System.Windows.Forms.Button();
            this.softwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetsTableAdapter = new _307_Coursework.mssql2003115DataSetTableAdapters.AssetsTableAdapter();
            this.tableAdapterManager = new _307_Coursework.mssql2003115DataSetTableAdapters.TableAdapterManager();
            this.softwareTableAdapter = new _307_Coursework.mssql2003115DataSetTableAdapters.SoftwareTableAdapter();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.updatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.NVDButton = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            assetIDLabel = new System.Windows.Forms.Label();
            systemNameLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            iPAddressLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            operatingSystemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingNavigator)).BeginInit();
            this.assetsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2003115DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assetIDLabel
            // 
            assetIDLabel.AutoSize = true;
            assetIDLabel.Location = new System.Drawing.Point(40, 288);
            assetIDLabel.Name = "assetIDLabel";
            assetIDLabel.Size = new System.Drawing.Size(50, 13);
            assetIDLabel.TabIndex = 4;
            assetIDLabel.Text = "Asset ID:";
            // 
            // systemNameLabel
            // 
            systemNameLabel.AutoSize = true;
            systemNameLabel.Location = new System.Drawing.Point(15, 314);
            systemNameLabel.Name = "systemNameLabel";
            systemNameLabel.Size = new System.Drawing.Size(75, 13);
            systemNameLabel.TabIndex = 6;
            systemNameLabel.Text = "System Name:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(48, 340);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 8;
            modelLabel.Text = "Model:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(238, 314);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 12;
            typeLabel.Text = "Type:";
            // 
            // iPAddressLabel
            // 
            iPAddressLabel.AutoSize = true;
            iPAddressLabel.Location = new System.Drawing.Point(214, 340);
            iPAddressLabel.Name = "iPAddressLabel";
            iPAddressLabel.Size = new System.Drawing.Size(58, 13);
            iPAddressLabel.TabIndex = 14;
            iPAddressLabel.Text = "IPAddress:";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new System.Drawing.Point(199, 291);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(73, 13);
            manufacturerLabel.TabIndex = 15;
            manufacturerLabel.Text = "Manufacturer:";
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(384, 291);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 16;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(434, 314);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(33, 13);
            noteLabel.TabIndex = 18;
            noteLabel.Text = "Note:";
            // 
            // operatingSystemLabel
            // 
            operatingSystemLabel.AutoSize = true;
            operatingSystemLabel.Location = new System.Drawing.Point(442, 342);
            operatingSystemLabel.Name = "operatingSystemLabel";
            operatingSystemLabel.Size = new System.Drawing.Size(25, 13);
            operatingSystemLabel.TabIndex = 35;
            operatingSystemLabel.Text = "OS:";
            // 
            // connectionBox
            // 
            this.connectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectionBox.AutoSize = true;
            this.connectionBox.Location = new System.Drawing.Point(12, 617);
            this.connectionBox.Name = "connectionBox";
            this.connectionBox.Size = new System.Drawing.Size(78, 17);
            this.connectionBox.TabIndex = 0;
            this.connectionBox.Text = "Connected";
            this.connectionBox.UseVisualStyleBackColor = true;
            this.connectionBox.CheckedChanged += new System.EventHandler(this.connectionBox_CheckedChanged);
            // 
            // assetsBindingNavigator
            // 
            this.assetsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assetsBindingNavigator.BindingSource = this.assetsBindingSource;
            this.assetsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assetsBindingNavigator.DeleteItem = null;
            this.assetsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.assetsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.assetsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assetsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assetsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assetsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assetsBindingNavigator.Name = "assetsBindingNavigator";
            this.assetsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assetsBindingNavigator.Size = new System.Drawing.Size(1092, 25);
            this.assetsBindingNavigator.TabIndex = 2;
            this.assetsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "Assets";
            this.assetsBindingSource.DataSource = this.mssql2003115DataSet;
            this.assetsBindingSource.CurrentChanged += new System.EventHandler(this.assetsBindingSource_CurrentChanged);
            // 
            // mssql2003115DataSet
            // 
            this.mssql2003115DataSet.DataSetName = "mssql2003115DataSet";
            this.mssql2003115DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // assetIDTextBox
            // 
            this.assetIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "AssetID", true));
            this.assetIDTextBox.Location = new System.Drawing.Point(93, 285);
            this.assetIDTextBox.Name = "assetIDTextBox";
            this.assetIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.assetIDTextBox.TabIndex = 5;
            // 
            // systemNameTextBox
            // 
            this.systemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "SystemName", true));
            this.systemNameTextBox.Location = new System.Drawing.Point(93, 311);
            this.systemNameTextBox.Name = "systemNameTextBox";
            this.systemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.systemNameTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(93, 337);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 9;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(278, 311);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 13;
            // 
            // iPAddressTextBox
            // 
            this.iPAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "IPAddress", true));
            this.iPAddressTextBox.Location = new System.Drawing.Point(278, 337);
            this.iPAddressTextBox.Name = "iPAddressTextBox";
            this.iPAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.iPAddressTextBox.TabIndex = 15;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "Manufacturer", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(278, 288);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTextBox.TabIndex = 16;
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.assetsBindingSource, "PurchaseDate", true));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(471, 285);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchaseDateDateTimePicker.TabIndex = 17;
            this.purchaseDateDateTimePicker.ValueChanged += new System.EventHandler(this.purchaseDateDateTimePicker_ValueChanged);
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "Note", true));
            this.noteTextBox.Location = new System.Drawing.Point(471, 311);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(200, 20);
            this.noteTextBox.TabIndex = 19;
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // assetsDataGridView
            // 
            this.assetsDataGridView.AutoGenerateColumns = false;
            this.assetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.OperatingSystem});
            this.assetsDataGridView.DataSource = this.assetsBindingSource;
            this.assetsDataGridView.Location = new System.Drawing.Point(1, 38);
            this.assetsDataGridView.Name = "assetsDataGridView";
            this.assetsDataGridView.ReadOnly = true;
            this.assetsDataGridView.Size = new System.Drawing.Size(1042, 220);
            this.assetsDataGridView.TabIndex = 19;
            this.assetsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assetsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AssetID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AssetID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SystemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SystemName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn4.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IPAddress";
            this.dataGridViewTextBoxColumn6.HeaderText = "IPAddress";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PurchaseDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "PurchaseDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn8.HeaderText = "Note";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // OperatingSystem
            // 
            this.OperatingSystem.DataPropertyName = "OperatingSystem";
            this.OperatingSystem.HeaderText = "OperatingSystem";
            this.OperatingSystem.Name = "OperatingSystem";
            this.OperatingSystem.ReadOnly = true;
            // 
            // InsertBTN
            // 
            this.InsertBTN.Location = new System.Drawing.Point(888, 283);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(75, 23);
            this.InsertBTN.TabIndex = 20;
            this.InsertBTN.Text = "Insert";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(807, 283);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 22;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(889, 9);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 23;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "This Device";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Win32_ComputerSystem",
            "Win32_DiskDrive",
            "Win32_OperatingSystem",
            "Win32_Processor",
            "Win32_ProgramGroup",
            "Win32_SystemDevices",
            "Win32_StartupCommand"});
            this.comboBox1.Location = new System.Drawing.Point(29, 410);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(289, 407);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 27;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // dgvWMI
            // 
            this.dgvWMI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWMI.Location = new System.Drawing.Point(29, 451);
            this.dgvWMI.Name = "dgvWMI";
            this.dgvWMI.Size = new System.Drawing.Size(335, 150);
            this.dgvWMI.TabIndex = 28;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(677, 337);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(86, 23);
            this.infoButton.TabIndex = 29;
            this.infoButton.Text = "Software Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // softwareBindingSource
            // 
            this.softwareBindingSource.DataMember = "Software";
            this.softwareBindingSource.DataSource = this.mssql2003115DataSet;
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AssetsTableAdapter = this.assetsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SoftwareTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _307_Coursework.mssql2003115DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // softwareTableAdapter
            // 
            this.softwareTableAdapter.ClearBeforeFill = true;
            // 
            // OSTextBox
            // 
            this.OSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "OperatingSystem", true));
            this.OSTextBox.Location = new System.Drawing.Point(471, 339);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(200, 20);
            this.OSTextBox.TabIndex = 36;
            // 
            // updatedDateTimePicker
            // 
            this.updatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.softwareBindingSource, "Updated", true));
            this.updatedDateTimePicker.Enabled = false;
            this.updatedDateTimePicker.Location = new System.Drawing.Point(471, 391);
            this.updatedDateTimePicker.Name = "updatedDateTimePicker";
            this.updatedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.updatedDateTimePicker.TabIndex = 37;
            this.updatedDateTimePicker.Visible = false;
            // 
            // versionTextBox
            // 
            this.versionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.softwareBindingSource, "Version", true));
            this.versionTextBox.Location = new System.Drawing.Point(471, 365);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(200, 20);
            this.versionTextBox.TabIndex = 38;
            this.versionTextBox.Visible = false;
            this.versionTextBox.TextChanged += new System.EventHandler(this.versionTextBox_TextChanged);
            // 
            // NVDButton
            // 
            this.NVDButton.Location = new System.Drawing.Point(908, 451);
            this.NVDButton.Name = "NVDButton";
            this.NVDButton.Size = new System.Drawing.Size(75, 23);
            this.NVDButton.TabIndex = 39;
            this.NVDButton.Text = "Search";
            this.NVDButton.UseVisualStyleBackColor = true;
            this.NVDButton.Click += new System.EventHandler(this.NVDButton_Click_1);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(629, 481);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(354, 130);
            this.txtResponse.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Version:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Updated:";
            this.label3.Visible = false;
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(629, 453);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(273, 20);
            this.keywordTextBox.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 655);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.NVDButton);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(this.updatedDateTimePicker);
            this.Controls.Add(this.OSTextBox);
            this.Controls.Add(operatingSystemLabel);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.dgvWMI);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.InsertBTN);
            this.Controls.Add(this.assetsDataGridView);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(manufacturerLabel);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(iPAddressLabel);
            this.Controls.Add(this.iPAddressTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(systemNameLabel);
            this.Controls.Add(this.systemNameTextBox);
            this.Controls.Add(assetIDLabel);
            this.Controls.Add(this.assetIDTextBox);
            this.Controls.Add(this.assetsBindingNavigator);
            this.Controls.Add(this.connectionBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingNavigator)).EndInit();
            this.assetsBindingNavigator.ResumeLayout(false);
            this.assetsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2003115DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox connectionBox;
        private mssql2003115DataSet mssql2003115DataSet;
        private System.Windows.Forms.BindingSource assetsBindingSource;
        private mssql2003115DataSetTableAdapters.AssetsTableAdapter assetsTableAdapter;
        private mssql2003115DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator assetsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox assetIDTextBox;
        private System.Windows.Forms.TextBox systemNameTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox iPAddressTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DataGridView assetsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatingSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.DataGridView dgvWMI;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.BindingSource softwareBindingSource;
        private mssql2003115DataSetTableAdapters.SoftwareTableAdapter softwareTableAdapter;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.DateTimePicker updatedDateTimePicker;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.Button NVDButton;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keywordTextBox;
    }
}

