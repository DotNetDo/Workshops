using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopDemo
{
    public class WebDriver
    {
        public ChromeDriver instance { get; set; }
        public WebDriverWait wait { get; set; }

        public WebDriver()
        {
            instance = new ChromeDriver();
            wait = new WebDriverWait(instance, TimeSpan.FromSeconds(20));
        }

        public void Navigate(string url)
        {
            instance.Navigate().GoToUrl(url);
        }
    }
}
