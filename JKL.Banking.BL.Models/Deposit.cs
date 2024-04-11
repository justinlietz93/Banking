using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKL.Banking.BL.Models
{
    #region Properties
    public class Deposit
    {
		private int depositId;

		public int DepositId
		{
			get { return depositId; }
			set { depositId = value; }
		}

		private double depositAmount;

		public double DepositAmount
		{
			get { return depositAmount; }
			set { depositAmount = value; }
		}

		private DateTime depositDate;

		public DateTime DepositDate
		{
			get { return depositDate; }
			set { depositDate = value; }
		}
        #endregion
    }
}
