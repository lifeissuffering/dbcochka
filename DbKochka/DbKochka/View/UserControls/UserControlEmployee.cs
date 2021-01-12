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
    public partial class UserControlEmployee : UserControl
    {
        public UserControlEmployee()
        {
            InitializeComponent();
        }
        private string _FIO;

        public string FIO
        {
            get { return _FIO; }
            set { _FIO = value; labelFIO.Text += value; }
        }
        private string _exp;

        public string Exp
        {
            get { return _exp; }
            set { _exp = value; labelExp.Text += value; }
        }
        private string _numClub;

        public string NumbClub
        {
            get { return _numClub; }
            set { _numClub = value; labelClubNumber.Text += value; }
        }
        private string _tab;

        public string Tabel
        {
            get { return _tab; }
            set { _tab = value; labelTabel.Text = value; }
        }
        private string _pos;

        public string Pos
        {
            get { return _pos; }
            set { _pos = value; labelPosition.Text += value; }
        }
        private bool _visibleButtons;
                
        public bool VisibleButtons
        {
            get { return _visibleButtons; }
            set { _visibleButtons = value; buttonDelete.Enabled = value;
                buttonDelete.Visible = value; buttonEdit.Enabled = value; buttonEdit.Visible = value; }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Text == "Изменить")
            {
                foreach (Control c in Controls)
                {
                    if (c is TextBox t)
                    {
                        t.Visible = true;
                        t.ReadOnly = false;
                    }
                }
                buttonEdit.Text = "Сохранить";
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is TextBox t)
                    {
                        t.Visible = false;
                        t.ReadOnly = true;
                        
                    }
                }
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") 
                {
                    return;
                }
                labelFIO.Text = textBox1.Text;
                labelClubNumber.Text = textBox2.Text;
                labelExp.Text = textBox3.Text;
                labelPosition.Text = textBox4.Text;
                using (KochkaDBEntities1 ct = new KochkaDBEntities1())
                {
                    Employee empl = ct.Employees.FirstOrDefault(x => x.ServiceNumber.ToString() == labelTabel.Text);
                    if (empl != null)
                    {
                        empl.EmplyeeSecondName = labelFIO.Text.Split(' ')[0];
                        empl.EmplyeeName = labelFIO.Text.Split(' ')[1];
                        if (labelFIO.Text.Split(' ').Length > 2)
                        {
                            empl.EmplyeeMiddleName = labelFIO.Text.Split(' ')[2];
                        }
                        empl.Name = labelPosition.Text;
                        ct.SaveChanges();
                    }
                }
                buttonEdit.Text = "Изменить";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (KochkaDBEntities1 ct = new KochkaDBEntities1())
            {
                var item = ct.Employees.FirstOrDefault(x => x.ServiceNumber.ToString() == labelTabel.Text);
                ct.Employees.Remove(item);
                ct.SaveChanges();
                buttonDelete.Text = "Удалено!";
                buttonDelete.Enabled = false;
            }
        }
    }
}
