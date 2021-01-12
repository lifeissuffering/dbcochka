using DbKochka.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbKochka.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SignIn_Click(object sender, EventArgs e)
        {
            Program.CurrentUser.Login = textboxLogin.Text;
            Program.CurrentUser.Password = textBoxPassword.Text;
            string[] users = File.ReadAllLines("users.txt", Encoding.UTF8);
            foreach (string user in users)
            {
                if (user.Split(' ')[0] == Program.CurrentUser.Login && user.Split(' ')[1] == Program.CurrentUser.Password)
                {
                    Program.CurrentUser.Group = Convert.ToInt32(user.Split(' ')[2]);
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    Hide();
                }
            }
        }
    }
}
