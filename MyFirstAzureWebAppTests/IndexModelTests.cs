using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAzureWebApp.Pages;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAzureWebApp.Pages.Tests
{
    [TestClass()]
    public class IndexModelTests
    {
        readonly IndexModel _MyProperty;
        public IndexModelTests(IndexModel MyProperty) { 
            _MyProperty = MyProperty;
        }
        [TestMethod()]
        public void OnGetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddAdd_ByAdding_TwoNumber_return_sum_ofTwo_Number()
        {
            Assert.AreEqual(9, _MyProperty.Add(4, 5));
        }
    }
}