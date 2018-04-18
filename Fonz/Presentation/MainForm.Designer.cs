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
			this.trawlPage = new System.Windows.Forms.TabPage();
			this.trawlComparisonDataGroupBox = new System.Windows.Forms.GroupBox();
			this.comparisonDataGridView = new System.Windows.Forms.DataGridView();
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
			this.crawlPage = new System.Windows.Forms.TabPage();
			this.crawlSiteGroupBox = new System.Windows.Forms.GroupBox();
			this.crawlSiteCommenceButton = new System.Windows.Forms.Button();
			this.crawlSiteTextBox = new System.Windows.Forms.TextBox();
			this.crawlSiteHostnameLabel = new System.Windows.Forms.Label();
			this.comparisonDataSet = new System.Data.DataSet();
			this.trawlConsoleGroupBox = new System.Windows.Forms.GroupBox();
			this.trawlConsoleClearButton = new System.Windows.Forms.Button();
			this.trawlConsoleTextBox = new System.Windows.Forms.RichTextBox();
			this.tabControl.SuspendLayout();
			this.trawlPage.SuspendLayout();
			this.trawlComparisonDataGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.comparisonDataGridView)).BeginInit();
			this.trawlConnectionStringGroupBox.SuspendLayout();
			this.crawlPage.SuspendLayout();
			this.crawlSiteGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.comparisonDataSet)).BeginInit();
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
			this.tabControl.Controls.Add(this.trawlPage);
			this.tabControl.Controls.Add(this.crawlPage);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(617, 333);
			this.tabControl.TabIndex = 2;
			// 
			// trawlPage
			// 
			this.trawlPage.Controls.Add(this.trawlComparisonDataGroupBox);
			this.trawlPage.Controls.Add(this.trawlConnectionStringPortTextBox);
			this.trawlPage.Controls.Add(this.trawlConnectionStringPortLabel);
			this.trawlPage.Controls.Add(this.trawlConnectionStringAddressTextBox);
			this.trawlPage.Controls.Add(this.trawlConnectionStringAddressLabel);
			this.trawlPage.Controls.Add(this.trawlConnectionStringPasswordTextBox);
			this.trawlPage.Controls.Add(this.trawlConnectionStringVerifyButton);
			this.trawlPage.Controls.Add(this.trawlConnectionStringUserTextBox);
			this.trawlPage.Controls.Add(this.trawlConnectionStringGroupBox);
			this.trawlPage.Location = new System.Drawing.Point(4, 22);
			this.trawlPage.Name = "trawlPage";
			this.trawlPage.Padding = new System.Windows.Forms.Padding(3);
			this.trawlPage.Size = new System.Drawing.Size(609, 307);
			this.trawlPage.TabIndex = 0;
			this.trawlPage.Text = "Trawl";
			this.trawlPage.UseVisualStyleBackColor = true;
			// 
			// trawlComparisonDataGroupBox
			// 
			this.trawlComparisonDataGroupBox.Controls.Add(this.comparisonDataGridView);
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
			// comparisonDataGridView
			// 
			this.comparisonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.comparisonDataGridView.Location = new System.Drawing.Point(6, 19);
			this.comparisonDataGridView.Name = "comparisonDataGridView";
			this.comparisonDataGridView.Size = new System.Drawing.Size(384, 122);
			this.comparisonDataGridView.TabIndex = 14;
			// 
			// trawlReferenceSheetGenerateButton
			// 
			this.trawlReferenceSheetGenerateButton.Location = new System.Drawing.Point(406, 122);
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
			// crawlPage
			// 
			this.crawlPage.Controls.Add(this.crawlSiteGroupBox);
			this.crawlPage.Location = new System.Drawing.Point(4, 22);
			this.crawlPage.Name = "crawlPage";
			this.crawlPage.Padding = new System.Windows.Forms.Padding(3);
			this.crawlPage.Size = new System.Drawing.Size(609, 307);
			this.crawlPage.TabIndex = 1;
			this.crawlPage.Text = "Crawl";
			this.crawlPage.UseVisualStyleBackColor = true;
			// 
			// crawlSiteGroupBox
			// 
			this.crawlSiteGroupBox.Controls.Add(this.crawlSiteCommenceButton);
			this.crawlSiteGroupBox.Controls.Add(this.crawlSiteTextBox);
			this.crawlSiteGroupBox.Controls.Add(this.crawlSiteHostnameLabel);
			this.crawlSiteGroupBox.Location = new System.Drawing.Point(6, 6);
			this.crawlSiteGroupBox.Name = "crawlSiteGroupBox";
			this.crawlSiteGroupBox.Size = new System.Drawing.Size(597, 82);
			this.crawlSiteGroupBox.TabIndex = 0;
			this.crawlSiteGroupBox.TabStop = false;
			this.crawlSiteGroupBox.Text = "Site";
			// 
			// crawlSiteCommenceButton
			// 
			this.crawlSiteCommenceButton.Location = new System.Drawing.Point(406, 48);
			this.crawlSiteCommenceButton.Name = "crawlSiteCommenceButton";
			this.crawlSiteCommenceButton.Size = new System.Drawing.Size(185, 20);
			this.crawlSiteCommenceButton.TabIndex = 4;
			this.crawlSiteCommenceButton.Text = "Commence";
			this.crawlSiteCommenceButton.UseVisualStyleBackColor = true;
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
			// comparisonDataSet
			// 
			this.comparisonDataSet.DataSetName = "ComparisonDataSet";
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
			this.trawlPage.ResumeLayout(false);
			this.trawlPage.PerformLayout();
			this.trawlComparisonDataGroupBox.ResumeLayout(false);
			this.trawlComparisonDataGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.comparisonDataGridView)).EndInit();
			this.trawlConnectionStringGroupBox.ResumeLayout(false);
			this.trawlConnectionStringGroupBox.PerformLayout();
			this.crawlPage.ResumeLayout(false);
			this.crawlSiteGroupBox.ResumeLayout(false);
			this.crawlSiteGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.comparisonDataSet)).EndInit();
			this.trawlConsoleGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage trawlPage;
		private System.Windows.Forms.Label trawlConnectionStringUserLabel;
		private System.Windows.Forms.TabPage crawlPage;
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
		private System.Windows.Forms.Button crawlSiteCommenceButton;
		private System.Windows.Forms.TextBox crawlSiteTextBox;
		private System.Windows.Forms.Label crawlSiteHostnameLabel;
		private System.Windows.Forms.DataGridView comparisonDataGridView;
		private System.Data.DataSet comparisonDataSet;
		private System.Windows.Forms.GroupBox trawlConsoleGroupBox;
		private System.Windows.Forms.Button trawlConsoleClearButton;
		private System.Windows.Forms.RichTextBox trawlConsoleTextBox;
	}
}

