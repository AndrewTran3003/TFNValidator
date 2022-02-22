using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFNValidator.Services.Concrete;

namespace TFNValidator_Test
{
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
