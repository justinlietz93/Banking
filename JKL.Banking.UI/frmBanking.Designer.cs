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
            lblCustomers = new Label();
            lblDeposits = new Label();
            lblWithdrawals = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            dataGridView1 = new DataGridView();
            DepositId = new DataGridViewTextBoxColumn();
            DepositAmount = new DataGridViewTextBoxColumn();
            DepositDate = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            WithdrawalId = new DataGridViewTextBoxColumn();
            WithdrawalAmount = new DataGridViewTextBoxColumn();
            WithdrawalDate = new DataGridViewTextBoxColumn();
            listBox1 = new ListBox();
            lblFName = new Label();
            lblLName = new Label();
            lblSSN = new Label();
            lblId = new Label();
            lblBirthDate = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblMemberID = new Label();
            dtpBirthDate = new DateTimePicker();
            btnAddDeposit = new Button();
            btnEditDeposit = new Button();
            btnAddWithdrawal = new Button();
            btnEditWithdrawal = new Button();
            btnExit = new Button();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            lblDeposits.Location = new Point(21, 234);
            lblDeposits.Name = "lblDeposits";
            lblDeposits.Size = new Size(62, 17);
            lblDeposits.TabIndex = 1;
            lblDeposits.Text = "Deposits";
            // 
            // lblWithdrawals
            // 
            lblWithdrawals.AutoSize = true;
            lblWithdrawals.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblWithdrawals.Location = new Point(21, 443);
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
            statusStrip1.Size = new Size(589, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DepositId, DepositAmount, DepositDate });
            dataGridView1.Location = new Point(21, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(546, 150);
            dataGridView1.TabIndex = 4;
            // 
            // DepositId
            // 
            DepositId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DepositId.HeaderText = "DepositId";
            DepositId.Name = "DepositId";
            // 
            // DepositAmount
            // 
            DepositAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DepositAmount.HeaderText = "DepositAmount";
            DepositAmount.Name = "DepositAmount";
            // 
            // DepositDate
            // 
            DepositDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DepositDate.HeaderText = "DepositDate";
            DepositDate.Name = "DepositDate";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { WithdrawalId, WithdrawalAmount, WithdrawalDate });
            dataGridView2.Location = new Point(21, 443);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(546, 150);
            dataGridView2.TabIndex = 5;
            // 
            // WithdrawalId
            // 
            WithdrawalId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WithdrawalId.HeaderText = "WithdrawalId";
            WithdrawalId.Name = "WithdrawalId";
            // 
            // WithdrawalAmount
            // 
            WithdrawalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WithdrawalAmount.HeaderText = "WithdrawalAmount";
            WithdrawalAmount.Name = "WithdrawalAmount";
            // 
            // WithdrawalDate
            // 
            WithdrawalDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WithdrawalDate.HeaderText = "WithdrawalDate";
            WithdrawalDate.Name = "WithdrawalDate";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(279, 169);
            listBox1.TabIndex = 6;
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(401, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(401, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(401, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 23);
            textBox3.TabIndex = 14;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMemberID
            // 
            lblMemberID.BorderStyle = BorderStyle.FixedSingle;
            lblMemberID.Location = new Point(401, 141);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(152, 23);
            lblMemberID.TabIndex = 15;
            lblMemberID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(401, 173);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(152, 23);
            dtpBirthDate.TabIndex = 16;
            // 
            // btnAddDeposit
            // 
            btnAddDeposit.Location = new Point(367, 410);
            btnAddDeposit.Name = "btnAddDeposit";
            btnAddDeposit.Size = new Size(97, 23);
            btnAddDeposit.TabIndex = 17;
            btnAddDeposit.Text = "Add Deposit";
            btnAddDeposit.UseVisualStyleBackColor = true;
            btnAddDeposit.Click += btnAddDeposit_Click;
            // 
            // btnEditDeposit
            // 
            btnEditDeposit.Location = new Point(470, 410);
            btnEditDeposit.Name = "btnEditDeposit";
            btnEditDeposit.Size = new Size(97, 23);
            btnEditDeposit.TabIndex = 18;
            btnEditDeposit.Text = "Edit Deposit";
            btnEditDeposit.UseVisualStyleBackColor = true;
            btnEditDeposit.Click += btnEditDeposit_Click;
            // 
            // btnAddWithdrawal
            // 
            btnAddWithdrawal.Location = new Point(260, 599);
            btnAddWithdrawal.Name = "btnAddWithdrawal";
            btnAddWithdrawal.Size = new Size(110, 23);
            btnAddWithdrawal.TabIndex = 19;
            btnAddWithdrawal.Text = "Add Withdrawal";
            btnAddWithdrawal.UseVisualStyleBackColor = true;
            btnAddWithdrawal.Click += btnAddWithdrawal_Click;
            // 
            // btnEditWithdrawal
            // 
            btnEditWithdrawal.Location = new Point(376, 599);
            btnEditWithdrawal.Name = "btnEditWithdrawal";
            btnEditWithdrawal.Size = new Size(110, 23);
            btnEditWithdrawal.TabIndex = 20;
            btnEditWithdrawal.Text = "Edit Withdrawal";
            btnEditWithdrawal.UseVisualStyleBackColor = true;
            btnEditWithdrawal.Click += btnEditWithdrawal_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(492, 599);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmBanking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 653);
            Controls.Add(btnExit);
            Controls.Add(btnEditWithdrawal);
            Controls.Add(btnAddWithdrawal);
            Controls.Add(btnEditDeposit);
            Controls.Add(btnAddDeposit);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblMemberID);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblBirthDate);
            Controls.Add(lblId);
            Controls.Add(lblSSN);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Controls.Add(listBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(lblWithdrawals);
            Controls.Add(lblDeposits);
            Controls.Add(lblCustomers);
            Name = "frmBanking";
            Text = "Customer Information";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomers;
        private Label lblDeposits;
        private Label lblWithdrawals;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private ListBox listBox1;
        private Label lblFName;
        private Label lblLName;
        private Label lblSSN;
        private Label lblId;
        private Label lblBirthDate;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblMemberID;
        private DateTimePicker dtpBirthDate;
        private Button btnAddDeposit;
        private Button btnEditDeposit;
        private Button btnAddWithdrawal;
        private Button btnEditWithdrawal;
        private Button btnExit;
        private DataGridViewTextBoxColumn DepositId;
        private DataGridViewTextBoxColumn DepositAmount;
        private DataGridViewTextBoxColumn DepositDate;
        private DataGridViewTextBoxColumn WithdrawalId;
        private DataGridViewTextBoxColumn WithdrawalAmount;
        private DataGridViewTextBoxColumn WithdrawalDate;
    }
}
