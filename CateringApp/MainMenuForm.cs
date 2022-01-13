using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CateringApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Authorization f0 = (Authorization)Application.OpenForms["Authorization"];
            this.Close();
        }

        private void buttonPricerWin_Click(object sender, EventArgs e)
        {
            PricerMenuForm f1 = (PricerMenuForm)Application.OpenForms["PricerMenuForm"];
            this.Close();
        }

        private void buttonCookerWin_Click(object sender, EventArgs e)
        {
            CookerMenuForm f2 = (CookerMenuForm)Application.OpenForms["CookerMenuForm"];
            this.Close();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm f3 = (AddProductForm)Application.OpenForms["AddProductForm"];
            this.Close();
        }
    }
}
