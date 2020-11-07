using Mars_QA_Specflow_T1.Helpers;
using Mars_QA_Specflow_T1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars_QA_Specflow_T1.Hooks
{
    [Binding]
    public sealed class Hooks
    {

        [BeforeScenario]
        public void Setup()
        {

            //Defining the browser
            Driver driver = new Driver();
            driver.Initialize();

            ExcelLibHelpers.PopulateInCollection(@"D:\ic test\Repo-IC Mars-QA1\Mars_QA_1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            Thread.Sleep(5000);
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // close the window and release the memory
            Driver.driver.Dispose();
            
        }
    }
}






