using JKL.Banking.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace JKL.Banking.BL
{
    public class DepositManager
    {
        public static List<Deposit> Populate(int customerId)
        {
            List<Deposit> list = new List<Deposit>();
            switch (customerId)
            {
                case 1:
                    list.Add(new Deposit { DepositId = 1, DepositAmount = 1234.50, DepositDate = new DateTime(2024, 1, 1) });
                    list.Add(new Deposit { DepositId = 2, DepositAmount = 1500.75, DepositDate = new DateTime(2023, 12, 15) });
                    list.Add(new Deposit { DepositId = 3, DepositAmount = 275.00, DepositDate = new DateTime(2023, 11, 30) });
                    break;
                case 2:
                    list.Add(new Deposit { DepositId = 4, DepositAmount = 100.60, DepositDate = new DateTime(2023, 11, 25) });
                    list.Add(new Deposit { DepositId = 5, DepositAmount = 50.25, DepositDate = new DateTime(2023, 10, 10) });
                    break;
                case 3:
                    list.Add(new Deposit { DepositId = 6, DepositAmount = 200.00, DepositDate = new DateTime(2023, 9, 5) });
                    list.Add(new Deposit { DepositId = 7, DepositAmount = 75.50, DepositDate = new DateTime(2023, 8, 20) });
                    break;
            }
            return list;
        }
    }
}
