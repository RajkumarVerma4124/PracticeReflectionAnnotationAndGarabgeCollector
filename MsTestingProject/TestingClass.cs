using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpression;
using System;

namespace MsTestingProject
{
    
    [TestClass]
    public class TestingClass
    {
        Program program = null;

        [TestInitialize]
        public void SetUp()
        {
            program = new Program();
        }

        [TestCategory("Addition")]
        [TestMethod]
        public void TestAdditionMethod()
        {
            ///AAA methodology
            ///Arange
            int first = 10, second = 20;
            int expectedValue = 30;

            ///Act
            int actual = program.Add(first, second);

            ///Assert
            Assert.AreEqual(expectedValue, actual);
        }

        [TestCategory("Subtraction")]
        [TestMethod]
        public void TestSubtractionMethod()
        {
            ///AAA methodology
            ///Arange
            int first = 30, second = 20;
            int expectedValue = 10;

            ///Act
            int actual = program.Subtract(first, second);

            ///Assert
            Assert.AreEqual(expectedValue, actual);
        }
    }
}
