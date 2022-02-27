﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFNValidator.Helpers;
using TFNValidator.Model;

namespace TFNValidator_Test
{
    [TestClass]
    public class LinkedValueHelper_Test
    {
        #region Public Methods

        [TestMethod]
        [DataRow("123456789", "123459876", true)]
        [DataRow("123459876", "443459871", true)]
        [DataRow("598756789", "443459871", true)]
        [DataRow("598755221", "44345987123", true)]
        [DataRow("123456789", "443459871", false)]
        [DataRow("123456789", "98765432", false)]
        [DataRow("98765987123", "598755221", true)]
        [DataRow("98765987123", "123456789", false)]
        [DataRow("598755221", "123456789", false)]
        public void IsLinked_Test(string string1, string string2, bool expect)
        {
            Assert.AreEqual(expect, LinkedValueHelper.IsLinked(string1, string2));
        }
        [TestMethod]

        [DynamicData(nameof(GetDataEntriesLast30Seconds_Date))]
        public void GetDataEntriesLast30Seconds_Test(List<RequestEntry> input, int expect)
        {
            Assert.AreEqual(expect,LinkedValueHelper.GetDataEntriesLast30Seconds(input).Count);
        }
        private static IEnumerable<object[]> GetDataEntriesLast30Seconds_Date
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
                        },
                        new ()
                        {
                            Id = new Guid(),
                            Value = "443459871",
                            DateSubmitted = DateTime.Now.AddSeconds(-35)
                        },
                        new ()
                        {
                            Id = new Guid(),
                            Value = "443459871",
                            DateSubmitted = DateTime.Now.AddSeconds(-38)
                        },
                        new ()
                        {
                            Id = new Guid(),
                            Value = "443459871",
                            DateSubmitted = DateTime.Now.AddSeconds(-40)
                        }
                    },
                    3
                };
            }
        }
        #endregion Public Methods
    }
}