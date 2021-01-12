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
    public partial class UserControlVisitor : UserControl
    {
        public UserControlVisitor()
        {
            InitializeComponent();
        }

        private void UserControlVisitor_Load(object sender, EventArgs e)
        {

        }
        private string _clubCard;

        public string ClubCard
        {
            get { return _clubCard; }
            set { _clubCard = value; labelClubCard.Text += value; }
        }
        private string _client;
        public string Client
        {
            get { return _client; }
            set { _client = value; labelClientName.Text += value; }
        }
        private string _birth;

        public string Birth
        {
            get { return _birth; }
            set { _birth = value; labelBirth.Text += value; }
        }
        private string _passport;

        public string Passport
        {
            get { return _passport; }
            set { _passport = value; labelPassport.Text += value; }
        }


    }
}
