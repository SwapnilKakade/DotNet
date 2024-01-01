using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelloWorld;
using System.Security.Principal;

namespace UnitTestApp
{
    // Attributes
    //MetaData
    [TestClass]   
    public class BankTest
    {
        [TestMethod]
        public void DebitAmountTest()
        {
            // Arrange
            double initialBalance = 600;
            double debitAmount = 100;

            double expectedBalance = 500;

            //AUT

            Account acct = new Account();

            //ACT

            acct.Balance = initialBalance;
            acct.Withdraw(debitAmount);

            double actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);

        }

        [TestMethod]
        public void CreditAmountTest()
        {
            // Arrange
            double initialBalance = 800;
            double creditAmount = 100;

            double expectedBalance = 900;

            //AUT

            Account acct = new Account();


            //ACT

            acct.Balance = initialBalance;
            acct.Deposit(creditAmount);

            double actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void InterestCalculateTest()
        {
            double initialBalance = 9000;
            double rateOfInterest = 0.5;
            double expectedBalance = initialBalance + (initialBalance * rateOfInterest); // Calculate expected balance

            Account acct = new Account();

            acct.Balance = initialBalance;
            acct.Calculate(rateOfInterest);
            double actualBalance = acct.Balance;

            Assert.AreEqual(expectedBalance, actualBalance);
        }

    }
}   

