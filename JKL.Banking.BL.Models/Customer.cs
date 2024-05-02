using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKL.Banking.BL.Models
{
    public class Customer : Person
    {
        #region Properties


        private List<Deposit> deposits;

        public List<Deposit> Deposits
        {
            get { return deposits; }
            set { deposits = value; }
        }

        private List<Withdrawal> withdrawals;

        public List<Withdrawal> Withdrawals
        {
            get { return withdrawals; }
            set { withdrawals = value; }
        }


        #endregion


    }
}
