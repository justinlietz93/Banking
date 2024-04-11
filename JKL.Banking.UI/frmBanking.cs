using JKL.Banking.BL;
using JKL.Banking.BL.Models;
using System.Windows.Forms;

namespace JKL.Banking.UI
{


    public partial class frmBanking : Form
    {
        List<Customer> customers;

        public frmBanking()
        {
            InitializeComponent();
        }

        private void frmBanking_Load(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                // Populates listbox with customer info
                customers = CustomerManager.Populate();

                Refresh();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
                throw;
            }
        }

        private void Refresh()
        {
            // Refreshes customer listbox
            lbxCustomers.DataSource = null;
            lbxCustomers.DataSource = customers;
            lbxCustomers.DisplayMember = "FullName";
        }

        private void btnAddDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                frmDeposit depositForm = new frmDeposit(ScreenMode.Add);

                // Checks if customer is selected
                if (lbxCustomers.SelectedIndex >= 0)
                {
                    // Sends customer info to deposit form
                    depositForm.Customer = customers[lbxCustomers.SelectedIndex];
                    depositForm.ShowDialog(); 

                    // Updates datagridview
                    dgvDeposits.DataSource = null;
                    dgvDeposits.DataSource = customers[lbxCustomers.SelectedIndex].Deposits;

                    // Hides ID column and maintains column width
                    AutoFillColWidth(dgvDeposits);
                }
                else
                {
                    throw new Exception("Please select a customer.");
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnEditDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                frmDeposit depositForm = new frmDeposit(ScreenMode.Edit);

                // Checks if customer is selected
                if (lbxCustomers.SelectedIndex >= 0 
                    && dgvDeposits.CurrentRow != null 
                    && dgvDeposits.CurrentRow.Index >= 0)
                {
                    // Sends customer data to deposit form
                    depositForm.Customer = customers[lbxCustomers.SelectedIndex];
                    depositForm.DepositId = dgvDeposits.CurrentRow.Index;
                    depositForm.ShowDialog();

                    // Updates values in data grid view
                    dgvDeposits.DataSource = null;
                    dgvDeposits.DataSource = customers[lbxCustomers.SelectedIndex].Deposits;
                    
                    // Hides ID column and maintains column width
                    AutoFillColWidth(dgvDeposits);
                }
                else
                {
                    throw new Exception("Please select a customer and a deposit.");
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnAddWithdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                frmWithdrawal withdrawalForm = new frmWithdrawal(ScreenMode.Add);

                // Checks if a customer is selected
                if (lbxCustomers.SelectedIndex >= 0)
                {
                    // Sends customer id to the withdrawalForm for correct data
                    withdrawalForm.Customer = customers[lbxCustomers.SelectedIndex];
                    withdrawalForm.ShowDialog();

                    // Resets data source to show updated values
                    dgvWithdrawals.DataSource = null;
                    dgvWithdrawals.DataSource = customers[lbxCustomers.SelectedIndex].Withdrawals;

                    // Hides ID column and maintains column width
                    AutoFillColWidth(dgvWithdrawals);
                }
                else
                {
                    throw new Exception("Please select a customer.");
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnEditWithdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                frmWithdrawal withdrawalForm = new frmWithdrawal(ScreenMode.Edit);

                if (lbxCustomers.SelectedIndex >= 0
                    && dgvWithdrawals.CurrentRow != null
                    && dgvWithdrawals.CurrentRow.Index >= 0)
                {
                    withdrawalForm.Customer = customers[lbxCustomers.SelectedIndex];
                    withdrawalForm.WithdrawalId = dgvWithdrawals.CurrentRow.Index;
                    withdrawalForm.ShowDialog();

                    dgvWithdrawals.DataSource = null;
                    dgvWithdrawals.DataSource = customers[lbxCustomers.SelectedIndex].Withdrawals;


                    AutoFillColWidth(dgvWithdrawals);
                }
                else
                {
                    throw new Exception("Please select a customer and a withdrawal.");
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                // Get selected customer
                Customer customer = customers[lbxCustomers.SelectedIndex];

                // Display customer info
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtSSN.Text = customer.SSN;
                lblMemberID.Text = customer.ID.ToString();
                dtpBirthDate.Value = customer.BirthDate;

                // Display deposits data
                dgvDeposits.DataSource = null;
                dgvDeposits.DataSource = customer.Deposits;
                dgvDeposits.Columns[0].Visible = false;

                // Display withdrawal data
                dgvWithdrawals.DataSource = null;
                dgvWithdrawals.DataSource = customer.Withdrawals;
                dgvWithdrawals.Columns[0].Visible = false;

                AutoFillColWidth(dgvDeposits);
                AutoFillColWidth(dgvWithdrawals);
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void AutoFillColWidth(DataGridView window)
        {
            foreach (DataGridViewColumn column in window.Columns)
            {
                // Set column width to fill
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Hide the deposit ID column
            window.Columns[0].Visible = false;
        }
    }
}
