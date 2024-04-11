using JKL.Banking.BL.Models;

namespace JKL.Banking.BL.Test
{
    [TestClass]
    public class utCustomer
    {
        [TestMethod]
        public void PopulateTest()
        {
            // Set Expectation
            int expected = 3;
            
            // Run populate method
            List<Customer> items = CustomerManager.Populate();
            int actual = items.Count;

            // Assert success
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(items[0].Deposits.Count == 3);
        }
    }
}