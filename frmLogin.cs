using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betamartukk
{
    public partial class frmLogin : Form
    {
        Form1 frm;
        public frmLogin(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        string query;
        int maxrow;

        private void oklogin(object sender, EventArgs e)
        {
            query = "SELECT * FROM tblUser WHERE U_UNAME ='" + textBox_Username.Text + "' AND U_PASS = '" + textBox_Password.Text + "'";
            maxrow = config.maxrow(query);

            if(maxrow > 0)
            {
                MessageBox.Show("User successfully logged in");
                frm.enable_menu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account does not exist!","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
