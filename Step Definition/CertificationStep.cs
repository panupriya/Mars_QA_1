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
    public sealed class CertificationStep
    {

        IWebDriver driver = new ChromeDriver();


        [AfterScenario]
        public void Dispose()
        {
            // close the window and release the memory
            driver.Dispose();
        }

        //Add certification
        [Given(@"I login to Website")]
        public void GivenILoginToWebsite()
        {
            

        }
        [When(@"I add new Certifications")]
        public void WhenIAddNewCertifications()
        {
           
        }

        [Then(@"I am able to verify that Certifications is added succsfully")]
        public void ThenIAmAbleToVerifyThatCertificationsIsAddedSuccsfully()
        {
            
        }

        //Edit certification
        [Given(@"I login to the website for editing certification")]
        public void GivenILoginToTheWebsiteForEditingCertification()
        {
            
        }
        [Given(@"I click in Edit Button for certifications")]
        public void GivenIClickInEditButtonForCertifications()
        {
           
        }
        [When(@"I edit the Certification record and dispaly the alert message")]
        public void WhenIEditTheCertificationRecordAndDispalyTheAlertMessage()
        {
            
        }
        [Then(@"I am able to verify that Certifications edited successfully")]
        public void ThenIAmAbleToVerifyThatCertificationsEditedSuccessfully()
        {
            
        }





        //Delete certification
        [Given(@"I go to certification and try to delete it")]
        public void GivenIGoToCertificationAndTryToDeleteIt()
        {
           
        }
        [Then(@"I am able to delete certification successfully")]
        public void ThenIAmAbleToDeleteCertificationSuccessfully()
        {
           
        }


    }
}
