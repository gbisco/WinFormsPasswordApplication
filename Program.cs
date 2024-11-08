namespace WinFormsPasswordApplication
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Launch the Form
            Application.Run(new PasswordEntryForm());
        }
    }
}