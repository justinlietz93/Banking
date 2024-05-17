using JKL.Banking.BL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKL.Banking.UI
{

    public partial class frmWithdrawal : Form
    {
        private ScreenMode screenMode;

        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private int withdrawalId;

        public int WithdrawalId
        {
            get { return withdrawalId; }
            set { withdrawalId = value; }
        }

        // Changes title of form based on screen mode
        public frmWithdrawal(ScreenMode screenMode)
        {
            InitializeComponent();
            this.screenMode = screenMode;
            this.Text = screenMode.ToString() + " Withdrawal";
        }

        private void frmWithdrawal_Load(object sender, EventArgs e)
        {
            // Fills in input boxes with correct customer data
            if (screenMode == ScreenMode.Edit)
            {
                txtWithdrawalAmount.Text = customer.Withdrawals[withdrawalId].WithdrawalAmount.ToString();
                dtpWithdrawalDate.Value = customer.Withdrawals[withdrawalId].WithdrawalDate;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Adds data to withdrawal data grid view from input
                if (screenMode == ScreenMode.Add)
                {
                    if (double.TryParse(txtWithdrawalAmount.Text, out double withdrawalAmount))
                    {
                        Withdrawal withdrawal = new Withdrawal();

                        // Ternary operation
                        withdrawal.WithdrawalId = customer.Withdrawals.Any() ? customer.Withdrawals.Max(a => a.WithdrawalId) + 1 : 1;
                        withdrawal.WithdrawalAmount = withdrawalAmount;
                        withdrawal.WithdrawalDate = dtpWithdrawalDate.Value.Date;
                        withdrawal.CustID = customer.ID;

                        customer.Withdrawals.Add(withdrawal);
                    }
                    else
                    {
                        MessageBox.Show("Invalid withdrawal amount. Enter a valid number.");
                    }
                }
                // Modifies customer information for withdrawal data grid view
                else if (screenMode == ScreenMode.Edit)
                {
                    if (double.TryParse(txtWithdrawalAmount.Text, out double withdrawalAmount))
                    {
                        customer.Withdrawals[WithdrawalId].WithdrawalAmount = withdrawalAmount;
                        customer.Withdrawals[WithdrawalId].WithdrawalDate = DateTime.Parse(dtpWithdrawalDate.Text);
                    }
                    else
                    {
                        MessageBox.Show("Invalid withdrawal amount. Enter a valid number.");
                    }
                }

                this.Close();

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
