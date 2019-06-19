namespace YojanSevaKendra
{
	partial class Bankpage
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
            System.Windows.Forms.Label accNoLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label iFSCLabel;
            System.Windows.Forms.Label accTypeLabel;
            System.Windows.Forms.Label uIDLabel;
            System.Windows.Forms.Label pANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bankpage));
            this.govtdbsDataSet = new YojanSevaKendra.govtdbsDataSet();
            this.bANK_ACCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANK_ACCTableAdapter = new YojanSevaKendra.govtdbsDataSetTableAdapters.BANK_ACCTableAdapter();
            this.tableAdapterManager = new YojanSevaKendra.govtdbsDataSetTableAdapters.TableAdapterManager();
            this.accNoTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.iFSCTextBox = new System.Windows.Forms.TextBox();
            this.uIDTextBox = new System.Windows.Forms.TextBox();
            this.pANTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.accTypecomboBox = new System.Windows.Forms.ComboBox();
            this.process1 = new System.Diagnostics.Process();
            accNoLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            iFSCLabel = new System.Windows.Forms.Label();
            accTypeLabel = new System.Windows.Forms.Label();
            uIDLabel = new System.Windows.Forms.Label();
            pANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.govtdbsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANK_ACCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accNoLabel
            // 
            accNoLabel.AutoSize = true;
            accNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            accNoLabel.Location = new System.Drawing.Point(648, 365);
            accNoLabel.Name = "accNoLabel";
            accNoLabel.Size = new System.Drawing.Size(69, 20);
            accNoLabel.TabIndex = 1;
            accNoLabel.Text = "Acc No:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nameLabel.Location = new System.Drawing.Point(648, 393);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(58, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // iFSCLabel
            // 
            iFSCLabel.AutoSize = true;
            iFSCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iFSCLabel.Location = new System.Drawing.Point(648, 421);
            iFSCLabel.Name = "iFSCLabel";
            iFSCLabel.Size = new System.Drawing.Size(51, 20);
            iFSCLabel.TabIndex = 5;
            iFSCLabel.Text = "IFSC:";
            // 
            // accTypeLabel
            // 
            accTypeLabel.AutoSize = true;
            accTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            accTypeLabel.Location = new System.Drawing.Point(648, 448);
            accTypeLabel.Name = "accTypeLabel";
            accTypeLabel.Size = new System.Drawing.Size(84, 20);
            accTypeLabel.TabIndex = 7;
            accTypeLabel.Text = "Acc Type:";
            accTypeLabel.Click += new System.EventHandler(this.accTypeLabel_Click);
            // 
            // uIDLabel
            // 
            uIDLabel.AutoSize = true;
            uIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            uIDLabel.Location = new System.Drawing.Point(648, 477);
            uIDLabel.Name = "uIDLabel";
            uIDLabel.Size = new System.Drawing.Size(43, 20);
            uIDLabel.TabIndex = 9;
            uIDLabel.Text = "UID:";
            // 
            // pANLabel
            // 
            pANLabel.AutoSize = true;
            pANLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            pANLabel.Location = new System.Drawing.Point(648, 505);
            pANLabel.Name = "pANLabel";
            pANLabel.Size = new System.Drawing.Size(48, 20);
            pANLabel.TabIndex = 11;
            pANLabel.Text = "PAN:";
            // 
            // govtdbsDataSet
            // 
            this.govtdbsDataSet.DataSetName = "govtdbsDataSet";
            this.govtdbsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bANK_ACCBindingSource
            // 
            this.bANK_ACCBindingSource.DataMember = "BANK_ACC";
            this.bANK_ACCBindingSource.DataSource = this.govtdbsDataSet;
            // 
            // bANK_ACCTableAdapter
            // 
            this.bANK_ACCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AADHAARTableAdapter = null;
            this.tableAdapterManager.APPLIED_SERVICESTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANK_ACCTableAdapter = this.bANK_ACCTableAdapter;
            this.tableAdapterManager.ELIGIBLE_FORTableAdapter = null;
            this.tableAdapterManager.PANTableAdapter = null;
            this.tableAdapterManager.SERVICESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YojanSevaKendra.govtdbsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accNoTextBox
            // 
            this.accNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANK_ACCBindingSource, "AccNo", true));
            this.accNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.accNoTextBox.Location = new System.Drawing.Point(759, 359);
            this.accNoTextBox.Name = "accNoTextBox";
            this.accNoTextBox.Size = new System.Drawing.Size(203, 26);
            this.accNoTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANK_ACCBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(759, 387);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(203, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // iFSCTextBox
            // 
            this.iFSCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANK_ACCBindingSource, "IFSC", true));
            this.iFSCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iFSCTextBox.Location = new System.Drawing.Point(759, 415);
            this.iFSCTextBox.Name = "iFSCTextBox";
            this.iFSCTextBox.Size = new System.Drawing.Size(203, 26);
            this.iFSCTextBox.TabIndex = 6;
            // 
            // uIDTextBox
            // 
            this.uIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANK_ACCBindingSource, "UID", true));
            this.uIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uIDTextBox.Location = new System.Drawing.Point(759, 471);
            this.uIDTextBox.Name = "uIDTextBox";
            this.uIDTextBox.Size = new System.Drawing.Size(203, 26);
            this.uIDTextBox.TabIndex = 10;
            this.uIDTextBox.TextChanged += new System.EventHandler(this.uIDTextBox_TextChanged);
            // 
            // pANTextBox
            // 
            this.pANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANK_ACCBindingSource, "PAN", true));
            this.pANTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pANTextBox.Location = new System.Drawing.Point(759, 499);
            this.pANTextBox.Name = "pANTextBox";
            this.pANTextBox.Size = new System.Drawing.Size(203, 26);
            this.pANTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save and Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(625, 298);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(410, 43);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "ENTER YOUR BANK DETAILS";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // accTypecomboBox
            // 
            this.accTypecomboBox.FormattingEnabled = true;
            this.accTypecomboBox.Items.AddRange(new object[] {
            "Savings",
            "Recurring Deposit"});
            this.accTypecomboBox.Location = new System.Drawing.Point(759, 444);
            this.accTypecomboBox.Name = "accTypecomboBox";
            this.accTypecomboBox.Size = new System.Drawing.Size(203, 24);
            this.accTypecomboBox.TabIndex = 22;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Bankpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1107, 695);
            this.Controls.Add(this.accTypecomboBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(accNoLabel);
            this.Controls.Add(this.accNoTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(iFSCLabel);
            this.Controls.Add(this.iFSCTextBox);
            this.Controls.Add(accTypeLabel);
            this.Controls.Add(uIDLabel);
            this.Controls.Add(this.uIDTextBox);
            this.Controls.Add(pANLabel);
            this.Controls.Add(this.pANTextBox);
            this.Name = "Bankpage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.govtdbsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANK_ACCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private govtdbsDataSet govtdbsDataSet;
		private System.Windows.Forms.BindingSource bANK_ACCBindingSource;
		private govtdbsDataSetTableAdapters.BANK_ACCTableAdapter bANK_ACCTableAdapter;
		private govtdbsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox accNoTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox iFSCTextBox;
		private System.Windows.Forms.TextBox uIDTextBox;
		private System.Windows.Forms.TextBox pANTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox accTypecomboBox;
        private System.Diagnostics.Process process1;
    }
}