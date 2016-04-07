using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cubit;
using Cubit.Controllers;
using Cubit.Services;

namespace Cubit.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var pm = new PeopleManager();
            ViewResult result = controller.Index(pm) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


    }
}
