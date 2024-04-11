namespace JKL.Banking.UI
{


    public partial class frmBanking : Form
    {
        public frmBanking()
        {
            InitializeComponent();
        }

        private void btnAddDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                frmDeposit frmDeposit = new frmDeposit(ScreenMode.Add);

                frmDeposit.ShowDialog();
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

                frmDeposit frmDeposit = new frmDeposit(ScreenMode.Edit);

                frmDeposit.ShowDialog();
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

                frmWithdrawal frmWithdrawal = new frmWithdrawal(ScreenMode.Add);

                frmWithdrawal.ShowDialog();
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

                frmWithdrawal frmWithdrawal = new frmWithdrawal(ScreenMode.Edit);

                frmWithdrawal.ShowDialog();
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
    }
}
