using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Newbookmodels.Tests
{
    class SignUpPage
    {
        private readonly IWebDriver _webDriver;

        private static readonly By _firstName = By.CssSelector("[name= first_name]");
        private static readonly By _lastName = By.CssSelector("[name= last_name]");
        private static readonly By _email = By.CssSelector("[name= email]");
        private static readonly By _password = By.CssSelector("[name= password]");
        private static readonly By _passwordConfirm = By.CssSelector("[name= password_confirm]");
        private static readonly By _phone = By.CssSelector("[name=phone_number]");
        private static readonly By _nextButton = By.CssSelector("[class^=SignupForm__submitButton]");
        private static readonly By _companyName = By.CssSelector("[placeholder='Creative Inc.']");
        private static readonly By _companyAddress = By.CssSelector("[placeholder='2459 Bentley Ave. Los Angeles CA 90025']");
        private static readonly By _companyUrl = By.CssSelector("[placeholder='creativeinc.com']");
        private static readonly By _industry = By.CssSelector("[placeholder='Select Industry']");
        private static readonly By _finishButton = By.CssSelector("button[class^=SignupCompanyForm__submitButton]");

        public SignUpPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public SignUpPage SetCompanyName(string name)
        {
            _webDriver.FindElement(_companyName).SendKeys(name);
            return this;
        }

        public SignUpPage SetCompanyUrl(string url)
        {
            _webDriver.FindElement(_companyUrl).SendKeys(url);
            return this;
        }

        public SignUpPage SetCompanyAddress(string address)
        {
            _webDriver.FindElement(_companyAddress).SendKeys(address);
            _webDriver.FindElement(By.CssSelector("[class = 'pac-item-query']")).Click();
            return this;
        }
        public SignUpPage SetIndustry()
        {
            _webDriver.FindElement(_industry).Click();
            Thread.Sleep(1000);
            _webDriver.FindElements(By.CssSelector("[class^=Select__optionText]"))[1].Click();
            return this;
        }
        public SignUpPage CliclFinishButton()
        {
            _webDriver.FindElement(_finishButton).Click();
            return this;
        }

        public SignUpPage OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join");
            return this;
        }
        public SignUpPage SetFirstName(string firstName)
        {
            _webDriver.FindElement(_firstName).SendKeys(firstName);
            return this;
        }
        public SignUpPage SetLastName(string lastName)
        {
            _webDriver.FindElement(_lastName).SendKeys(lastName);
            return this;
        }
        public SignUpPage SetEmail(string email)
        {
            _webDriver.FindElement(_email).SendKeys(email);
            return this;
        }
        public SignUpPage SetPassword(string password)
        {
            _webDriver.FindElement(_password).SendKeys(password);
            return this;
        }
        public SignUpPage SetConfirmPassword(string passwordConfirm)
        {
            _webDriver.FindElement(_passwordConfirm).SendKeys(passwordConfirm);
            return this;
        }
        public SignUpPage SetPhone(string phone)
        {
            _webDriver.FindElement(_phone).SendKeys(phone);
            return this;
        }
        public void ClickNextButton()
        {
            _webDriver.FindElement(_nextButton).Click();
        }
    }
}
