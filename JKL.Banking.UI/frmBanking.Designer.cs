namespace JKL.Banking.UI
{
    partial class frmBanking
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblCustomers = new Label();
            lblDeposits = new Label();
            lblWithdrawals = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            dgvDeposits = new DataGridView();
            dgvWithdrawals = new DataGridView();
            lbxCustomers = new ListBox();
            lblFName = new Label();
            lblLName = new Label();
            lblSSN = new Label();
            lblId = new Label();
            lblBirthDate = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtSSN = new TextBox();
            lblMemberID = new Label();
            dtpBirthDate = new DateTimePicker();
            btnAddDeposit = new Button();
            btnEditDeposit = new Button();
            btnAddWithdrawal = new Button();
            btnEditWithdrawal = new Button();
            btnExit = new Button();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeposits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWithdrawals).BeginInit();
            SuspendLayout();
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomers.Location = new Point(21, 7);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(73, 17);
            lblCustomers.TabIndex = 0;
            lblCustomers.Text = "Customers";
            // 
            // lblDeposits
            // 
            lblDeposits.AutoSize = true;
            lblDeposits.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeposits.Location = new Point(21, 211);
            lblDeposits.Name = "lblDeposits";
            lblDeposits.Size = new Size(62, 17);
            lblDeposits.TabIndex = 1;
            lblDeposits.Text = "Deposits";
            // 
            // lblWithdrawals
            // 
            lblWithdrawals.AutoSize = true;
            lblWithdrawals.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblWithdrawals.Location = new Point(21, 416);
            lblWithdrawals.Name = "lblWithdrawals";
            lblWithdrawals.Size = new Size(85, 17);
            lblWithdrawals.TabIndex = 2;
            lblWithdrawals.Text = "Withdrawals";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 631);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(632, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            // 
            // dgvDeposits
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionBackColor = Color.Green;
            dgvDeposits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDeposits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeposits.Location = new Point(21, 231);
            dgvDeposits.Name = "dgvDeposits";
            dgvDeposits.RowTemplate.Height = 25;
            dgvDeposits.Size = new Size(590, 150);
            dgvDeposits.TabIndex = 4;
            // 
            // dgvWithdrawals
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dgvWithdrawals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvWithdrawals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWithdrawals.Location = new Point(21, 439);
            dgvWithdrawals.Name = "dgvWithdrawals";
            dgvWithdrawals.RowTemplate.Height = 25;
            dgvWithdrawals.Size = new Size(590, 150);
            dgvWithdrawals.TabIndex = 5;
            // 
            // lbxCustomers
            // 
            lbxCustomers.FormattingEnabled = true;
            lbxCustomers.ItemHeight = 15;
            lbxCustomers.Location = new Point(21, 27);
            lbxCustomers.Name = "lbxCustomers";
            lbxCustomers.Size = new Size(279, 169);
            lbxCustomers.TabIndex = 6;
            lbxCustomers.SelectedIndexChanged += lbxCustomers_SelectedIndexChanged;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(317, 27);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(67, 15);
            lblFName.TabIndex = 7;
            lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(317, 65);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(66, 15);
            lblLName.TabIndex = 8;
            lblLName.Text = "Last Name:";
            // 
            // lblSSN
            // 
            lblSSN.AutoSize = true;
            lblSSN.Location = new Point(317, 103);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(31, 15);
            lblSSN.TabIndex = 9;
            lblSSN.Text = "SSN:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(317, 141);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 10;
            lblId.Text = "Id:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(317, 179);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(62, 15);
            lblBirthDate.TabIndex = 11;
            lblBirthDate.Text = "Birth Date:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(401, 25);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 23);
            txtFirstName.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(401, 63);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 23);
            txtLastName.TabIndex = 13;
            // 
            // txtSSN
            // 
            txtSSN.BorderStyle = BorderStyle.FixedSingle;
            txtSSN.Location = new Point(401, 101);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(210, 23);
            txtSSN.TabIndex = 14;
            txtSSN.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMemberID
            // 
            lblMemberID.BorderStyle = BorderStyle.FixedSingle;
            lblMemberID.Location = new Point(401, 141);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(210, 23);
            lblMemberID.TabIndex = 15;
            lblMemberID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(401, 173);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(210, 23);
            dtpBirthDate.TabIndex = 16;
            // 
            // btnAddDeposit
            // 
            btnAddDeposit.Location = new Point(323, 387);
            btnAddDeposit.Name = "btnAddDeposit";
            btnAddDeposit.Size = new Size(141, 23);
            btnAddDeposit.TabIndex = 17;
            btnAddDeposit.Text = "Add Deposit";
            btnAddDeposit.UseVisualStyleBackColor = true;
            btnAddDeposit.Click += btnAddDeposit_Click;
            // 
            // btnEditDeposit
            // 
            btnEditDeposit.Location = new Point(470, 387);
            btnEditDeposit.Name = "btnEditDeposit";
            btnEditDeposit.Size = new Size(141, 23);
            btnEditDeposit.TabIndex = 18;
            btnEditDeposit.Text = "Edit Deposit";
            btnEditDeposit.UseVisualStyleBackColor = true;
            btnEditDeposit.Click += btnEditDeposit_Click;
            // 
            // btnAddWithdrawal
            // 
            btnAddWithdrawal.Location = new Point(172, 599);
            btnAddWithdrawal.Name = "btnAddWithdrawal";
            btnAddWithdrawal.Size = new Size(154, 23);
            btnAddWithdrawal.TabIndex = 19;
            btnAddWithdrawal.Text = "Add Withdrawal";
            btnAddWithdrawal.UseVisualStyleBackColor = true;
            btnAddWithdrawal.Click += btnAddWithdrawal_Click;
            // 
            // btnEditWithdrawal
            // 
            btnEditWithdrawal.Location = new Point(332, 599);
            btnEditWithdrawal.Name = "btnEditWithdrawal";
            btnEditWithdrawal.Size = new Size(154, 23);
            btnEditWithdrawal.TabIndex = 20;
            btnEditWithdrawal.Text = "Edit Withdrawal";
            btnEditWithdrawal.UseVisualStyleBackColor = true;
            btnEditWithdrawal.Click += btnEditWithdrawal_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(492, 599);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 23);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmBanking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 653);
            Controls.Add(btnExit);
            Controls.Add(btnEditWithdrawal);
            Controls.Add(btnAddWithdrawal);
            Controls.Add(btnEditDeposit);
            Controls.Add(btnAddDeposit);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblMemberID);
            Controls.Add(txtSSN);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblBirthDate);
            Controls.Add(lblId);
            Controls.Add(lblSSN);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Controls.Add(lbxCustomers);
            Controls.Add(dgvWithdrawals);
            Controls.Add(dgvDeposits);
            Controls.Add(statusStrip1);
            Controls.Add(lblWithdrawals);
            Controls.Add(lblDeposits);
            Controls.Add(lblCustomers);
            Name = "frmBanking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Information";
            Load += frmBanking_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeposits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWithdrawals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomers;
        private Label lblDeposits;
        private Label lblWithdrawals;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private DataGridView dgvDeposits;
        private DataGridView dgvWithdrawals;
        private ListBox lbxCustomers;
        private Label lblFName;
        private Label lblLName;
        private Label lblSSN;
        private Label lblId;
        private Label lblBirthDate;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSSN;
        private Label lblMemberID;
        private DateTimePicker dtpBirthDate;
        private Button btnAddDeposit;
        private Button btnEditDeposit;
        private Button btnAddWithdrawal;
        private Button btnEditWithdrawal;
        private Button btnExit;
    }
}
