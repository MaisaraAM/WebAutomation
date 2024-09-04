using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Threading;
using WebDriver.Utilities;
using By = WebDriver.Utilities.ElementFactory.by;

namespace MaisaraTest.Pages
{
    public class Menu
    {
        private IWebDriver _webdriver;
        WebUIActions webUIActions;
        WebWaits webWaits;

        WebUIElement homeIcon = new WebUIElement(By.CssSelector, ".logo-text:nth-child(22)");

        public Menu(IWebDriver webdriver)
        {
            this._webdriver = webdriver;
            webUIActions = new WebUIActions(webdriver);
            webWaits = new WebWaits(webdriver);
        }

        public void menu1(string mainMenuItem) 
        {
            WebUIElement menu1Item = new WebUIElement(By.LinkText, mainMenuItem);

            webUIActions.moveToElement(menu1Item);
            Thread.Sleep(1000);
        }

        public void menu2(string subMenuItem)
        {
            WebUIElement menu2Item = new WebUIElement(By.LinkText, subMenuItem);

            webUIActions.moveToElement(menu2Item);
            Thread.Sleep(1000);
            webUIActions.moveToElementAndClick(menu2Item);
        }

        public void menu3(string subMenuItem, string subSubMenuItem)
        {
            WebUIElement menu2Item = new WebUIElement(By.LinkText, subMenuItem);
            WebUIElement menu3Item = new WebUIElement(By.LinkText, subSubMenuItem);

            webUIActions.moveToElement(menu2Item);
            Thread.Sleep(1000);
            webUIActions.moveToElementAndClick(menu3Item);
        }

        public void navigateMenu(string menu1Item, string menu2Item, string menu3Item = "")
        {
            webWaits.WaitTillToUIElementPresent(homeIcon);

            menu1(menu1Item);

            if (menu3Item.Length == 0)
            {
                menu2(menu2Item);
                webWaits.WaitTillToUIElementPresent(homeIcon);
            }
            else if (menu3Item.Length > 0)
            {
                menu3(menu2Item, menu3Item);
                webWaits.WaitTillToUIElementPresent(homeIcon);
            }
        }
    }
}
