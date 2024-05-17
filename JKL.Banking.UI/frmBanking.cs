using JKL.Banking.BL;
using JKL.Banking.BL.Models;
using Microsoft.Extensions.Configuration;

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
                this.Text = settings.Text;


                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                // Populates listbox with customer info
                //customers = CustomerManager.ReadXML(settings.CustomerXMLFileName);
                //customers = CustomerManager.Populate();


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
            customers = CustomerManager.Load();
            // Refreshes customer listbox
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = customers;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int numCustomers = customers.Count;
            lblStatus.ForeColor = Color.Blue;
            lblStatus.Text = numCustomers + " customers loaded.";

            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCustomers.SelectedRows[0].Index;

                // Updates DataGridView for deposits
                dgvDeposits.DataSource = null;
                dgvDeposits.DataSource = customers[selectedIndex].Deposits;
                AutoFillColWidth(dgvDeposits);

                // Updates DataGridView for withdrawals
                dgvWithdrawals.DataSource = null;
                dgvWithdrawals.DataSource = customers[selectedIndex].Withdrawals;
                AutoFillColWidth(dgvWithdrawals);
            }
            dgvCustomers.Columns[0].Visible = false;
        }

        private void btnAddDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                frmDeposit depositForm = new frmDeposit(ScreenMode.Add);

                // Checks if a customer is selected
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int selectedIndex = dgvCustomers.SelectedRows[0].Index;

                    // Sends customer info to deposit form
                    depositForm.Customer = customers[selectedIndex];
                    depositForm.ShowDialog();

                    // Updates DataGridView
                    Refresh();
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

                // Checks if a customer and a deposit are selected
                if (dgvCustomers.SelectedRows.Count > 0
                    && dgvDeposits.CurrentRow != null
                    && dgvDeposits.CurrentRow.Index >= 0)
                {
                    int selectedIndex = dgvCustomers.SelectedRows[0].Index;

                    // Sends customer data to deposit form
                    depositForm.Customer = customers[selectedIndex];
                    depositForm.DepositId = dgvDeposits.CurrentRow.Index;
                    depositForm.ShowDialog();

                    // Updates values in data grid view
                    dgvDeposits.DataSource = null;
                    dgvDeposits.DataSource = customers[selectedIndex].Deposits;

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
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int selectedIndex = dgvCustomers.SelectedRows[0].Index;

                    // Sends customer id to the withdrawalForm for correct data
                    withdrawalForm.Customer = customers[selectedIndex];
                    withdrawalForm.ShowDialog();

                    // Resets data source to show updated values
                    Refresh();
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

                // Checks if a customer and a withdrawal are selected
                if (dgvCustomers.SelectedRows.Count > 0
                    && dgvWithdrawals.CurrentRow != null
                    && dgvWithdrawals.CurrentRow.Index >= 0)
                {
                    int selectedIndex = dgvCustomers.SelectedRows[0].Index;

                    // Sends customer data to withdrawal form
                    withdrawalForm.Customer = customers[selectedIndex];
                    withdrawalForm.WithdrawalId = dgvWithdrawals.CurrentRow.Index;
                    withdrawalForm.ShowDialog();

                    // Updates values in data grid view
                    dgvWithdrawals.DataSource = null;
                    dgvWithdrawals.DataSource = customers[selectedIndex].Withdrawals;

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

        private void AutoFillColWidth(DataGridView window)
        {
            foreach (DataGridViewColumn column in window.Columns)
            {
                // Set column width to fill
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Hide the deposit ID column
            window.Columns[0].Visible = false;
            window.Columns[1].Visible = false;
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
            if (dgvCustomers.Rows.Count > 0)
            {
                dgvCustomers.ClearSelection();
                dgvCustomers.Rows[0].Selected = true;
            }
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
                customer.Deposits = new List<Deposit>();
                customer.Withdrawals = new List<Withdrawal>();


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

                customer.ID = 1;
                if (customers.Any())
                {
                    customer.ID = customers.Max(c => c.ID) + 1;
                }

                SetProperties(customer);

                customers.Add(customer);
                int results = CustomerManager.Insert(customer);
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

                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int selectedIndex = dgvCustomers.SelectedRows[0].Index;
                    Customer customer = customers[selectedIndex];
                    // Remove the selected customer
                    customers.Remove(customer);
                    int results = CustomerManager.Delete(customer.ID);

                    Refresh();
                    ClearScreen();

                    if (dgvCustomers.Rows.Count > 0)
                    {
                        dgvCustomers.ClearSelection();
                        dgvCustomers.Rows[0].Selected = true;
                    }
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

                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int selectedIndex = dgvCustomers.SelectedRows[0].Index;
                    Customer customer = customers[selectedIndex];

                    int maxId = 0;
                    // Get max id for all deposits and withdrawals in all customers
                    foreach (Customer c in customers)
                    {
                        foreach (Deposit d in c.Deposits)
                        {
                            if (d.DepositId > maxId)
                            {
                                maxId = d.DepositId;
                            }
                        }
                    }

                    foreach (Customer c in customers)
                    {
                        foreach (Withdrawal w in c.Withdrawals)
                        {
                            if (w.WithdrawalId > maxId)
                            {
                                maxId = w.WithdrawalId;
                            }
                        }
                    }

                    SetProperties(customer);
                    int results = CustomerManager.Update(customer, maxId);
                    Refresh();
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

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int selectedIndex = dgvCustomers.SelectedRows[0].Index;
                    if (selectedIndex >= 0 && selectedIndex < customers.Count)
                    {
                        Customer customer = customers[selectedIndex];
                        DisplayCustomerDetails(customer);
                    }
                    else
                    {
                        throw new Exception("Selected index is out of range.");
                    }
                }
                else
                {
                    ClearCustomerDetails();
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void ClearCustomerDetails()
        {
            ClearScreen();
        }

        private void DisplayCustomerDetails(Customer customer)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                // Check if a valid customer is selected
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int selectedIndex = dgvCustomers.SelectedRows[0].Index;
                    if (selectedIndex >= 0 && selectedIndex < customers.Count)
                    {
                        // Get selected customer
                        customer = customers[selectedIndex];

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
                        if (dgvDeposits.Columns.Count > 0)
                        {
                            dgvDeposits.Columns[0].Visible = false;
                            dgvDeposits.Columns[1].Visible = false;
                        }

                        // Display withdrawal data
                        dgvWithdrawals.DataSource = null;
                        dgvWithdrawals.DataSource = customer.Withdrawals;
                        if (dgvWithdrawals.Columns.Count > 0)
                        {
                            dgvWithdrawals.Columns[0].Visible = false;
                            dgvWithdrawals.Columns[1].Visible = false;
                        }

                        AutoFillColWidth(dgvDeposits);
                        AutoFillColWidth(dgvWithdrawals);
                    }
                    else
                    {
                        // Handle the case where the selected index is out of range
                        throw new Exception("Selected index is out of range.");
                    }
                }
                else
                {
                    // Handle the case where no customer is selected
                    throw new Exception("No customer is selected.");
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
