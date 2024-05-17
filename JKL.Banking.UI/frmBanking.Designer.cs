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
            dgvCustomers = new DataGridView();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeposits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWithdrawals).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomers.Location = new Point(30, 42);
            lblCustomers.Margin = new Padding(4, 0, 4, 0);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(111, 28);
            lblCustomers.TabIndex = 0;
            lblCustomers.Text = "Customers";
            // 
            // lblDeposits
            // 
            lblDeposits.AutoSize = true;
            lblDeposits.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeposits.Location = new Point(30, 458);
            lblDeposits.Margin = new Padding(4, 0, 4, 0);
            lblDeposits.Name = "lblDeposits";
            lblDeposits.Size = new Size(94, 28);
            lblDeposits.TabIndex = 1;
            lblDeposits.Text = "Deposits";
            // 
            // lblWithdrawals
            // 
            lblWithdrawals.AutoSize = true;
            lblWithdrawals.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblWithdrawals.Location = new Point(30, 775);
            lblWithdrawals.Margin = new Padding(4, 0, 4, 0);
            lblWithdrawals.Name = "lblWithdrawals";
            lblWithdrawals.Size = new Size(131, 28);
            lblWithdrawals.TabIndex = 2;
            lblWithdrawals.Text = "Withdrawals";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 1153);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(1308, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            // 
            // dgvDeposits
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionBackColor = Color.Green;
            dgvDeposits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDeposits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeposits.Location = new Point(30, 492);
            dgvDeposits.Margin = new Padding(4, 5, 4, 5);
            dgvDeposits.Name = "dgvDeposits";
            dgvDeposits.RowHeadersWidth = 62;
            dgvDeposits.RowTemplate.Height = 25;
            dgvDeposits.Size = new Size(1264, 250);
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
            dgvWithdrawals.Location = new Point(30, 813);
            dgvWithdrawals.Margin = new Padding(4, 5, 4, 5);
            dgvWithdrawals.Name = "dgvWithdrawals";
            dgvWithdrawals.RowHeadersWidth = 62;
            dgvWithdrawals.RowTemplate.Height = 25;
            dgvWithdrawals.Size = new Size(1264, 250);
            dgvWithdrawals.TabIndex = 5;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(876, 78);
            lblFName.Margin = new Padding(4, 0, 4, 0);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(101, 25);
            lblFName.TabIndex = 7;
            lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(876, 127);
            lblLName.Margin = new Padding(4, 0, 4, 0);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(99, 25);
            lblLName.TabIndex = 8;
            lblLName.Text = "Last Name:";
            // 
            // lblSSN
            // 
            lblSSN.AutoSize = true;
            lblSSN.Location = new Point(876, 175);
            lblSSN.Margin = new Padding(4, 0, 4, 0);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(49, 25);
            lblSSN.TabIndex = 9;
            lblSSN.Text = "SSN:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(876, 222);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 25);
            lblId.TabIndex = 10;
            lblId.Text = "Id:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(876, 268);
            lblBirthDate.Margin = new Padding(4, 0, 4, 0);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(94, 25);
            lblBirthDate.TabIndex = 11;
            lblBirthDate.Text = "Birth Date:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(996, 75);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(299, 31);
            txtFirstName.TabIndex = 12;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(996, 123);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(299, 31);
            txtLastName.TabIndex = 13;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtSSN
            // 
            txtSSN.BorderStyle = BorderStyle.FixedSingle;
            txtSSN.Location = new Point(996, 172);
            txtSSN.Margin = new Padding(4, 5, 4, 5);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(299, 31);
            txtSSN.TabIndex = 14;
            txtSSN.TextAlign = HorizontalAlignment.Right;
            txtSSN.TextChanged += txtSSN_TextChanged;
            // 
            // lblMemberID
            // 
            lblMemberID.BorderStyle = BorderStyle.FixedSingle;
            lblMemberID.Location = new Point(996, 215);
            lblMemberID.Margin = new Padding(4, 0, 4, 0);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(299, 37);
            lblMemberID.TabIndex = 15;
            lblMemberID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(996, 258);
            dtpBirthDate.Margin = new Padding(4, 5, 4, 5);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(298, 31);
            dtpBirthDate.TabIndex = 16;
            dtpBirthDate.ValueChanged += dtpBirthDate_ValueChanged;
            // 
            // btnAddDeposit
            // 
            btnAddDeposit.Location = new Point(883, 752);
            btnAddDeposit.Margin = new Padding(4, 5, 4, 5);
            btnAddDeposit.Name = "btnAddDeposit";
            btnAddDeposit.Size = new Size(201, 38);
            btnAddDeposit.TabIndex = 17;
            btnAddDeposit.Text = "Add Deposit";
            btnAddDeposit.UseVisualStyleBackColor = true;
            btnAddDeposit.Click += btnAddDeposit_Click;
            // 
            // btnEditDeposit
            // 
            btnEditDeposit.Location = new Point(1093, 752);
            btnEditDeposit.Margin = new Padding(4, 5, 4, 5);
            btnEditDeposit.Name = "btnEditDeposit";
            btnEditDeposit.Size = new Size(201, 38);
            btnEditDeposit.TabIndex = 18;
            btnEditDeposit.Text = "Edit Deposit";
            btnEditDeposit.UseVisualStyleBackColor = true;
            btnEditDeposit.Click += btnEditDeposit_Click;
            // 
            // btnAddWithdrawal
            // 
            btnAddWithdrawal.Location = new Point(667, 1083);
            btnAddWithdrawal.Margin = new Padding(4, 5, 4, 5);
            btnAddWithdrawal.Name = "btnAddWithdrawal";
            btnAddWithdrawal.Size = new Size(220, 38);
            btnAddWithdrawal.TabIndex = 19;
            btnAddWithdrawal.Text = "Add Withdrawal";
            btnAddWithdrawal.UseVisualStyleBackColor = true;
            btnAddWithdrawal.Click += btnAddWithdrawal_Click;
            // 
            // btnEditWithdrawal
            // 
            btnEditWithdrawal.Location = new Point(895, 1083);
            btnEditWithdrawal.Margin = new Padding(4, 5, 4, 5);
            btnEditWithdrawal.Name = "btnEditWithdrawal";
            btnEditWithdrawal.Size = new Size(220, 38);
            btnEditWithdrawal.TabIndex = 20;
            btnEditWithdrawal.Text = "Edit Withdrawal";
            btnEditWithdrawal.UseVisualStyleBackColor = true;
            btnEditWithdrawal.Click += btnEditWithdrawal_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1124, 1083);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(170, 38);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(205, 205, 205);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1308, 35);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuWriteToFile });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(54, 29);
            mnuFile.Text = "File";
            // 
            // mnuWriteToFile
            // 
            mnuWriteToFile.Name = "mnuWriteToFile";
            mnuWriteToFile.Size = new Size(210, 34);
            mnuWriteToFile.Text = "Write To File";
            mnuWriteToFile.Click += mnuWriteToFile_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1093, 430);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 38);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(883, 382);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(201, 38);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1093, 382);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(201, 38);
            btnClear.TabIndex = 28;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(883, 430);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(201, 38);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblAge
            // 
            lblAge.BorderStyle = BorderStyle.FixedSingle;
            lblAge.Location = new Point(996, 302);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(89, 37);
            lblAge.TabIndex = 30;
            lblAge.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(876, 308);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 31;
            label2.Text = "Age:";
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(30, 78);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.RowTemplate.Height = 33;
            dgvCustomers.Size = new Size(823, 342);
            dgvCustomers.TabIndex = 32;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // frmBanking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1308, 1175);
            Controls.Add(dgvCustomers);
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
            Controls.Add(dgvWithdrawals);
            Controls.Add(dgvDeposits);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(lblWithdrawals);
            Controls.Add(lblDeposits);
            Controls.Add(lblCustomers);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
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
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
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
        private DataGridView dgvCustomers;
    }
}
