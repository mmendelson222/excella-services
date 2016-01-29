using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using Services.Controllers;

namespace Services.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            DemoController controller = new DemoController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            DemoController controller = new DemoController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            DemoController controller = new DemoController();

            // Act
            controller.Factors(new Models.DemoInputModel()
            {
                 Count = 4, InputString = "hi"
            });

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            DemoController controller = new DemoController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            DemoController controller = new DemoController();

            // Act
            controller.Delete(5);
            // Assert
        }
    }
}

