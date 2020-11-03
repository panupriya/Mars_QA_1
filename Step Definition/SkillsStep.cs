using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Mars_QA_Specflow_T1.Steps
{
    [Binding]
    public sealed class SkillsStep
    {


        IWebDriver driver = new ChromeDriver();
        

        [AfterScenario]
        public void Dispose()
        {
            // close the window and release the memory
            driver.Dispose();
        }

        //Add skills
        [Given(@"Login to Mars Portal Skill page")]
        public void GivenLoginToMarsPortalSkillPage()
        {
            
        }
        [When(@"I add skills")]
        public void WhenIAddSkills()
        {
            
        }
        [Then(@"I am able to verify that Skills record added sucessfully")]
        public void ThenIAmAbleToVerifyThatSkillsRecordAddedSucessfully()
        {
            
        }


        //Edit skill

        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            
        }
        [When(@"I click in Edit Button of skill")]
        public void WhenIClickInEditButtonOfSkill()
        {
            
        }
        [When(@"I edit the Skills record")]
        public void WhenIEditTheSkillsRecord()
        {
            
        }

        [Then(@"I am able to verify that Skills updated sucessfully")]
        public void ThenIAmAbleToVerifyThatSkillsUpdatedSucessfully()
        {
            
        }


        //Delete skills

        [Given(@"I login to the website to dlete skill")]
        public void GivenILoginToTheWebsiteToDleteSkill()
        {
            
        }
        [When(@"I try to delete addedes skills")]
        public void WhenITryToDeleteAddedesSkills()
        {
            
        }
        [Then(@"I am able to delete the skill successfully")]
        public void ThenIAmAbleToDeleteTheSkillSuccessfully()
        {
            
        }


    }
}
