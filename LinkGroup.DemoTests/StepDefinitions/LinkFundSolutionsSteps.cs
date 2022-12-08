using LinkGroup.DemoTests.LinkGroupPOM;
using System;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests.StepDefinitions
{
    [Binding]
    internal class LinkFundSolutionsSteps
    {
        LinkFundSolutionsPage Page = new LinkFundSolutionsPage(); 

        [Given(@"I have opened the Found Solutions page")]
        public void GivenIHaveOpenedTheFoundSolutionsPage()
        {
            Page.LoadUrl();
        }

        [When(@"I view Funds")]
        public void WhenIViewFunds()
        {
            Page.ViewFund();
        }

        [Then(@"I can select the investment managers for (.*) investors")]
        public void ThenICanSelectTheInvestmentManagersForUKInvestors(string country)
        {
            switch (country)
            {
                case "UK":
                    Page.SelectUK();
                    break;
                case "Irish":
                    Page.SelectIrish();
                    break;
                case "Swiss":
                    Page.SelectSwiss();
                    break;
                default: throw new Exception("Country not defined");
            }

        }
    }
}