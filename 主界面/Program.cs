using System;
using System.Windows.Forms;
using 主界面.窗体;

namespace 主界面
{
    internal static class Program
    {
        /// <summary>
        ///     应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PreferenceSetForm());
        }
    }
}