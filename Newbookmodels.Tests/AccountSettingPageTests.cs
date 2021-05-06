using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace Newbookmodels.Tests
{
    class AccountSettingPageTests
    {
        private IWebDriver _webDriver;
        private AccountSettingsPage _accountSettingPage;
        private SignUpPage _signUpPage;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _accountSettingPage = new AccountSettingsPage(_webDriver);
            _signUpPage = new SignUpPage(_webDriver);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
        [Test]
        public void ChangeFirstName()
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

            _accountSettingPage.OpenPage()
                .ClickFirstEdit()
                .SetFirstName("Aboba")
                .ClickFirsSaveChanges();

            Thread.Sleep(500);

            var actualResult = _webDriver.FindElements(By.CssSelector("nb-account-info-general-information .paragraph_type_gray"))[1].Text.Trim();

            Assert.AreEqual("Aboba", actualResult);            
        }
    }
}
