using JKL.Banking.BL.Models;
using JKL.Banking.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKL.Banking.BL.Test
{
    [TestClass]
    public class utWithdrawal
    {
        [TestMethod]
        public void PopulateTest()
        {
            // Expectation
            var expectedWithdrawalsCustomer1 = 3;
            var expectedWithdrawalsCustomer2 = 2;
            var expectedWithdrawalsCustomer3 = 2;

            // Run populate method on fake customers
            var withdrawalsCustomer1 = WithdrawalManager.Populate(1);
            var withdrawalsCustomer2 = WithdrawalManager.Populate(2);
            var withdrawalsCustomer3 = WithdrawalManager.Populate(3);

            // Assert success
            Assert.AreEqual(expectedWithdrawalsCustomer1, withdrawalsCustomer1.Count);
            Assert.AreEqual(expectedWithdrawalsCustomer2, withdrawalsCustomer2.Count);
            Assert.AreEqual(expectedWithdrawalsCustomer3, withdrawalsCustomer3.Count);
        }
    }
}
