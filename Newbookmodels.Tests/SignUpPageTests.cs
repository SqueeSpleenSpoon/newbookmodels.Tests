using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace Newbookmodels.Tests
{
    class SignUpPageTests : BaseTestsClass
    {        
        [Test]
        public void Registration()
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

            var actualResult = WebDriver.Url;

            Assert.AreEqual("https://newbookmodels.com/explore", actualResult);
        }

    }
}
