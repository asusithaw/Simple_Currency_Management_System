using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simple_Currency_Exchange_System.Utils;
using Simple_Currency_Exchange_System.Entities;

namespace Simple_Currency_Exchange_System.UI.Currencies
{
    public partial class CurrencyEditorForm : Form
    {
        private readonly Currency _currency = null;

        public CurrencyEditorForm(Currency currency)
        {
            _currency = currency;
            InitializeComponent();

            using (var scope = new SessionScope())
            {
                countryLookUpEdit.Properties.DataSource = DAO<Country>.ListAll();
            }

            DisplayData();
        }

        private void DisplayData()
        {
            if (_currency == null)
                return;

            txtCode.Text = _currency.Code;
            txtName.Text = _currency.Name;
            countryLookUpEdit.EditValue = _currency.Country == null ? null : (object)_currency.Country.Id;
            txtMiddleRate.Value = _currency.MiddleRate;
            txtBuyRate.Value = _currency.BuyRate;
            txtSellRate.Value = _currency.SellRate;
            chkIsActive.Checked = _currency.IsActive;
        }

        private void UpdateData()
        {
            _currency.Code = txtCode.Text;
            _currency.Name = txtName.Text;
            _currency.Country = countryLookUpEdit.EditValue == null ? null : DAO<Country>.Get(countryLookUpEdit.EditValue);
            _currency.BuyRate = txtBuyRate.Value;
            _currency.SellRate = txtSellRate.Value;
            _currency.MiddleRate = txtMiddleRate.Value;
            _currency.IsActive = chkIsActive.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateData();
                DAO<Currency>.Save(_currency);
                MessageBox.Show("Currency Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the currency: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
