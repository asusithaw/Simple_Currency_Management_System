using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Linq;
using Simple_Currency_Exchange_System.Entities;
using Simple_Currency_Exchange_System.Utils;

namespace Simple_Currency_Exchange_System.UI.Currencies
{
    public partial class CurrencyListForm : Form
    {
        public CurrencyListForm()
        {
            InitializeComponent();            
        }

        private void currencyGridControl_Load(object sender, EventArgs e)
        {
            LoadCurrencies();
        }

        private void LoadCurrencies()
        {
            try
            {
                using (var scope = new SessionScope())
                {
                    var currencies = DAO<Currency>.ListAll();
                    currencyBindingSource.DataSource = currencies;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading currencies: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Currency currency = new Currency
            {
                Code = "<NEW>",
                Name = "<NEW>"
            };
            using (CurrencyEditorForm currencyEditorForm = new CurrencyEditorForm(currency))
            {
                if (currencyEditorForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCurrencies();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCurrency = currencyBindingSource.Current as Currency;
            {
                using (CurrencyEditorForm currencyEditorForm = new CurrencyEditorForm(selectedCurrency))
                {
                    if (currencyEditorForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadCurrencies();
                    }
                }
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a currency to edit."+ ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCurrency = currencyBindingSource.Current as Currency;
                if (selectedCurrency == null)
                {
                    MessageBox.Show("Please select a currency to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Do you really want to delete this currency?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                DAO<Currency>.Delete(selectedCurrency);
                LoadCurrencies(); 
                MessageBox.Show("Currency deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the currency: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

