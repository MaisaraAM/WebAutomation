using MaisaraTest.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaisaraTest.Tests
{
    public class OpenContactUsPage : TestFixtureBase
    {
        static string Url = "";

        [Test]
        public void openContactUsPage()
        {
            Url = "https://www.cbe.org.eg/en/contact-us";
            OpenBrowser(Url);

            ContactUsPage contactUsPage = new ContactUsPage(_webdriver);

            contactUsPage.contactUs();
        }
    }
}
