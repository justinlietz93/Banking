namespace JKL.Banking.UI
{
    partial class frmDeposit
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
            btnSave = new Button();
            dtpDepositDate = new DateTimePicker();
            txtDepositAmount = new TextBox();
            lblDepositDate = new Label();
            lblDepositAmount = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(126, 102);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtpDepositDate
            // 
            dtpDepositDate.Location = new Point(146, 56);
            dtpDepositDate.Name = "dtpDepositDate";
            dtpDepositDate.Size = new Size(213, 23);
            dtpDepositDate.TabIndex = 8;
            // 
            // txtDepositAmount
            // 
            txtDepositAmount.BorderStyle = BorderStyle.FixedSingle;
            txtDepositAmount.Location = new Point(146, 12);
            txtDepositAmount.Name = "txtDepositAmount";
            txtDepositAmount.Size = new Size(129, 23);
            txtDepositAmount.TabIndex = 7;
            // 
            // lblDepositDate
            // 
            lblDepositDate.AutoSize = true;
            lblDepositDate.Location = new Point(26, 62);
            lblDepositDate.Name = "lblDepositDate";
            lblDepositDate.Size = new Size(74, 15);
            lblDepositDate.TabIndex = 6;
            lblDepositDate.Text = "Deposit Date";
            // 
            // lblDepositAmount
            // 
            lblDepositAmount.AutoSize = true;
            lblDepositAmount.Location = new Point(26, 14);
            lblDepositAmount.Name = "lblDepositAmount";
            lblDepositAmount.Size = new Size(94, 15);
            lblDepositAmount.TabIndex = 5;
            lblDepositAmount.Text = "Deposit Amount";
            // 
            // frmDeposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 137);
            Controls.Add(btnSave);
            Controls.Add(dtpDepositDate);
            Controls.Add(txtDepositAmount);
            Controls.Add(lblDepositDate);
            Controls.Add(lblDepositAmount);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmDeposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += frmDeposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private DateTimePicker dtpDepositDate;
        private TextBox txtDepositAmount;
        private Label lblDepositDate;
        private Label lblDepositAmount;
    }
}