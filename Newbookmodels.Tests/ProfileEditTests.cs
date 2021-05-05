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
    class ProfileEditTests : BasedTests
    {
        [Test]
        public void ChengePrimaryAccountHolderName()
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

            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");

            var edit = WebDriver.FindElements(By.CssSelector("[class=edit-switcher__icon_type_edit]"))[0];
            edit.Click();

            var name = WebDriver.FindElements(By.CssSelector("input[class*=nput__self_type_text-underline]"))[0];
            name.Clear();
            name.SendKeys("John");

            var lastName = WebDriver.FindElements(By.CssSelector("input[class*=nput__self_type_text-underline]"))[1];
            lastName.Clear();
            lastName.SendKeys("Travis");

            var saveChanges = WebDriver.FindElements(By.CssSelector("button[class*=button_type_default]"))[0];
            saveChanges.Click();

            Thread.Sleep(3000);
            var actualResult = WebDriver.FindElements(By.CssSelector("[class=paragraph_type_gray]"))[1].Text.Trim();

            Assert.AreEqual("John Travis", actualResult);
        }
        [Test]
        public void ChengeCompanyLocation()
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

            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");

            var edit = WebDriver.FindElements(By.CssSelector("[class=edit-switcher__icon_type_edit]"))[0];
            edit.Click();

            var companyLocation = WebDriver.FindElements(By.CssSelector("input[class*=nput__self_type_text-underline]"))[2];
            companyLocation.Clear();
            companyLocation.SendKeys("b");
            WebDriver.FindElement(By.CssSelector("[class = 'pac-item-query']")).Click();

            var saveChanges = WebDriver.FindElements(By.CssSelector("button[class*=button_type_default]"))[0];
            saveChanges.Click();

            Thread.Sleep(1500);

            var actualResult = WebDriver.FindElements(By.CssSelector("[class=paragraph_type_gray]"))[2].Text.Trim();

            Assert.AreEqual("Бостон, Массачусетс, Сполучені Штати Америки", actualResult);
        }
        [Test]
        public void ChengeIndustry()
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

            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");

            var edit = WebDriver.FindElements(By.CssSelector("[class=edit-switcher__icon_type_edit]"))[0];
            edit.Click();

            var industry = WebDriver.FindElements(By.CssSelector("input[class*=nput__self_type_text-underline]"))[3];
            industry.Clear();
            industry.SendKeys("Education");

            var saveChanges = WebDriver.FindElements(By.CssSelector("button[class*=button_type_default]"))[0];
            saveChanges.Click();

            Thread.Sleep(1500);

            var actualResult = WebDriver.FindElements(By.CssSelector("[class=paragraph_type_gray]"))[3].Text.Trim();

            Assert.AreEqual("Education", actualResult);
        }

        [Test]
        public void ChangeEmail()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email = WebDriver.FindElement(By.CssSelector("[type = email]"));
            email.SendKeys("jexon1992@gmail.com");

            var password1 = WebDriver.FindElement(By.CssSelector("[type = password]"));
            password1.SendKeys("12345QWERTy_");

            var LogInButton = WebDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            LogInButton.Click();

            wait.Until(ExpectedConditions.UrlContains("Fexplore"));

            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");

            var edit = WebDriver.FindElements(By.CssSelector("[class=edit-switcher__icon_type_edit]"))[1];
            edit.Click();

            var password = WebDriver.FindElement(By.CssSelector("[class*=input__self_type_password-underline]"));
            password.SendKeys("12345QWERTy_");

            var newEmail = WebDriver.FindElements(By.CssSelector("[class*=input__self_type_text-underline]"))[0];
            newEmail.SendKeys("john_travis1996@gmail.com");

            var saveChanges = WebDriver.FindElements(By.CssSelector("[class*=button_type_default]"))[0];
             saveChanges.Click();

            Thread.Sleep(1500);
            var actualResult = WebDriver.FindElements(By.CssSelector("[class*=font-weight-bold]"))[0].Text.Trim();

            Assert.AreEqual("john_travis1996@gmail.com", actualResult);
        }

        [Test]
        public void ChangePassword()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email1 = WebDriver.FindElement(By.CssSelector("[type = email]"));
            email1.SendKeys("john_travis1996@gmail.com");

            var password1 = WebDriver.FindElement(By.CssSelector("[type = password]"));
            password1.SendKeys("12345QWERTy_");

            var LogInButton1 = WebDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            LogInButton1.Click();

            wait.Until(ExpectedConditions.UrlContains("Fexplore"));

            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");

            var edit = WebDriver.FindElements(By.CssSelector("[class=edit-switcher__icon_type_edit]"))[2];
            edit.Click();

            var currentPassword = WebDriver.FindElement(By.CssSelector("input[placeholder*=Current]"));
            currentPassword.SendKeys("12345QWERTy_");

            var newPassword = WebDriver.FindElements(By.CssSelector("input[placeholder*=New]"))[0];
            newPassword.SendKeys("12345QWERTy_1");

            var retypeNewPassword = WebDriver.FindElements(By.CssSelector("input[placeholder*=New]"))[1];
            retypeNewPassword.SendKeys("12345QWERTy_1");
            

            var saveChanges = WebDriver.FindElements(By.CssSelector("button[class*=button_type_default]"))[1];
            saveChanges.Click();

            Thread.Sleep(1500);

            var logOut = WebDriver.FindElement(By.CssSelector("div[class*= link_type_logout]"));
            logOut.Click();

            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email = WebDriver.FindElement(By.CssSelector("[type = email]"));
            email.SendKeys("john_travis1996@gmail.com");

            var password = WebDriver.FindElement(By.CssSelector("[type = password]"));
            password.SendKeys("12345QWERTy_1");

            var LogInButton = WebDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            LogInButton.Click();

            Thread.Sleep(1000);

            var actualResult = WebDriver.Url;

            Assert.AreEqual("https://newbookmodels.com/explore", actualResult);
        }

        [Test]
        public void ChangePhone()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email1 = WebDriver.FindElement(By.CssSelector("[type = email]"));
            email1.SendKeys("john_travis1996@gmail.com");

            var password1 = WebDriver.FindElement(By.CssSelector("[type = password]"));
            password1.SendKeys("12345QWERTy_1");

            var LogInButton1 = WebDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            LogInButton1.Click();

            wait.Until(ExpectedConditions.UrlContains("Fexplore"));

            WebDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");

            var edit = WebDriver.FindElements(By.CssSelector("[class=edit-switcher__icon_type_edit]"))[3];
            edit.Click();

            var currentPassword = WebDriver.FindElements(By.CssSelector("input[class*=input__self ]"))[1];
            currentPassword.SendKeys("12345QWERTy_1"); 

            var newPhone = WebDriver.FindElements(By.CssSelector("input[class*=input__self_type_text-underline]"))[1];
            newPhone.SendKeys("3221488505");

            var saveChanges = WebDriver.FindElements(By.CssSelector("[class*=button_type_default]"))[2];
            saveChanges.Click();

            Thread.Sleep(1050);
            var actualResult = WebDriver.FindElements(By.CssSelector("span[class^=font]"))[1].Text.Trim();

            Assert.AreEqual("322.148.8505", actualResult);
        }
    }
}
