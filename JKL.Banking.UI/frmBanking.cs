using JKL.Banking.BL;
using JKL.Banking.BL.Models;
using Microsoft.VisualBasic.Devices;
using Microsoft.Extensions.Configuration;
using System.Runtime;
using System.Windows.Forms;
using JKL.ComputerWorld.BL.Models;

namespace JKL.Banking.UI
{


    public partial class frmBanking : Form
    {
        List<Customer> customers;
        MySettings settings;

        public frmBanking()
        {
            InitializeComponent();
        }

        private void frmBanking_Load(object sender, EventArgs e)
        {
            try
            {
                settings = Program.Configuration.GetSection("MySettings").Get<MySettings>();

                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                // Populates listbox with customer info
                //customers = CustomerManager.ReadXML(settings.CustomerXMLFileName);
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
            int numCustomers = customers.Count;
            lblStatus.ForeColor = Color.Blue;
            lblStatus.Text = numCustomers + " customers loaded.";
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

                // Check if a valid index is selected
                if (lbxCustomers.SelectedIndex >= 0 && lbxCustomers.SelectedIndex < customers.Count)
                {
                    // Get selected customer
                    Customer customer = customers[lbxCustomers.SelectedIndex];

                    // Display customer info
                    txtFirstName.Text = customer.FirstName;
                    txtLastName.Text = customer.LastName;
                    txtSSN.Text = customer.SSN;
                    lblAge.Text = customer.Age.ToString();
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
                else
                {
                    // Handle the case where the selected index is out of range
                    throw new Exception("Selected index is out of range.");
                }
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

        private void dgvDeposits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //// Get selected customer
            //Customer customer = customers[lbxCustomers.SelectedIndex];

            //customer.FirstName = txtFirstName.Text;
            //Refresh();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            //// Get selected customer
            //Customer customer = customers[lbxCustomers.SelectedIndex];

            //customer.LastName = txtLastName.Text;
            //Refresh();
        }

        private void txtSSN_TextChanged(object sender, EventArgs e)
        {
            //// Get selected customer
            //Customer customer = customers[lbxCustomers.SelectedIndex];

            //customer.SSN = txtSSN.Text;
            //Refresh();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            //// Get selected customer
            //Customer customer = customers[lbxCustomers.SelectedIndex];

            //customer.BirthDate = dtpBirthDate.Value;
            //Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            lbxCustomers.SelectedIndex = 0;
            lblMemberID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSSN.Text = string.Empty;
            lblAge.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now;
        }

        private void SetProperties(Customer customer)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.BirthDate = dtpBirthDate.Value;
                customer.SSN = txtSSN.Text;

            }
            catch (Exception ex)
            {

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                Customer customer = new Customer();
                customer.ID = customers.Count + 1;
                SetProperties(customer);

                customer.Deposits = new List<Deposit>();
                customer.Withdrawals = new List<Withdrawal>();

                customers.Add(customer);
                Refresh();
            }
            catch (Exception ex)
            {

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                if (lbxCustomers.SelectedIndex >= 0)
                {
                    // Remove the selected customer
                    customers.Remove(customers[lbxCustomers.SelectedIndex]);

                    Refresh();
                    ClearScreen();
                    lbxCustomers.SelectedIndex = 0;
                }
                else
                {
                    // Nothing selected
                    throw new Exception("Nothing is selected for deletion.");
                }

            }
            catch (Exception ex)
            {

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                Customer customer = customers[lbxCustomers.SelectedIndex];
                SetProperties(customer);

                Refresh();
            }
            catch (Exception ex)
            {

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void mnuWriteToFile_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                if (customers != null)
                {
                    bool results = CustomerManager.WriteXML(customers, settings.CustomerXMLFileName);
                }
            }
            catch (Exception ex)
            {

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }
    }
}
