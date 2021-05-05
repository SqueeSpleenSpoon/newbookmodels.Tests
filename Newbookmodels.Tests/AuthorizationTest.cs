using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
namespace Newbookmodels.Tests
{
    class AuthorizationTest : BasedTests
    {    
        [Test]
        public void Authorization()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email = WebDriver.FindElement(By.CssSelector("[type = email]"));
            email.SendKeys("jexon1992@gmail.com");  

            var password = WebDriver.FindElement(By.CssSelector("[type = password]"));
            password.SendKeys("12345QWERTy_"); 

            var LogInButton = WebDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            LogInButton.Click();

            wait.Until(ExpectedConditions.UrlContains("Fexplore"));

            var actualResult = WebDriver.Url;

            Assert.AreEqual("https://newbookmodels.com/join/company?goBackUrl=%2Fexplore", actualResult);
        }

    }
}
