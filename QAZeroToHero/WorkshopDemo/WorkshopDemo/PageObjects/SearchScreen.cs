using OpenQA.Selenium;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkshopDemo.PageObjects
{
    internal class SearchScreen
    {
        private WebDriver driver;

        IWebElement Post;
        IWebElement NothingFoundError => driver.wait.Until(EC.ElementIsVisible(By.ClassName("search-nothing-found")));

        public SearchScreen(WebDriver driver)
        {
            this.driver = driver;
        }

        internal void ValidateResults(string samplePost)
        {
            Post = driver.wait.Until(EC.ElementToBeClickable(By.XPath("//h2/a[contains(text(), '" + samplePost + "')]")));
            Assert.IsTrue(Post.Displayed, "Searched Post is not displayed.");
        }

        internal void ValidateNothingFoundError(string invalidPost)
        {
            Assert.IsTrue(NothingFoundError.Displayed, "Nothing found error is not displayed."); 
        }
    }
}