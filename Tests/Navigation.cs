using DemoQA.Utilities.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.Tests
{
    public class NavigationToPages : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com");
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
