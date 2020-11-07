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
        internal void LoginSteps()
        {
            

            //click on signin button
            IWebElement signin = Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signin.Click();

            //enter users email address 
            IWebElement email = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            email.SendKeys("ishaansandeep@yahoo.com");
            
            //enter passward
            IWebElement passward = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passward.SendKeys("ishaansandeep");

            ////Click on Remember me
            
            //IWebElement Remember = Driver.driver.FindElement(By.Name("rememberDetails"));
            //Remember.Click();

            // click on login button
            IWebElement loginButton = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
           
            try
            {
                Wait.WaitForElement(Driver.driver, "XPath", "//*[contains(text(),'Ishaan Sandeep')]", 10000);
                // check login is successfull
                var loginCheck = "test";
                loginCheck = Driver.driver.FindElement(By.XPath("//*[contains(text(),'Ishaan Sandeep')]")).GetAttribute("innerText");

                Assert.That(loginCheck == "Ishaan Sandeep");
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed at login step", ex.Message);
            }
        }
    }
}
