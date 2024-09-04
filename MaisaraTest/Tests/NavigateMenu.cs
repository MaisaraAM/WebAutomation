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
    public class NavigateMenu : TestFixtureBase
    {
        static string Url = "";

        [Test]
        public void navigateMenu()
        {
            Url = "https://www.cbe.org.eg/en/contact-us";
            OpenBrowser(Url);

            Menu menu = new Menu(_webdriver);
            
            menu.navigateMenu("Explore", "Markets", "Money and Capital Markets");
        }
    }
}
