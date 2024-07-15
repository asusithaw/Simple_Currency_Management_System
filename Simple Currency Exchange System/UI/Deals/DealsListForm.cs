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
using Simple_Currency_Exchange_System.UI.Deals;

namespace Simple_Currency_Exchange_System
{    
    public partial class DealsListForm : Form
    {
        public DealsListForm()
        {
            InitializeComponent();
        }

        private void dealGridControl_Load(object sender, EventArgs e)
        {
            LoadDeals();
        }

        private void LoadDeals()
        {
            try
            {
                using (var scope = new SessionScope())
                {
                    var deals = DAO<Deal>.ListAll();
                    dealBindingSource.DataSource = deals;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading currencies: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Deal deal = new Deal
            {
                Customer = "<NEW>"
            };
            using (DealEditorForm dealEditorForm = new DealEditorForm(deal))
            {
                if (dealEditorForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDeals();
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDeal = dealBindingSource.Current as Deal;
                {
                    using (DealEditorForm dealEditorForm = new DealEditorForm(selectedDeal))
                    {
                        if (dealEditorForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadDeals();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a currency to edit." + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDeal = dealBindingSource.Current as Deal;
                if (selectedDeal == null)
                {
                    MessageBox.Show("Please select a deal to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Do you really want to delete this deal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                DAO<Deal>.Delete(selectedDeal);
                LoadDeals();
                MessageBox.Show("Deal deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the deal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
