using System;
using System.Windows.Forms;

namespace AppCuaChiTu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateSqliteDbExtension.Create();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AddForm());
        }
    }
}
