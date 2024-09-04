using MaisaraTest.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaisaraTest.Tests
{
    public class OpenFaqPage : TestFixtureBase
    {
        static string Url = "";

        [Test]
        public void openFaqPage()
        {
            Url = "https://www.cbe.org.eg/en/contact-us/website-faqs";
            OpenBrowser(Url);

            
            FaqPage faqPage = new FaqPage(_webdriver);
            
            faqPage.getFaq();
        }
    }
}
