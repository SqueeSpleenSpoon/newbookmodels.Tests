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
    internal class BaseTestsClass
    {
        protected IWebDriver WebDriver;
        protected SignUpPage SignUpPage;
        protected AccountSettingsPage AccountSettingsPage;
        protected SignInPage SignInPage;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            SignUpPage = new SignUpPage(WebDriver);
            SignInPage = new SignInPage(WebDriver);
            AccountSettingsPage = new AccountSettingsPage(WebDriver);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
