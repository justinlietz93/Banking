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
using JKL.Banking.BL;
using JKL.Utility.PL;

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

        // Changes title of form based on screen mode
        public frmDeposit(ScreenMode screenMode)
        {
            InitializeComponent();
            this.screenMode = screenMode;
            this.Text = screenMode.ToString() + " Deposit";
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            // Fills text input boxes with correct customer deposit data
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
                // Adds input deposit data to deposit data grid view
                if (screenMode == ScreenMode.Add)
                {
                    if (double.TryParse(txtDepositAmount.Text, out double depositAmount))
                    {
                        Deposit deposit = new Deposit();

                        // Ternary operation to increment id number
                        deposit.DepositId = Database.GetNextDepositId();
                        deposit.DepositAmount = depositAmount;
                        deposit.DepositDate = dtpDepositDate.Value.Date;
                        deposit.CustID = customer.ID;

                        //customer.Deposits.Add(deposit);
                        int results = DepositManager.Insert(deposit);
                    }
                    else
                    {
                        MessageBox.Show("Invalid deposit amount. Enter a valid number.");
                    }
                }
                // Modifies deposit data on deposit data grid view
                else if (screenMode == ScreenMode.Edit)
                {
                    if (double.TryParse(txtDepositAmount.Text, out double depositAmount))
                    {
                        customer.Deposits[DepositId].DepositAmount = depositAmount;
                        customer.Deposits[DepositId].DepositDate = DateTime.Parse(dtpDepositDate.Text);
                        int results = DepositManager.Update(customer.Deposits[DepositId]);
                    }
                    else
                    {
                        MessageBox.Show("Invalid deposit amount. Enter a valid number.");
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
