using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbKochka.View
{
    public partial class UserControlClubCards : UserControl
    {
        public UserControlClubCards()
        {
            InitializeComponent();
        }
        private string _nameCard;

        public string NameCard
        {
            get { return _nameCard; }
            set { _nameCard = value; labelClubNumber.Text += value; }
        }
        private string _grafik;

        public string Grafik
        {
            get { return _grafik; }
            set { _grafik = value; label4.Text += value; }
        }
        private string _year;

        public string Year
        {
            get { return _year; }
            set { _year = value; label1.Text += value; }
        }
        private string _halfYear;

        public string HalfYear
        {
            get { return _halfYear; }
            set { _halfYear = value; label2.Text += value; }
        }
        private string _month;

        public string Month
        {
            get { return _month; }
            set { _month = value; label3.Text += value; }
        }
        private string _;

        public string MyProperty
        {
            get { return _; }
            set { _ = value; label5.Text += value; }
        }





    }
}
