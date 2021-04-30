using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
namespace Newbookmodels.Tests
{
    class AuthorizationTest
    {
        private IWebDriver _webDriver;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);         
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        public void Authorization()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email = _webDriver.FindElement(By.CssSelector("[type = email]"));
            email.SendKeys("nebayig768@laraskey.com");  

            var password = _webDriver.FindElement(By.CssSelector("[type = password]"));
            password.SendKeys("12345QWERTy_"); 

            var LogInButton = _webDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            LogInButton.Click();

            var actualResult = _webDriver.Url;

            Assert.AreEqual("https://newbookmodels.com/explore", actualResult);
        }

    }
}
