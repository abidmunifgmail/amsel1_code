using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Smoke Test")]
        public void TestCase1_LoginWithValidCrendentials()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("www.adactin.com/HotelApp");

            IWebElement my_userName = driver.FindElement(By.Id("username"));
            my_userName.SendKeys("abidtester");

            IWebElement my_password = driver.FindElement(By.Id("password"));
            my_password.SendKeys("tester");

            IWebElement submit_Btn = driver.FindElement(By.Id("login"));
            submit_Btn.Click();

            Thread.Sleep(5000);

            string welcomeMessage = driver.FindElement(By.Id("username_show")).GetAttribute("value");

            Assert.AreEqual(welcomeMessage, "Hello abidtester!");

            driver.Quit();
        }

        [TestMethod, TestCategory("Regression Test")]
        public void TestCase2_LoginWithInvalidCrendentials()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("www.adactin.com/HotelApp");

            IWebElement my_userName = driver.FindElement(By.Id("username"));
            my_userName.SendKeys("abidtester");

            IWebElement my_password = driver.FindElement(By.Id("password"));
            my_password.SendKeys("tester");

            IWebElement submit_Btn = driver.FindElement(By.Id("login"));
            submit_Btn.Click();

            Thread.Sleep(5000);

            string welcomeMessage = driver.FindElement(By.Id("username_show")).GetAttribute("value");

            Assert.AreEqual(welcomeMessage, "Hello abidtester!");

            driver.Quit();
        }

    }
}
