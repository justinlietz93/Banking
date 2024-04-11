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
    public class utDeposit
    {
        [TestMethod]
        public void PopulateTest()
        {
            // Set expectation for test
            var expectedDepositsCustomer1 = 3;
            var expectedDepositsCustomer2 = 2;
            var expectedDepositsCustomer3 = 2;

            // Run Populate method for fake customer
            var depositsCustomer1 = DepositManager.Populate(1);
            var depositsCustomer2 = DepositManager.Populate(2);
            var depositsCustomer3 = DepositManager.Populate(3);

            // Assert test success
            Assert.AreEqual(expectedDepositsCustomer1, depositsCustomer1.Count);
            Assert.AreEqual(expectedDepositsCustomer2, depositsCustomer2.Count);
            Assert.AreEqual(expectedDepositsCustomer3, depositsCustomer3.Count);
        }
    }
}
