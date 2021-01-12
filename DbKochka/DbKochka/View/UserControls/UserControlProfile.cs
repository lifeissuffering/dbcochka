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
    public partial class UserControlProfile : UserControl
    {
        FlowLayoutPanel panel;
        Form2 f2;
        public UserControlProfile(Form2 form, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            f2 = form;
            panel = flowLayoutPanel;
        }
        private string _buttonText;

        public string ButtonText
        {
            get { return _buttonText; }
            set { _buttonText = value; button.Text = value; }
        }

        private void button_Click(object sender, EventArgs e)
        {
            using (KochkaDBEntities1 ct = new KochkaDBEntities1()) {
                if (Program.CurrentUser.Group == 1)
                {
                    if (ButtonText == "Мой абонемент")
                    {
                        SeasonTicket t = ct.SeasonTickets
                            .ToList()
                            .FirstOrDefault(x => x.CardNumber == Program.CurrentUser.Login);
                        Employee em = ct.Employees
                            .ToList()
                            .FirstOrDefault(x => x.ServiceNumber == t.ServiceNumber);
                        UserControlSeasonTicket item = new UserControlSeasonTicket()
                        {
                            ClubNumber = t.NumberOfClub.ToString(),
                            DateEnd = t.DateOfEnd.ToString(),
                            DateBegin = t.DateOfRegistration.ToString(),
                            StillHave = t.VisitsStillHave.ToString(),
                            Employee = em.Name,
                            ContactId = t.ContractId.ToString(),
                            NameCard = t.CardName,
                            ClubCard = t.CardNumber
                        };
                        f2.ClearLayoutPanel();
                        panel.Controls.Add(item);
                    }


                    if (ButtonText == "Мой тренер") 
                    {
                        CoachContract contract = ct.CoachContracts
                            .ToList()
                            .FirstOrDefault(x => x.CardNumber == Program.CurrentUser.Login);
                        Employee employee = ct.Employees
                            .ToList()
                            .FirstOrDefault(x => x.ServiceNumber == contract.ServiceNumber);
                        UserControlTrainerCoach item = new UserControlTrainerCoach()
                        {
                            ContractId = contract.CoachContractId.ToString(),
                            CoachName = employee.EmplyeeSecondName + ' ' + employee.Name + ' ' + employee.EmplyeeMiddleName,
                            Quanity = contract.QuantityTraining.ToString(),
                            StillHave = contract.StillHaveTraining.ToString(),
                            DateBegin = contract.DateOfConclusion.ToString(),
                            DateEnd = contract.ExpiryDate.ToString(),
                            ClientName = ct.Visitors.ToList().FirstOrDefault(x => x.CardNumber == contract.CardNumber).VisitorSecondName
                        };
                        f2.ClearLayoutPanel();
                        panel.Controls.Add(item);
                    }

                    if (ButtonText == "Посещения") 
                    {
                        f2.ClearLayoutPanel();
                        bool Empty = true;
                        foreach (Visit visit in ct.Visits.ToList()) 
                        {
                            if (visit.CardNumber == Program.CurrentUser.Login)
                            {
                                
                                UserControlVisits item = new UserControlVisits()
                                {
                                    Date = visit.DateOfVisit.ToString(),
                                    NumberOfClub = visit.NumberOfClub.ToString(),
                                    CardName = visit.CardName.ToString(),
                                    ContarctId = visit.ContractId.ToString(),
                                    CName = ct.Visitors
                                    .ToList()
                                    .FirstOrDefault(x => x.CardNumber == Program.CurrentUser.Login).VisitorSecondName
                                };
                                Empty = false;
                                panel.Controls.Add(item);
                            }
                        }
                        if (Empty)
                        {
                            panel.Controls
                                .Add
                                (
                                    new UserControlGuestVisit()
                                    { 
                                        TextMessage = "Посещений нет", 
                                        ClearSecondLabel = "" 
                                    }
                                );
                        }   
                    }
            }
                else if (Program.CurrentUser.Group == 2)
                {
                    if (ButtonText == "Мои контракты") 
                    {
                        f2.ClearLayoutPanel();
                        bool Empty = true;
                        Employee employee = ct.Employees
                            .ToList()
                            .FirstOrDefault(x => x.ServiceNumber.ToString() == Program.CurrentUser.Login);
                        foreach (CoachContract contract in ct.CoachContracts.ToList())
                        {
                            if (contract.ServiceNumber.ToString() == Program.CurrentUser.Login)
                            {
                                UserControlTrainerCoach item = new UserControlTrainerCoach()
                                {
                                    ContractId = contract.CoachContractId.ToString(),
                                    CoachName = employee.EmplyeeSecondName + ' ' + employee.Name + ' ' + employee.EmplyeeMiddleName,
                                    Quanity = contract.QuantityTraining.ToString(),
                                    StillHave = contract.StillHaveTraining.ToString(),
                                    DateBegin = contract.DateOfConclusion.ToString(),
                                    DateEnd = contract.ExpiryDate.ToString(),
                                    ClientName = ct.Visitors.ToList().FirstOrDefault(x => x.CardNumber == contract.CardNumber).VisitorSecondName
                                };
                                Empty = false;
                                panel.Controls.Add(item);
                            }
                        }
                        if (Empty)
                        {
                            panel.Controls
                                .Add
                                (
                                    new UserControlGuestVisit()
                                    {
                                        TextMessage = "Контрактов нет",
                                        ClearSecondLabel = ""
                                    }
                                );
                        }
                    }
            }
                else if (Program.CurrentUser.Group == 3)
                {

                    if (ButtonText == "Абонементы") 
                    {
                        f2.ClearLayoutPanel();
                        UserControlSeasonTicket it = new UserControlSeasonTicket();
                        
                        var tick = from seasonTicket in ct.SeasonTickets
                                   join employee in ct.Employees on seasonTicket.ServiceNumber equals employee.ServiceNumber
                                   join visitor in ct.Visitors on seasonTicket.CardNumber equals visitor.CardNumber
                                   select new
                                   {
                                       NumberOfClub = seasonTicket.NumberOfClub,
                                       NameCard = seasonTicket.CardName,
                                       CardNumber = seasonTicket.CardNumber,
                                       DateBegin = seasonTicket.DateOfRegistration,
                                       DateEnd = seasonTicket.DateOfEnd,
                                       StillHave = seasonTicket.VisitsStillHave,
                                       ContractId = seasonTicket.ContractId,
                                       EmployeeName = employee.EmplyeeSecondName ,
                                       ClientName = visitor.VisitorSecondName 
                                   };
                        foreach(var i in tick.ToList())
                        {
                            UserControlSeasonTicket item = new UserControlSeasonTicket()
                            {
                                ClubNumber = i.NumberOfClub.ToString(),
                                NameCard = i.NameCard,
                                ClubCard = i.CardNumber,
                                DateBegin = i.DateBegin.ToString(),
                                DateEnd = i.DateEnd.ToString(),
                                ContactId = i.ContractId.ToString(),
                                StillHave = i.StillHave.ToString(),
                                Employee = i.EmployeeName,
                                Client = i.ClientName
                            };
                            panel.Controls.Add(item);
                        }
                    }


                    if (ButtonText == "Клиенты") 
                    {
                        f2.ClearLayoutPanel();
                        foreach (Visitor v in ct.Visitors)
                        {
                            UserControlVisitor item = new UserControlVisitor()
                            {
                                Client = v.VisitorSecondName + ' ' + v.VisitorName,
                                Birth = v.VisitorBDate.ToString(),
                                ClubCard = v.CardNumber,
                                Passport = v.VisitorPassport
                            };
                            panel.Controls.Add(item);
                        }
                    }
                    if (ButtonText == "Контракты") 
                    {

                        f2.ClearLayoutPanel();
                        bool Empty = true;
                        foreach (CoachContract contract in ct.CoachContracts.ToList())
                        {
                            UserControlTrainerCoach item = new UserControlTrainerCoach()
                            {
                                ContractId = contract.CoachContractId.ToString(),
                                CoachName = "Табельный номер тренера: " + contract.ServiceNumber.ToString(),
                                Quanity = contract.QuantityTraining.ToString(),
                                StillHave = contract.StillHaveTraining.ToString(),
                                DateBegin = contract.DateOfConclusion.ToString(),
                                DateEnd = contract.ExpiryDate.ToString(),
                                ClientName = ct.Visitors.ToList().FirstOrDefault(x => x.CardNumber == contract.CardNumber).VisitorSecondName
                            };
                            Empty = false;
                            panel.Controls.Add(item);
                        }
                        if (Empty)
                        {
                            panel.Controls
                                .Add
                                (
                                    new UserControlGuestVisit()
                                    {
                                        TextMessage = "Контрактов нет",
                                        ClearSecondLabel = ""
                                    }
                                );
                        }
                    }


                    if (ButtonText == "Посещения")
                    {
                        f2.ClearLayoutPanel();
                        bool Empty = true;
                        foreach (Visit visit in ct.Visits.ToList())
                        {
                            try
                            {
                                UserControlVisits item = new UserControlVisits()
                                {
                                    Date = visit.DateOfVisit.ToString(),
                                    NumberOfClub = visit.NumberOfClub.ToString(),
                                    CardName = visit.CardName.ToString(),
                                    ContarctId = visit.ContractId.ToString(),
                                    CName = ct.Visitors
                                    .ToList()
                                    .FirstOrDefault(x => x.CardNumber == visit.CardNumber).VisitorSecondName
                                };
                                Empty = false;
                                panel.Controls.Add(item);
                            }
                            catch(Exception ex)
                            {
                                throw new NullReferenceException(ex.Message);
                            }
                        }
                        if (Empty)
                        {
                            panel.Controls
                                .Add
                                (
                                    new UserControlGuestVisit()
                                    {
                                        TextMessage = "Посещений нет",
                                        ClearSecondLabel = ""
                                    }
                                );
                        }
                    }


                    if (ButtonText == "Заявки на гостевой визит") 
                    {
                        string line;
                        f2.ClearLayoutPanel();
                        System.IO.StreamReader file =
                new System.IO.StreamReader("Applications.txt");
                        while ((line = file.ReadLine()) != null)
                        {
                            UserControlApp app = new UserControlApp()
                            {
                                Date = line.Split(' ')[0] + ' ' + line.Split(' ')[1],
                                Number = line.Split(' ')[2],
                                NameClient = line.Split(' ')[3] + ' ' + line.Split(' ')[4]
                            };
                            panel.Controls.Add(app);
                        }
                        file.Close();
                    }
    

            } }
        }
    }
}
