namespace WinFormsPasswordApplication
{
    partial class PasswordEntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtGeneratedPassword = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(12, 90);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(160, 23);
            this.btnGeneratePassword.TabIndex = 0;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.BtnGeneratePassword_Click);
            // 
            // txtGeneratedPassword
            // 
            this.txtGeneratedPassword.Location = new System.Drawing.Point(12, 119);
            this.txtGeneratedPassword.Name = "txtGeneratedPassword";
            this.txtGeneratedPassword.Size = new System.Drawing.Size(200, 20);
            this.txtGeneratedPassword.TabIndex = 1;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(12, 12);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(200, 20);
            this.txtAccountName.TabIndex = 2;
            this.txtAccountName.PlaceholderText = "Account Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 47);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.PlaceholderText = "Description";
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Location = new System.Drawing.Point(12, 150);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(200, 23);
            this.btnSavePassword.TabIndex = 4;
            this.btnSavePassword.Text = "Save Password Entry";
            this.btnSavePassword.UseVisualStyleBackColor = true;
            this.btnSavePassword.Click += new System.EventHandler(this.BtnSavePassword_Click);
            // 
            // PasswordEntryForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtGeneratedPassword);
            this.Controls.Add(this.btnGeneratePassword);
            this.Name = "PasswordEntryForm";
            this.Text = "Password Entry";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TextBox txtGeneratedPassword;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSavePassword;
    }
}