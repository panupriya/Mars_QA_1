using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_QA_Specflow_T1.Pages
{
    class Driver
    {
        //Initialize the browser
        public static IWebDriver driver;

        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://192.168.99.100:5000");

            //Maximise the window
            driver.Manage().Window.Maximize();
        }
    }
}
