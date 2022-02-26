using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFNValidator.Helpers;
using TFNValidator.Model;
using TFNValidator.Services.Concrete;

namespace TFNValidator_Test
{
    [TestClass]
    public class LinkedValueHelper_Test
    {
        [TestMethod]
        [DataRow("123456789", "123459876", true)]
        [DataRow("123459876", "443459871", true)]
        [DataRow("598756789", "443459871", true)]
        [DataRow("598755221", "44345987123", true)]
        [DataRow("123456789", "443459871", false)]
        [DataRow("123456789", "98765432", false)]

        public void IsLinked_Test(string string1, string string2, bool expect)
        {
            Assert.AreEqual(expect, LinkedValueHelper.IsLinked(string1,string2));
        }
    }
    [TestClass]
    public class LinkedValuesValidator_Test
    {
        [TestMethod]

        [DynamicData(nameof(TestData))]
        public void AreThreeValuesLinked_Test(List<RequestEntry> input, bool expect)
        {
            LinkedValidator validator = new();
            Assert.AreEqual(expect, validator.Validate(input));
        }
        private static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[]
                {
                    new List<RequestEntry>
                    {
                        new ()
                        {
                            Id = new Guid(),
                            Value = "123456789",
                            DateSubmitted = DateTime.Parse("03/01/2009 05:42:00")
                        },
                        new ()
                        {
                            Id = new Guid(),
                            Value = "123459876",
                            DateSubmitted = DateTime.Parse("03/01/2009 05:42:05")
                        },
                        new ()
                        {
                            Id = new Guid(),
                            Value = "443459871",
                            DateSubmitted = DateTime.Parse("03/01/2009 05:42:10")
                        }
                    },
                    true
                };

            }
        }
    }
}
