using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArgumentChecking.Test
{
    [TestClass]
    public class ArgumentCheckLibraryTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DirectSingleArgumentCheck()
        {
            DirectCheck.SingleArgumentCheck(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DirectMultipleArgumentCheck()
        {
            DirectCheck.MultipleArgumentCheck(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DirectStringIsEmpty()
        {
            DirectCheck.SingleStringEmpty(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DirectWhitespace()
        {
            DirectCheck.SingleWhitespaceEmpty(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DirectIsValidStringNull()
        {
            DirectCheck.SingleIsValidString(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DirectIsValidStringEmpty()
        {
            DirectCheck.SingleIsValidString(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DirectIsValidStringWhitespace()
        {
            DirectCheck.SingleIsValidString(" ");
        }
    }

    [TestClass]
    public class ArgumentCheckLibraryLazyCheck
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LazySingleArgumentCheck()
        {
            CheckLazy.SingleArgumentCheck(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LazyDiferentArgumentCheck()
        {
            CheckLazy.DifferentArgumentCheck(null, string.Empty);
        }
    }
}
