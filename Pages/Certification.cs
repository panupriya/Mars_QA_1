using Mars_QA_Specflow_T1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mars_QA_Specflow_T1.Pages
{
    class Certification
    {
        //Add Certifications details
        internal void AddCertification()
        {
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);

            //click on Certification
            IWebElement certification = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certification.Click();

            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div", 10000);

            //click on addnew certification
            IWebElement addCerti = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addCerti.Click();

            //input certification
            IWebElement inputCer = Driver.driver.FindElement(By.Name("certificationName"));
            inputCer.Click();
            IWebElement cerName = Driver.driver.FindElement(By.Name("certificationName"));
            cerName.SendKeys("ISTQB");

            //input certificationfrom
            IWebElement inputCerF = Driver.driver.FindElement(By.Name("certificationFrom"));
            inputCerF.Click();
            IWebElement cerFrom = Driver.driver.FindElement(By.Name("certificationFrom"));
            cerFrom.SendKeys("ITB");

            //select year from dropdown list
            IWebElement year = Driver.driver.FindElement(By.Name("certificationYear"));
            year.Click();

            new SelectElement(Driver.driver.FindElement(By.Name("certificationYear"))).SelectByText("2020");

            //click on add
            IWebElement add = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            add.Click();

            //Add second certification
            //click on addnew certification
            IWebElement addCerti1 = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addCerti1.Click();

            Wait.WaitForElementVisibility(Driver.driver, "Name", "certificationName", 10000);
            //input second certification
            IWebElement inputCer1 = Driver.driver.FindElement(By.Name("certificationName"));
            inputCer1.Click();
            IWebElement cerName1 = Driver.driver.FindElement(By.Name("certificationName"));
            cerName1.SendKeys("Auto CADD");

            //input certificationfrom
            IWebElement inputCerF1 = Driver.driver.FindElement(By.Name("certificationFrom"));
            inputCerF1.Click();
            IWebElement cerFrom1 = Driver.driver.FindElement(By.Name("certificationFrom"));
            cerFrom1.SendKeys("CADD");

            //select year from dropdown list
            IWebElement year1 = Driver.driver.FindElement(By.Name("certificationYear"));
            year1.Click();

            new SelectElement(Driver.driver.FindElement(By.Name("certificationYear"))).SelectByText("2018");

            //click on add
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]", 10000);
            IWebElement add1 = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            add1.Click();

        }

        //Validate added certification

        internal void VerifyCertification()
        {
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]", 5000);
            IWebElement addedCerti = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            if (addedCerti.Text == "ISTQB")
            {
                Console.WriteLine("Certification added succesfully");

            }
            else
            {
                Console.WriteLine("Certification is not added");

            }
        }

        //Edit certification
        internal void EditCertification()
        {
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);

            //click on Certification
            IWebElement certification = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certification.Click();

            //select certification name to edit
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]", 10000);

            IWebElement nameEdit = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            nameEdit.Click();

            //click on update button corresponding to certification
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[1]/i", 10000);

            IWebElement editCerti = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[1]/i"));
            editCerti.Click();

        }
        internal void EditDetailsCertification()
        {
            //Edit year from drop down list
            
            //select year from dropdown list
            IWebElement year = Driver.driver.FindElement(By.Name("certificationYear"));
            year.Click();

            new SelectElement(Driver.driver.FindElement(By.Name("certificationYear"))).SelectByText("2019");

            //click on update
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]", 10000);

            IWebElement updCerti = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            updCerti.Click();


        }

        //Validate edited certification
        internal void ValidateEditedCertification()
        {
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[3]", 5000);
            IWebElement valEdcer = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[3]"));
            if (valEdcer.Text == "2019")
            {
                Console.WriteLine("Certification edited succesfully");

            }
            else
            {
                Console.WriteLine("Certification is not edited succesfully");

            }

        }

        //Delete certification
        internal void DeleteCertification()
        {
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);

            //click on Certification
            IWebElement certification = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certification.Click();

            //Select certification which is to be deleted
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);

            IWebElement selDel = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            selDel.Click();

            //click on delete button
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]", 10000);

            IWebElement del = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]"));
            del.Click();

        }

        //Validate deleted certification
        internal void ValidateDeletedCertification()
        {
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 5000);
            IWebElement delcerti = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (delcerti.Text != "Auto CADD")
            {
                Console.WriteLine("Certification deleted succesfully");

            }
            else
            {
                Console.WriteLine("Certification is not deleted succesfully");

            }

        }

    }
}
