using System;
using ArgumentChecking.Model;
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
