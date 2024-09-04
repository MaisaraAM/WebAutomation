using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver.Utilities;
using By = WebDriver.Utilities.ElementFactory.by;

namespace MaisaraTest.Pages
{
    public class FaqPage : TestFixtureBase
    {
        private IWebDriver _webdriver;
        WebUIActions webUIActions;
        WebWaits webWaits;

        WebUIElement homeIcon = new WebUIElement(By.CssSelector, ".logo-text:nth-child(22)");
        WebUIElement faqButton1 = new WebUIElement(By.CssSelector, "#\\34 F1597B2B5314DCC851763C5EDD858F7 > button");
        WebUIElement faqButton2 = new WebUIElement(By.CssSelector, "#\\38 46993F04E8C4B6FB23CF5FEC2DC7F46 > button");
        WebUIElement faqButton3 = new WebUIElement(By.CssSelector, "#\\37 7D699DEFF6E49EFBF51A4BF4A76AA05 > button");
        WebUIElement faqButton4 = new WebUIElement(By.CssSelector, "#E7A77DBDC3EC42B8BF9FEB3C16D0F6B5 > button");
        WebUIElement faqButton5 = new WebUIElement(By.CssSelector, "#EE336F06766D4F43952027FAB23066CE > button");
       
        WebUIElement faqTab1Q = new WebUIElement(By.CssSelector, "#\\34 F1597B2B5314DCC851763C5EDD858F7 > div > div.mb-2.faq-question > span");
        WebUIElement faqTab1A = new WebUIElement(By.CssSelector, "#\\34 F1597B2B5314DCC851763C5EDD858F7 > div > div.question-content > div > p:nth-child(2)");
        
        WebUIElement faqTab2Q = new WebUIElement(By.CssSelector, "#\\38 46993F04E8C4B6FB23CF5FEC2DC7F46 > div > div.mb-2.faq-question > span");
        WebUIElement faqTab2A = new WebUIElement(By.CssSelector, "#\\38 46993F04E8C4B6FB23CF5FEC2DC7F46 > div > div.question-content > div > p:nth-child(2)");
        
        WebUIElement faqTab3Q = new WebUIElement(By.CssSelector, "#\\37 7D699DEFF6E49EFBF51A4BF4A76AA05 > div > div.mb-2.faq-question > span");
        WebUIElement faqTab3A = new WebUIElement(By.CssSelector, "#\\37 7D699DEFF6E49EFBF51A4BF4A76AA05 > div > div.question-content > div > p:nth-child(2)");
        
        WebUIElement faqTab4Q = new WebUIElement(By.CssSelector, "#E7A77DBDC3EC42B8BF9FEB3C16D0F6B5 > div > div.mb-2.faq-question > span");
        WebUIElement faqTab4A = new WebUIElement(By.CssSelector, "#E7A77DBDC3EC42B8BF9FEB3C16D0F6B5 > div > div.question-content > div > p:nth-child(2)");
        
        WebUIElement faqTab5Q = new WebUIElement(By.CssSelector, "#EE336F06766D4F43952027FAB23066CE > div > div.mb-2.faq-question > span");
        WebUIElement faqTab5A = new WebUIElement(By.CssSelector, "#EE336F06766D4F43952027FAB23066CE > div > div.question-content > div > p:nth-child(2)");

        public FaqPage(IWebDriver webdriver)
        {
            this._webdriver = webdriver;
            webUIActions = new WebUIActions(webdriver);
            webWaits = new WebWaits(webdriver);
        }

        public void faQ1()
        {
            webUIActions.getGridColumnValues(faqTab1Q);
            webUIActions.getGridColumnValues(faqTab1A);

            webUIActions.clickOnElement(faqButton1);
        }

        public void faQ2()
        {
            webUIActions.clickOnElement(faqButton2);

            webUIActions.getGridColumnValues(faqTab2Q);
            webUIActions.getGridColumnValues(faqTab2A);

            webUIActions.clickOnElement(faqButton2);
        }

        public void faQ3()
        {
            webUIActions.clickOnElement(faqButton3);

            webUIActions.getGridColumnValues(faqTab3Q);
            webUIActions.getGridColumnValues(faqTab3A);

            webUIActions.clickOnElement(faqButton3);
        }

        public void faQ4()
        {
            webUIActions.clickOnElement(faqButton4);

            webUIActions.getGridColumnValues(faqTab4Q);
            webUIActions.getGridColumnValues(faqTab4A);

            webUIActions.clickOnElement(faqButton4);
        }

        public void faQ5()
        {
            webUIActions.clickOnElement(faqButton5);

            webUIActions.getGridColumnValues(faqTab5Q);
            webUIActions.getGridColumnValues(faqTab5A);

            //webUIActions.clickOnElement(faqButton5);
        }

        public void getFaq()
        {
            webWaits.WaitTillToUIElementPresent(homeIcon);

            faQ1();
            faQ2();
            faQ3();
            faQ4();
            faQ5();
        }
    }
}
