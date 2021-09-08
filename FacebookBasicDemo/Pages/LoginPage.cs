using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FacebookBasicDemo.Pages
{
    public class LoginPage
    {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            String title1 = "Facebook - लॉग इन किंवा साइन अप";
            String title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LoginToFacebook(IWebDriver driver)
        {
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("testingtestdatablz@gmail.com");

            IWebElement password = driver.FindElement(By.Id("pass"));
            password.SendKeys("testing123");

            IWebElement loginBt = driver.FindElement(By.Name("login"));
            loginBt.Click();
        }
        
    }
}
