namespace YojanSevaKendra
{
	partial class PANpage
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
            System.Windows.Forms.Label pANLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label taxPaidLabel;
            System.Windows.Forms.Label annual_IncomeLabel;
            System.Windows.Forms.Label occupationLabel;
            System.Windows.Forms.Label uIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PANpage));
            this.govtdbsDataSet = new YojanSevaKendra.govtdbsDataSet();
            this.pANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pANTableAdapter = new YojanSevaKendra.govtdbsDataSetTableAdapters.PANTableAdapter();
            this.tableAdapterManager = new YojanSevaKendra.govtdbsDataSetTableAdapters.TableAdapterManager();
            this.pANTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.taxPaidTextBox = new System.Windows.Forms.TextBox();
            this.annual_IncomeTextBox = new System.Windows.Forms.TextBox();
            this.uIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.occupationComboBox = new System.Windows.Forms.ComboBox();
            this.DObtextBox = new System.Windows.Forms.TextBox();
            pANLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            taxPaidLabel = new System.Windows.Forms.Label();
            annual_IncomeLabel = new System.Windows.Forms.Label();
            occupationLabel = new System.Windows.Forms.Label();
            uIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.govtdbsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pANLabel
            // 
            pANLabel.AutoSize = true;
            pANLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            pANLabel.Location = new System.Drawing.Point(394, 297);
            pANLabel.Name = "pANLabel";
            pANLabel.Size = new System.Drawing.Size(48, 20);
            pANLabel.TabIndex = 1;
            pANLabel.Text = "PAN:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nameLabel.Location = new System.Drawing.Point(394, 325);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(58, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dOBLabel.Location = new System.Drawing.Point(394, 354);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(52, 20);
            dOBLabel.TabIndex = 5;
            dOBLabel.Text = "DOB:";
            // 
            // taxPaidLabel
            // 
            taxPaidLabel.AutoSize = true;
            taxPaidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            taxPaidLabel.Location = new System.Drawing.Point(394, 381);
            taxPaidLabel.Name = "taxPaidLabel";
            taxPaidLabel.Size = new System.Drawing.Size(79, 20);
            taxPaidLabel.TabIndex = 7;
            taxPaidLabel.Text = "Tax Paid:";
            // 
            // annual_IncomeLabel
            // 
            annual_IncomeLabel.AutoSize = true;
            annual_IncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            annual_IncomeLabel.Location = new System.Drawing.Point(394, 409);
            annual_IncomeLabel.Name = "annual_IncomeLabel";
            annual_IncomeLabel.Size = new System.Drawing.Size(124, 20);
            annual_IncomeLabel.TabIndex = 9;
            annual_IncomeLabel.Text = "Annual Income:";
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            occupationLabel.Location = new System.Drawing.Point(394, 437);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new System.Drawing.Size(99, 20);
            occupationLabel.TabIndex = 11;
            occupationLabel.Text = "Occupation:";
            // 
            // uIDLabel
            // 
            uIDLabel.AutoSize = true;
            uIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            uIDLabel.Location = new System.Drawing.Point(394, 465);
            uIDLabel.Name = "uIDLabel";
            uIDLabel.Size = new System.Drawing.Size(43, 20);
            uIDLabel.TabIndex = 13;
            uIDLabel.Text = "UID:";
            // 
            // govtdbsDataSet
            // 
            this.govtdbsDataSet.DataSetName = "govtdbsDataSet";
            this.govtdbsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pANBindingSource
            // 
            this.pANBindingSource.DataMember = "PAN";
            this.pANBindingSource.DataSource = this.govtdbsDataSet;
            // 
            // pANTableAdapter
            // 
            this.pANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AADHAARTableAdapter = null;
            this.tableAdapterManager.APPLIED_SERVICESTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANK_ACCTableAdapter = null;
            this.tableAdapterManager.ELIGIBLE_FORTableAdapter = null;
            this.tableAdapterManager.PANTableAdapter = this.pANTableAdapter;
            this.tableAdapterManager.SERVICESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YojanSevaKendra.govtdbsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pANTextBox
            // 
            this.pANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pANBindingSource, "PAN", true));
            this.pANTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pANTextBox.Location = new System.Drawing.Point(530, 294);
            this.pANTextBox.Name = "pANTextBox";
            this.pANTextBox.Size = new System.Drawing.Size(227, 26);
            this.pANTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pANBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(530, 322);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(227, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // taxPaidTextBox
            // 
            this.taxPaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pANBindingSource, "TaxPaid", true));
            this.taxPaidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.taxPaidTextBox.Location = new System.Drawing.Point(530, 378);
            this.taxPaidTextBox.Name = "taxPaidTextBox";
            this.taxPaidTextBox.Size = new System.Drawing.Size(227, 26);
            this.taxPaidTextBox.TabIndex = 8;
            // 
            // annual_IncomeTextBox
            // 
            this.annual_IncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pANBindingSource, "Annual_Income", true));
            this.annual_IncomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.annual_IncomeTextBox.Location = new System.Drawing.Point(530, 406);
            this.annual_IncomeTextBox.Name = "annual_IncomeTextBox";
            this.annual_IncomeTextBox.Size = new System.Drawing.Size(227, 26);
            this.annual_IncomeTextBox.TabIndex = 10;
            // 
            // uIDTextBox
            // 
            this.uIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pANBindingSource, "UID", true));
            this.uIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uIDTextBox.Location = new System.Drawing.Point(530, 462);
            this.uIDTextBox.Name = "uIDTextBox";
            this.uIDTextBox.Size = new System.Drawing.Size(227, 26);
            this.uIDTextBox.TabIndex = 14;
            this.uIDTextBox.TextChanged += new System.EventHandler(this.uIDTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save and Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(378, 234);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(475, 54);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "ENTER YOUR PAN DETAILS";
            // 
            // occupationComboBox
            // 
            this.occupationComboBox.FormattingEnabled = true;
            this.occupationComboBox.Items.AddRange(new object[] {
            "Student",
            "Business",
            "Housewife",
            "Entrepreneur",
            "Agriculture",
            "Employed",
            "Unemployed",
            "Retired"});
            this.occupationComboBox.Location = new System.Drawing.Point(530, 433);
            this.occupationComboBox.Name = "occupationComboBox";
            this.occupationComboBox.Size = new System.Drawing.Size(227, 24);
            this.occupationComboBox.TabIndex = 23;
            this.occupationComboBox.SelectedIndexChanged += new System.EventHandler(this.occupationComboBox_SelectedIndexChanged);
            // 
            // DObtextBox
            // 
            this.DObtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DObtextBox.Location = new System.Drawing.Point(530, 350);
            this.DObtextBox.Name = "DObtextBox";
            this.DObtextBox.Size = new System.Drawing.Size(227, 26);
            this.DObtextBox.TabIndex = 24;
            this.DObtextBox.TextChanged += new System.EventHandler(this.DObtextBox_TextChanged);
            // 
            // PANpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1107, 695);
            this.Controls.Add(this.DObtextBox);
            this.Controls.Add(this.occupationComboBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(pANLabel);
            this.Controls.Add(this.pANTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(taxPaidLabel);
            this.Controls.Add(this.taxPaidTextBox);
            this.Controls.Add(annual_IncomeLabel);
            this.Controls.Add(this.annual_IncomeTextBox);
            this.Controls.Add(occupationLabel);
            this.Controls.Add(uIDLabel);
            this.Controls.Add(this.uIDTextBox);
            this.Name = "PANpage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.govtdbsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private govtdbsDataSet govtdbsDataSet;
		private System.Windows.Forms.BindingSource pANBindingSource;
		private govtdbsDataSetTableAdapters.PANTableAdapter pANTableAdapter;
		private govtdbsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox pANTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox taxPaidTextBox;
		private System.Windows.Forms.TextBox annual_IncomeTextBox;
		private System.Windows.Forms.TextBox uIDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox occupationComboBox;
        private System.Windows.Forms.TextBox DObtextBox;
    }
}