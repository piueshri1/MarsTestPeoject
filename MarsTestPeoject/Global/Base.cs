
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using MarsTestPeoject.Config;
using MarsTestPeoject.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static MarsTestPeoject.Global.GlobalDefinitions;

namespace MarsTestPeoject.Global
{
   public class Base
    {
        #region To access Path from resource file

        public static int Browser = Int32.Parse(MarsResource.Browser);
        public static string ExcelPath = Path.GetFullPath(Directory.GetCurrentDirectory() + MarsResource.ExcelPath);
        public static string ScreenshotPath = Path.GetFullPath(Directory.GetCurrentDirectory() + MarsResource.ScreenshotPath);
        public static string ReportPath = Path.GetFullPath(Directory.GetCurrentDirectory() + MarsResource.ReportPath);
        public static string FileUploadPath = Path.GetFullPath(Directory.GetCurrentDirectory() + MarsResource.ReportXMLPath);

        #endregion

        

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;

        #endregion
        [OneTimeSetUp]
        public void StartExtentReports()
        {
            // Initialize ExtentReports
            var htmlReporter = new ExtentHtmlReporter(ReportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }


        #region setup and tear down

        [SetUp]
        public void Inititalize()
        {
            

           
            switch (Browser)
            {
                case 1:
                    driver = new FirefoxDriver();
                    break;
                case 2:
                    driver = new ChromeDriver();
                    break;
            }

            // Maximize browser window
            driver.Manage().Window.Maximize();

           
            if (MarsResource.IsLogin == "true")
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();

            }
            else
            {
                SignUp obj = new SignUp();
                obj.register();
            }
            // Initialize ExtentReports
            //#region Initialise Reports
            //var htmlReporter = new ExtentHtmlReporter(ReportPath);
            //extent = new ExtentReports();
            //extent.AttachReporter(htmlReporter);

            //#endregion
        }


        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.ToString() != "Passed")
            {
                // Take a screenshot          
                string img = SaveScreenShotClass.SaveScreenshot(driver, "Screenshot");
                test.AddScreenCaptureFromPath(img);
            }

           // Quit browser
            driver.Quit();
        }
        [OneTimeTearDown]
        public void SaveExtentReports()
        {
            // Save Extentereport html file
            extent.Flush();
        }

        #endregion
    }
}

