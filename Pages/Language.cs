using Mars_QA_Specflow_T1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Mars_QA_Specflow_T1.Pages
{
    class Language
    {



        // Add language
        internal void AddLanguage(IWebDriver driver)
        {
            //Thread.Sleep(10000);
            Wait.WaitForElementVisibility(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 10000);

            //click on add new language--1
            IWebElement newLang = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            newLang.Click(); 

            //input language
            IWebElement inputlangC = driver.FindElement(By.Name("name"));
            inputlangC.Click();
            IWebElement inputlang = driver.FindElement(By.Name("name"));
            inputlang.SendKeys("English");

            //select language level
            IWebElement langLevel = driver.FindElement(By.Name("level"));
            langLevel.Click();

            new SelectElement(driver.FindElement(By.Name("level"))).SelectByText("Conversational");
            
            //click on add
            IWebElement add = driver.FindElement(By.XPath("//input[@value='Add']"));
            add.Click();

            //Thread.Sleep(10000);
            Wait.WaitForElementVisibility(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 10000);
            //click on add new language--2
            IWebElement newLang1 = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            newLang1.Click();

            //input  second language
            IWebElement inputlangC1 = driver.FindElement(By.Name("name"));
            inputlangC1.Click();
            IWebElement inputlang1 = driver.FindElement(By.Name("name"));
            inputlang1.SendKeys("Malayalam");

            //select second language level
            IWebElement langLevel1 = driver.FindElement(By.Name("level"));
            langLevel1.Click();

            new SelectElement(driver.FindElement(By.Name("level"))).SelectByText("Native/Bilingual");

            //click on add
            IWebElement add1 = driver.FindElement(By.XPath("//input[@value='Add']"));
            add1.Click();
        }

        
      
        //Add language validation
        internal void IsLanguageAdded(IWebDriver driver)
        {
            //Thread.Sleep(5000);
            Wait.WaitForElementVisibility(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]", 5000);
            IWebElement addedelang = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            if (addedelang.Text == "English")
            {
                Console.WriteLine("Language added succesfully");
                
            }
            else
            {
                Console.WriteLine("New language is not added");
              
            }
        }

        

        ////using try-catch method
        // try
        //    {
        //     var languagecheck = "test";
        //     var levelcheck = "test";
        //languagecheck = driver.FindElement(By.XPath(".//table[@class=\"ui fixed table\"]/tbody/tr/td[text()='English']")).GetAttribute("textContent");
        //levelcheck = driver.FindElement(By.XPath(".//table[@class=\"ui fixed table\"]/tbody/tr/td[text()='Conversational']")).GetAttribute("textContent");

        //        Assert.That(languagecheck == "English" && levelcheck == "Conversational");
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.Fail("verify new language failed", ex.Message);
        //    }

        //Delete language
        internal void DeleteLanguage(IWebDriver driver)
        {
            // Thread.Sleep(20000);
            Wait.WaitForElement(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 20000);
            try
            {
                //Select language to delete
                IWebElement lanToDel = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                lanToDel.Click();
            }
            catch(Exception ex)
            {
                Console.WriteLine("canot able to locate element", ex.Message);
            }
            //click on delete cross button
            IWebElement cross = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i"));
            cross.Click();
        }

      

        //Delete language validation
        internal void IsLanguageDeleted(IWebDriver driver)
        {
            //Thread.Sleep(10000);
            Wait.WaitForElement(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
           //Select language to delete
           IWebElement del = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (del.Text != "Malayalam")
            {
                Console.WriteLine("Language deleted succesfully");

            }
            else
            {
                Console.WriteLine("Language is not deleted sucessfully");
            }
               

        }

        //Update language
        internal void UpdateLanguage(IWebDriver driver)
        {
            //click on language which is to be updated
            Wait.WaitForElementVisibility(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 10000);
            IWebElement updateLag = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            updateLag.Click();

            //click on update button corresponding to the language
            Wait.WaitForElementVisibility(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 1000);
            IWebElement update = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            update.Click();

            //update language from dropdown list

            //select language level
            IWebElement langLevel = driver.FindElement(By.Name("level"));
            langLevel.Click();

            new SelectElement(driver.FindElement(By.Name("level"))).SelectByText("Fluent");

            //click on update
            IWebElement add =driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            add.Click();


        }

        //Update language validation

        internal void IsLanguageUpdateed(IWebDriver driver)
        {
            Wait.WaitForElementVisibility(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]", 5000);
            IWebElement updatedlang = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            if (updatedlang.Text == "Fluent")
            {
                Console.WriteLine("Language updateded succesfully");

            }
            else
            {
                Console.WriteLine("Language is not updated");

            }

        }



    }

}
