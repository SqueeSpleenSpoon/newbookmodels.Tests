using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace Newbookmodels.Tests
{
    class AccountSettingPageTests : BaseTestsClass
    {
       
        [Test]
        public void ChangeFirstName()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));

            SignUpPage.OpenPage()
                .SetFirstName($"Valera{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetLastName($"Zmih{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetEmail($"{DateTime.Now.ToString("yyyyMMdhhmmss")}@ukr.net")
                .SetPassword("12345QWERTy_")
                .SetConfirmPassword("12345QWERTy_")
                .SetPhone("5558883332")
                .ClickNextButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/join/company"));

            SignUpPage.SetCompanyName("Obolon")
                .SetCompanyUrl("https://obolon.ua/ua")
                .SetCompanyAddress("Boston, MA, USA")
                .SetIndustry()
                .CliclFinishButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/explore"));

            AccountSettingsPage.OpenPage()
                .ClickFirstEdit()
                .SetFirstName("Aboba")
                .ClickFirsSaveChanges();

            Thread.Sleep(2500);

            var actualResult = WebDriver.FindElements(By.CssSelector("nb-account-info-general-information .paragraph_type_gray"))[1].Text.Trim().Split(" ")[0];

            Assert.AreEqual("Aboba", actualResult);            
        }
        [Test]
        public void ChangeLastName()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));

            SignUpPage.OpenPage()
                .SetFirstName($"Valera{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetLastName($"Zmih{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetEmail($"{DateTime.Now.ToString("yyyyMMdhhmmss")}@ukr.net")
                .SetPassword("12345QWERTy_")
                .SetConfirmPassword("12345QWERTy_")
                .SetPhone("5558883332")
                .ClickNextButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/join/company"));

            SignUpPage.SetCompanyName("Obolon")
                .SetCompanyUrl("https://obolon.ua/ua")
                .SetCompanyAddress("Boston, MA, USA")
                .SetIndustry()
                .CliclFinishButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/explore"));

            AccountSettingsPage.OpenPage()
                .ClickFirstEdit()
                .SetLastName("Petrov")
                .ClickFirsSaveChanges();

            Thread.Sleep(2500);

            var actualResult = WebDriver.FindElements(By.CssSelector("nb-account-info-general-information .paragraph_type_gray"))[1].Text.Trim().Split(" ")[1];

            Assert.AreEqual("Petrov", actualResult);
        }
        
        [Test]
        public void ChangeCompanyLocation()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));

            SignUpPage.OpenPage()
                .SetFirstName($"Valera{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetLastName($"Zmih{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetEmail($"{DateTime.Now.ToString("yyyyMMdhhmmss")}@ukr.net")
                .SetPassword("12345QWERTy_")
                .SetConfirmPassword("12345QWERTy_")
                .SetPhone("5558883332")
                .ClickNextButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/join/company"));

            SignUpPage.SetCompanyName("Obolon")
                .SetCompanyUrl("https://obolon.ua/ua")
                .SetCompanyAddress("Boston, MA, USA")
                .SetIndustry()
                .CliclFinishButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/explore"));

            AccountSettingsPage.OpenPage()
               .ClickFirstEdit()
               .SetCompanyLocation("a")
               .ClickFirsSaveChanges();

            Thread.Sleep(2500);

            var actualResult = WebDriver.FindElements(By.CssSelector("nb-account-info-general-information .paragraph_type_gray"))[2].Text.Trim();

            Assert.AreEqual("Зона 51, Невада, Сполучені Штати Америки", actualResult);
        }

        [Test]
        public void ChangeIndustry()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));

            SignUpPage.OpenPage()
                .SetFirstName($"Valera{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetLastName($"Zmih{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetEmail($"{DateTime.Now.ToString("yyyyMMdhhmmss")}@ukr.net")
                .SetPassword("12345QWERTy_")
                .SetConfirmPassword("12345QWERTy_")
                .SetPhone("5558883332")
                .ClickNextButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/join/company"));

            SignUpPage.SetCompanyName("Obolon")
                .SetCompanyUrl("https://obolon.ua/ua")
                .SetCompanyAddress("Boston, MA, USA")
                .SetIndustry()
                .CliclFinishButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/explore"));

            AccountSettingsPage.OpenPage()
               .ClickFirstEdit()
               .SetIndustry("Education")
               .ClickFirsSaveChanges();

            Thread.Sleep(1500);

            var actualResult = WebDriver.FindElements(By.CssSelector("nb-account-info-general-information .paragraph_type_gray"))[3].Text.Trim();

            Assert.AreEqual("Education", actualResult);
        }

        [Test]
        public void ChangeEmail()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));

            SignUpPage.OpenPage()
                .SetFirstName($"Valera{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetLastName($"Zmih{DateTime.Now.ToString("yyyyMMdhhmmss")}")
                .SetEmail($"{DateTime.Now.ToString("yyyyMMdhhmmss")}@ukr.net")
                .SetPassword("12345QWERTy_")
                .SetConfirmPassword("12345QWERTy_")
                .SetPhone("5558883332")
                .ClickNextButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/join/company"));

            SignUpPage.SetCompanyName("Obolon")
                .SetCompanyUrl("https://obolon.ua/ua")
                .SetCompanyAddress("Boston, MA, USA")
                .SetIndustry()
                .CliclFinishButton();

            wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/explore"));

            AccountSettingsPage.OpenPage()
                .ClickSecondEdit()
                .SetPasswordForEmail("12345QWERTy_")
                .SetNewEmail("Egor_Ship1@ukr.net")
                .ClickSecondSaveChanges();

            Thread.Sleep(1500);

            var actualResult = WebDriver.FindElement(By.CssSelector("nb-account-info-email-address .font-weight-bold")).Text.Trim();

            Assert.AreEqual("Egor_Ship1@ukr.net", actualResult);
        }
    }
}
