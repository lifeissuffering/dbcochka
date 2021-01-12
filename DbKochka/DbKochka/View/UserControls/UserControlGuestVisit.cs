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
    public partial class UserControlGuestVisit : UserControl
    {
        private string _textMessage;

        public string TextMessage
        {
            get { return _textMessage; }
            set { _textMessage = value; label1.Text = value; }
        }
        private string _clearsecondlabel;

        public string ClearSecondLabel
        {
            get { return _clearsecondlabel; }
            set { _clearsecondlabel = value; labelInfo.Text = ""; }
        }
        public UserControlGuestVisit()
        {
            InitializeComponent();
        }
    }
}
