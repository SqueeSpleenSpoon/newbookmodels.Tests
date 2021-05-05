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
 
            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email = WebDriver.FindElement(By.CssSelector("[type = email]"));
            email.SendKeys("nebayig768@laraskey.com");  

            var password = WebDriver.FindElement(By.CssSelector("[type = password]"));
            password.SendKeys("12345QWERTy_"); 

            var LogInButton = WebDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            LogInButton.Click();

            var actualResult = WebDriver.Url;

            Assert.AreEqual("https://newbookmodels.com/explore", actualResult);
        }

    }
}
