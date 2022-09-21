namespace Notes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //with args(user open file with the program)
            if (args != null && args.Length > 0)
            {
                string fileName = args[0];
                //Check file exists
                if (File.Exists(fileName))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Form1 MainForm = new Form1();
                    MainForm.OpenFileArgs(fileName);
                    Application.Run(MainForm);
                }

            }
            //without args
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}