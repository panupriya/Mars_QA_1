using Docker.DotNet.Models;
using Mars_QA_Specflow_T1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_QA_Specflow_T1.Steps
{
    [Binding]
    public sealed class ProfileDetailsStepDefinition
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


            //Scenario 1 Add language

            [Given(@"I login to the website with valid credentials")]
            public void GivenILoginToTheWebsiteWithValidCredentials()
            {
                var signin = new LoginPage();
                signin.LoginSteps(driver);
            }
            [When(@"I try to add new language on profile page")]
            public void WhenITryToAddNewLanguageOnProfilePage()
            {
                var addLang = new ProfilePage();
                addLang.AddLanguage(driver);

            }
            [Then(@"Selled should able to add new language successfully")]
            public void ThenSelledShouldAbleToAddNewLanguageSuccessfully()
            {
                var verifylang = new ProfilePage();
                verifylang.IsLanguageAdded(driver);

            }



            //Scenario 2--Delete language

            [Given(@"I try to delete existing language")]
            public void GivenITryToDeleteExistingLanguage()
            {

                 var signin = new LoginPage();
                 signin.LoginSteps(driver);
                 var delLang = new ProfilePage();
                delLang.DeleteLanguage(driver);
            }
            [Then(@"Seller able to delete existing language successfully")]
            public void ThenSellerAbleToDeleteExistingLanguageSuccessfully()
            {
                var checkdel = new ProfilePage();
                checkdel.IsLanguageDeleted(driver);
            }


            //Scenario 3-- Add education Details
            [Given(@"I login the website with valid credentials")]
            public void GivenILoginTheWebsiteWithValidCredentials()
            {
                var signin = new LoginPage();
                signin.LoginSteps(driver);
            }

            [When(@"I add education details '(.*)','(.*)','(.*)'")]
            public void WhenIAddEducationDetails(string Country, string Title, string Year)
            {
                var addEdu = new ProfilePage();
                addEdu.AddEducation(driver, Country, Title, Year);
            }

            [Then(@"Seller should able to add education details successfully")]
            public void ThenSellerShouldAbleToAddEducationDetailsSuccessfully()
            {
                var addeduval = new ProfilePage();
                addeduval.IsEducationAdded(driver);
            }

            //Scenario 3(a)-- Update educational details
            [Given(@"I login to website for updating education details")]
            public void GivenILoginToWebsiteForUpdatingEducationDetails()
            {
                var signin = new LoginPage();
                signin.LoginSteps(driver);
            }

            [When(@"I update the education detail'(.*)'")]
            public void WhenIUpdateTheEducationDetail(string Title)
            {
                var updateEdu = new ProfilePage();
                updateEdu.UpdateEducation(driver, Title);
            }

            [Then(@"I should be able to update the education detail successfully")]
            public void ThenIShouldBeAbleToUpdateTheEducationDetailSuccessfully()
            {
                var updateeduval = new ProfilePage();
                updateeduval.IsEducationUpdated(driver);
            }


        

    }
}
