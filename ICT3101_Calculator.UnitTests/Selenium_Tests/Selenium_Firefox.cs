using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ICT3101_Calculator.UnitTests.Selenium_Tests
{
    class Selenium_Firefox
    {
        private string _testURL = "https://google.com";
        private IWebDriver _driver;

        [SetUp]
        public void Start_Browser()
        {
            //Setup local Selenium WebDriver
            FirefoxOptions option = new FirefoxOptions();
            option.AddArgument("--headless");
            String path = @"C:\Windows\Webdrivers";
            //String path = Directory.GetCurrentDirectory() + @"/../../../Selenium_Tests";
            //_driver = new FirefoxDriver(@"C:\Users\nicho\Documents\SIT_3101\Lab 1\ICT3101_Calculator.UnitTests\Selenium_Tests", option);
            _driver = new FirefoxDriver(path, option);
        }

        [Test]
        public void GoogleSubtract_WhenSubtracting2from6_ResultEquals4()
        {
            //Setup
            _driver.Url = _testURL;
            System.Threading.Thread.Sleep(1000);
            //Act
            IWebElement searchBox = _driver.FindElement(By.CssSelector("[name='q']"));
            searchBox.SendKeys("6-2" + Keys.Return);
            System.Threading.Thread.Sleep(1000);
            //Assert
            IWebElement calcAnswer = _driver.FindElement(By.Id("cwos"));
            Assert.That(calcAnswer.Text, Is.EqualTo("4"));
        }

        [TearDown]
        public void Close_Browser()
        {
            _driver.Quit();
        }
    }
}
