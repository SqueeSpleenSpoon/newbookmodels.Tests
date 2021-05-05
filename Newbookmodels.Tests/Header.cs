using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbookmodels.Tests
{
    public class Header
    {
        private readonly IWebDriver _webDriver;

        private static readonly By _avatar = By.CssSelector("[class^=AvatarClient__container]");
    }
}
