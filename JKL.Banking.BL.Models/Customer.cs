using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKL.Banking.BL.Models
{
    public class Customer
    {
        #region Properties
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

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
