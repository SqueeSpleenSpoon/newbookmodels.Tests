using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace Newbookmodels.Tests
{
    class ProfileEditTests : AuthorizationTest
    {
        private IWebDriver _webDriver;

        [Test]
        public void AddCard()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");

            var email = _webDriver.FindElement(By.CssSelector("[type = email]"));
            email.SendKeys("nebayig768@laraskey.com");

            var password = _webDriver.FindElement(By.CssSelector("[type = password]"));
            password.SendKeys("12345QWERTy_");

            var logInButton = _webDriver.FindElement(By.CssSelector("button[class^= SignInForm]"));
            logInButton.Click();

            var avatar = _webDriver.FindElement(By.CssSelector("div[class*= link_type_logout]"));
            avatar.Click();
            
            var card = _webDriver.FindElement(By.CssSelector("[placeholder^=Card]"));
            card.SendKeys("3566000020000410");

            var fullName = _webDriver.FindElement(By.CssSelector("[class*=input__self]"));
            fullName.SendKeys("JOHN TRAVOLTA");

            var termins = _webDriver.FindElement(By.CssSelector("input[autocomplete = cc - exp]"));
            termins.SendKeys("0223"); 

            var cvc = _webDriver.FindElement(By.CssSelector("input[autocomplete = cc - csc]"));
            termins.SendKeys("123");

            var saveButton = _webDriver.FindElements(By.CssSelector("[class*=button_type_default]"))[1];
            saveButton.Click();


           //  Assert.AreEqual("https://newbookmodels.com/auth/signin", actualResult);
        }
        [Test]
        public void ChengePrimaryAccountHolderName()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");

            var edit = _webDriver.FindElements(By.CssSelector("[class=edit-switcher__icon_type_edit]"))[0];
            edit.Click();

            var name = _webDriver.FindElements(By.CssSelector("input[class*=nput__self_type_text-underline]"))[0];
            name.Clear();
            name.SendKeys("John");

            var lastName = _webDriver.FindElements(By.CssSelector("input[class*=nput__self_type_text-underline]"))[1];
            lastName.Clear();
            lastName.SendKeys("Travis");

            var saveChanges = _webDriver.FindElements(By.CssSelector("button[class*=button_type_default]"))[0];
            saveChanges.Click();

            var actualResult = _webDriver.FindElements(By.CssSelector("[class=paragraph_type_gray]"))[1].Text.Trim();

            Assert.AreEqual("John Travis", actualResult);
        }
        [Test]
        public void ChengeCompanyLocation()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");

            var edit = _webDriver.FindElements(By.CssSelector("[class=edit-switcher__icon_type_edit]"))[0];
            edit.Click();

            var companyLocation = _webDriver.FindElements(By.CssSelector("input[class*=nput__self_type_text-underline]"))[2];
            companyLocation.Clear();
            companyLocation.SendKeys("b");
            _webDriver.FindElement(By.CssSelector("[class = 'pac-item-query']")).Click();

            var saveChanges = _webDriver.FindElements(By.CssSelector("button[class*=button_type_default]"))[0];
            saveChanges.Click();

            var actualResult = _webDriver.FindElements(By.CssSelector("[class=paragraph_type_gray]"))[2].Text.Trim();

            Assert.AreEqual("Бостон, Массачусетс, Сполучені Штати Америки", actualResult);
        }
        [Test]
        public void ChengeIndustry()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");

            var edit = _webDriver.FindElements(By.CssSelector("[class=edit-switcher__icon_type_edit]"))[0];
            edit.Click();

            var industry = _webDriver.FindElements(By.CssSelector("input[class*=nput__self_type_text-underline]"))[3];
            industry.Clear();
            industry.SendKeys("Education");

            var saveChanges = _webDriver.FindElements(By.CssSelector("button[class*=button_type_default]"))[0];
            saveChanges.Click();

            var actualResult = _webDriver.FindElements(By.CssSelector("[class=paragraph_type_gray]"))[3].Text.Trim();

            Assert.AreEqual("Education", actualResult);
        }

        [Test]
        public void ChangeEmail()
        {
            var edit = _webDriver.FindElements(By.CssSelector("[class=edit-switcher__icon_type_edit]"))[1];
            edit.Click();

            var password = _webDriver.FindElement(By.CssSelector("[class*=input__self_type_password-underline]"));
            password.SendKeys("12345QWERTy_");

            var newEmail = _webDriver.FindElements(By.CssSelector("[class*=input__self_type_text-underline]"))[0];
            newEmail.SendKeys("john_travis1996@gmail.com");

            var saveChanges = _webDriver.FindElements(By.CssSelector("[class*=button_type_default]"))[0];
             saveChanges.Click();

            var actualResult = _webDriver.FindElements(By.CssSelector("[class*=font-weight-bold]"))[0].Text.Trim();

            Assert.AreEqual("john_travis1996@gmail.com", actualResult);
        }
    }
}
