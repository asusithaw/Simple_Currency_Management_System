using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simple_Currency_Exchange_System.UI.Currencies;

namespace Simple_Currency_Exchange_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCurrencies_Click(object sender, EventArgs e)
        {
            new CurrencyListForm().Show();
        }

        private void btnDeals_Click(object sender, EventArgs e)
        {
            new DealsListForm().Show();
        }
    }
}
