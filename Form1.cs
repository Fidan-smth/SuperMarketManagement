using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if(SelectRole.SelectedIndex > -1)
            {
                if(SelectRole.SelectedItem.ToString() == "Admin")
                {
                    ProductForm prod = new ProductForm();
                    prod.Show();
                    this.Hide();
                }
                else
                {
                    SellingForm selling = new SellingForm();
                    selling.Show();
                    this.Hide();
                }
            }
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
