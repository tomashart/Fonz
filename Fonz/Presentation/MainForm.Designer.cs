namespace Fonz
{
	partial class MainForm
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
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.referenceTab = new System.Windows.Forms.TabPage();
			this.referenceComparisonDataGroupBox = new System.Windows.Forms.GroupBox();
			this.referenceComparisonDataGridView = new System.Windows.Forms.DataGridView();
			this.referenceComparisonDataSKURadio = new System.Windows.Forms.RadioButton();
			this.referenceComparisonDataProductIdRadio = new System.Windows.Forms.RadioButton();
			this.referenceComparisonDataHeaderCheckBox = new System.Windows.Forms.CheckBox();
			this.referenceComparisonDataLoadButton = new System.Windows.Forms.Button();
			this.referenceComparisonDataSheetGenerateButton = new System.Windows.Forms.Button();
			this.referenceConnectionStringPortTextBox = new System.Windows.Forms.TextBox();
			this.referenceConnectionStringPortLabel = new System.Windows.Forms.Label();
			this.referenceConnectionStringAddressTextBox = new System.Windows.Forms.TextBox();
			this.referenceConnectionStringAddressLabel = new System.Windows.Forms.Label();
			this.referenceConnectionStringPasswordTextBox = new System.Windows.Forms.TextBox();
			this.referenceConnectionStringVerifyButton = new System.Windows.Forms.Button();
			this.referenceConnectionStringUserTextBox = new System.Windows.Forms.TextBox();
			this.referenceConnectionStringGroupBox = new System.Windows.Forms.GroupBox();
			this.referenceConnectionStringDatabaseTextBox = new System.Windows.Forms.TextBox();
			this.referenceConnectionStringDatabaseLabel = new System.Windows.Forms.Label();
			this.referenceConnectionStringPasswordLabel = new System.Windows.Forms.Label();
			this.referenceConnectionStringUserLabel = new System.Windows.Forms.Label();
			this.grabTab = new System.Windows.Forms.TabPage();
			this.grabDataGroupBox = new System.Windows.Forms.GroupBox();
			this.grabDataDocumentsLabel = new System.Windows.Forms.CheckBox();
			this.grabDataDocumentsTextBox = new System.Windows.Forms.TextBox();
			this.grabDataCategoryTextBox = new System.Windows.Forms.TextBox();
			this.grabDataCategoryLabel = new System.Windows.Forms.CheckBox();
			this.grabDataAttributesTextBox = new System.Windows.Forms.TextBox();
			this.grabDataAttributesLabel = new System.Windows.Forms.CheckBox();
			this.grabDataPictureTextBox = new System.Windows.Forms.TextBox();
			this.grabDataPictureLabel = new System.Windows.Forms.CheckBox();
			this.grabDataFullDescriptionTextBox = new System.Windows.Forms.TextBox();
			this.grabDataFullDescriptionLabel = new System.Windows.Forms.CheckBox();
			this.grabDataNameTextBox = new System.Windows.Forms.TextBox();
			this.grabDataNameLabel = new System.Windows.Forms.CheckBox();
			this.grabDataButton = new System.Windows.Forms.Button();
			this.grabSiteGroupBox = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grabSiteTextBox = new System.Windows.Forms.TextBox();
			this.grabSiteHostnameLabel = new System.Windows.Forms.Label();
			this.consoleGroupBox = new System.Windows.Forms.GroupBox();
			this.consoleClearButton = new System.Windows.Forms.Button();
			this.consoleTextBox = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.serializeTab = new System.Windows.Forms.TabPage();
			this.serializeXMLSave = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.referenceTab.SuspendLayout();
			this.referenceComparisonDataGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.referenceComparisonDataGridView)).BeginInit();
			this.referenceConnectionStringGroupBox.SuspendLayout();
			this.grabTab.SuspendLayout();
			this.grabDataGroupBox.SuspendLayout();
			this.grabSiteGroupBox.SuspendLayout();
			this.consoleGroupBox.SuspendLayout();
			this.serializeTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 685);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(617, 23);
			this.progressBar.TabIndex = 1;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.referenceTab);
			this.tabControl.Controls.Add(this.grabTab);
			this.tabControl.Controls.Add(this.serializeTab);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(617, 333);
			this.tabControl.TabIndex = 2;
			// 
			// referenceTab
			// 
			this.referenceTab.Controls.Add(this.referenceComparisonDataGroupBox);
			this.referenceTab.Controls.Add(this.referenceConnectionStringPortTextBox);
			this.referenceTab.Controls.Add(this.referenceConnectionStringPortLabel);
			this.referenceTab.Controls.Add(this.referenceConnectionStringAddressTextBox);
			this.referenceTab.Controls.Add(this.referenceConnectionStringAddressLabel);
			this.referenceTab.Controls.Add(this.referenceConnectionStringPasswordTextBox);
			this.referenceTab.Controls.Add(this.referenceConnectionStringVerifyButton);
			this.referenceTab.Controls.Add(this.referenceConnectionStringUserTextBox);
			this.referenceTab.Controls.Add(this.referenceConnectionStringGroupBox);
			this.referenceTab.Location = new System.Drawing.Point(4, 22);
			this.referenceTab.Name = "referenceTab";
			this.referenceTab.Padding = new System.Windows.Forms.Padding(3);
			this.referenceTab.Size = new System.Drawing.Size(609, 307);
			this.referenceTab.TabIndex = 0;
			this.referenceTab.Text = "Reference";
			this.referenceTab.UseVisualStyleBackColor = true;
			// 
			// referenceComparisonDataGroupBox
			// 
			this.referenceComparisonDataGroupBox.Controls.Add(this.label3);
			this.referenceComparisonDataGroupBox.Controls.Add(this.referenceComparisonDataGridView);
			this.referenceComparisonDataGroupBox.Controls.Add(this.referenceComparisonDataSKURadio);
			this.referenceComparisonDataGroupBox.Controls.Add(this.referenceComparisonDataProductIdRadio);
			this.referenceComparisonDataGroupBox.Controls.Add(this.referenceComparisonDataHeaderCheckBox);
			this.referenceComparisonDataGroupBox.Controls.Add(this.referenceComparisonDataLoadButton);
			this.referenceComparisonDataGroupBox.Controls.Add(this.referenceComparisonDataSheetGenerateButton);
			this.referenceComparisonDataGroupBox.Location = new System.Drawing.Point(6, 140);
			this.referenceComparisonDataGroupBox.Name = "referenceComparisonDataGroupBox";
			this.referenceComparisonDataGroupBox.Size = new System.Drawing.Size(597, 160);
			this.referenceComparisonDataGroupBox.TabIndex = 12;
			this.referenceComparisonDataGroupBox.TabStop = false;
			this.referenceComparisonDataGroupBox.Text = "Comparison Data";
			// 
			// referenceComparisonDataGridView
			// 
			this.referenceComparisonDataGridView.AllowUserToAddRows = false;
			this.referenceComparisonDataGridView.AllowUserToDeleteRows = false;
			this.referenceComparisonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.referenceComparisonDataGridView.Location = new System.Drawing.Point(6, 19);
			this.referenceComparisonDataGridView.Name = "referenceComparisonDataGridView";
			this.referenceComparisonDataGridView.ReadOnly = true;
			this.referenceComparisonDataGridView.Size = new System.Drawing.Size(394, 135);
			this.referenceComparisonDataGridView.TabIndex = 16;
			// 
			// referenceComparisonDataSKURadio
			// 
			this.referenceComparisonDataSKURadio.AutoSize = true;
			this.referenceComparisonDataSKURadio.Checked = true;
			this.referenceComparisonDataSKURadio.Location = new System.Drawing.Point(406, 64);
			this.referenceComparisonDataSKURadio.Name = "referenceComparisonDataSKURadio";
			this.referenceComparisonDataSKURadio.Size = new System.Drawing.Size(47, 17);
			this.referenceComparisonDataSKURadio.TabIndex = 18;
			this.referenceComparisonDataSKURadio.TabStop = true;
			this.referenceComparisonDataSKURadio.Text = "SKU";
			this.referenceComparisonDataSKURadio.UseVisualStyleBackColor = true;
			// 
			// referenceComparisonDataProductIdRadio
			// 
			this.referenceComparisonDataProductIdRadio.AutoSize = true;
			this.referenceComparisonDataProductIdRadio.Location = new System.Drawing.Point(406, 41);
			this.referenceComparisonDataProductIdRadio.Name = "referenceComparisonDataProductIdRadio";
			this.referenceComparisonDataProductIdRadio.Size = new System.Drawing.Size(71, 17);
			this.referenceComparisonDataProductIdRadio.TabIndex = 17;
			this.referenceComparisonDataProductIdRadio.Text = "ProductId";
			this.referenceComparisonDataProductIdRadio.UseVisualStyleBackColor = true;
			// 
			// referenceComparisonDataHeaderCheckBox
			// 
			this.referenceComparisonDataHeaderCheckBox.AutoSize = true;
			this.referenceComparisonDataHeaderCheckBox.Location = new System.Drawing.Point(406, 87);
			this.referenceComparisonDataHeaderCheckBox.Name = "referenceComparisonDataHeaderCheckBox";
			this.referenceComparisonDataHeaderCheckBox.Size = new System.Drawing.Size(111, 17);
			this.referenceComparisonDataHeaderCheckBox.TabIndex = 16;
			this.referenceComparisonDataHeaderCheckBox.Text = "First row is header";
			this.referenceComparisonDataHeaderCheckBox.UseVisualStyleBackColor = true;
			// 
			// referenceComparisonDataLoadButton
			// 
			this.referenceComparisonDataLoadButton.Location = new System.Drawing.Point(406, 110);
			this.referenceComparisonDataLoadButton.Name = "referenceComparisonDataLoadButton";
			this.referenceComparisonDataLoadButton.Size = new System.Drawing.Size(185, 19);
			this.referenceComparisonDataLoadButton.TabIndex = 14;
			this.referenceComparisonDataLoadButton.Text = "Load...";
			this.referenceComparisonDataLoadButton.UseVisualStyleBackColor = true;
			this.referenceComparisonDataLoadButton.Click += new System.EventHandler(this.Reference_ComparisonData_Load);
			// 
			// referenceComparisonDataSheetGenerateButton
			// 
			this.referenceComparisonDataSheetGenerateButton.Location = new System.Drawing.Point(406, 135);
			this.referenceComparisonDataSheetGenerateButton.Name = "referenceComparisonDataSheetGenerateButton";
			this.referenceComparisonDataSheetGenerateButton.Size = new System.Drawing.Size(185, 19);
			this.referenceComparisonDataSheetGenerateButton.TabIndex = 13;
			this.referenceComparisonDataSheetGenerateButton.Text = "Generate";
			this.referenceComparisonDataSheetGenerateButton.UseVisualStyleBackColor = true;
			this.referenceComparisonDataSheetGenerateButton.Click += new System.EventHandler(this.Reference_ComparisonData_Generate);
			// 
			// referenceConnectionStringPortTextBox
			// 
			this.referenceConnectionStringPortTextBox.Location = new System.Drawing.Point(209, 99);
			this.referenceConnectionStringPortTextBox.Name = "referenceConnectionStringPortTextBox";
			this.referenceConnectionStringPortTextBox.Size = new System.Drawing.Size(197, 20);
			this.referenceConnectionStringPortTextBox.TabIndex = 8;
			this.referenceConnectionStringPortTextBox.Text = "3306";
			// 
			// referenceConnectionStringPortLabel
			// 
			this.referenceConnectionStringPortLabel.AutoSize = true;
			this.referenceConnectionStringPortLabel.Location = new System.Drawing.Point(212, 83);
			this.referenceConnectionStringPortLabel.Name = "referenceConnectionStringPortLabel";
			this.referenceConnectionStringPortLabel.Size = new System.Drawing.Size(26, 13);
			this.referenceConnectionStringPortLabel.TabIndex = 7;
			this.referenceConnectionStringPortLabel.Text = "Port";
			// 
			// referenceConnectionStringAddressTextBox
			// 
			this.referenceConnectionStringAddressTextBox.Location = new System.Drawing.Point(12, 99);
			this.referenceConnectionStringAddressTextBox.Name = "referenceConnectionStringAddressTextBox";
			this.referenceConnectionStringAddressTextBox.Size = new System.Drawing.Size(191, 20);
			this.referenceConnectionStringAddressTextBox.TabIndex = 6;
			// 
			// referenceConnectionStringAddressLabel
			// 
			this.referenceConnectionStringAddressLabel.AutoSize = true;
			this.referenceConnectionStringAddressLabel.Location = new System.Drawing.Point(15, 83);
			this.referenceConnectionStringAddressLabel.Name = "referenceConnectionStringAddressLabel";
			this.referenceConnectionStringAddressLabel.Size = new System.Drawing.Size(45, 13);
			this.referenceConnectionStringAddressLabel.TabIndex = 5;
			this.referenceConnectionStringAddressLabel.Text = "Address";
			// 
			// referenceConnectionStringPasswordTextBox
			// 
			this.referenceConnectionStringPasswordTextBox.Location = new System.Drawing.Point(209, 56);
			this.referenceConnectionStringPasswordTextBox.Name = "referenceConnectionStringPasswordTextBox";
			this.referenceConnectionStringPasswordTextBox.Size = new System.Drawing.Size(197, 20);
			this.referenceConnectionStringPasswordTextBox.TabIndex = 4;
			// 
			// referenceConnectionStringVerifyButton
			// 
			this.referenceConnectionStringVerifyButton.Location = new System.Drawing.Point(412, 99);
			this.referenceConnectionStringVerifyButton.Name = "referenceConnectionStringVerifyButton";
			this.referenceConnectionStringVerifyButton.Size = new System.Drawing.Size(185, 20);
			this.referenceConnectionStringVerifyButton.TabIndex = 2;
			this.referenceConnectionStringVerifyButton.Text = "Verify";
			this.referenceConnectionStringVerifyButton.UseVisualStyleBackColor = true;
			this.referenceConnectionStringVerifyButton.Click += new System.EventHandler(this.Reference_ConnectionString_Verify);
			// 
			// referenceConnectionStringUserTextBox
			// 
			this.referenceConnectionStringUserTextBox.Location = new System.Drawing.Point(12, 56);
			this.referenceConnectionStringUserTextBox.Name = "referenceConnectionStringUserTextBox";
			this.referenceConnectionStringUserTextBox.Size = new System.Drawing.Size(191, 20);
			this.referenceConnectionStringUserTextBox.TabIndex = 1;
			// 
			// referenceConnectionStringGroupBox
			// 
			this.referenceConnectionStringGroupBox.Controls.Add(this.referenceConnectionStringDatabaseTextBox);
			this.referenceConnectionStringGroupBox.Controls.Add(this.referenceConnectionStringDatabaseLabel);
			this.referenceConnectionStringGroupBox.Controls.Add(this.referenceConnectionStringPasswordLabel);
			this.referenceConnectionStringGroupBox.Controls.Add(this.referenceConnectionStringUserLabel);
			this.referenceConnectionStringGroupBox.Location = new System.Drawing.Point(6, 6);
			this.referenceConnectionStringGroupBox.Name = "referenceConnectionStringGroupBox";
			this.referenceConnectionStringGroupBox.Size = new System.Drawing.Size(597, 128);
			this.referenceConnectionStringGroupBox.TabIndex = 11;
			this.referenceConnectionStringGroupBox.TabStop = false;
			this.referenceConnectionStringGroupBox.Text = "Connection String";
			// 
			// referenceConnectionStringDatabaseTextBox
			// 
			this.referenceConnectionStringDatabaseTextBox.Location = new System.Drawing.Point(406, 50);
			this.referenceConnectionStringDatabaseTextBox.Name = "referenceConnectionStringDatabaseTextBox";
			this.referenceConnectionStringDatabaseTextBox.Size = new System.Drawing.Size(185, 20);
			this.referenceConnectionStringDatabaseTextBox.TabIndex = 16;
			// 
			// referenceConnectionStringDatabaseLabel
			// 
			this.referenceConnectionStringDatabaseLabel.AutoSize = true;
			this.referenceConnectionStringDatabaseLabel.Location = new System.Drawing.Point(409, 34);
			this.referenceConnectionStringDatabaseLabel.Name = "referenceConnectionStringDatabaseLabel";
			this.referenceConnectionStringDatabaseLabel.Size = new System.Drawing.Size(53, 13);
			this.referenceConnectionStringDatabaseLabel.TabIndex = 15;
			this.referenceConnectionStringDatabaseLabel.Text = "Database";
			// 
			// referenceConnectionStringPasswordLabel
			// 
			this.referenceConnectionStringPasswordLabel.AutoSize = true;
			this.referenceConnectionStringPasswordLabel.Location = new System.Drawing.Point(206, 34);
			this.referenceConnectionStringPasswordLabel.Name = "referenceConnectionStringPasswordLabel";
			this.referenceConnectionStringPasswordLabel.Size = new System.Drawing.Size(53, 13);
			this.referenceConnectionStringPasswordLabel.TabIndex = 3;
			this.referenceConnectionStringPasswordLabel.Text = "Password";
			// 
			// referenceConnectionStringUserLabel
			// 
			this.referenceConnectionStringUserLabel.AutoSize = true;
			this.referenceConnectionStringUserLabel.Location = new System.Drawing.Point(9, 34);
			this.referenceConnectionStringUserLabel.Name = "referenceConnectionStringUserLabel";
			this.referenceConnectionStringUserLabel.Size = new System.Drawing.Size(29, 13);
			this.referenceConnectionStringUserLabel.TabIndex = 0;
			this.referenceConnectionStringUserLabel.Text = "User";
			// 
			// grabTab
			// 
			this.grabTab.Controls.Add(this.grabDataGroupBox);
			this.grabTab.Controls.Add(this.grabSiteGroupBox);
			this.grabTab.Location = new System.Drawing.Point(4, 22);
			this.grabTab.Name = "grabTab";
			this.grabTab.Padding = new System.Windows.Forms.Padding(3);
			this.grabTab.Size = new System.Drawing.Size(609, 307);
			this.grabTab.TabIndex = 1;
			this.grabTab.Text = "Grab";
			this.grabTab.UseVisualStyleBackColor = true;
			// 
			// grabDataGroupBox
			// 
			this.grabDataGroupBox.Controls.Add(this.grabDataDocumentsLabel);
			this.grabDataGroupBox.Controls.Add(this.grabDataDocumentsTextBox);
			this.grabDataGroupBox.Controls.Add(this.grabDataCategoryTextBox);
			this.grabDataGroupBox.Controls.Add(this.grabDataCategoryLabel);
			this.grabDataGroupBox.Controls.Add(this.grabDataAttributesTextBox);
			this.grabDataGroupBox.Controls.Add(this.grabDataAttributesLabel);
			this.grabDataGroupBox.Controls.Add(this.grabDataPictureTextBox);
			this.grabDataGroupBox.Controls.Add(this.grabDataPictureLabel);
			this.grabDataGroupBox.Controls.Add(this.grabDataFullDescriptionTextBox);
			this.grabDataGroupBox.Controls.Add(this.grabDataFullDescriptionLabel);
			this.grabDataGroupBox.Controls.Add(this.grabDataNameTextBox);
			this.grabDataGroupBox.Controls.Add(this.grabDataNameLabel);
			this.grabDataGroupBox.Controls.Add(this.grabDataButton);
			this.grabDataGroupBox.Location = new System.Drawing.Point(6, 152);
			this.grabDataGroupBox.Name = "grabDataGroupBox";
			this.grabDataGroupBox.Size = new System.Drawing.Size(597, 149);
			this.grabDataGroupBox.TabIndex = 11;
			this.grabDataGroupBox.TabStop = false;
			this.grabDataGroupBox.Text = "Data";
			// 
			// grabDataDocumentsLabel
			// 
			this.grabDataDocumentsLabel.AutoSize = true;
			this.grabDataDocumentsLabel.Checked = true;
			this.grabDataDocumentsLabel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.grabDataDocumentsLabel.Location = new System.Drawing.Point(302, 90);
			this.grabDataDocumentsLabel.Name = "grabDataDocumentsLabel";
			this.grabDataDocumentsLabel.Size = new System.Drawing.Size(80, 17);
			this.grabDataDocumentsLabel.TabIndex = 22;
			this.grabDataDocumentsLabel.Text = "Documents";
			this.grabDataDocumentsLabel.UseVisualStyleBackColor = true;
			// 
			// grabDataDocumentsTextBox
			// 
			this.grabDataDocumentsTextBox.Location = new System.Drawing.Point(302, 113);
			this.grabDataDocumentsTextBox.Name = "grabDataDocumentsTextBox";
			this.grabDataDocumentsTextBox.Size = new System.Drawing.Size(142, 20);
			this.grabDataDocumentsTextBox.TabIndex = 21;
			this.grabDataDocumentsTextBox.Text = "#productDetailCenterDownloads a";
			// 
			// grabDataCategoryTextBox
			// 
			this.grabDataCategoryTextBox.Location = new System.Drawing.Point(154, 113);
			this.grabDataCategoryTextBox.Name = "grabDataCategoryTextBox";
			this.grabDataCategoryTextBox.Size = new System.Drawing.Size(142, 20);
			this.grabDataCategoryTextBox.TabIndex = 19;
			this.grabDataCategoryTextBox.Text = "ol.breadcrumb .breadcrumb-item";
			// 
			// grabDataCategoryLabel
			// 
			this.grabDataCategoryLabel.AutoSize = true;
			this.grabDataCategoryLabel.Checked = true;
			this.grabDataCategoryLabel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.grabDataCategoryLabel.Location = new System.Drawing.Point(154, 90);
			this.grabDataCategoryLabel.Name = "grabDataCategoryLabel";
			this.grabDataCategoryLabel.Size = new System.Drawing.Size(68, 17);
			this.grabDataCategoryLabel.TabIndex = 18;
			this.grabDataCategoryLabel.Text = "Category";
			this.grabDataCategoryLabel.UseVisualStyleBackColor = true;
			// 
			// grabDataAttributesTextBox
			// 
			this.grabDataAttributesTextBox.Location = new System.Drawing.Point(6, 113);
			this.grabDataAttributesTextBox.Name = "grabDataAttributesTextBox";
			this.grabDataAttributesTextBox.Size = new System.Drawing.Size(142, 20);
			this.grabDataAttributesTextBox.TabIndex = 17;
			this.grabDataAttributesTextBox.Text = "table.tech_table tbody tr td p";
			// 
			// grabDataAttributesLabel
			// 
			this.grabDataAttributesLabel.AutoSize = true;
			this.grabDataAttributesLabel.Checked = true;
			this.grabDataAttributesLabel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.grabDataAttributesLabel.Location = new System.Drawing.Point(6, 90);
			this.grabDataAttributesLabel.Name = "grabDataAttributesLabel";
			this.grabDataAttributesLabel.Size = new System.Drawing.Size(70, 17);
			this.grabDataAttributesLabel.TabIndex = 16;
			this.grabDataAttributesLabel.Text = "Attributes";
			this.grabDataAttributesLabel.UseVisualStyleBackColor = true;
			// 
			// grabDataPictureTextBox
			// 
			this.grabDataPictureTextBox.Location = new System.Drawing.Point(302, 52);
			this.grabDataPictureTextBox.Name = "grabDataPictureTextBox";
			this.grabDataPictureTextBox.Size = new System.Drawing.Size(142, 20);
			this.grabDataPictureTextBox.TabIndex = 15;
			this.grabDataPictureTextBox.Text = "#detailImage img.img-fluid[src]";
			// 
			// grabDataPictureLabel
			// 
			this.grabDataPictureLabel.AutoSize = true;
			this.grabDataPictureLabel.Checked = true;
			this.grabDataPictureLabel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.grabDataPictureLabel.Location = new System.Drawing.Point(302, 29);
			this.grabDataPictureLabel.Name = "grabDataPictureLabel";
			this.grabDataPictureLabel.Size = new System.Drawing.Size(59, 17);
			this.grabDataPictureLabel.TabIndex = 14;
			this.grabDataPictureLabel.Text = "Picture";
			this.grabDataPictureLabel.UseVisualStyleBackColor = true;
			// 
			// grabDataFullDescriptionTextBox
			// 
			this.grabDataFullDescriptionTextBox.Location = new System.Drawing.Point(154, 52);
			this.grabDataFullDescriptionTextBox.Name = "grabDataFullDescriptionTextBox";
			this.grabDataFullDescriptionTextBox.Size = new System.Drawing.Size(142, 20);
			this.grabDataFullDescriptionTextBox.TabIndex = 13;
			this.grabDataFullDescriptionTextBox.Text = "#blockProductInfo #productDetailCenterDescription";
			// 
			// grabDataFullDescriptionLabel
			// 
			this.grabDataFullDescriptionLabel.AutoSize = true;
			this.grabDataFullDescriptionLabel.Checked = true;
			this.grabDataFullDescriptionLabel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.grabDataFullDescriptionLabel.Location = new System.Drawing.Point(154, 29);
			this.grabDataFullDescriptionLabel.Name = "grabDataFullDescriptionLabel";
			this.grabDataFullDescriptionLabel.Size = new System.Drawing.Size(98, 17);
			this.grabDataFullDescriptionLabel.TabIndex = 12;
			this.grabDataFullDescriptionLabel.Text = "Full Description";
			this.grabDataFullDescriptionLabel.UseVisualStyleBackColor = true;
			// 
			// grabDataNameTextBox
			// 
			this.grabDataNameTextBox.Location = new System.Drawing.Point(6, 52);
			this.grabDataNameTextBox.Name = "grabDataNameTextBox";
			this.grabDataNameTextBox.Size = new System.Drawing.Size(142, 20);
			this.grabDataNameTextBox.TabIndex = 11;
			this.grabDataNameTextBox.Text = "div.productdetail_info div.productdetail_info_right h1";
			// 
			// grabDataNameLabel
			// 
			this.grabDataNameLabel.AutoSize = true;
			this.grabDataNameLabel.Checked = true;
			this.grabDataNameLabel.CheckState = System.Windows.Forms.CheckState.Checked;
			this.grabDataNameLabel.Location = new System.Drawing.Point(6, 29);
			this.grabDataNameLabel.Name = "grabDataNameLabel";
			this.grabDataNameLabel.Size = new System.Drawing.Size(54, 17);
			this.grabDataNameLabel.TabIndex = 5;
			this.grabDataNameLabel.Text = "Name";
			this.grabDataNameLabel.UseVisualStyleBackColor = true;
			// 
			// grabDataButton
			// 
			this.grabDataButton.Location = new System.Drawing.Point(449, 113);
			this.grabDataButton.Name = "grabDataButton";
			this.grabDataButton.Size = new System.Drawing.Size(142, 20);
			this.grabDataButton.TabIndex = 4;
			this.grabDataButton.Text = "Commence";
			this.grabDataButton.UseVisualStyleBackColor = true;
			this.grabDataButton.Click += new System.EventHandler(this.Grab_Data_Commence);
			// 
			// grabSiteGroupBox
			// 
			this.grabSiteGroupBox.Controls.Add(this.radioButton2);
			this.grabSiteGroupBox.Controls.Add(this.radioButton1);
			this.grabSiteGroupBox.Controls.Add(this.textBox2);
			this.grabSiteGroupBox.Controls.Add(this.label2);
			this.grabSiteGroupBox.Controls.Add(this.textBox1);
			this.grabSiteGroupBox.Controls.Add(this.label1);
			this.grabSiteGroupBox.Controls.Add(this.grabSiteTextBox);
			this.grabSiteGroupBox.Controls.Add(this.grabSiteHostnameLabel);
			this.grabSiteGroupBox.Location = new System.Drawing.Point(6, 6);
			this.grabSiteGroupBox.Name = "grabSiteGroupBox";
			this.grabSiteGroupBox.Size = new System.Drawing.Size(597, 140);
			this.grabSiteGroupBox.TabIndex = 0;
			this.grabSiteGroupBox.TabStop = false;
			this.grabSiteGroupBox.Text = "Site";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(309, 48);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(47, 17);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Auth";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(209, 48);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(64, 17);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "No Auth";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(203, 104);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(191, 20);
			this.textBox2.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(206, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Password";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(6, 104);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(191, 20);
			this.textBox1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Username / Email";
			// 
			// grabSiteTextBox
			// 
			this.grabSiteTextBox.Location = new System.Drawing.Point(6, 48);
			this.grabSiteTextBox.Name = "grabSiteTextBox";
			this.grabSiteTextBox.Size = new System.Drawing.Size(191, 20);
			this.grabSiteTextBox.TabIndex = 3;
			this.grabSiteTextBox.Text = "https://eshop.wuerth.de/0/<SKU>.sku/en/US/EUR/";
			// 
			// grabSiteHostnameLabel
			// 
			this.grabSiteHostnameLabel.AutoSize = true;
			this.grabSiteHostnameLabel.Location = new System.Drawing.Point(9, 32);
			this.grabSiteHostnameLabel.Name = "grabSiteHostnameLabel";
			this.grabSiteHostnameLabel.Size = new System.Drawing.Size(66, 13);
			this.grabSiteHostnameLabel.TabIndex = 2;
			this.grabSiteHostnameLabel.Text = "URL Pattern";
			// 
			// consoleGroupBox
			// 
			this.consoleGroupBox.Controls.Add(this.consoleClearButton);
			this.consoleGroupBox.Controls.Add(this.consoleTextBox);
			this.consoleGroupBox.Location = new System.Drawing.Point(12, 351);
			this.consoleGroupBox.Name = "consoleGroupBox";
			this.consoleGroupBox.Size = new System.Drawing.Size(613, 329);
			this.consoleGroupBox.TabIndex = 15;
			this.consoleGroupBox.TabStop = false;
			this.consoleGroupBox.Text = "Console";
			// 
			// consoleClearButton
			// 
			this.consoleClearButton.Location = new System.Drawing.Point(416, 304);
			this.consoleClearButton.Name = "consoleClearButton";
			this.consoleClearButton.Size = new System.Drawing.Size(185, 19);
			this.consoleClearButton.TabIndex = 14;
			this.consoleClearButton.Text = "Clear";
			this.consoleClearButton.UseVisualStyleBackColor = true;
			this.consoleClearButton.Click += new System.EventHandler(this.Console_Clear);
			// 
			// consoleTextBox
			// 
			this.consoleTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.consoleTextBox.Location = new System.Drawing.Point(6, 19);
			this.consoleTextBox.Name = "consoleTextBox";
			this.consoleTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.consoleTextBox.Size = new System.Drawing.Size(595, 279);
			this.consoleTextBox.TabIndex = 9;
			this.consoleTextBox.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(403, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Identifier:";
			// 
			// serializeTab
			// 
			this.serializeTab.Controls.Add(this.serializeXMLSave);
			this.serializeTab.Location = new System.Drawing.Point(4, 22);
			this.serializeTab.Name = "serializeTab";
			this.serializeTab.Size = new System.Drawing.Size(609, 307);
			this.serializeTab.TabIndex = 2;
			this.serializeTab.Text = "Serialize";
			this.serializeTab.UseVisualStyleBackColor = true;
			// 
			// serializeXMLSave
			// 
			this.serializeXMLSave.Location = new System.Drawing.Point(522, 272);
			this.serializeXMLSave.Name = "serializeXMLSave";
			this.serializeXMLSave.Size = new System.Drawing.Size(75, 23);
			this.serializeXMLSave.TabIndex = 0;
			this.serializeXMLSave.Text = "Save";
			this.serializeXMLSave.UseVisualStyleBackColor = true;
			this.serializeXMLSave.Click += new System.EventHandler(this.Serialize_XML_Save);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 720);
			this.Controls.Add(this.consoleGroupBox);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.progressBar);
			this.Name = "MainForm";
			this.Text = "Shoplifter - Powered by Storefront";
			this.tabControl.ResumeLayout(false);
			this.referenceTab.ResumeLayout(false);
			this.referenceTab.PerformLayout();
			this.referenceComparisonDataGroupBox.ResumeLayout(false);
			this.referenceComparisonDataGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.referenceComparisonDataGridView)).EndInit();
			this.referenceConnectionStringGroupBox.ResumeLayout(false);
			this.referenceConnectionStringGroupBox.PerformLayout();
			this.grabTab.ResumeLayout(false);
			this.grabDataGroupBox.ResumeLayout(false);
			this.grabDataGroupBox.PerformLayout();
			this.grabSiteGroupBox.ResumeLayout(false);
			this.grabSiteGroupBox.PerformLayout();
			this.consoleGroupBox.ResumeLayout(false);
			this.serializeTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage referenceTab;
		private System.Windows.Forms.Label referenceConnectionStringUserLabel;
		private System.Windows.Forms.TabPage grabTab;
		private System.Windows.Forms.TextBox referenceConnectionStringPortTextBox;
		private System.Windows.Forms.Label referenceConnectionStringPortLabel;
		private System.Windows.Forms.TextBox referenceConnectionStringAddressTextBox;
		private System.Windows.Forms.Label referenceConnectionStringAddressLabel;
		private System.Windows.Forms.TextBox referenceConnectionStringPasswordTextBox;
		private System.Windows.Forms.Label referenceConnectionStringPasswordLabel;
		private System.Windows.Forms.Button referenceConnectionStringVerifyButton;
		private System.Windows.Forms.TextBox referenceConnectionStringUserTextBox;
		private System.Windows.Forms.GroupBox referenceConnectionStringGroupBox;
		private System.Windows.Forms.GroupBox referenceComparisonDataGroupBox;
		private System.Windows.Forms.Button referenceComparisonDataSheetGenerateButton;
		private System.Windows.Forms.TextBox referenceConnectionStringDatabaseTextBox;
		private System.Windows.Forms.Label referenceConnectionStringDatabaseLabel;
		private System.Windows.Forms.GroupBox grabSiteGroupBox;
		private System.Windows.Forms.TextBox grabSiteTextBox;
		private System.Windows.Forms.Label grabSiteHostnameLabel;
		private System.Windows.Forms.GroupBox consoleGroupBox;
		private System.Windows.Forms.Button consoleClearButton;
		private System.Windows.Forms.RichTextBox consoleTextBox;
		private System.Windows.Forms.GroupBox grabDataGroupBox;
		private System.Windows.Forms.Button grabDataButton;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button referenceComparisonDataLoadButton;
		private System.Windows.Forms.TextBox grabDataCategoryTextBox;
		private System.Windows.Forms.CheckBox grabDataCategoryLabel;
		private System.Windows.Forms.TextBox grabDataAttributesTextBox;
		private System.Windows.Forms.CheckBox grabDataAttributesLabel;
		private System.Windows.Forms.TextBox grabDataPictureTextBox;
		private System.Windows.Forms.CheckBox grabDataPictureLabel;
		private System.Windows.Forms.TextBox grabDataFullDescriptionTextBox;
		private System.Windows.Forms.CheckBox grabDataFullDescriptionLabel;
		private System.Windows.Forms.TextBox grabDataNameTextBox;
		private System.Windows.Forms.CheckBox grabDataNameLabel;
		private System.Windows.Forms.CheckBox grabDataDocumentsLabel;
		private System.Windows.Forms.TextBox grabDataDocumentsTextBox;
		private System.Windows.Forms.CheckBox referenceComparisonDataHeaderCheckBox;
		private System.Windows.Forms.RadioButton referenceComparisonDataSKURadio;
		private System.Windows.Forms.RadioButton referenceComparisonDataProductIdRadio;
		private System.Windows.Forms.DataGridView referenceComparisonDataGridView;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage serializeTab;
		private System.Windows.Forms.Button serializeXMLSave;
	}
}

