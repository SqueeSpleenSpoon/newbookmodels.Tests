using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;


namespace Newbookmodels.Tests
{
    class LogOutTest : AuthorizationTest
    {
        private IWebDriver _webDriver;
      
        [Test]
        public void LogOut()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email = _webDriver.FindElement(By.CssSelector("[type = email]"));
            email.SendKeys("nebayig768@laraskey.com");

            var password = _webDriver.FindElement(By.CssSelector("[type = password]"));
            password.SendKeys("12345QWERTy_");

            var logInButton = _webDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            logInButton.Click();

            var avatar = _webDriver.FindElement(By.CssSelector("[class^=AvatarClient__avatar]"));
            avatar.Click();

            var logOut = _webDriver.FindElement(By.CssSelector("div[class*= link_type_logout]"));
            logOut.Click(); 

            var actualResult = _webDriver.Url;

            Assert.AreEqual("https://newbookmodels.com/auth/signin", actualResult);
        }
    }
}
