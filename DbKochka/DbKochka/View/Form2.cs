using DbKochka.Properties;
using DbKochka.View.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DbKochka.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void buttonGuestVisit_Click(object sender, EventArgs e)
        {
            using (KochkaDBEntities1 context = new KochkaDBEntities1())
            {
                ClearLayoutPanel();
                UserControlGuestVisit item = new UserControlGuestVisit();
                UserControlGuestVisit2 item2 = new UserControlGuestVisit2();
                flowLayoutPanelMain.Height = 550;
                flowLayoutPanelMain.Controls.Add(item); 
                flowLayoutPanelMain.Controls.Add(item2);
            }
        }
        public void ClearProfilePanel()
        {
           
        }
        public void ClearLayoutPanel()
        {
            /*foreach (Control ctrl in flowLayoutPanelMain.Controls)
            {
                if (ctrl != panelLogo) 
                    flowLayoutPanelMain.Controls.Remove(ctrl);
            }*/
            for (int i=0; i< flowLayoutPanelMain.Controls.Count; i++)
            {
                if (flowLayoutPanelMain.Controls[i] != panelLogo)
                {
                    flowLayoutPanelMain.Controls.RemoveAt(i);
                    i--;
                }
            }
            Controls.Remove(panelGuestVisit);
        }
        public void Profile()
        {
            ClearLayoutPanel();
            if (Program.CurrentUser.Group == 0)
            {
                UserControlSignIn item = new UserControlSignIn(this);
                flowLayoutPanelMain.Controls.Add(item);
            }
            else if (Program.CurrentUser.Group == 1) {
                

                UserControlProfile item1 = new UserControlProfile(this, flowLayoutPanelMain)
                {
                    ButtonText = "Мой абонемент"
                };
                UserControlProfile item2 = new UserControlProfile(this, flowLayoutPanelMain)
                {
                    ButtonText = "Мой тренер"
                };
                UserControlProfile item3 = new UserControlProfile(this, flowLayoutPanelMain)
                {
                    ButtonText = "Посещения"
                };
                UserControlProfile[] items = new UserControlProfile[3] {item1, item2, item3};
                flowLayoutPanelMain.Controls.AddRange(items);
            }
            else if (Program.CurrentUser.Group == 2)
            {
                UserControlProfile item2 = new UserControlProfile(this, flowLayoutPanelMain)
                {
                    ButtonText = "Мои контракты"
                };
               
                flowLayoutPanelMain.Controls.Add(item2);
            }
            else if (Program.CurrentUser.Group == 3)
            {
                UserControlProfile item1 = new UserControlProfile(this, flowLayoutPanelMain)
                {
                    ButtonText = "Абонементы"
                };
                UserControlProfile item2 = new UserControlProfile(this, flowLayoutPanelMain)
                {
                    ButtonText = "Клиенты"
                };
                UserControlProfile item3 = new UserControlProfile(this, flowLayoutPanelMain)
                {
                    ButtonText = "Контракты"
                };
                UserControlProfile item4 = new UserControlProfile(this, flowLayoutPanelMain)
                {
                    ButtonText = "Посещения"
                };
                UserControlProfile item5 = new UserControlProfile(this, flowLayoutPanelMain)
                {
                    ButtonText = "Заявки на гостевой визит"
                };
                UserControlProfile[] items = new UserControlProfile[5] { item1, item2, item3, item4, item5 };
                flowLayoutPanelMain.Controls.AddRange(items);
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Profile();
        }
        public Image _Resize(Image original)
        {
            return new Bitmap(original, new Size(150, 150));
        }
        private void buttonProvide_Click(object sender, EventArgs e)
        {
            ClearLayoutPanel();
            using (KochkaDBEntities1 ct = new KochkaDBEntities1())
            {
                foreach (Provide p in ct.Provides)
                {
                    UserControlProvide item = new UserControlProvide()
                    {
                        ClubNumber = p.NumberOfClub.ToString(),
                        Provide = p.NameService

                    };
                    if (p.NameService == "Gym") {
                        item.ProvidePic = _Resize(Resources.Gym);

                    }
                    else if(p.NameService == "Sauna")
                    {
                        item.ProvidePic = _Resize(Resources.Sauna);
                    }
                    else
                    {
                        item.ProvidePic = _Resize(Resources.Swimming_Pool);
                    }
                    flowLayoutPanelMain.Controls.Add(item);
                }
            }
        }

        private void buttonClubCard_Click(object sender, EventArgs e)
        {
            ClearLayoutPanel();
            using (KochkaDBEntities1 ct = new KochkaDBEntities1())
            {
                foreach (ClubCard c in ct.ClubCards)
                {
                    UserClubCards cc = new UserClubCards()
                    {
                        Grafik = c.ChartOfVisits,
                        Cost = c.CoastMonth + "/" + c.CoastHalfYear + "/" + c.CoastYear,
                        Quantity = c.QuantityOfVisitsPerMonth.ToString(),
                        NameClubCard = c.CardName
                    };
                    flowLayoutPanelMain.Controls.Add(cc);
                }
            }
        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {
            ClearLayoutPanel();
            flowLayoutPanelMain.Controls.Add(new UserControlContacts());
        }

        private void buttonTeam_Click(object sender, EventArgs e)
        {
            ClearLayoutPanel();
            using (KochkaDBEntities1 ct = new KochkaDBEntities1())
            {
                UserControlAdd add = new UserControlAdd();
                flowLayoutPanelMain.Controls.Add(add);
                foreach (Employee empl in ct.Employees)
                {
                    UserControlEmployee item = new UserControlEmployee()
                    {
                        FIO = empl.EmplyeeSecondName + " " + empl.EmplyeeName + " " + empl.EmplyeeMiddleName,
                        Exp = empl.Experience.ToString(),
                        NumbClub = empl.NumberOfClub.ToString(),
                        Pos = empl.Name
                    };
                    if (Program.CurrentUser.Group == 3)
                    {
                        item.Tabel = empl.ServiceNumber.ToString();
                        item.VisibleButtons = true;
                    }
                    flowLayoutPanelMain.Controls.Add(item);
                }
            }
        }
    }
}
