using TechTalk.SpecFlow;
using LinkGroup.DemoTests.LinkGroupPOM;

namespace LinkGroup.DemoTests.StepDefinitions
{
    [Binding]
    internal class LinkGroupSteps
    {

        LinkGroupPage Page = new LinkGroupPage();
        private string homePageUrl = "https://www.linkgroup.com/";

        [When(@"I open the home page (.*)")]
        public void WhenIOpenTheHomePage(string url)
        {
            Page.LoadUrl(url);
        }

        [Then(@"the page is displayed")]
        public void ThenThePageIsDisplayed()
        {
            Page.ForThePageIsDisplayed();
        }


        [Given(@"I have opened the home page")]
         public void GivenIHaveOpenedTheHomePage()
        {
            Page.LoadUrl(homePageUrl);
        }

        [Given(@"I have agreed to the cookie policy")]
        public void GivenIHaveAgreedToTheCookiePolicy()
        {
            Page.AcceptCookie();
        }

        [When(@"I select Contact")]
        public void WhenISelectContact()
        {
            Page.SelectContact();
        }

        [Then(@"the Contact page is displayed")]
        public void ThenTheContactPageIsDisplayed()
        {
            Page.ForTheContactIsDisplayed();
        }

    }
}
