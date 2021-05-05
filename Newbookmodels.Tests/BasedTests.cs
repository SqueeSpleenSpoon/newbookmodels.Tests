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
    class BasedTests
    {
        protected IWebDriver WebDriver;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
