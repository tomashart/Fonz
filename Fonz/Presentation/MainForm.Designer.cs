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
			this.trawlComparisonDataGroupBox = new System.Windows.Forms.GroupBox();
			this.trawlReferenceLoadButton = new System.Windows.Forms.Button();
			this.trawlReferenceSheetGenerateButton = new System.Windows.Forms.Button();
			this.trawlComparisonDataCategoriesCheckBox = new System.Windows.Forms.CheckBox();
			this.trawlComparisonDataProductsCheckBox = new System.Windows.Forms.CheckBox();
			this.trawlConnectionStringPortTextBox = new System.Windows.Forms.TextBox();
			this.trawlConnectionStringPortLabel = new System.Windows.Forms.Label();
			this.trawlConnectionStringAddressTextBox = new System.Windows.Forms.TextBox();
			this.trawlConnectionStringAddressLabel = new System.Windows.Forms.Label();
			this.trawlConnectionStringPasswordTextBox = new System.Windows.Forms.TextBox();
			this.trawlConnectionStringVerifyButton = new System.Windows.Forms.Button();
			this.trawlConnectionStringUserTextBox = new System.Windows.Forms.TextBox();
			this.trawlConnectionStringGroupBox = new System.Windows.Forms.GroupBox();
			this.trawlConnectionStringDatabaseTextBox = new System.Windows.Forms.TextBox();
			this.trawlConnectionStringDatabaseLabel = new System.Windows.Forms.Label();
			this.trawlConnectionStringPasswordLabel = new System.Windows.Forms.Label();
			this.trawlConnectionStringUserLabel = new System.Windows.Forms.Label();
			this.grabTab = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.crawlSiteGroupBox = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.crawlSiteTextBox = new System.Windows.Forms.TextBox();
			this.crawlSiteHostnameLabel = new System.Windows.Forms.Label();
			this.trawlConsoleGroupBox = new System.Windows.Forms.GroupBox();
			this.trawlConsoleClearButton = new System.Windows.Forms.Button();
			this.trawlConsoleTextBox = new System.Windows.Forms.RichTextBox();
			this.referenceComparisonListView = new System.Windows.Forms.ListView();
			this.tabControl.SuspendLayout();
			this.referenceTab.SuspendLayout();
			this.trawlComparisonDataGroupBox.SuspendLayout();
			this.trawlConnectionStringGroupBox.SuspendLayout();
			this.grabTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.crawlSiteGroupBox.SuspendLayout();
			this.trawlConsoleGroupBox.SuspendLayout();
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
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(617, 333);
			this.tabControl.TabIndex = 2;
			// 
			// referenceTab
			// 
			this.referenceTab.Controls.Add(this.trawlComparisonDataGroupBox);
			this.referenceTab.Controls.Add(this.trawlConnectionStringPortTextBox);
			this.referenceTab.Controls.Add(this.trawlConnectionStringPortLabel);
			this.referenceTab.Controls.Add(this.trawlConnectionStringAddressTextBox);
			this.referenceTab.Controls.Add(this.trawlConnectionStringAddressLabel);
			this.referenceTab.Controls.Add(this.trawlConnectionStringPasswordTextBox);
			this.referenceTab.Controls.Add(this.trawlConnectionStringVerifyButton);
			this.referenceTab.Controls.Add(this.trawlConnectionStringUserTextBox);
			this.referenceTab.Controls.Add(this.trawlConnectionStringGroupBox);
			this.referenceTab.Location = new System.Drawing.Point(4, 22);
			this.referenceTab.Name = "referenceTab";
			this.referenceTab.Padding = new System.Windows.Forms.Padding(3);
			this.referenceTab.Size = new System.Drawing.Size(609, 307);
			this.referenceTab.TabIndex = 0;
			this.referenceTab.Text = "Reference";
			this.referenceTab.UseVisualStyleBackColor = true;
			// 
			// trawlComparisonDataGroupBox
			// 
			this.trawlComparisonDataGroupBox.Controls.Add(this.referenceComparisonListView);
			this.trawlComparisonDataGroupBox.Controls.Add(this.trawlReferenceLoadButton);
			this.trawlComparisonDataGroupBox.Controls.Add(this.trawlReferenceSheetGenerateButton);
			this.trawlComparisonDataGroupBox.Controls.Add(this.trawlComparisonDataCategoriesCheckBox);
			this.trawlComparisonDataGroupBox.Controls.Add(this.trawlComparisonDataProductsCheckBox);
			this.trawlComparisonDataGroupBox.Location = new System.Drawing.Point(6, 140);
			this.trawlComparisonDataGroupBox.Name = "trawlComparisonDataGroupBox";
			this.trawlComparisonDataGroupBox.Size = new System.Drawing.Size(597, 160);
			this.trawlComparisonDataGroupBox.TabIndex = 12;
			this.trawlComparisonDataGroupBox.TabStop = false;
			this.trawlComparisonDataGroupBox.Text = "Comparison Data";
			// 
			// trawlReferenceLoadButton
			// 
			this.trawlReferenceLoadButton.Location = new System.Drawing.Point(406, 110);
			this.trawlReferenceLoadButton.Name = "trawlReferenceLoadButton";
			this.trawlReferenceLoadButton.Size = new System.Drawing.Size(185, 19);
			this.trawlReferenceLoadButton.TabIndex = 14;
			this.trawlReferenceLoadButton.Text = "Load...";
			this.trawlReferenceLoadButton.UseVisualStyleBackColor = true;
			this.trawlReferenceLoadButton.Click += new System.EventHandler(this.trawlReferenceLoadButton_Click);
			// 
			// trawlReferenceSheetGenerateButton
			// 
			this.trawlReferenceSheetGenerateButton.Location = new System.Drawing.Point(406, 135);
			this.trawlReferenceSheetGenerateButton.Name = "trawlReferenceSheetGenerateButton";
			this.trawlReferenceSheetGenerateButton.Size = new System.Drawing.Size(185, 19);
			this.trawlReferenceSheetGenerateButton.TabIndex = 13;
			this.trawlReferenceSheetGenerateButton.Text = "Generate";
			this.trawlReferenceSheetGenerateButton.UseVisualStyleBackColor = true;
			this.trawlReferenceSheetGenerateButton.Click += new System.EventHandler(this.Trawl_Generate_Click);
			// 
			// trawlComparisonDataCategoriesCheckBox
			// 
			this.trawlComparisonDataCategoriesCheckBox.AutoSize = true;
			this.trawlComparisonDataCategoriesCheckBox.Location = new System.Drawing.Point(515, 19);
			this.trawlComparisonDataCategoriesCheckBox.Name = "trawlComparisonDataCategoriesCheckBox";
			this.trawlComparisonDataCategoriesCheckBox.Size = new System.Drawing.Size(76, 17);
			this.trawlComparisonDataCategoriesCheckBox.TabIndex = 4;
			this.trawlComparisonDataCategoriesCheckBox.Text = "Categories";
			this.trawlComparisonDataCategoriesCheckBox.UseVisualStyleBackColor = true;
			// 
			// trawlComparisonDataProductsCheckBox
			// 
			this.trawlComparisonDataProductsCheckBox.AutoSize = true;
			this.trawlComparisonDataProductsCheckBox.Location = new System.Drawing.Point(406, 19);
			this.trawlComparisonDataProductsCheckBox.Name = "trawlComparisonDataProductsCheckBox";
			this.trawlComparisonDataProductsCheckBox.Size = new System.Drawing.Size(68, 17);
			this.trawlComparisonDataProductsCheckBox.TabIndex = 0;
			this.trawlComparisonDataProductsCheckBox.Text = "Products";
			this.trawlComparisonDataProductsCheckBox.UseVisualStyleBackColor = true;
			// 
			// trawlConnectionStringPortTextBox
			// 
			this.trawlConnectionStringPortTextBox.Location = new System.Drawing.Point(209, 99);
			this.trawlConnectionStringPortTextBox.Name = "trawlConnectionStringPortTextBox";
			this.trawlConnectionStringPortTextBox.Size = new System.Drawing.Size(197, 20);
			this.trawlConnectionStringPortTextBox.TabIndex = 8;
			this.trawlConnectionStringPortTextBox.Text = "3306";
			// 
			// trawlConnectionStringPortLabel
			// 
			this.trawlConnectionStringPortLabel.AutoSize = true;
			this.trawlConnectionStringPortLabel.Location = new System.Drawing.Point(212, 83);
			this.trawlConnectionStringPortLabel.Name = "trawlConnectionStringPortLabel";
			this.trawlConnectionStringPortLabel.Size = new System.Drawing.Size(26, 13);
			this.trawlConnectionStringPortLabel.TabIndex = 7;
			this.trawlConnectionStringPortLabel.Text = "Port";
			// 
			// trawlConnectionStringAddressTextBox
			// 
			this.trawlConnectionStringAddressTextBox.Location = new System.Drawing.Point(12, 99);
			this.trawlConnectionStringAddressTextBox.Name = "trawlConnectionStringAddressTextBox";
			this.trawlConnectionStringAddressTextBox.Size = new System.Drawing.Size(191, 20);
			this.trawlConnectionStringAddressTextBox.TabIndex = 6;
			// 
			// trawlConnectionStringAddressLabel
			// 
			this.trawlConnectionStringAddressLabel.AutoSize = true;
			this.trawlConnectionStringAddressLabel.Location = new System.Drawing.Point(15, 83);
			this.trawlConnectionStringAddressLabel.Name = "trawlConnectionStringAddressLabel";
			this.trawlConnectionStringAddressLabel.Size = new System.Drawing.Size(45, 13);
			this.trawlConnectionStringAddressLabel.TabIndex = 5;
			this.trawlConnectionStringAddressLabel.Text = "Address";
			// 
			// trawlConnectionStringPasswordTextBox
			// 
			this.trawlConnectionStringPasswordTextBox.Location = new System.Drawing.Point(209, 56);
			this.trawlConnectionStringPasswordTextBox.Name = "trawlConnectionStringPasswordTextBox";
			this.trawlConnectionStringPasswordTextBox.Size = new System.Drawing.Size(197, 20);
			this.trawlConnectionStringPasswordTextBox.TabIndex = 4;
			// 
			// trawlConnectionStringVerifyButton
			// 
			this.trawlConnectionStringVerifyButton.Location = new System.Drawing.Point(412, 99);
			this.trawlConnectionStringVerifyButton.Name = "trawlConnectionStringVerifyButton";
			this.trawlConnectionStringVerifyButton.Size = new System.Drawing.Size(185, 20);
			this.trawlConnectionStringVerifyButton.TabIndex = 2;
			this.trawlConnectionStringVerifyButton.Text = "Verify";
			this.trawlConnectionStringVerifyButton.UseVisualStyleBackColor = true;
			this.trawlConnectionStringVerifyButton.Click += new System.EventHandler(this.Verify_Click);
			// 
			// trawlConnectionStringUserTextBox
			// 
			this.trawlConnectionStringUserTextBox.Location = new System.Drawing.Point(12, 56);
			this.trawlConnectionStringUserTextBox.Name = "trawlConnectionStringUserTextBox";
			this.trawlConnectionStringUserTextBox.Size = new System.Drawing.Size(191, 20);
			this.trawlConnectionStringUserTextBox.TabIndex = 1;
			// 
			// trawlConnectionStringGroupBox
			// 
			this.trawlConnectionStringGroupBox.Controls.Add(this.trawlConnectionStringDatabaseTextBox);
			this.trawlConnectionStringGroupBox.Controls.Add(this.trawlConnectionStringDatabaseLabel);
			this.trawlConnectionStringGroupBox.Controls.Add(this.trawlConnectionStringPasswordLabel);
			this.trawlConnectionStringGroupBox.Controls.Add(this.trawlConnectionStringUserLabel);
			this.trawlConnectionStringGroupBox.Location = new System.Drawing.Point(6, 6);
			this.trawlConnectionStringGroupBox.Name = "trawlConnectionStringGroupBox";
			this.trawlConnectionStringGroupBox.Size = new System.Drawing.Size(597, 128);
			this.trawlConnectionStringGroupBox.TabIndex = 11;
			this.trawlConnectionStringGroupBox.TabStop = false;
			this.trawlConnectionStringGroupBox.Text = "Connection String";
			// 
			// trawlConnectionStringDatabaseTextBox
			// 
			this.trawlConnectionStringDatabaseTextBox.Location = new System.Drawing.Point(406, 50);
			this.trawlConnectionStringDatabaseTextBox.Name = "trawlConnectionStringDatabaseTextBox";
			this.trawlConnectionStringDatabaseTextBox.Size = new System.Drawing.Size(185, 20);
			this.trawlConnectionStringDatabaseTextBox.TabIndex = 16;
			// 
			// trawlConnectionStringDatabaseLabel
			// 
			this.trawlConnectionStringDatabaseLabel.AutoSize = true;
			this.trawlConnectionStringDatabaseLabel.Location = new System.Drawing.Point(409, 34);
			this.trawlConnectionStringDatabaseLabel.Name = "trawlConnectionStringDatabaseLabel";
			this.trawlConnectionStringDatabaseLabel.Size = new System.Drawing.Size(53, 13);
			this.trawlConnectionStringDatabaseLabel.TabIndex = 15;
			this.trawlConnectionStringDatabaseLabel.Text = "Database";
			// 
			// trawlConnectionStringPasswordLabel
			// 
			this.trawlConnectionStringPasswordLabel.AutoSize = true;
			this.trawlConnectionStringPasswordLabel.Location = new System.Drawing.Point(206, 34);
			this.trawlConnectionStringPasswordLabel.Name = "trawlConnectionStringPasswordLabel";
			this.trawlConnectionStringPasswordLabel.Size = new System.Drawing.Size(53, 13);
			this.trawlConnectionStringPasswordLabel.TabIndex = 3;
			this.trawlConnectionStringPasswordLabel.Text = "Password";
			// 
			// trawlConnectionStringUserLabel
			// 
			this.trawlConnectionStringUserLabel.AutoSize = true;
			this.trawlConnectionStringUserLabel.Location = new System.Drawing.Point(9, 34);
			this.trawlConnectionStringUserLabel.Name = "trawlConnectionStringUserLabel";
			this.trawlConnectionStringUserLabel.Size = new System.Drawing.Size(29, 13);
			this.trawlConnectionStringUserLabel.TabIndex = 0;
			this.trawlConnectionStringUserLabel.Text = "User";
			// 
			// grabTab
			// 
			this.grabTab.Controls.Add(this.groupBox1);
			this.grabTab.Controls.Add(this.crawlSiteGroupBox);
			this.grabTab.Location = new System.Drawing.Point(4, 22);
			this.grabTab.Name = "grabTab";
			this.grabTab.Padding = new System.Windows.Forms.Padding(3);
			this.grabTab.Size = new System.Drawing.Size(609, 307);
			this.grabTab.TabIndex = 1;
			this.grabTab.Text = "Grab";
			this.grabTab.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.grabDataDocumentsLabel);
			this.groupBox1.Controls.Add(this.grabDataDocumentsTextBox);
			this.groupBox1.Controls.Add(this.grabDataCategoryTextBox);
			this.groupBox1.Controls.Add(this.grabDataCategoryLabel);
			this.groupBox1.Controls.Add(this.grabDataAttributesTextBox);
			this.groupBox1.Controls.Add(this.grabDataAttributesLabel);
			this.groupBox1.Controls.Add(this.grabDataPictureTextBox);
			this.groupBox1.Controls.Add(this.grabDataPictureLabel);
			this.groupBox1.Controls.Add(this.grabDataFullDescriptionTextBox);
			this.groupBox1.Controls.Add(this.grabDataFullDescriptionLabel);
			this.groupBox1.Controls.Add(this.grabDataNameTextBox);
			this.groupBox1.Controls.Add(this.grabDataNameLabel);
			this.groupBox1.Controls.Add(this.grabDataButton);
			this.groupBox1.Location = new System.Drawing.Point(6, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(597, 149);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data";
			// 
			// grabDataDocumentsLabel
			// 
			this.grabDataDocumentsLabel.AutoSize = true;
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
			// 
			// grabDataCategoryTextBox
			// 
			this.grabDataCategoryTextBox.Location = new System.Drawing.Point(154, 113);
			this.grabDataCategoryTextBox.Name = "grabDataCategoryTextBox";
			this.grabDataCategoryTextBox.Size = new System.Drawing.Size(142, 20);
			this.grabDataCategoryTextBox.TabIndex = 19;
			// 
			// grabDataCategoryLabel
			// 
			this.grabDataCategoryLabel.AutoSize = true;
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
			// 
			// grabDataAttributesLabel
			// 
			this.grabDataAttributesLabel.AutoSize = true;
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
			// 
			// grabDataPictureLabel
			// 
			this.grabDataPictureLabel.AutoSize = true;
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
			// 
			// grabDataFullDescriptionLabel
			// 
			this.grabDataFullDescriptionLabel.AutoSize = true;
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
			this.grabDataButton.Click += new System.EventHandler(this.Grab_Commence);
			// 
			// crawlSiteGroupBox
			// 
			this.crawlSiteGroupBox.Controls.Add(this.radioButton2);
			this.crawlSiteGroupBox.Controls.Add(this.radioButton1);
			this.crawlSiteGroupBox.Controls.Add(this.textBox2);
			this.crawlSiteGroupBox.Controls.Add(this.label2);
			this.crawlSiteGroupBox.Controls.Add(this.textBox1);
			this.crawlSiteGroupBox.Controls.Add(this.label1);
			this.crawlSiteGroupBox.Controls.Add(this.crawlSiteTextBox);
			this.crawlSiteGroupBox.Controls.Add(this.crawlSiteHostnameLabel);
			this.crawlSiteGroupBox.Location = new System.Drawing.Point(6, 6);
			this.crawlSiteGroupBox.Name = "crawlSiteGroupBox";
			this.crawlSiteGroupBox.Size = new System.Drawing.Size(597, 140);
			this.crawlSiteGroupBox.TabIndex = 0;
			this.crawlSiteGroupBox.TabStop = false;
			this.crawlSiteGroupBox.Text = "Site";
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
			// crawlSiteTextBox
			// 
			this.crawlSiteTextBox.Location = new System.Drawing.Point(6, 48);
			this.crawlSiteTextBox.Name = "crawlSiteTextBox";
			this.crawlSiteTextBox.Size = new System.Drawing.Size(191, 20);
			this.crawlSiteTextBox.TabIndex = 3;
			this.crawlSiteTextBox.Text = "http://";
			// 
			// crawlSiteHostnameLabel
			// 
			this.crawlSiteHostnameLabel.AutoSize = true;
			this.crawlSiteHostnameLabel.Location = new System.Drawing.Point(9, 32);
			this.crawlSiteHostnameLabel.Name = "crawlSiteHostnameLabel";
			this.crawlSiteHostnameLabel.Size = new System.Drawing.Size(55, 13);
			this.crawlSiteHostnameLabel.TabIndex = 2;
			this.crawlSiteHostnameLabel.Text = "Hostname";
			// 
			// trawlConsoleGroupBox
			// 
			this.trawlConsoleGroupBox.Controls.Add(this.trawlConsoleClearButton);
			this.trawlConsoleGroupBox.Controls.Add(this.trawlConsoleTextBox);
			this.trawlConsoleGroupBox.Location = new System.Drawing.Point(16, 351);
			this.trawlConsoleGroupBox.Name = "trawlConsoleGroupBox";
			this.trawlConsoleGroupBox.Size = new System.Drawing.Size(597, 329);
			this.trawlConsoleGroupBox.TabIndex = 15;
			this.trawlConsoleGroupBox.TabStop = false;
			this.trawlConsoleGroupBox.Text = "Console";
			// 
			// trawlConsoleClearButton
			// 
			this.trawlConsoleClearButton.Location = new System.Drawing.Point(406, 304);
			this.trawlConsoleClearButton.Name = "trawlConsoleClearButton";
			this.trawlConsoleClearButton.Size = new System.Drawing.Size(185, 19);
			this.trawlConsoleClearButton.TabIndex = 14;
			this.trawlConsoleClearButton.Text = "Clear";
			this.trawlConsoleClearButton.UseVisualStyleBackColor = true;
			this.trawlConsoleClearButton.Click += new System.EventHandler(this.Trawl_Clear_Click);
			// 
			// trawlConsoleTextBox
			// 
			this.trawlConsoleTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.trawlConsoleTextBox.Location = new System.Drawing.Point(6, 19);
			this.trawlConsoleTextBox.Name = "trawlConsoleTextBox";
			this.trawlConsoleTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.trawlConsoleTextBox.Size = new System.Drawing.Size(585, 279);
			this.trawlConsoleTextBox.TabIndex = 9;
			this.trawlConsoleTextBox.Text = "";
			// 
			// referenceComparisonListView
			// 
			this.referenceComparisonListView.Location = new System.Drawing.Point(6, 19);
			this.referenceComparisonListView.Name = "referenceComparisonListView";
			this.referenceComparisonListView.Size = new System.Drawing.Size(394, 135);
			this.referenceComparisonListView.TabIndex = 15;
			this.referenceComparisonListView.UseCompatibleStateImageBehavior = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 720);
			this.Controls.Add(this.trawlConsoleGroupBox);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.progressBar);
			this.Name = "MainForm";
			this.Text = "Fonz - Powered by Storefront TM";
			this.tabControl.ResumeLayout(false);
			this.referenceTab.ResumeLayout(false);
			this.referenceTab.PerformLayout();
			this.trawlComparisonDataGroupBox.ResumeLayout(false);
			this.trawlComparisonDataGroupBox.PerformLayout();
			this.trawlConnectionStringGroupBox.ResumeLayout(false);
			this.trawlConnectionStringGroupBox.PerformLayout();
			this.grabTab.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.crawlSiteGroupBox.ResumeLayout(false);
			this.crawlSiteGroupBox.PerformLayout();
			this.trawlConsoleGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage referenceTab;
		private System.Windows.Forms.Label trawlConnectionStringUserLabel;
		private System.Windows.Forms.TabPage grabTab;
		private System.Windows.Forms.TextBox trawlConnectionStringPortTextBox;
		private System.Windows.Forms.Label trawlConnectionStringPortLabel;
		private System.Windows.Forms.TextBox trawlConnectionStringAddressTextBox;
		private System.Windows.Forms.Label trawlConnectionStringAddressLabel;
		private System.Windows.Forms.TextBox trawlConnectionStringPasswordTextBox;
		private System.Windows.Forms.Label trawlConnectionStringPasswordLabel;
		private System.Windows.Forms.Button trawlConnectionStringVerifyButton;
		private System.Windows.Forms.TextBox trawlConnectionStringUserTextBox;
		private System.Windows.Forms.GroupBox trawlConnectionStringGroupBox;
		private System.Windows.Forms.GroupBox trawlComparisonDataGroupBox;
		private System.Windows.Forms.Button trawlReferenceSheetGenerateButton;
		private System.Windows.Forms.CheckBox trawlComparisonDataCategoriesCheckBox;
		private System.Windows.Forms.CheckBox trawlComparisonDataProductsCheckBox;
		private System.Windows.Forms.TextBox trawlConnectionStringDatabaseTextBox;
		private System.Windows.Forms.Label trawlConnectionStringDatabaseLabel;
		private System.Windows.Forms.GroupBox crawlSiteGroupBox;
		private System.Windows.Forms.TextBox crawlSiteTextBox;
		private System.Windows.Forms.Label crawlSiteHostnameLabel;
		private System.Windows.Forms.GroupBox trawlConsoleGroupBox;
		private System.Windows.Forms.Button trawlConsoleClearButton;
		private System.Windows.Forms.RichTextBox trawlConsoleTextBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button grabDataButton;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button trawlReferenceLoadButton;
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
		private System.Windows.Forms.ListView referenceComparisonListView;
	}
}

