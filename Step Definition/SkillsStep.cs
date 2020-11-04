using Mars_QA_Specflow_T1.Pages;
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
            var signin = new LoginPage();
            signin.LoginSteps(driver);
        }
        [When(@"I add skills")]
        public void WhenIAddSkills()
        {
            var addskill = new Skills();
            addskill.AddSkill(driver);
        }
        [Then(@"I am able to verify that Skills record added sucessfully")]
        public void ThenIAmAbleToVerifyThatSkillsRecordAddedSucessfully()
        {
            var skillVal = new Skills();
            skillVal.ValidateSkill(driver);
        }


        //Edit skill

        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            var signin = new LoginPage();
            signin.LoginSteps(driver);
        }
        [When(@"I click in Edit Button of skill")]
        public void WhenIClickInEditButtonOfSkill()
        {
            var editSkill = new Skills();
            editSkill.EditSkill(driver);
        }
        [When(@"I edit the Skills record")]
        public void WhenIEditTheSkillsRecord()
        {
            var editSDetails = new Skills();
            editSDetails.EditSkillDetails(driver);
        }

        [Then(@"I am able to verify that Skills updated sucessfully")]
        public void ThenIAmAbleToVerifyThatSkillsUpdatedSucessfully()
        {
            var valEdtSkill = new Skills();
            valEdtSkill.ValidateEditedSkill(driver);
        }


        //Delete skills

        [Given(@"I login to the website to dlete skill")]
        public void GivenILoginToTheWebsiteToDleteSkill()
        {
            var signin = new LoginPage();
            signin.LoginSteps(driver);
        }
        [When(@"I try to delete addedes skills")]
        public void WhenITryToDeleteAddedesSkills()
        {
            var delSkill = new Skills();
            delSkill.DeleteSkill(driver);

        }
        [Then(@"I am able to delete the skill successfully")]
        public void ThenIAmAbleToDeleteTheSkillSuccessfully()
        {
            var valDelSkill = new Skills();
            valDelSkill.ValidateDeletedSkill(driver);
        }


    }
}
