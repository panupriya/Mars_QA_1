using Mars_QA_Specflow_T1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            //ExcelLibHelper.PopulateInCollection(@"D:\ic test\Repo-IC Mars-QA1\Mars_QA_1\Data\Mars.xlsx", "Credentials");

        }

        [AfterScenario]
        public void AfterScenario()
        {
            // close the window and release the memory
            Driver.driver.Dispose();
            
        }
    }
}






