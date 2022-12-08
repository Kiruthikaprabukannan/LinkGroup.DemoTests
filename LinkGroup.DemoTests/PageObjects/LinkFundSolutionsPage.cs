using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace LinkGroup.DemoTests.LinkGroupPOM
{
    public class LinkFundSolutionsPage
    {
        IWebDriver driver;
        private string url = "https://www.linkfundsolutions.co.uk/";
        private IWebElement Fund => driver.FindElement(By.Id("navItem-funds"));
        private IWebElement UK => driver.FindElement(By.XPath("//*[contains(text(),'UK')]"));
        private IWebElement Irish => driver.FindElement(By.XPath("//*[contains(text(),'Irish')]"));
        private IWebElement Swiss => driver.FindElement(By.XPath("//*[contains(text(),'Swiss')]"));
        private IWebElement InvestmentPage => driver.FindElement(By.Id("pageHero"));

        public void LoadUrl()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        public void ViewFund()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(Fund).Perform();
        }
        public void SelectUK()
        {
            UK.Click();
            Assert.True(InvestmentPage.Displayed);
            driver.Close();
        }
        public void SelectIrish()
        {
            Irish.Click();
            Assert.True(InvestmentPage.Displayed);
            driver.Close();
        }
        public void SelectSwiss()
        {
            Swiss.Click();
            Assert.True(InvestmentPage.Displayed);
            driver.Close();
        }
    }
}
