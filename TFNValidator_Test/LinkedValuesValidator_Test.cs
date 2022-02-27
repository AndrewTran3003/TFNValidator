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
    public class LinkedValuesValidator_Test
    {
        [TestMethod]

        [DynamicData(nameof(AreThreeValuesLinked_Data))]
        public void AreThreeValuesLinked_Test(List<RequestEntry> input, bool expect)
        {
            LinkedValueValidator validator = new();
            Assert.AreEqual(expect, validator.Validate(input));
        }
        
        private static IEnumerable<object[]> AreThreeValuesLinked_Data
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
                            DateSubmitted = DateTime.Now.AddSeconds(-5)
                        },
                        new ()
                        {
                            Id = new Guid(),
                            Value = "123459876",
                            DateSubmitted = DateTime.Now.AddSeconds(-10)
                        },
                        new ()
                        {
                            Id = new Guid(),
                            Value = "443459871",
                            DateSubmitted = DateTime.Now.AddSeconds(-15)
                        }
                    },
                    true
                };

                yield return new object[]
                {
                    new List<RequestEntry>
                    {
                        new ()
                        {
                            Id = new Guid(),
                            Value = "98765987123",
                            DateSubmitted = DateTime.Parse("03/01/2009 05:42:00")
                        },
                        new ()
                        {
                            Id = new Guid(),
                            Value = "598755221",
                            DateSubmitted = DateTime.Parse("03/01/2009 05:42:05")
                        },
                        new ()
                        {
                            Id = new Guid(),
                            Value = "123456789",
                            DateSubmitted = DateTime.Parse("03/01/2009 05:42:10")
                        }
                    },
                    false
                };

            }
        }
    }
}
