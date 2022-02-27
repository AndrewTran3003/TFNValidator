using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFNValidator.Helpers;

namespace TFNValidator_Test
{
    [TestClass]
    public class StringHelper_Test
    {
        #region Public Methods

        [TestMethod]
        [DataRow("648 188 480", "648188480")]
        [DataRow("648 188    499", "648188499")]
        [DataRow("  648 188 519  ", "648188519")]
        public void RemoveWhiteSpace_Test(string input, string expect)
        {
            Assert.AreEqual(expect, StringHelper.RemoveWhiteSpace(input));
        }

        #endregion Public Methods
    }
}