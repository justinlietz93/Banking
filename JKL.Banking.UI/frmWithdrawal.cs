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

        public frmWithdrawal(ScreenMode screenMode)
        {
            InitializeComponent();
            this.screenMode = screenMode;
            this.Text = screenMode.ToString() + " Withdrawal";
        }

        private void frmWithdrawal_Load(object sender, EventArgs e)
        {
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
                if (screenMode == ScreenMode.Add)
                {
                    Withdrawal withdrawal = new Withdrawal();

                    // Ternary operation
                    withdrawal.WithdrawalId = customer.Withdrawals.Any() ? customer.Withdrawals.Max(a => a.WithdrawalId) + 1 : 1;
                    withdrawal.WithdrawalAmount = double.Parse(txtWithdrawalAmount.Text);
                    withdrawal.WithdrawalDate = dtpWithdrawalDate.Value.Date;

                    customer.Withdrawals.Add(withdrawal);
                }
                else if (screenMode == ScreenMode.Edit)
                {
                    customer.Withdrawals[WithdrawalId].WithdrawalAmount = double.Parse(txtWithdrawalAmount.Text);
                    customer.Withdrawals[WithdrawalId].WithdrawalDate = DateTime.Parse(dtpWithdrawalDate.Text);
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
