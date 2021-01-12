using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbKochka.View.UserControls
{
    public partial class UserControlAdd : UserControl
    {
        public UserControlAdd()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (KochkaDBEntities1 ct = new KochkaDBEntities1())
            {
                Employee em = new Employee()
                {
                    
                    EmplyeeSecondName = textBox1.Text.Split(' ')[0],
                    EmplyeeName = textBox1.Text.Split(' ')[1],
                    EmplyeeMiddleName = (textBox1.Text.Split(' ').Length > 2) ? textBox1.Text.Split(' ')[2] : null,
                    Experience = Convert.ToInt32(textBox3.Text),
                    NumberOfClub = Convert.ToInt32(textBox2.Text),
                    Name = textBox4.Text
                   
                };
                em.ServiceNumber = ct.Employees.Where(x => x.NumberOfClub == em.NumberOfClub).Count();
                var item = ct.Clubs.FirstOrDefault(x => x.NumberOfClub ==em.NumberOfClub);//типа триггер
                if (item == null) { return; }
                var item2 = ct.Positions.FirstOrDefault(x => x.Name == em.Name);
                if (item2 == null) { return; }
                
                ct.Employees.Add(em);
                ct.SaveChanges();
            }
            buttonAdd.Text = "Добавлено!";
            foreach(Control c in Controls)
            {
                if (c is TextBox t)
                {
                    t.Text = "";
                }
            }
            buttonAdd.Enabled = false;
        }
    }
}
