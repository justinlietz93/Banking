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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuWriteToFile = new ToolStripMenuItem();
            btnDelete = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            lblAge = new Label();
            label2 = new Label();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeposits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWithdrawals).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomers.Location = new Point(21, 25);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(73, 17);
            lblCustomers.TabIndex = 0;
            lblCustomers.Text = "Customers";
            // 
            // lblDeposits
            // 
            lblDeposits.AutoSize = true;
            lblDeposits.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeposits.Location = new Point(21, 275);
            lblDeposits.Name = "lblDeposits";
            lblDeposits.Size = new Size(62, 17);
            lblDeposits.TabIndex = 1;
            lblDeposits.Text = "Deposits";
            // 
            // lblWithdrawals
            // 
            lblWithdrawals.AutoSize = true;
            lblWithdrawals.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblWithdrawals.Location = new Point(21, 465);
            lblWithdrawals.Name = "lblWithdrawals";
            lblWithdrawals.Size = new Size(85, 17);
            lblWithdrawals.TabIndex = 2;
            lblWithdrawals.Text = "Withdrawals";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 683);
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
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionBackColor = Color.Green;
            dgvDeposits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDeposits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeposits.Location = new Point(21, 295);
            dgvDeposits.Name = "dgvDeposits";
            dgvDeposits.RowTemplate.Height = 25;
            dgvDeposits.Size = new Size(590, 150);
            dgvDeposits.TabIndex = 4;
            dgvDeposits.CellContentClick += dgvDeposits_CellContentClick;
            // 
            // dgvWithdrawals
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Firebrick;
            dgvWithdrawals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvWithdrawals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWithdrawals.Location = new Point(21, 488);
            dgvWithdrawals.Name = "dgvWithdrawals";
            dgvWithdrawals.RowTemplate.Height = 25;
            dgvWithdrawals.Size = new Size(590, 150);
            dgvWithdrawals.TabIndex = 5;
            // 
            // lbxCustomers
            // 
            lbxCustomers.FormattingEnabled = true;
            lbxCustomers.ItemHeight = 15;
            lbxCustomers.Location = new Point(21, 45);
            lbxCustomers.Name = "lbxCustomers";
            lbxCustomers.Size = new Size(279, 214);
            lbxCustomers.TabIndex = 6;
            lbxCustomers.SelectedIndexChanged += lbxCustomers_SelectedIndexChanged;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(317, 56);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(67, 15);
            lblFName.TabIndex = 7;
            lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(317, 85);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(66, 15);
            lblLName.TabIndex = 8;
            lblLName.Text = "Last Name:";
            // 
            // lblSSN
            // 
            lblSSN.AutoSize = true;
            lblSSN.Location = new Point(317, 114);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(31, 15);
            lblSSN.TabIndex = 9;
            lblSSN.Text = "SSN:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(317, 142);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 10;
            lblId.Text = "Id:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(317, 170);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(62, 15);
            lblBirthDate.TabIndex = 11;
            lblBirthDate.Text = "Birth Date:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(401, 54);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 23);
            txtFirstName.TabIndex = 12;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(401, 83);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 23);
            txtLastName.TabIndex = 13;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtSSN
            // 
            txtSSN.BorderStyle = BorderStyle.FixedSingle;
            txtSSN.Location = new Point(401, 112);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(210, 23);
            txtSSN.TabIndex = 14;
            txtSSN.TextAlign = HorizontalAlignment.Right;
            txtSSN.TextChanged += txtSSN_TextChanged;
            // 
            // lblMemberID
            // 
            lblMemberID.BorderStyle = BorderStyle.FixedSingle;
            lblMemberID.Location = new Point(401, 138);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(210, 23);
            lblMemberID.TabIndex = 15;
            lblMemberID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(401, 164);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(210, 23);
            dtpBirthDate.TabIndex = 16;
            dtpBirthDate.ValueChanged += dtpBirthDate_ValueChanged;
            // 
            // btnAddDeposit
            // 
            btnAddDeposit.Location = new Point(323, 451);
            btnAddDeposit.Name = "btnAddDeposit";
            btnAddDeposit.Size = new Size(141, 23);
            btnAddDeposit.TabIndex = 17;
            btnAddDeposit.Text = "Add Deposit";
            btnAddDeposit.UseVisualStyleBackColor = true;
            btnAddDeposit.Click += btnAddDeposit_Click;
            // 
            // btnEditDeposit
            // 
            btnEditDeposit.Location = new Point(470, 451);
            btnEditDeposit.Name = "btnEditDeposit";
            btnEditDeposit.Size = new Size(141, 23);
            btnEditDeposit.TabIndex = 18;
            btnEditDeposit.Text = "Edit Deposit";
            btnEditDeposit.UseVisualStyleBackColor = true;
            btnEditDeposit.Click += btnEditDeposit_Click;
            // 
            // btnAddWithdrawal
            // 
            btnAddWithdrawal.Location = new Point(172, 648);
            btnAddWithdrawal.Name = "btnAddWithdrawal";
            btnAddWithdrawal.Size = new Size(154, 23);
            btnAddWithdrawal.TabIndex = 19;
            btnAddWithdrawal.Text = "Add Withdrawal";
            btnAddWithdrawal.UseVisualStyleBackColor = true;
            btnAddWithdrawal.Click += btnAddWithdrawal_Click;
            // 
            // btnEditWithdrawal
            // 
            btnEditWithdrawal.Location = new Point(332, 648);
            btnEditWithdrawal.Name = "btnEditWithdrawal";
            btnEditWithdrawal.Size = new Size(154, 23);
            btnEditWithdrawal.TabIndex = 20;
            btnEditWithdrawal.Text = "Edit Withdrawal";
            btnEditWithdrawal.UseVisualStyleBackColor = true;
            btnEditWithdrawal.Click += btnEditWithdrawal_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(492, 648);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 23);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(205, 205, 205);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(632, 24);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuWriteToFile });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "File";
            // 
            // mnuWriteToFile
            // 
            mnuWriteToFile.Name = "mnuWriteToFile";
            mnuWriteToFile.Size = new Size(180, 22);
            mnuWriteToFile.Text = "Write To File";
            mnuWriteToFile.Click += mnuWriteToFile_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(470, 261);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 23);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(323, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 23);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(470, 232);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 23);
            btnClear.TabIndex = 28;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(323, 261);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 23);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblAge
            // 
            lblAge.BorderStyle = BorderStyle.FixedSingle;
            lblAge.Location = new Point(401, 190);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(63, 23);
            lblAge.TabIndex = 30;
            lblAge.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 194);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 31;
            label2.Text = "Age:";
            // 
            // frmBanking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(632, 705);
            Controls.Add(label2);
            Controls.Add(lblAge);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
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
            Controls.Add(menuStrip1);
            Controls.Add(lblWithdrawals);
            Controls.Add(lblDeposits);
            Controls.Add(lblCustomers);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "frmBanking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Information";
            Load += frmBanking_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeposits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWithdrawals).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuWriteToFile;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Label lblAge;
        private Label label2;
    }
}
