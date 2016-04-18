using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TESTER
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(){
            if (Directory.Exists(Environment.CurrentDirectory + "\\TEST") == false)
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\TEST");
            if (Directory.Exists(Environment.CurrentDirectory + "\\UserTest") == false)
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\UserTest");
            if (File.Exists(Environment.CurrentDirectory + "\\EI.txt") == false)
                File.Create(Environment.CurrentDirectory + "\\EI.txt");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegisterForm());
        }
    }
}
