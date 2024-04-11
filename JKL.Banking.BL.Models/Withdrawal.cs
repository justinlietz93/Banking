using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKL.Banking.BL.Models
{
    public class Withdrawal
    {
        #region Properties
        private int withdrawalId;

        public int WithdrawalId
        {
            get { return withdrawalId; }
            set { withdrawalId = value; }
        }

        private double withdrawalAmount;

        public double WithdrawalAmount
        {
            get { return withdrawalAmount; }
            set { withdrawalAmount = value; }
        }

        private DateTime withdrawalDate;

        public DateTime WithdrawalDate
        {
            get { return withdrawalDate; }
            set { withdrawalDate = value; }
        }

        #endregion
    }
}
