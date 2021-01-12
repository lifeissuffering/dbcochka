using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbKochka
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
      
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View.Form2());
        }
        public class User
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public int Group { get; set; }
        }
        public static User CurrentUser = new User();
    }
}
