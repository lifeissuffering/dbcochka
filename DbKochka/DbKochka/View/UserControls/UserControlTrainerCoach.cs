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
    public partial class UserControlTrainerCoach : UserControl
    {
        public UserControlTrainerCoach()
        {
            InitializeComponent();
        }
        private string _contractId;

        public string ContractId
        {
            get { return _contractId; }
            set { _contractId = value; labelContractId.Text += value; }
        }
        private string _service;

        public string Service
        {
            get { return _service; }
            set { _service = value; labelTrainerName.Text = value; }
        }

        private string _CoachName;

        public string CoachName
        {
            get { return _CoachName; }
            set { _CoachName = value; labelTrainerName.Text += value; }
        }
        private string _ClientName;

        public string ClientName
        {
            get { return _ClientName; }
            set { _ClientName = value; labelClientName.Text += value; }
        }
        private string _quanity;

        public string Quanity
        {
            get { return _quanity; }
            set { _quanity = value; labelQuanity.Text += value; }
        }
        private string _stilhave;

        public string StillHave
        {
            get { return _stilhave; }
            set { _stilhave = value; labelStillHave.Text += value; }
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
    }
}
