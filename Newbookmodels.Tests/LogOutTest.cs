using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email = WebDriver.FindElement(By.CssSelector("[type = email]"));
            email.SendKeys("jexon1992@gmail.com");

            var password = WebDriver.FindElement(By.CssSelector("[type = password]"));
            password.SendKeys("12345QWERTy_");

            var LogInButton = WebDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            LogInButton.Click();

            wait.Until(ExpectedConditions.UrlContains("Fexplore"));

            var avatar = WebDriver.FindElement(By.CssSelector("[class^=AvatarClient__avatar]"));
            avatar.Click();

            var logOut = WebDriver.FindElement(By.CssSelector("div[class*= link_type_logout]"));
            logOut.Click(); 

            var actualResult = WebDriver.Url;

            Assert.AreEqual("https://newbookmodels.com/auth/signin", actualResult);
        }
    }
}
