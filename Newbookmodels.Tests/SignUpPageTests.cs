using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace Newbookmodels.Tests
{
    class SignUpPageTests
    {
        private IWebDriver _webDriver;
        private SignUpPage _signUpPage;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _signUpPage = new SignUpPage(_webDriver);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        public void Registration()
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));

            _signUpPage.OpenPage()
                .SetFirstName($"Valera{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetLastName($"Zmih{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetEmail($"{DateTime.Now.ToString("yyyyMMdhhmmss")}@ukr.net")
                .SetPassword("12345QWERTy_")
                .SetConfirmPassword("12345QWERTy_")
                .SetPhone("5558883332")
                .ClickNextButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/join/company"));

            var actualResult = _webDriver.Url;

            Assert.AreEqual("https://newbookmodels.com/join/company", actualResult);
        }

    }
}
