using Mars_QA_Specflow_T1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mars_QA_Specflow_T1.Pages
{
    class Education
    {
        // Add education details
        internal void AddEducation(IWebDriver driver, string country, string title, string year)
        {
            //Thread.Sleep(5000);
            Wait.WaitForElement(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5000);
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

            //Thread.Sleep(1000);
            Wait.WaitForElement(driver, "XPath", "//input[@value='Add']", 1000);
            //click on add education
            IWebElement addnew = driver.FindElement(By.XPath("//input[@value='Add']"));
            addnew.Click();


        }

        // addeducation validation

        internal void IsEducationAdded(IWebDriver driver)
        {
            //Thread.Sleep(1000);
            Wait.WaitForElement(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]", 1000);
            IWebElement eduVal = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            if (eduVal.Text == "India")
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
            //Thread.Sleep(5000);
            Wait.WaitForElement(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5000);
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

        // validate updated educational details
        internal void IsEducationUpdated(IWebDriver driver)
        {
            //Thread.Sleep(1000);
            Wait.WaitForElement(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]", 1000);
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

        //Delete educational details
        internal void DeleteEducation(IWebDriver driver)
        {
            //Thread.Sleep(5000);
            Wait.WaitForElementVisibility(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
            //click on education
            IWebElement edu = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            edu.Click();
            
            // Thread.Sleep(20000);
            Wait.WaitForElement(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 20000);
            try
            {
                //Select education to delete
                IWebElement eduToDel = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                eduToDel.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("canot able to locate element", ex.Message);
            }
            Wait.WaitForElement(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[2]/i", 20000);
           //click on delete cross button
           IWebElement cross = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[2]/i"));
            cross.Click();
        }

        
        //validate deleted successfully or not
        internal void IsEducationDeleted(IWebDriver driver)
        {
            //Thread.Sleep(10000);
            Wait.WaitForElement(driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]", 1000);
            //Select language to delete
            IWebElement deledu = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
            if (deledu.Text != "M.Tech")
            {
                Console.WriteLine("Education deleted succesfully");

            }
            else
            {
                Console.WriteLine("Education is not deleted sucessfully");
            }
        }
    }
}
