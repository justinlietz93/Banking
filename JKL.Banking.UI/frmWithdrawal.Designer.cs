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
            lblWithdrawalAmount.Location = new Point(23, 13);
            lblWithdrawalAmount.Name = "lblWithdrawalAmount";
            lblWithdrawalAmount.Size = new Size(114, 15);
            lblWithdrawalAmount.TabIndex = 0;
            lblWithdrawalAmount.Text = "Withdrawal Amount";
            // 
            // lblWithdrawalDate
            // 
            lblWithdrawalDate.AutoSize = true;
            lblWithdrawalDate.Location = new Point(23, 61);
            lblWithdrawalDate.Name = "lblWithdrawalDate";
            lblWithdrawalDate.Size = new Size(94, 15);
            lblWithdrawalDate.TabIndex = 1;
            lblWithdrawalDate.Text = "Withdrawal Date";
            // 
            // txtWithdrawalAmount
            // 
            txtWithdrawalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtWithdrawalAmount.Location = new Point(157, 11);
            txtWithdrawalAmount.Name = "txtWithdrawalAmount";
            txtWithdrawalAmount.Size = new Size(129, 23);
            txtWithdrawalAmount.TabIndex = 2;
            // 
            // dtpWithdrawalDate
            // 
            dtpWithdrawalDate.Location = new Point(157, 55);
            dtpWithdrawalDate.Name = "dtpWithdrawalDate";
            dtpWithdrawalDate.Size = new Size(206, 23);
            dtpWithdrawalDate.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 99);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmWithdrawal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 134);
            Controls.Add(btnSave);
            Controls.Add(dtpWithdrawalDate);
            Controls.Add(txtWithdrawalAmount);
            Controls.Add(lblWithdrawalDate);
            Controls.Add(lblWithdrawalAmount);
            FormBorderStyle = FormBorderStyle.Fixed3D;
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