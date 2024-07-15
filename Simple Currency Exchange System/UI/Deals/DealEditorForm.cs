using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simple_Currency_Exchange_System.Entities;
using Simple_Currency_Exchange_System.Utils;

namespace Simple_Currency_Exchange_System.UI.Deals
{
    public partial class DealEditorForm : Form
    {
        private readonly Deal _deal = null;

        public DealEditorForm(Deal deal)
        {
            _deal = deal;
            InitializeComponent();

            using (new SessionScope()) 
            {
                currencyLookUpEdit.Properties.DataSource = DAO<Currency>.ListAll();
            }

            DisplayData();
        }

        private void DisplayData()
        {
            if (_deal == null)
                return;

            txtCustomer.Text = _deal.Customer;
            cboAction.SelectedIndex = (int)_deal.Action;
            txtAmount.Value = _deal.Amount;
            currencyLookUpEdit.EditValue = _deal.Currency == null ? null : (object)_deal.Currency.Id;
            txtRate.Value = _deal.Rate;
            txtNett.Text = _deal.Nett.ToString();
        }

        private void UpdateData()
        {
            _deal.Customer = txtCustomer.Text;
            _deal.Action = (Action)cboAction.SelectedIndex;
            _deal.Amount = txtAmount.Value;
            _deal.Currency = currencyLookUpEdit.EditValue == null ? null : DAO<Currency>.Get(currencyLookUpEdit.EditValue);
            _deal.Rate = txtRate.Value; 
            _deal.Nett = _deal.Amount * _deal.Rate;
            _deal.Date = DateTime.Today.Date;

            if (_deal.Currency != null)
            {
                if (_deal.Action == Action.Buy)
                {
                    _deal.Currency.BuyRate = txtRate.Value;
                }
                else if (_deal.Action == Action.Sell)
                {
                    _deal.Currency.SellRate = txtRate.Value;
                }
                DAO<Currency>.Save(_deal.Currency); 
            }
        }

        private decimal GetRate(Currency currency, Action action)
        {
            if (currency == null)
                return 0m;

            return action == Action.Buy ? currency.BuyRate : currency.SellRate;
        }

        private void UpdateNett()
        {
            decimal amount = txtAmount.Value;
            decimal rate = txtRate.Value;
            txtNett.Text = (amount * rate).ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateData();
                DAO<Deal>.Save(_deal);
                MessageBox.Show("Deal Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the deal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currencyLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            UpdateRate();
        }

        private void cboAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRate();
        }

        private void txtAmount_ValueChanged(object sender, EventArgs e)
        {
            UpdateNett();
        }

        private void txtRate_ValueChanged(object sender, EventArgs e)
        {
            UpdateNett();
        }

        private void UpdateRate()
        {
            var selectedCurrency = currencyLookUpEdit.EditValue == null ? null : DAO<Currency>.Get(currencyLookUpEdit.EditValue);
            var selectedAction = (Action)cboAction.SelectedIndex;
            txtRate.Value = GetRate(selectedCurrency, selectedAction);
            UpdateNett(); 
        }

        
    }
}
