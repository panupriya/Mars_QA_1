using Mars_QA_Specflow_T1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Mars_QA_Specflow_T1.Steps_Definision
{
    [Binding]
    public sealed class EducationStep
    {
        IWebDriver driver;
        [BeforeScenario]

        public void LaunchBrowser()
        {
            // initialise driver
            driver = new ChromeDriver();

        }

        [AfterScenario]
        public void Dispose()
        {
            // close the window and release the memory
            driver.Dispose();
        }
        // Add education Details
        [Given(@"I login the website with valid credentials")]
        public void GivenILoginTheWebsiteWithValidCredentials()
        {
            var signin = new LoginPage();
            signin.LoginSteps(driver);
        }

        [When(@"I add education details '(.*)','(.*)','(.*)'")]
        public void WhenIAddEducationDetails(string Country, string Title, string Year)
        {
            var addEdu = new Education();
            addEdu.AddEducation(driver, Country, Title, Year);
        }

        [Then(@"Seller should able to add education details successfully")]
        public void ThenSellerShouldAbleToAddEducationDetailsSuccessfully()
        {
            var addeduval = new Education();
            addeduval.IsEducationAdded(driver);
        }

        // Update educational details
        [Given(@"I login to website for updating education details")]
        public void GivenILoginToWebsiteForUpdatingEducationDetails()
        {
            var signin = new LoginPage();
            signin.LoginSteps(driver);
        }

        [When(@"I update the education detail'(.*)'")]
        public void WhenIUpdateTheEducationDetail(string Title)
        {
            var updateEdu = new Education();
            updateEdu.UpdateEducation(driver, Title);
        }

        [Then(@"I should be able to update the education detail successfully")]
        public void ThenIShouldBeAbleToUpdateTheEducationDetailSuccessfully()
        {
            var updateeduval = new Education();
            updateeduval.IsEducationUpdated(driver);
        }

        //Delete educational details
        [Given(@"I click in Delete Education Button")]
        public void GivenIClickInDeleteEducationButton()
        {
            var signin = new LoginPage();
            signin.LoginSteps(driver);

            var delEdu = new Education();
            delEdu.DeleteEducation(driver);
        }


        [Then(@"Seller able to delete education successfully")]
        public void ThenSellerAbleToDeleteEducationSuccessfully()
        {
            var checkEdel = new Education();
            checkEdel.IsEducationDeleted(driver);
        }



    }
}
