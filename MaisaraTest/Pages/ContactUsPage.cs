using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using WebDriver.Utilities;
using By = WebDriver.Utilities.ElementFactory.by;

namespace MaisaraTest.Pages
{
    public class ContactUsPage : TestFixtureBase
    {
        private IWebDriver _webdriver;
        WebUIActions webUIActions;
        WebWaits webWaits;

        WebUIElement homeIcon = new WebUIElement(By.CssSelector, ".logo-text:nth-child(22)");
        WebUIElement phone = new WebUIElement(By.CssSelector, "div.contact-desc > span > a");
        WebUIElement address = new WebUIElement(By.CssSelector, "section > div > div > div > div:nth-child(2) > div > span");
        WebUIElement sendMsgLink = new WebUIElement(By.CssSelector, "div>a[href*=\"/en/contact-us/send-message\"]");
        WebUIElement faq = new WebUIElement(By.CssSelector, "div>a[href*=\"/en/contact-us/website-faqs\"]");

        public ContactUsPage(IWebDriver webdriver)
        {
            this._webdriver = webdriver;
            webUIActions = new WebUIActions(webdriver);
            webWaits = new WebWaits(webdriver);
        }

        public string getPhone()
        {
            return webUIActions.getText(phone);
        }

        public string getAddress()
        {
            return webUIActions.getText(address);
        }

        public void sendMsgClick()
        {
            webUIActions.clickOnElement(sendMsgLink);
        }

        public void faqClick()
        {
            webUIActions.clickOnElement(faq);
        }

        public void contactUs()
        {
            webWaits.WaitTillToUIElementPresent(homeIcon);

            getPhone();
            getAddress();
            sendMsgClick();

            webWaits.WaitTillToUIElementPresent(homeIcon);

            _webdriver.Navigate().Back();
            _webdriver.Navigate().Back();

            webWaits.WaitTillToUIElementPresent(homeIcon);

            faqClick();

            webWaits.WaitTillToUIElementPresent(homeIcon);
        }
    }
}
