using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFNValidator.Helpers;
using TFNValidator.Services.Concrete;

namespace TFNValidator_Test
{
    

    [TestClass]
    public class TfnValidator_Test
    {

        [TestMethod]
        [DataRow("648 188 480", true)]
        [DataRow("648 188 48 1", false)]
        [DataRow("648 188 499", true)]
        [DataRow("648 188 519", true)]
        [DataRow("648 188 518", false)]
        [DataRow("648 188 527", true)]
        [DataRow("648 188 535", true)]
        [DataRow("714 925 631", true)]

        public void VerifyNineDigitTfn_Test(string input, bool expect)
        {
            TfnValidator validator = new();
            Assert.AreEqual(expect, validator.VerifyNineDigitTfn(input));
        }

        [TestMethod]
        [DataRow("37 118 629", true)]
        [DataRow("37 118  629  ", true)]
        [DataRow("37 118 628", false)]
        [DataRow("37 118 660", true)]
        [DataRow("37 118 661", false)]
        [DataRow("37 118 705", true)]
        [DataRow("38 593 474", true)]
        [DataRow("85 655 797", true)]

        public void VerifyEightDigitTfn_Test(string input, bool expect)
        {
            TfnValidator validator = new();
            Assert.AreEqual(expect, validator.VerifyEightDigitTfn(input));
        }
    }
}
