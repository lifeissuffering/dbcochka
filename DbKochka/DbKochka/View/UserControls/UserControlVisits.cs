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
    public partial class UserControlVisits : UserControl
    {
        public UserControlVisits()
        {
            InitializeComponent();
        }

        private void UserControlVisits_Load(object sender, EventArgs e)
        {

        }
        private string _date;

        public string Date
        {
            get { return _date; }
            set { _date = value; labelDate.Text += value; }
        }
        private string _numberOfClub;

        public string NumberOfClub
        {
            get { return _numberOfClub; }
            set { _numberOfClub = value; labelNumberOfCLub.Text += value; }
        }
        private string _cardName;

        public string CardName
        {
            get { return _cardName; }
            set { _cardName = value; labelCardName.Text += value; }
        }
        private string _contractId;

        public string ContarctId
        {
            get { return _contractId; }
            set { _contractId = value; labelContractId.Text += value; }
        }
        private string _cName;

        public string CName
        {
            get { return _cName; }
            set { _cName = value; labelClientName.Text += value; }
        }




    }
}
