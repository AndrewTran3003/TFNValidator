using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFNValidator.Helpers;

namespace TFNValidator_Test
{
    [TestClass]
    public class DigitHelper_Test
    {
        #region Public Methods

        [TestMethod]
        [DataRow("648 188 480", true)]
        [DataRow("648 188    499", true)]
        [DataRow("  648 188 519 ^ ", false)]
        [DataRow("  648 188 519 abc ", false)]
        public void ContainsOnlyNumber_Test(string input, bool expect)
        {
            Assert.AreEqual(expect, DigitHelper.ContainsOnlyNumberAndWhiteSpace(input));
        }

        [TestMethod]
        [DataRow('9', 9)]
        [DataRow('8', 8)]
        [DataRow('7', 7)]
        [DataRow('6', 6)]
        [DataRow('5', 5)]
        [DataRow('4', 4)]
        [DataRow('3', 3)]
        [DataRow('2', 2)]
        [DataRow('1', 1)]
        [DataRow('0', 0)]
        public void ConvertToInt_Test(char input, int expect)
        {
            Assert.AreEqual(expect, DigitHelper.ConvertToInt(input));
        }

        [TestMethod]
        [DataRow(1, 10)]
        [DataRow(2, 7)]
        [DataRow(3, 8)]
        [DataRow(4, 4)]
        [DataRow(5, 6)]
        [DataRow(6, 3)]
        [DataRow(7, 5)]
        [DataRow(8, 1)]
        public void GetWeightFactor_EightDigit_Test(int input, int expect)
        {
            Assert.AreEqual(expect, WeightFactorHelper.Get_EightDigit(input));
        }

        [TestMethod]
        [DataRow(1, 10)]
        [DataRow(2, 7)]
        [DataRow(3, 8)]
        [DataRow(4, 4)]
        [DataRow(5, 6)]
        [DataRow(6, 3)]
        [DataRow(7, 5)]
        [DataRow(8, 2)]
        [DataRow(9, 1)]
        public void GetWeightFactor_NineDigit_Test(int input, int expect)
        {
            Assert.AreEqual(expect, WeightFactorHelper.Get_NineDigit(input));
        }

        #endregion Public Methods
    }
}