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
    public partial class UserClubCards : UserControl
    {
        public UserClubCards()
        {
            InitializeComponent();
        }
        private string _nameClubCard;

        public string NameClubCard
        {
            get { return _nameClubCard; }
            set { _nameClubCard = value; labelClubCard.Text += value; }
        }
        private string _grafik;

        public string Grafik
        {
            get { return _grafik; }
            set { _grafik = value; labelGrafik.Text += value; }
        }
        private string _quantity;

        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; labelQuantity.Text += value; }
        }

        private string _cost;

        public string Cost
        {
            get { return _cost; }
            set { _cost = value; labelCost.Text += value; }
        }




    }
    

}
