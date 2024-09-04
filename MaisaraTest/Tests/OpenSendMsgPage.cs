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
    public class OpenSendMsgPage : TestFixtureBase
    {
        static string Url = "";

        [Test]
        public void openSendMsgPage()
        {
            Url = "https://www.cbe.org.eg/en/contact-us";
            OpenBrowser(Url);

            SendMsgPage sendMsgPage = new SendMsgPage(_webdriver);

            sendMsgPage.sendMsg("John Doe", "FinCIRT report an incident", "abc@abc.com", "Egypt +20", "1234567890", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac dignissim purus, eget posuere purus.");
        }
    }
}
