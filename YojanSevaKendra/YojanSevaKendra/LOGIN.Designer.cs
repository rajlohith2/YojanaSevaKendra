namespace YojanSevaKendra
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.LOGINbutton = new System.Windows.Forms.Button();
            this.uidtextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LOGINbutton
            // 
            this.LOGINbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LOGINbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LOGINbutton.Location = new System.Drawing.Point(811, 441);
            this.LOGINbutton.Name = "LOGINbutton";
            this.LOGINbutton.Size = new System.Drawing.Size(121, 35);
            this.LOGINbutton.TabIndex = 2;
            this.LOGINbutton.Text = "LOGIN";
            this.LOGINbutton.UseVisualStyleBackColor = false;
            this.LOGINbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // uidtextbox
            // 
            this.uidtextbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.uidtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uidtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uidtextbox.Location = new System.Drawing.Point(763, 315);
            this.uidtextbox.Name = "uidtextbox";
            this.uidtextbox.Size = new System.Drawing.Size(212, 23);
            this.uidtextbox.TabIndex = 3;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.passwordtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordtextbox.Location = new System.Drawing.Point(763, 391);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(212, 23);
            this.passwordtextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(757, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "UID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(757, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(773, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 67);
            this.button1.TabIndex = 7;
            this.button1.Text = "NEW REGISTRATION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1107, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.uidtextbox);
            this.Controls.Add(this.LOGINbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LOGIN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LOGINbutton;
        private System.Windows.Forms.TextBox uidtextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}