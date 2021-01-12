using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DbKochka.View.UserControls
{
    public partial class UserControlSignIn : UserControl
    {
        public Form2 f2;
        public UserControlSignIn(Form2 form)
        {
            InitializeComponent();
            f2 = form;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {

            string line;
            bool flag = false;
            System.IO.StreamReader file =
                new System.IO.StreamReader("users.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Split(' ')[0] == textBox1.Text &&
                    line.Split(' ')[1].Substring(line.Split(' ')[1].Length - 4) == textBox2.Text)
                {
                    Program.CurrentUser = new Program.User()
                    {
                        Login = textBox1.Text,
                        Password = textBox2.Text,
                        Group = Convert.ToInt32(line.Split(' ')[2])
                    };
                    if (Parent.Parent.Controls.Find("buttonLogin", true)[0] is Button btn)
                    {
                        btn.Text = "Профиль";
                        f2.Profile();
                    }
                    flag = true;
                }
            }
            if (flag == false)
            {
                label1.Text = "Неверные логин или пароль!";
            }
           
            file.Close();


        }
        
    }
}
