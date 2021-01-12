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
    public partial class UserControlApp : UserControl
    {
        public UserControlApp()
        {
            InitializeComponent();
        }
        private string _nameClient;

        public string NameClient
        {
            get { return _nameClient; }
            set { _nameClient = value; labelName.Text += value; }
        }
        private string _Date;

        public string Date
        {
            get { return _Date; }
            set { _Date = value; labelDate.Text += value; }
        }
        private string _Number;

        public string Number
        {
            get { return _Number; }
            set { _Number = value; labelNumber.Text += value; }
        }
    }
}
