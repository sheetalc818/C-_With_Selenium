
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FacebookBasicDemo.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
