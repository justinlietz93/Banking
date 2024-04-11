using JKL.Banking.BL.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace JKL.Banking.UI
{
    public enum ScreenMode
    {
        Add = 0,
        Edit
    }

    public partial class frmDeposit : Form
    {
        private ScreenMode screenMode;

        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private int depositId;

        public int DepositId
        {
            get { return depositId; }
            set { depositId = value; }
        }


        public frmDeposit(ScreenMode screenMode)
        {
            InitializeComponent();
            this.screenMode = screenMode;
            this.Text = screenMode.ToString() + " Deposit";
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            if (screenMode == ScreenMode.Edit)
            {
                txtDepositAmount.Text = customer.Deposits[depositId].DepositAmount.ToString();
                dtpDepositDate.Value = customer.Deposits[depositId].DepositDate;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (screenMode == ScreenMode.Add)
                {
                    Deposit deposit = new Deposit();

                    // Ternary operation
                    deposit.DepositId = customer.Deposits.Any() ? customer.Deposits.Max(a => a.DepositId) + 1 : 1;
                    deposit.DepositAmount = double.Parse(txtDepositAmount.Text);
                    deposit.DepositDate = dtpDepositDate.Value.Date;

                    customer.Deposits.Add(deposit);
                }
                else if (screenMode == ScreenMode.Edit)
                {
                    customer.Deposits[DepositId].DepositAmount = double.Parse(txtDepositAmount.Text);
                    customer.Deposits[DepositId].DepositDate = DateTime.Parse(dtpDepositDate.Text);
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
