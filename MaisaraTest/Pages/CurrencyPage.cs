using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebDriver.Utilities;
using By = WebDriver.Utilities.ElementFactory.by;

namespace MaisaraTest.Pages
{
    public class CurrencyPage : TestFixtureBase
    {
        private IWebDriver _webdriver;
        WebUIActions webUIActions;
        WebWaits webWaits;

        public string currBuyVal = "";

        WebUIElement homeIcon = new WebUIElement(By.CssSelector, ".logo-text:nth-child(22)");
        WebUIElement dateText = new WebUIElement(By.ClassName, "table-desc");

        public CurrencyPage(IWebDriver webdriver)
        {
            this._webdriver = webdriver;
            webUIActions = new WebUIActions(webdriver);
            webWaits = new WebWaits(webdriver);
        }

        public void currList(string curr, IWebDriver webdriver)
        {
            bool dateFound = false;
            int index = 1;
            string rowCurr = "";

            webWaits.WaitTillToUIElementPresent(homeIcon);

            string dateTextVal = webUIActions.getText(dateText);

            //////////////////////////
            dateFound = true;
            while (true)
            {
                rowCurr = webUIActions.getText(new WebUIElement(By.CssSelector, "tbody > tr:nth-child(" + index.ToString() + ") > td:nth-child(1)"));
                if (rowCurr.Trim() == curr)
                {
                    break;
                }
                index++;
            }

            currBuyVal = webUIActions.getText(new WebUIElement(By.CssSelector, "tbody > tr:nth-child(" + index.ToString() + ") > td:nth-child(2)"));
            Console.WriteLine("Buy Rate: " + currBuyVal);

            string currSellVal = webUIActions.getText(new WebUIElement(By.CssSelector, "tbody > tr:nth-child(" + index.ToString() + ") > td:nth-child(3)"));
            Console.WriteLine("Sell Rate: " + currSellVal);
        }
    }
}
