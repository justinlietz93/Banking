using JKL.Banking.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKL.Banking.BL
{
    internal class WithdrawalManager
    {
        public static List<Withdrawal> Populate(int customerId)
        {
            List<Withdrawal> list = new List<Withdrawal>();

            switch (customerId)
            {
                case 1:
                    list.Add(new Withdrawal { WithdrawalId = 1, WithdrawalAmount = 500.25, WithdrawalDate = new DateTime(2024, 1, 5) });
                    list.Add(new Withdrawal { WithdrawalId = 2, WithdrawalAmount = 200.00, WithdrawalDate = new DateTime(2023, 12, 20) });
                    list.Add(new Withdrawal { WithdrawalId = 3, WithdrawalAmount = 1000.00, WithdrawalDate = new DateTime(2023, 11, 10) });
                    break;
                case 2:
                    list.Add(new Withdrawal { WithdrawalId = 4, WithdrawalAmount = 300.75, WithdrawalDate = new DateTime(2023, 10, 15) });
                    list.Add(new Withdrawal { WithdrawalId = 5, WithdrawalAmount = 150.50, WithdrawalDate = new DateTime(2023, 9, 30) });
                    break;
                case 3:
                    list.Add(new Withdrawal { WithdrawalId = 6, WithdrawalAmount = 100.00, WithdrawalDate = new DateTime(2023, 8, 25) });
                    list.Add(new Withdrawal { WithdrawalId = 7, WithdrawalAmount = 75.25, WithdrawalDate = new DateTime(2023, 7, 10) });
                    break;
            }
            return list;
        }
    }
}