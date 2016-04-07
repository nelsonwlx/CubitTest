using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cubit.Services;

namespace Cubit.Tests.Logics
{
    [TestClass]
    public class AddOneYear
    {
        [TestMethod]
        public void AddOneYearCheck()
        {
            var pm = new PeopleManager();

            var expected = pm.People[0].Age + 1;

            var newValue = pm.AddOneYearToAge()[0].Age;

            Assert.AreEqual(expected, newValue);

        
        }
    }
}
