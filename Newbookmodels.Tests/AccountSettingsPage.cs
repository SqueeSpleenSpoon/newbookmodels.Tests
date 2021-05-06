using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Newbookmodels.Tests
{
    class AccountSettingsPage
    {
        private readonly IWebDriver _webDriver;

        private static readonly By _firstEdit = By.CssSelector("nb-account-info-general-information .edit-switcher__icon_type_edit"); 
        private static readonly By _firstName = By.CssSelector("input[placeholder *= First]");
        private static readonly By _lastName = By.CssSelector("input[placeholder*=Last]");
        private static readonly By _companyLocation = By.CssSelector("input[placeholder*=Company]");
        private static readonly By _industry = By.CssSelector("input[placeholder*=Industry]");
        private static readonly By _firstSaveChanges = By.CssSelector("nb-account-info-general-information .button_type_default");

        public AccountSettingsPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public AccountSettingsPage OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");
            return this;
        }
        public AccountSettingsPage ClickFirstEdit()
        {
            _webDriver.FindElement(_firstEdit).Click();
            return this;
        }
        public AccountSettingsPage SetFirstName(string firstNane)
        {
            _webDriver.FindElement(_firstName).SendKeys(firstNane);
            return this;
        }
        public AccountSettingsPage SetLastName(string lastNane)
        {
            _webDriver.FindElement(_lastName).SendKeys(lastNane);
            return this;
        }
        public AccountSettingsPage SetCompanyLocation(string companyLocation)
        {
            _webDriver.FindElement(_companyLocation).SendKeys(companyLocation);
            Thread.Sleep(1000);
            _webDriver.FindElement(By.CssSelector("[class = 'pac-item-query']")).Click();
            return this;
        }
        public AccountSettingsPage SetIndustry(string industry)
        {
            _webDriver.FindElement(_industry).SendKeys(industry);
            return this;
        }
        public AccountSettingsPage ClickFirsSaveChanges()
        {
            _webDriver.FindElement(_firstSaveChanges).Click();
            return this;
        }
    }
}
