namespace YojanSevaKendra
{
    partial class Appliedpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appliedpage));
            this.govtdbsDataSet = new YojanSevaKendra.govtdbsDataSet();
            this.aPPLIED_SERVICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPLIED_SERVICESTableAdapter = new YojanSevaKendra.govtdbsDataSetTableAdapters.APPLIED_SERVICESTableAdapter();
            this.tableAdapterManager = new YojanSevaKendra.govtdbsDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AppNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.govtdbsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.govtdbsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLIED_SERVICESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.govtdbsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // govtdbsDataSet
            // 
            this.govtdbsDataSet.DataSetName = "govtdbsDataSet";
            this.govtdbsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPLIED_SERVICESBindingSource
            // 
            this.aPPLIED_SERVICESBindingSource.DataMember = "APPLIED_SERVICES";
            this.aPPLIED_SERVICESBindingSource.DataSource = this.govtdbsDataSet;
            // 
            // aPPLIED_SERVICESTableAdapter
            // 
            this.aPPLIED_SERVICESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AADHAARTableAdapter = null;
            this.tableAdapterManager.APPLIED_SERVICESTableAdapter = this.aPPLIED_SERVICESTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANK_ACCTableAdapter = null;
            this.tableAdapterManager.ELIGIBLE_FORTableAdapter = null;
            this.tableAdapterManager.PANTableAdapter = null;
            this.tableAdapterManager.SERVICESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YojanSevaKendra.govtdbsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppNo,
            this.ServiceCode,
            this.Status});
            this.dataGridView1.DataSource = this.govtdbsDataSetBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(74, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AppNo
            // 
            this.AppNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AppNo.DataPropertyName = "AppNo";
            this.AppNo.HeaderText = "Application Number";
            this.AppNo.MinimumWidth = 50;
            this.AppNo.Name = "AppNo";
            this.AppNo.Width = 168;
            // 
            // ServiceCode
            // 
            this.ServiceCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ServiceCode.DataPropertyName = "ServiceCode";
            this.ServiceCode.HeaderText = "Service Code";
            this.ServiceCode.Name = "ServiceCode";
            this.ServiceCode.Width = 127;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status of your Application";
            this.Status.Name = "Status";
            this.Status.Width = 208;
            // 
            // govtdbsDataSetBindingSource
            // 
            this.govtdbsDataSetBindingSource.DataSource = this.govtdbsDataSet;
            this.govtdbsDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "UID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aadhaar ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(901, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Appliedpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1107, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Appliedpage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.govtdbsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPLIED_SERVICESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.govtdbsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private govtdbsDataSet govtdbsDataSet;
        private System.Windows.Forms.BindingSource aPPLIED_SERVICESBindingSource;
        private govtdbsDataSetTableAdapters.APPLIED_SERVICESTableAdapter aPPLIED_SERVICESTableAdapter;
        private govtdbsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource govtdbsDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}