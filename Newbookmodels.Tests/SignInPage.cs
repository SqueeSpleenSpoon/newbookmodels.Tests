using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbookmodels.Tests
{
    class SignInPage
    {
        private readonly IWebDriver _webDriver;

        private static readonly By _email = By.CssSelector("[type=email]");
        private static readonly By _password = By.CssSelector("[type=password]");
        private static readonly By _LogInButton = By.CssSelector("[class^=SignInForm__submitButton]");

        public SignInPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public SignInPage OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");
            return this;
        }

        public SignInPage SetEmail(string email)
        {
            _webDriver.FindElement(_email).SendKeys(email);
            return this;
        }

        public SignInPage SetPassword(string password)
        {
            _webDriver.FindElement(_password).SendKeys(password);
            return this;
        }

        public SignInPage ClickLogInButton()
        {
            _webDriver.FindElement(_LogInButton).Click();
            return this;
        }
    }
}
