using Mars_QA_Specflow_T1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Mars_QA_Specflow_T1.Pages
{
    class LoginPage
    {
        internal void LoginSteps(IWebDriver driver)
        {
            //Launch browser and enter url
            driver.Navigate().GoToUrl("http://192.168.99.100:5000");

            // maximize web browser
            driver.Manage().Window.Maximize();

            //click on signin button
            IWebElement signin = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signin.Click();

            //enter users email address 
            IWebElement email = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            email.SendKeys("ishaansandeep@yahoo.com");
            
            //enter passward
            IWebElement passward = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passward.SendKeys("ishaansandeep");

            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            //Thread.Sleep(10000);
            try
            {
                Wait.WaitForElement(driver, "XPath", "//*[contains(text(),'Ishaan Sandeep')]", 10000);
                // check login is successfull
                var loginCheck = "test";
                loginCheck = driver.FindElement(By.XPath("//*[contains(text(),'Ishaan Sandeep')]")).GetAttribute("innerText");

                Assert.That(loginCheck == "Ishaan Sandeep");
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed at login step", ex.Message);
            }
        }
    }
}
