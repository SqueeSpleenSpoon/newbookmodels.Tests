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
        [Test]
        public void LogOut()
        {
            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email = WebDriver.FindElement(By.CssSelector("[type = email]"));
            email.SendKeys("nebayig768@laraskey.com");

            var password = WebDriver.FindElement(By.CssSelector("[type = password]"));
            password.SendKeys("12345QWERTy_");

            var logInButton = WebDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            logInButton.Click();

            var avatar = WebDriver.FindElement(By.CssSelector("[class^=AvatarClient__avatar]"));
            avatar.Click();

            var logOut = WebDriver.FindElement(By.CssSelector("div[class*= link_type_logout]"));
            logOut.Click(); 

            var actualResult = WebDriver.Url;

            Assert.AreEqual("https://newbookmodels.com/auth/signin", actualResult);
        }
    }
}
