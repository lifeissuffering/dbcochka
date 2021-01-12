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
    public partial class UserControlSeasonTicket : UserControl
    {
        public UserControlSeasonTicket()
        {
            InitializeComponent();
        }
        private string _clubNumber;

        public string ClubNumber
        {
            get { return _clubNumber; }
            set { _clubNumber = value; labelClubNumber.Text += value; }
        }
        private string _name;

        public string NameCard
        {
            get { return _name; }
            set { _name = value; labelName.Text += value; }
        }
        private string _clubCard;

        public string ClubCard
        {
            get { return _clubCard; }
            set { _clubCard = value; labelClubCard.Text += value; }
        }
        private string _dateBegin;

        public string DateBegin
        {
            get { return _dateBegin; }
            set { _dateBegin = value; labelDateBegin.Text += value; }
        }
        private string _DateEnd;

        public string DateEnd
        {
            get { return _DateEnd; }
            set { _DateEnd = value; labelDateEnd.Text += value; }
        }
        private string _stillhave;

        public string StillHave
        {
            get { return _stillhave; }
            set { _stillhave = value; labelStillHave.Text += value; }
        }
        private string _contractId;

        public string ContactId
        {
            get { return _contractId; }
            set { _contractId = value; labelContractId.Text += value; }
        }
        private string _employee;

        public string Employee
        {
            get { return _employee; }
            set { _employee = value; labelEmployee.Text += value; }
        }
        private string _client;

        public string Client
        {
            get { return _client; }
            set { _client = value; labelClientName.Text += value; }
        }
       
    }
}
