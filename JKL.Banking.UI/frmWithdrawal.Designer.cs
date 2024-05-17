namespace JKL.Banking.UI
{
    partial class frmWithdrawal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWithdrawalAmount = new Label();
            lblWithdrawalDate = new Label();
            txtWithdrawalAmount = new TextBox();
            dtpWithdrawalDate = new DateTimePicker();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblWithdrawalAmount
            // 
            lblWithdrawalAmount.AutoSize = true;
            lblWithdrawalAmount.Location = new Point(33, 22);
            lblWithdrawalAmount.Margin = new Padding(4, 0, 4, 0);
            lblWithdrawalAmount.Name = "lblWithdrawalAmount";
            lblWithdrawalAmount.Size = new Size(171, 25);
            lblWithdrawalAmount.TabIndex = 0;
            lblWithdrawalAmount.Text = "Withdrawal Amount";
            // 
            // lblWithdrawalDate
            // 
            lblWithdrawalDate.AutoSize = true;
            lblWithdrawalDate.Location = new Point(33, 102);
            lblWithdrawalDate.Margin = new Padding(4, 0, 4, 0);
            lblWithdrawalDate.Name = "lblWithdrawalDate";
            lblWithdrawalDate.Size = new Size(143, 25);
            lblWithdrawalDate.TabIndex = 1;
            lblWithdrawalDate.Text = "Withdrawal Date";
            // 
            // txtWithdrawalAmount
            // 
            txtWithdrawalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtWithdrawalAmount.Location = new Point(224, 18);
            txtWithdrawalAmount.Margin = new Padding(4, 5, 4, 5);
            txtWithdrawalAmount.Name = "txtWithdrawalAmount";
            txtWithdrawalAmount.Size = new Size(183, 31);
            txtWithdrawalAmount.TabIndex = 2;
            // 
            // dtpWithdrawalDate
            // 
            dtpWithdrawalDate.Location = new Point(224, 92);
            dtpWithdrawalDate.Margin = new Padding(4, 5, 4, 5);
            dtpWithdrawalDate.Name = "dtpWithdrawalDate";
            dtpWithdrawalDate.Size = new Size(293, 31);
            dtpWithdrawalDate.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 165);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmWithdrawal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 223);
            Controls.Add(btnSave);
            Controls.Add(dtpWithdrawalDate);
            Controls.Add(txtWithdrawalAmount);
            Controls.Add(lblWithdrawalDate);
            Controls.Add(lblWithdrawalAmount);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmWithdrawal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Withdrawal";
            Load += frmWithdrawal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWithdrawalAmount;
        private Label lblWithdrawalDate;
        private TextBox txtWithdrawalAmount;
        private DateTimePicker dtpWithdrawalDate;
        private Button btnSave;
    }
}