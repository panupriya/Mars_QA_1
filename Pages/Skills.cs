using Mars_QA_Specflow_T1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mars_QA_Specflow_T1.Pages
{
    class Skills
    {
        //Add Skill
        internal void AddSkill()
        {
            //Thread.Sleep(10000);
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);

            //click on skills
            IWebElement skill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skill.Click();

           
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 10000);

            //click on add new skill
            IWebElement addSkill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addSkill.Click();


            //input skill
            IWebElement inputskillC = Driver.driver.FindElement(By.Name("name"));
            inputskillC.Click();
            IWebElement inputskill = Driver.driver.FindElement(By.Name("name"));
            inputskill.SendKeys("Test Analyst");

            //select skill level
            IWebElement skillLevel = Driver.driver.FindElement(By.Name("level"));
            skillLevel.Click();

            new SelectElement(Driver.driver.FindElement(By.Name("level"))).SelectByText("Beginner");

            //click on add
            IWebElement add = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            add.Click();

            //Add second skill
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 20000);

            //click on add second new skill
            IWebElement addSkill2 = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addSkill2.Click();

            Thread.Sleep(5000);
            //input skill
            IWebElement inputskillC2 = Driver.driver.FindElement(By.Name("name"));
            inputskillC2.Click();
            IWebElement inputskill2 = Driver.driver.FindElement(By.Name("name"));
            inputskill2.SendKeys("Automation Test Analyst");

            //select skill level
            IWebElement skillLevel2 = Driver.driver.FindElement(By.Name("level"));
            skillLevel2.Click();

            new SelectElement(Driver.driver.FindElement(By.Name("level"))).SelectByText("Beginner");

            //click on add
            IWebElement add2 = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            add2.Click();

        }


        //Validate added skills
        internal void ValidateSkill()
        {
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]", 5000);
            IWebElement addedSkill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            if (addedSkill.Text == "Test Analyst")
            {
                Console.WriteLine("skill added succesfully");

            }
            else
            {
                Console.WriteLine("New skill is not added");

            }
        }

        //Edit skill
        internal void EditSkill()
        {
            //Thread.Sleep(10000);
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);

            //click on skills
            IWebElement skill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skill.Click();

            //click on skill which is to be updated
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]", 5000);
            IWebElement selSkill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            selSkill.Click();
            
            //click on update button corresponding to the skill
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i", 10000);

            IWebElement skillup = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            skillup.Click();


        }
        
        internal void EditSkillDetails()
        {
            //update data from dropdown list
            //select skill level
            IWebElement skillLevelUp = Driver.driver.FindElement(By.Name("level"));
            skillLevelUp.Click();

            new SelectElement(Driver.driver.FindElement(By.Name("level"))).SelectByText("Intermediate");

            //click on update
            IWebElement update = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            update.Click();
        }

        //Validate edited skill
        internal void ValidateEditedSkill()
        {
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]", 5000);
            IWebElement updatedSkill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
            if (updatedSkill.Text == "Intermediate")
            {
                Console.WriteLine("Skill updateded succesfully");

            }
            else
            {
                Console.WriteLine("Skill is not updated");

            }

        }

        //Delete skill

        internal void DeleteSkill()
        {
            //Thread.Sleep(10000);
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);

            //click on skills
            IWebElement skill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skill.Click();

            //click on skill which is to be deleted
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 5000);
            IWebElement selSkill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            selSkill.Click();

            //click on delete cross button corresponditing to the skill
            IWebElement crossSkill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i"));
            crossSkill.Click();

        }

        //Validate deleted skill

        internal void ValidateDeletedSkill()
        {
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 5000);
            IWebElement delSkill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (delSkill.Text != "Automated Test Analyst")
            {
                Console.WriteLine("Skill deleted succesfully");

            }
            else
            {
                Console.WriteLine("Skill is not deleted");

            }


        }



    }
}
