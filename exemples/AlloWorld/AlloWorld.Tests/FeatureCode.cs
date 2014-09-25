using AlloWorld.SharedCode;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AlloWorld.Tests
{
    [Binding]
    public class FeatureCode
    {
        IEnumerable<dynamic> contacts;
        private DialerModel dialerModel;
        private static IDialService service;

        [Given(@"I have the following Contacts :")]
        public void GivenIHaveTheFollowingContacts(Table table)
        {
            contacts = table.Rows.Select(row => new { 
                name = row["name"],
                number = row["number"]
            });
            dialerModel = new DialerModel(FakeDialService());
        }

        private static IDialService FakeDialService()
        {
            return service = Substitute.For<IDialService>();
        }

        [When(@"I select (.*)")]
        public void WhenISelect(string name)
        {
            dialerModel.Dial(name);
        }

        [Then(@"the dialed number is (.*)")]
        public void ThenTheDialedNumberIs(string number)
        {
            service.Dial(number).
        }

    }
}
