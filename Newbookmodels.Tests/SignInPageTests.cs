using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Newbookmodels.Tests
{
    class SignInPageTests : BaseTestsClass
    {
        [Test]
        public void LogIn()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));

            SignInPage.OpenPage()
                .SetEmail("AFSAF@gmail.com")
                .SetPassword("12345QWERTy_")
                .ClickLogInButton();

            //wait.Until(ExpectedConditions.UrlMatches("https://newbookmodels.com/join/company?goBackUrl=%2Fexplore"));
            Thread.Sleep(1500);

            var actualResult = WebDriver.Url;

            Assert.AreEqual("https://newbookmodels.com/join/company?goBackUrl=%2Fexplore", actualResult);
        }
    }
}
