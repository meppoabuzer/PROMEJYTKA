using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols()
        {
            string password = "Passwd049049";
            bool expected = true;

            bool actual = PasswordChecker.validatePassword(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_4Symbols()
        {
            string password = "qa1@";
            bool expected = false;

            bool actual = PasswordChecker.validatePassword(password);

            Assert.IsFalse(actual);
        }
    }
}