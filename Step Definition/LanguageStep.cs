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
       
        //Add language
        [Given(@"I login to website with valid credentials")]
        public void GivenILoginToWebsiteWithValidCredentials()
        {
            var signin = new LoginPage();
            signin.LoginSteps();
        }

        [When(@"I try to add new Language on profile page")]
        public void WhenITryToAddNewLanguageOnProfilePage()
        {
            var addLang = new Language();
            addLang.AddLanguage();
        }

        [Then(@"Seller should able to add new language successfully")]
        public void ThenSellerShouldAbleToAddNewLanguageSuccessfully()
        {
            var verifylang = new Language();
            verifylang.IsLanguageAdded();
        }



        //Update Language
        [Given(@"I login to website")]
        public void GivenILoginToWebsite()
        {
            var signin = new LoginPage();
            signin.LoginSteps();
        }

        [When(@"I edit the Language record")]
        public void WhenIEditTheLanguageRecord()
        {
            var UpLang = new Language();
            UpLang.UpdateLanguage();
        }

       
        [Then(@"Seller should able to edit language successfully")]
        public void ThenSellerShouldAbleToEditLanguageSuccessfully()
        { 
            var verifUpdate = new Language();
            verifUpdate.IsLanguageUpdateed();
        }


         //Delete Language
        [Given(@"I click in Delete Button")]
        public void GivenIClickInDeleteButton()
        {
            var signin = new LoginPage();
            signin.LoginSteps();
            var delLang = new Language();
            delLang.DeleteLanguage();
        }

        [Then(@"Seller able to delete language successfully")]
        public void ThenSellerAbleToDeleteLanguageSuccessfully()
        {
            var checkdel = new Language();
            checkdel.IsLanguageDeleted();
        }

    }
}
