using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CateringApp
{
    public partial class Authorization : Form
    {
        СateringDataSetTableAdapters.AutentTableAdapter AuthAdapter = new СateringDataSetTableAdapters.AutentTableAdapter();
        СateringDataSet.AutentDataTable result;

        public Authorization()
        {
            InitializeComponent();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            String login = textBox_login.Text;
            String pass = textBox_password.Text;
            int good = 0;

            
            result = AuthAdapter.GetData();

            foreach (СateringDataSet.AutentRow AutentRow in result)
            {
                if (AutentRow.Login == login && AutentRow.Pass == pass)
                {
                    if (AutentRow.Position == "Admin")
                    {
                        MainMenuForm f1 = new MainMenuForm();
                        f1.ShowDialog();
                    }
                    else if (AutentRow.Position == "Кассир")
                    {
                        PricerMenuForm f2 = new PricerMenuForm();
                        f2.ShowDialog();
                    }
                    else if (AutentRow.Position == "Повар")
                    {
                        CookerMenuForm f3 = new CookerMenuForm();
                        f3.ShowDialog();
                    }
                    good = 1;
                }
            }
            if (good==0) MessageBox.Show("Неверный логин или пароль.");
        }

        
    }
}
