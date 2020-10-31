using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Mars_QA_Specflow_T1.Pages
{
    class ProfilePage
    {



        // Add language
        internal void AddLanguage(IWebDriver driver)
        {
            Thread.Sleep(10000);

            
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

            Thread.Sleep(10000);
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
            Thread.Sleep(5000);

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
            Thread.Sleep(20000);
            try
            {
                //Select language to delete
                IWebElement lanToDel = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
                lanToDel.Click();
            }
            catch(Exception ex)
            {
                Console.WriteLine("canot able to locate element", ex.Message);
            }
            //click on delete cross button
            IWebElement cross = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            cross.Click();
        }

      

        //Delete language validation
        internal void IsLanguageDeleted(IWebDriver driver)
        {
            Thread.Sleep(10000);
            //Select language to delete
            IWebElement del = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            if (del.Text != "English")
            {
                Console.WriteLine("Language deleted succesfully");

            }
            else
            {
                Console.WriteLine("language is not deleted sucessfully");
            }
               

        }

        // Add education details
        internal void AddEducation(IWebDriver driver, string country, string title, string year)
        {
            Thread.Sleep(5000);
            //click on education
            IWebElement addedu = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            addedu.Click();

            //click on add new education
            IWebElement addnewedu = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addnewedu.Click();

            //Add educational details--country from dropdown list
            IWebElement countrydpdn = driver.FindElement(By.Name("country"));
            countrydpdn.Click();
            new SelectElement(driver.FindElement(By.Name("country"))).SelectByText(country);


            //Add educational details -- title from drop list
            IWebElement titledpdn = driver.FindElement(By.Name("title"));
            titledpdn.Click();
            new SelectElement(driver.FindElement(By.Name("title"))).SelectByText(title);

            //Add educational details-- Year of graduation

            IWebElement yeardpdn = driver.FindElement(By.Name("yearOfGraduation"));
            yeardpdn.Click();
            new SelectElement(driver.FindElement(By.Name("yearOfGraduation"))).SelectByText(year);

            //input institute name
            IWebElement institute = driver.FindElement(By.Name("instituteName"));
            institute.SendKeys("Sree Buddhha College");
            //input degree
            IWebElement degree = driver.FindElement(By.Name("degree"));
            degree.SendKeys("EEE");

            Thread.Sleep(1000);
            //click on add education
            IWebElement addnew = driver.FindElement(By.XPath("//input[@value='Add']"));
            addnew.Click();

      
        }

        // addeducation validation

        internal void IsEducationAdded(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement eduVal = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            if(eduVal.Text == "India")
            {
                Console.WriteLine("Education details added successfully ");
            }
            else
            {
                Console.WriteLine("Education details are not added successfully ");
            }
        }

        //Update education details
        internal void UpdateEducation(IWebDriver driver, string titleName)
        {
            Thread.Sleep(5000);
            //click on education
            IWebElement updateedu = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            updateedu.Click();

            //click on update education
            IWebElement updateEdu = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            updateEdu.Click();

            //Update educational details -- title from drop list
            IWebElement titledn = driver.FindElement(By.Name("title"));
            titledn.Click();
            new SelectElement(driver.FindElement(By.Name("title"))).SelectByText(titleName);

            Thread.Sleep(1000);
            //click on update education
            IWebElement update = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            update.Click();

        }

        internal void IsEducationUpdated(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement eduUpVal = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            if (eduUpVal.Text == "M.Tech")
            {
                Console.WriteLine("Education details updated successfully ");
            }
            else
            {
                Console.WriteLine("Education details are not updated successfully ");
            }
        }



    }

}
