
namespace Learning_Deutsch_Again
{
    partial class FormConnect
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxProfilName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8F);
            this.button1.Location = new System.Drawing.Point(284, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Se Connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8F);
            this.button2.Location = new System.Drawing.Point(86, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "S\'inscrire";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxProfilName
            // 
            this.textBoxProfilName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxProfilName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxProfilName.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.textBoxProfilName.Location = new System.Drawing.Point(86, 61);
            this.textBoxProfilName.Name = "textBoxProfilName";
            this.textBoxProfilName.Size = new System.Drawing.Size(359, 32);
            this.textBoxProfilName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPassword.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.textBoxPassword.Location = new System.Drawing.Point(86, 111);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(359, 32);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 270);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxProfilName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormConnect";
            this.Text = "Connect";
            this.Load += new System.EventHandler(this.FormConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxProfilName;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}