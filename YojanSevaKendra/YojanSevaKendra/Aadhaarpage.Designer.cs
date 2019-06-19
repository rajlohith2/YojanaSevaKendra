namespace YojanSevaKendra
{
	partial class Aadhaarpage
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
            System.Windows.Forms.Label uIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label genderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aadhaarpage));
            this.govtdbsDataSet = new YojanSevaKendra.govtdbsDataSet();
            this.aADHAARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aADHAARTableAdapter = new YojanSevaKendra.govtdbsDataSetTableAdapters.AADHAARTableAdapter();
            this.tableAdapterManager = new YojanSevaKendra.govtdbsDataSetTableAdapters.TableAdapterManager();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            uIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.govtdbsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADHAARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uIDLabel
            // 
            uIDLabel.AutoSize = true;
            uIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            uIDLabel.Location = new System.Drawing.Point(582, 278);
            uIDLabel.Name = "uIDLabel";
            uIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            uIDLabel.Size = new System.Drawing.Size(43, 20);
            uIDLabel.TabIndex = 1;
            uIDLabel.Text = "UID:";
            uIDLabel.Click += new System.EventHandler(this.uIDLabel_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nameLabel.Location = new System.Drawing.Point(582, 306);
            nameLabel.Name = "nameLabel";
            nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nameLabel.Size = new System.Drawing.Size(58, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            phoneLabel.Location = new System.Drawing.Point(582, 334);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            phoneLabel.Size = new System.Drawing.Size(61, 20);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Phone:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dOBLabel.Location = new System.Drawing.Point(582, 363);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dOBLabel.Size = new System.Drawing.Size(52, 20);
            dOBLabel.TabIndex = 7;
            dOBLabel.Text = "DOB:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            addressLabel.Location = new System.Drawing.Point(582, 390);
            addressLabel.Name = "addressLabel";
            addressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            addressLabel.Size = new System.Drawing.Size(76, 20);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Address:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            genderLabel.Location = new System.Drawing.Point(582, 418);
            genderLabel.Name = "genderLabel";
            genderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            genderLabel.Size = new System.Drawing.Size(69, 20);
            genderLabel.TabIndex = 11;
            genderLabel.Text = "Gender:";
            // 
            // govtdbsDataSet
            // 
            this.govtdbsDataSet.DataSetName = "govtdbsDataSet";
            this.govtdbsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aADHAARBindingSource
            // 
            this.aADHAARBindingSource.DataMember = "AADHAAR";
            this.aADHAARBindingSource.DataSource = this.govtdbsDataSet;
            this.aADHAARBindingSource.CurrentChanged += new System.EventHandler(this.aADHAARBindingSource_CurrentChanged);
            // 
            // aADHAARTableAdapter
            // 
            this.aADHAARTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AADHAARTableAdapter = this.aADHAARTableAdapter;
            this.tableAdapterManager.APPLIED_SERVICESTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANK_ACCTableAdapter = null;
            this.tableAdapterManager.ELIGIBLE_FORTableAdapter = null;
            this.tableAdapterManager.PANTableAdapter = null;
            this.tableAdapterManager.SERVICESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YojanSevaKendra.govtdbsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uidTextBox
            // 
            this.uidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aADHAARBindingSource, "UID", true));
            this.uidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uidTextBox.Location = new System.Drawing.Point(672, 272);
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uidTextBox.Size = new System.Drawing.Size(200, 26);
            this.uidTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aADHAARBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(672, 300);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aADHAARBindingSource, "Phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phoneTextBox.Location = new System.Drawing.Point(672, 328);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phoneTextBox.Size = new System.Drawing.Size(200, 26);
            this.phoneTextBox.TabIndex = 6;
            // 
            // dobBox
            // 
            this.dobBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aADHAARBindingSource, "DOB", true));
            this.dobBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dobBox.Location = new System.Drawing.Point(672, 357);
            this.dobBox.Name = "dobBox";
            this.dobBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dobBox.Size = new System.Drawing.Size(200, 26);
            this.dobBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aADHAARBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addressTextBox.Location = new System.Drawing.Point(672, 384);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addressTextBox.Size = new System.Drawing.Size(200, 26);
            this.addressTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save and Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(493, 205);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(535, 61);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "ENTER YOUR AADHAAR DETAILS";
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "others.."});
            this.genderBox.Location = new System.Drawing.Point(672, 416);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(200, 24);
            this.genderBox.TabIndex = 20;
            this.genderBox.SelectedIndexChanged += new System.EventHandler(this.genderBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(578, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordTextBox.Location = new System.Drawing.Point(672, 446);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(200, 26);
            this.passwordTextBox.TabIndex = 22;
            // 
            // Aadhaarpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1107, 695);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(uIDLabel);
            this.Controls.Add(this.uidTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.dobBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(genderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Aadhaarpage";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.govtdbsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aADHAARBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private govtdbsDataSet govtdbsDataSet;
		private System.Windows.Forms.BindingSource aADHAARBindingSource;
		private govtdbsDataSetTableAdapters.AADHAARTableAdapter aADHAARTableAdapter;
		private govtdbsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox uidTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.DateTimePicker dobBox;
		private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}