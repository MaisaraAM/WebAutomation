using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using WebDriver.Utilities;
using By = WebDriver.Utilities.ElementFactory.by;

namespace MaisaraTest.Pages
{
    public class SendMsgPage : TestFixtureBase
    {
        private IWebDriver _webdriver;
        WebUIActions webUIActions;
        WebWaits webWaits;

        WebUIElement homeIcon = new WebUIElement(By.CssSelector, ".logo-text:nth-child(22)");
        WebUIElement contactName = new WebUIElement(By.Id, "contactName");
        WebUIElement openRequestMenu = new WebUIElement(By.CssSelector, "#contactRequestType-button > span.ui-selectmenu-text");
        WebUIElement requestType = new WebUIElement(By.ClassName, "ui-menu-item-wrapper");
        WebUIElement contactEmail = new WebUIElement(By.Id, "contactEmail");
        WebUIElement openCodesMenu = new WebUIElement(By.CssSelector, "#country-code > ul > li.dropdown__selected");
        WebUIElement countryCode = new WebUIElement(By.ClassName, "dropdown__list-item");
        WebUIElement phoneNumber = new WebUIElement(By.Id, "contactMobileNumber");
        WebUIElement textDescription = new WebUIElement(By.Id, "contactDescription");

        public SendMsgPage(IWebDriver webdriver)
        {
            this._webdriver = webdriver;
            webUIActions = new WebUIActions(webdriver);
            webWaits = new WebWaits(webdriver);
        }

        public void sendName(string name)
        {
            webUIActions.setText(contactName, name);
        }

        public void selectRequest(string request)
        {
            webUIActions.clickOnElement(openRequestMenu);
            webUIActions.clickOnGridItemByItsText(requestType, request);           
        }

        public void sendEmail(string email)
        {
            webUIActions.setText(contactEmail, email);
        }

        public void selectCountry(string country)
        {
            webUIActions.clickOnElement(openCodesMenu);
            webUIActions.clickOnGridItemByItsText(countryCode, country);
        }

        public void sendPhoneNumber(string phoneNum)
        {
            webUIActions.setText(phoneNumber, phoneNum);
        }

        public void sendDescription(string description)
        {
            webUIActions.setText(textDescription, description);
        }

        public void sendMsg(string name, string request, string email, string country, string phoneNum, string description)
        {
            webWaits.WaitTillToUIElementPresent(homeIcon);

            ContactUsPage contactUsPage = new ContactUsPage(_webdriver);
            contactUsPage.sendMsgClick();

            webWaits.WaitTillToUIElementPresent(homeIcon);

            sendName(name);
            selectRequest(request);
            sendEmail(email);
            selectCountry(country);
            sendPhoneNumber(phoneNum);
            sendDescription(description);
        }
    }
}
