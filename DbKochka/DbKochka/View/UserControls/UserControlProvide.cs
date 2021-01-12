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
    public partial class UserControlProvide : UserControl
    {
        public UserControlProvide()
        {
            InitializeComponent();
        }
        private string _provide;

        public string Provide
        {
            get { return _provide; }
            set { _provide = value; labelProvide.Text += value; }
        }
        private string _clubNumber;

        public string ClubNumber
        {
            get { return _clubNumber; }
            set { _clubNumber = value; labelClubNumber.Text += value; }
        }
        private Image _providePic;

        public Image ProvidePic
        {
            get { return  _providePic; }
            set {  _providePic = value; pictureBox1.Image = value; }
        }

    }
}
