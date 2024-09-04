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
    [TestFixture]
    public class GetCurrencyRates : TestFixtureBase
    {
        static string Url = "";

        [SetUp]
        public void OpenBrowser()
        {
           // OpenBrowser(Url);
        }

        [Test]

        public void getCurrencyRates()
        {
            Url = "https://www.cbe.org.eg/en/economic-research/statistics/cbe-exchange-rates";
            OpenBrowser(Url);
            CurrencyPage currencyPage = new CurrencyPage(_webdriver);
            currencyPage.currList("US Dollar", _webdriver);
        }
    }
}
