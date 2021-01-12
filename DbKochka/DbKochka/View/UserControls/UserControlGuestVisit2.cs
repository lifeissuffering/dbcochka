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
    public partial class UserControlGuestVisit2 : UserControl
    {
        public UserControlGuestVisit2()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("Applications.txt", true);
            writer.WriteLine((DateTime.Now).ToString() + ' ' + textBox3.Text + ' ' + textBox2.Text + ' ' + textBox1.Text + ' ');
            writer.Close();
            buttonSend.Text = "Отправлено!";
            buttonSend.Enabled = false;
            
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.ReadOnly = true;
                }
            }
            
        }
    }
}
