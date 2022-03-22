using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibaryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibaryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnTrue()
        {
            string password = "ASqw12$$";
            bool expected = true;

            bool actual = PasswordChecker.validatePassword(password);

            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        public void Check_4Symbols_ReturnFalse()
        {
            string password = "Aq1$";
            bool expected = false;

            bool actual = PasswordChecker.validatePassword(password);

            Assert.IsFalse(actual);
        }
    }
}