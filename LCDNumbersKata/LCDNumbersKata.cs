using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LCDNubmersKata
{
    // Each number translates to a 3x3 grid of either space, | or _, so:
    //
    // 123456789
    //
    // translates to:
    //
    //   _ _     _    _  _  _
    // | _|_||_||_ |_  ||_||_|
    // ||_ _|  | _||_| ||_| _|

    public class LCDNumbersKata
    {
        public string Translate(int number)
        {
            throw new NotImplementedException();
        }
    }

    [TestClass]
    public class Tests
    {
        public LCDNumbersKata System { get; set; }

        [TestInitialize]
        public void Setup()
        {
            System = new LCDNumbersKata();
        }

        [TestMethod]
        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
