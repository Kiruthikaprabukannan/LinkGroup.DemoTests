using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace LinkGroup.DemoTests.LinkGroupPOM
{
    public class LinkGroupPage
    {
        IWebDriver driver;
        private IWebElement PageLoGo => GetElement(By.Id("logo"));
        private IWebElement AllowCookie => GetElement(By.XPath("//*[@Class ='cc-btn cc-dismiss']"));
        private IWebElement Contact => GetElement(By.LinkText("Contact"));
        private IWebElement ContactHeader => GetElement(By.XPath("//*[@Class ='contentHeader']"));

        public void LoadUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        public void ForThePageIsDisplayed()
        {
            Assert.True(PageLoGo.Displayed, "Link group home page is not displayed");
            driver.Quit();
        }
        public void AcceptCookie()
        {
            AllowCookie.Click();
        }

        public void SelectContact()
        {
            Contact.Click();
        }
        public void ForTheContactIsDisplayed()
        {
            Assert.True(ContactHeader.Displayed, "Contact header is not displayed");
            driver.Quit();
        }
        private IWebElement GetElement(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }

    }
}
