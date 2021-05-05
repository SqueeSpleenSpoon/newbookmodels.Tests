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
    class RegistrationTests : BasedTests
    {
        [Test]
        public void Registration()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));


            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/join");

            var firstName = WebDriver.FindElement(By.CssSelector("[name= first_name]"));
            firstName.SendKeys($"Valera{DateTime.Now.ToString("yyyyMMdhhmmss")}");

            var lastName = WebDriver.FindElement(By.CssSelector("[name= last_name]"));
            lastName.SendKeys(($"Zmih{DateTime.Now.ToString("yyyyMMdhhmmss")}"));

            var email = WebDriver.FindElement(By.CssSelector("[name= email]"));
            email.SendKeys($"{DateTime.Now.ToString("yyyyMMdhhmmss")}@ukr.net");

            var password = WebDriver.FindElement(By.CssSelector("[name= password]"));
            password.SendKeys("12345QWERTy_");

            var passwordConfirm = WebDriver.FindElement(By.CssSelector("[name= password_confirm]"));
            passwordConfirm.SendKeys("12345QWERTy_");

            var mobile = WebDriver.FindElement(By.CssSelector("[name=phone_number]"));
            mobile.SendKeys("5558883332");

            var nextButton = WebDriver.FindElement(By.CssSelector("[class^=SignupForm__submitButton]"));
            nextButton.Click();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/join/company"));

            var result = WebDriver.Url;
            
            Assert.AreEqual("https://newbookmodels.com/join/company", result);
        }
    }
}