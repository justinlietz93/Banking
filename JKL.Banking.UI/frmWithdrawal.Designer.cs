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
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(157, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(157, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(206, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 99);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmWithdrawal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 134);
            Controls.Add(btnSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(lblWithdrawalDate);
            Controls.Add(lblWithdrawalAmount);
            Name = "frmWithdrawal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Withdrawal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWithdrawalAmount;
        private Label lblWithdrawalDate;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnSave;
    }
}