using Docker.DotNet.Models;
using Mars_QA_Specflow_T1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_QA_Specflow_T1.Steps
{
    [Binding]
    public sealed class LanguageStep
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


       

        //Add language
        [Given(@"I login to website with valid credentials")]
        public void GivenILoginToWebsiteWithValidCredentials()
        {
            var signin = new LoginPage();
            signin.LoginSteps(driver);
        }
        [When(@"I try to add new Language on profile page")]
        public void WhenITryToAddNewLanguageOnProfilePage()
        {
            var addLang = new Language();
            addLang.AddLanguage(driver);
        }
        [Then(@"Seller should able to add new language successfully")]
        public void ThenSellerShouldAbleToAddNewLanguageSuccessfully()
        {
            var verifylang = new Language();
            verifylang.IsLanguageAdded(driver);
        }



        //Update Language
        [Given(@"I login to website")]
        public void GivenILoginToWebsite()
        {
            var signin = new LoginPage();
            signin.LoginSteps(driver);
        }
        [When(@"I edit the Language record")]
        public void WhenIEditTheLanguageRecord()
        {
            var UpLang = new Language();
            UpLang.UpdateLanguage(driver);
        }

       
        [Then(@"Seller should able to edit language successfully")]
        public void ThenSellerShouldAbleToEditLanguageSuccessfully()
        { 
            var verifUpdate = new Language();
            verifUpdate.IsLanguageUpdateed(driver);
        }



        //Delete Language
        [Given(@"I click in Delete Button")]
        public void GivenIClickInDeleteButton()
        {
            var signin = new LoginPage();
            signin.LoginSteps(driver);
            var delLang = new Language();
            delLang.DeleteLanguage(driver);
        }
        [Then(@"Seller able to delete language successfully")]
        public void ThenSellerAbleToDeleteLanguageSuccessfully()
        {
            var checkdel = new Language();
            checkdel.IsLanguageDeleted(driver);
        }





    }
}
