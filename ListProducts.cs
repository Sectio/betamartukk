﻿using System;
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
    public partial class frmListofProducts : Form
    {
        public frmListofProducts()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        string sql;
        int maxrow;
        private void newclick(object sender, EventArgs e)
        {
            Form frm = new frmProduct();
            frm.ShowDialog();
        }

        public void refresh()
        {
            sql = "SELECT PROCODE as [ProductCode], (PRONAME + ' ' + PRODESC) AS [Product],CATEGORY AS [Category], (PROPRICE) AS [Price],PROQTY AS [Quantity] FROM  tblProductInfo";
            config.Load_DTG(sql, DTGLIST);
        }

        private void refreshclick(object sender, EventArgs e)
        {
            sql = "SELECT PROCODE as [ProductCode], (PRONAME + ' ' + PRODESC) AS [Product],CATEGORY AS [Category], (PROPRICE) AS [Price],PROQTY AS [Quantity] FROM  tblProductInfo";
            config.Load_DTG(sql, DTGLIST);
        }

        private void delleteclick(object sender, EventArgs e)
        { 
            sql = "DELETE * FROM tblProductInfo WHERE PROCODE = '" + DTGLIST.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "Failed to delete", "Product has been deleted.");
        }

        private void editclick(object sender, EventArgs e)
        {
            Form frm = new frmEditProduct(DTGLIST.CurrentRow.Cells[0].Value.ToString(),this);
            frm.ShowDialog();
        }

        private void frmListProducts_Load(object sender, EventArgs e)
        {
            refreshclick(sender, e);
        }
    }
}
