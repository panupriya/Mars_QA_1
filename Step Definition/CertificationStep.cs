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
    public sealed class CertificationStep
    {
        //Add certification
        [Given(@"I login to Website")]
        public void GivenILoginToWebsite()
        {
            var signin = new LoginPage();
            signin.LoginSteps();

        }
        [When(@"I add new Certifications")]
        public void WhenIAddNewCertifications()
        {
            var addCertifi = new Certification();
            addCertifi.AddCertification();
        }

        [Then(@"I am able to verify that Certifications is added succsfully")]
        public void ThenIAmAbleToVerifyThatCertificationsIsAddedSuccsfully()
        {
            var verCertifi = new Certification();
            verCertifi.VerifyCertification();

        }

       
        //Edit certification
        [Given(@"I login to the website for editing certification")]
        public void GivenILoginToTheWebsiteForEditingCertification()
        {
            var signin = new LoginPage();
            signin.LoginSteps();
        }
        [When(@"I click in Edit Button for certifications")]
        public void WhenIClickInEditButtonForCertifications()
        {
            var editCertifi = new Certification();
            editCertifi.EditCertification();

        }
        [When(@"I edit the Certification record and dispaly the alert message")]
        public void WhenIEditTheCertificationRecordAndDispalyTheAlertMessage()
        {
            var detailsCertifi = new Certification();
            detailsCertifi.EditDetailsCertification();
        }
        [Then(@"I am able to verify that Certifications edited successfully")]
        public void ThenIAmAbleToVerifyThatCertificationsEditedSuccessfully()
        {
            var valEdtCertifi = new Certification();
            valEdtCertifi.ValidateEditedCertification();
        }


        //Delete certification
        [Given(@"I go to certification and try to delete it")]
        public void GivenIGoToCertificationAndTryToDeleteIt()
        {
            var signin = new LoginPage();
            signin.LoginSteps();
            var delCertifi = new Certification();
            delCertifi.DeleteCertification();
        }
        [Then(@"I am able to delete certification successfully")]
        public void ThenIAmAbleToDeleteCertificationSuccessfully()
        {
            var valdelCertifi = new Certification();
            valdelCertifi.ValidateDeletedCertification();
        }

    }
}
