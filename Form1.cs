using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Betamartukk.Properties;

namespace Betamartukk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void shw( Form frm)
        { 
            frm.ShowDialog();
        }

        public void enable_menu()
        {
            tsBread.Enabled = true;
            tsListofProducts.Enabled = true;
            tsLogin.Text = "Logout";
            
            
            tsUser.Enabled = true;

        }

        private void disable_menu()
        {
            tsBread.Enabled = false;
            tsListofProducts.Enabled = false;
            tsLogin.Text = "Login";
           
            
            tsUser.Enabled = false;

        }
        private void Switch(object sender, EventArgs e)
        {
            disable_menu();
        }

        private void addproducts(object sender, EventArgs e)
        {
            shw(new frmProduct());
        }

        private void listProducts(object sender, EventArgs e)
        {
            shw(new frmListofProducts());
        }

        private void user(object sender, EventArgs e)
        {
            shw(new frmUser());
        }


        private void login(object sender, EventArgs e)
        {
            if(tsLogin.Text == "Login")
            {
                shw(new frmLogin(this));
            }
            else
            {
                disable_menu();
            }
           
        }
    }
}
