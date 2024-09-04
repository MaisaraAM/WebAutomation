using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Utilities;

namespace MaisaraTest
{
    public class TestFixtureBase
    {
        public IWebDriver _webdriver;

        WebDriverFactory webdriverFactory = new WebDriverFactory();
        WebDriverActions webdriverActions;

        public void OpenBrowser(string Url)
        {
            _webdriver = webdriverFactory.InitializeDriver(Url);
        }

        [TearDown]
        public void CloseBrowser()
        {
            webdriverFactory.CloseBrowser(_webdriver);
        }
    }
}
