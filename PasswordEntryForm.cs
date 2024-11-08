using System;
using System.Windows.Forms;


namespace WinFormsPasswordApplication
{
    public partial class PasswordEntryForm : Form
    {
        public PasswordEntryForm()
        {
            InitializeComponent();
        }

        // Event handler for the Generate Password button
        private void BtnGeneratePassword_Click(object sender, EventArgs e)
        {
            // Example: Generate a password based on criteria (simplified for illustration)
            string password = PasswordEntry.GeneratePassword(12, true, true);
            txtGeneratedPassword.Text = password; // Display generated password
        }

        // Event handler for saving the password entry
        private void BtnSavePassword_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text;
            string password = txtGeneratedPassword.Text;
            string description = txtDescription.Text;

            if (string.IsNullOrWhiteSpace(accountName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Account name and password cannot be empty.");
                return;
            }

            // Create a new PasswordEntry and add it manager
            PasswordEntry newEntry = new PasswordEntry(accountName, password, description);
            MessageBox.Show("Password entry saved successfully.");
        }
    }
}