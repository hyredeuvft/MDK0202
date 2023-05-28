using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ForTests;

namespace TestAddition
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double num1 = 1;
            double num2 = 1;
            double sum = 2;

            double res = Program.MyAddition(num1, num2);

            Assert.AreEqual(sum, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double[] arr = new double[5] { 16, 243, 34, 85, 56 };
            double bigNum = 243;
            double res = Program.BiggestNumber(arr);

            Assert.AreEqual(bigNum, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double num1 = 1;
            double num2 = 2;
            double num3 = 3;
            double correct = 3;

            double res = Program.MyMax(num1, num2, num3);

            Assert.AreEqual(correct, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string word = "Hello";
            int correct = 5;

            int res = Program.CountLitters(word);

            Assert.AreEqual(correct, res);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string s = "Hell*^@o569";
            int correct = 3;

            int res = Program.Nums(s);

            Assert.AreEqual(correct, res);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string s = "Hell*^@o569";
            int correct = 3;

            int res = Program.SpecialSymbol(s);

            Assert.AreEqual(correct, res);
        }
    }
}
