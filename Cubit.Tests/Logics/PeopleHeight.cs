using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Cubit.Data.People;

namespace Cubit.Tests
{
    [TestClass]
    public class PeopleHeight
    {
        [TestMethod]
        public void Angles_Height()
        {
            double expected = 17.25;

            var person = new Angle() { Age = 35 };

            Assert.AreEqual(expected, person.Height);
        }

        [TestMethod]
        public void Saxons_Height()
        {
            double expected = 17.25;

            var person = new Saxon() { Age = 35 };

            Assert.AreEqual(expected, person.Height);
        }

        [TestMethod]
        public void Jutes_Height()
        {
            double expected = 28.00;

            var person = new Jute() { Age = 35 };

            Assert.AreEqual(expected, person.Height);
        }

        [TestMethod]
        public void Asian_Height()
        {
            double expected = 10.21;

            var person = new Asian() { Age = 35 };

            Assert.AreEqual(expected, person.Height);
        }
    
    }
}
