using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkshopDemo.PageObjects
{
    internal class HomeScreen
    {
        private WebDriver driver;

        private IWebElement Logo => driver.wait.Until(EC.ElementIsVisible(By.ClassName("custom-logo")));
        private IWebElement Title => driver.wait.Until(EC.ElementIsVisible(By.ClassName("site-title")));
        private IWebElement Slogan => driver.wait.Until(EC.ElementIsVisible(By.ClassName("site-description")));

        public HomeScreen(WebDriver driver)
        {
            this.driver = driver;
        }

        internal void ValidateSloganIsPresent()
        {
            Assert.IsTrue(Slogan.Displayed, "Slogan is not displayed.");
        }

        internal void ValidateLogoIsPresent()
        {
            Assert.IsTrue(Logo.Displayed, "Logo is not displayed.");
        }

        internal void ValidateTitleIsPresent()
        {
            Assert.IsTrue(Title.Displayed, "Title is not displayed.");
        }
    }
}