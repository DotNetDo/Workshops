using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopDemo.PageObjects;
using WorkshopDemo.Values;

namespace WorkshopDemo.TestCases
{
    [TestClass]
    public class QABoyHomePageTests
    {
        private WebDriver driver;

        [TestInitialize]
        public void Initialize()
        {
            driver = new WebDriver();
            driver.Navigate(Strings.BaseURL);
        }

        [TestMethod]
        public void TestHeaderComponents()
        {
            var homeScreen = new HomeScreen(driver);
            homeScreen.ValidateLogoIsPresent();
            homeScreen.ValidateTitleIsPresent();
            homeScreen.ValidateSloganIsPresent();
        }

        [TestMethod]
        public void TestTopMenuComponents()
        {
            var topMenu = new TopMenu(driver);
            topMenu.ClickTwitterIcon();
            driver.Navigate(Strings.BaseURL);
            topMenu.ClickLinkedInIcon();
            driver.Navigate(Strings.BaseURL);
            topMenu.ClickHomeLink();
            topMenu.ClickAboutMeLink();
            topMenu.SearchPost(Strings.SamplePost);
        }

        [TestMethod]
        public void TestUserSearchForValidPost()
        {
            var topMenu = new TopMenu(driver);
            topMenu.SearchPost(Strings.SamplePost);

            var searchScreen = new SearchScreen(driver);
            searchScreen.ValidateResults(Strings.SamplePost);
        }

        [TestMethod]
        public void TestUserSearchForInvalidPost()
        {
            var topMenu = new TopMenu(driver);
            topMenu.SearchPost(Strings.InvalidPost);

            var searchScreen = new SearchScreen(driver);
            searchScreen.ValidateNothingFoundError(Strings.InvalidPost);
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.instance.Quit();
        }
    }
}
