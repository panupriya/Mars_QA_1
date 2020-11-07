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
        internal void AddEducation(string country, string title, string year)
        {
            //Thread.Sleep(5000);
            Wait.WaitForElement(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5000);
            //click on education
            IWebElement addedu = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            addedu.Click();

            //click on add new education
            IWebElement addnewedu = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addnewedu.Click();

            //Add educational details--country from dropdown list
            IWebElement countrydpdn = Driver.driver.FindElement(By.Name("country"));
            countrydpdn.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("country"))).SelectByText(country);


            //Add educational details -- title from drop list
            IWebElement titledpdn = Driver.driver.FindElement(By.Name("title"));
            titledpdn.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("title"))).SelectByText(title);

            //Add educational details-- Year of graduation

            IWebElement yeardpdn = Driver.driver.FindElement(By.Name("yearOfGraduation"));
            yeardpdn.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("yearOfGraduation"))).SelectByText(year);

            //input institute name
            IWebElement institute = Driver.driver.FindElement(By.Name("instituteName"));
            institute.SendKeys("Sree Buddhha College");
            //input degree
            IWebElement degree = Driver.driver.FindElement(By.Name("degree"));
            degree.SendKeys("EEE");

            //Thread.Sleep(1000);
            Wait.WaitForElement(Driver.driver, "XPath", "//input[@value='Add']", 1000);
            //click on add education
            IWebElement addnew = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            addnew.Click();

            //Add second educational details
            //click on add new education
           Wait.WaitForElement(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 5000);
           IWebElement addnewedu1 = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addnewedu1.Click();

            //Add  second educational details--country from dropdown list
            IWebElement countrydpdn1 = Driver.driver.FindElement(By.Name("country"));
            countrydpdn1.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("country"))).SelectByText("Australia");


            //Add  second educational details -- title from drop list
            IWebElement titledpdn1 = Driver.driver.FindElement(By.Name("title"));
            titledpdn1.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("title"))).SelectByText("M.B.A");

            //Add second educational details-- Year of graduation

            IWebElement yeardpdn1 = Driver.driver.FindElement(By.Name("yearOfGraduation"));
            yeardpdn1.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("yearOfGraduation"))).SelectByText("2020");

            //input institute name2
            IWebElement institute1 = Driver.driver.FindElement(By.Name("instituteName"));
            institute1.SendKeys("TAFE");
            //input second degree
            IWebElement degree1 = Driver.driver.FindElement(By.Name("degree"));
            degree1.SendKeys("Marketing");

            //Thread.Sleep(1000);
            Wait.WaitForElement(Driver.driver, "XPath", "//input[@value='Add']", 5000);
            //click on add education
            IWebElement addnew1 = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            addnew1.Click();


        }

        // addeducation validation

        internal void IsEducationAdded()
        {
            //Thread.Sleep(1000);
            Wait.WaitForElement(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]", 1000);
            IWebElement eduVal = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
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
        internal void UpdateEducation(string titleName)
        {
            //Thread.Sleep(5000);
            Wait.WaitForElement(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5000);
            //click on education
            IWebElement updateedu = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            updateedu.Click();

            //click on update education
            IWebElement updateEdu = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            updateEdu.Click();

            //Update educational details -- title from drop list
            IWebElement titledn = Driver.driver.FindElement(By.Name("title"));
            titledn.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("title"))).SelectByText(titleName);

            Thread.Sleep(1000);
            //click on update education
            IWebElement update = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            update.Click();

        }

        // validate updated educational details
        internal void IsEducationUpdated()
        {
            //Thread.Sleep(1000);
            Wait.WaitForElement(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]", 1000);
            IWebElement eduUpVal = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
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
        internal void DeleteEducation()
        {
            //Thread.Sleep(5000);
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
            //click on education
            IWebElement edu = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            edu.Click();
            
            // Thread.Sleep(20000);
            Wait.WaitForElement(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 20000);
            try
            {
                //Select education to delete
                IWebElement eduToDel = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                eduToDel.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("canot able to locate element", ex.Message);
            }
            Wait.WaitForElement(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[2]/i", 20000);
           //click on delete cross button
           IWebElement cross = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[2]/i"));
            cross.Click();
        }

        
        //validate deleted successfully or not
        internal void IsEducationDeleted()
        {
            //Thread.Sleep(10000);
            Wait.WaitForElement(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]", 1000);
            //Select language to delete
            IWebElement deledu = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
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
