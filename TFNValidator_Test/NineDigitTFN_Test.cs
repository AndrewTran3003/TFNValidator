using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFNValidator.Helpers;
using TFNValidator.Services.Concrete;

namespace TFNValidator_Test
{
    [TestClass]
    public class DigitHelper_Test
    {
        [TestMethod]

        [DataRow("648 188 480", "648188480")]
        [DataRow("648 188    499", "648188499")]
        [DataRow("  648 188 519  ", "648188519")]
        public void RemoveWhiteSpace_Test(string input, string expect)
        {
            Assert.AreEqual(expect, DigitHelper.RemoveWhiteSpace(input));
        }
        [TestMethod]
        [DataRow(1,10)]
        [DataRow(2, 7)]
        [DataRow(3, 8)]
        [DataRow(4, 4)]
        [DataRow(5, 6)]
        [DataRow(6, 3)]
        [DataRow(7, 5)]
        [DataRow(8, 2)]
        [DataRow(9, 1)]
        [DataRow(0, 0)]
        [DataRow(20, 0)]
        public void GetWeightFactor_NineDigit_Test(int input, int expect)
        {
            Assert.AreEqual(expect, DigitHelper.GetWeightFactor_NineDigit(input));
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
        [DataRow(9, 0)]
        [DataRow(0, 0)]
        [DataRow(20, 0)]
        public void GetWeightFactor_EightDigit_Test(int input, int expect)
        {
            Assert.AreEqual(expect, DigitHelper.GetWeightFactor_EightDigit(input));
        }

    }
    [TestClass]
    public class NineDigitTFN_Test
    {

        [TestMethod]
        [DataRow("648 188 480", false)]
        [DataRow("648 188 499", false)]
        [DataRow("648 188 519", false)]
        [DataRow("648 188 527", false)]
        [DataRow("648 188 535", true)]
        [DataRow("714 925 631", true)]

        public void IsTFNValid(string input, bool output)
        {
            NineDigitTFNValidator validator = new();
            Assert.AreEqual(output, validator.VerifyTFNNumber(input));
        }
    }
}
