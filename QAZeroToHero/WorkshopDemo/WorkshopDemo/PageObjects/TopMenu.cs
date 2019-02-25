using OpenQA.Selenium;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkshopDemo.PageObjects
{
    internal class TopMenu
    {
        private WebDriver driver;

        IWebElement TwitterIcon => driver.wait.Until(EC.ElementToBeClickable(By.LinkText("Twitter")));
        IWebElement LinkedInIcon => driver.wait.Until(EC.ElementToBeClickable(By.LinkText("LinkedIn")));
        IWebElement HomeLink => driver.wait.Until(EC.ElementToBeClickable(By.Id("menu-item-14")));
        IWebElement AboutMeLink => driver.wait.Until(EC.ElementToBeClickable(By.Id("menu-item-18")));
        IWebElement SearchTextbox => driver.wait.Until(EC.ElementToBeClickable(By.ClassName("search-field")));
        IWebElement SearchButton => driver.wait.Until(EC.ElementToBeClickable(By.ClassName("search-submit")));

        public TopMenu(WebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickTwitterIcon()
        {
            TwitterIcon.Click();
            Assert.IsTrue(driver.instance.Title.Contains("Twitter"), "Twitter site didn't show up.");
        }

        internal void ClickLinkedInIcon()
        {
            LinkedInIcon.Click();
            Assert.IsTrue(driver.instance.Title.Contains("LinkedIn"), "LinkedIn site didn't show up.");
        }

        internal void ClickHomeLink()
        {
            HomeLink.Click();
            Assert.IsTrue(driver.instance.Title.Contains("QA Boy"), "QA Boy site didn't show up.");
        }

        internal void ClickAboutMeLink()
        {
            AboutMeLink.Click();
            Assert.IsTrue(driver.instance.Title.Contains("About Me"), "About Me site didn't show up.");
        }

        internal void SearchPost(string samplePost)
        {
            SearchTextbox.SendKeys(samplePost);
            SearchButton.Click();
            Assert.IsTrue(driver.instance.Title.Contains("You searched for"), "Search site didn't show up.");
        }
    }
}