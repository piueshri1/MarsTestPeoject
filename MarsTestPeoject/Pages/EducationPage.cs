using MarsTestPeoject.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using static MarsTestPeoject.Global.GlobalDefinitions;

namespace MarsTestPeoject.Pages
{
    class EducationPage
    {
        //create constructer for education page....
        public EducationPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //page factory design pattern......

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNew { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement College { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[11]")]
        private IWebElement Country { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[8]")]
        private IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[8]")]
        private IWebElement Year { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement Add { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]")]
        private IWebElement Cancel { get; set; }
        [FindsBy(How =How.XPath, Using = "//*[@id='account - profile - section'']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[2]")]
        private IWebElement AddedDegree { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div")]
        private IWebElement Message { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")]
        private IWebElement EducationTab { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[6]/span[1]/i[1]")]
        private IWebElement EditEducationBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")]
        private IWebElement ClearUniversityText { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")]
        private IWebElement EditUniversityText { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[1]/div[3]/input[1]")]
        private IWebElement UpdateEducation { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i")]
        private IWebElement DeleteEducation { get; set; }
       

        public void EducationTestSteps()
        {
            // Referencing to an excel file and sheet name
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ProfilePage");
            EducationTab.Click();
            AddNew.Click();
            College.SendKeys(ExcelLib.ReadData(2, "University"));
            Degree.SendKeys(ExcelLib.ReadData(2, "Degree"));
            Country.Click();
            Title.Click();
            Year.Click();
            Add.Click();
            //bool isMessage = ValidateEducationSavedMessage(educationmessage);
            //Assert.IsTrue(isMessage);
            //bool isEducation = ValidateAddedEducation();
        }
        //public bool ValidateEducationSavedMessage( string educationmessage)
        //{
        //  //  Wait.ElementExist(driver, "XPath", "/html/body/div[1]/div", 30);

        //    if (Message.Text == educationmessage)
        //    {
        //        //Console.WriteLine("Success message is displayed, test passed");
        //        return true;
        //    }
        //    else
        //    {
        //        //Console.WriteLine("Success message is not displayed, test failed");
        //        return false;
        //    }
        //}

        //public bool ValidateAddedEducation()
        //{
        //   // Wait.ElementExist(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]", 30);

        //    //validate Education is added
        //    if (AddedDegree.Text == degree)
        //    {
        //        //Console.WriteLine("Certificate is added, test passed");
        //        return true;
        //    }
        //    else
        //    {
        //        //Console.WriteLine("Certificate is not added, test failed");
        //        return false;
        //    }
       // }
       public void EducationCancelSteps()
        {
            EducationTab.Click();
            AddNew.Click();
            Cancel.Click();

        }

        public void EducationUpdateSteps()
        {
            EducationTab.Click();
            //Edit Education Button
            EditEducationBtn.Click();

            //Edit Education
            ClearUniversityText.Clear();
            // Referencing to an excel file and sheet name
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ProfilePage");
            EditUniversityText.SendKeys(ExcelLib.ReadData(2, "EditUniversity"));

            //Click Update Education
            UpdateEducation.Click();
        }


        public void EducationDeleteSteps()
        {

            EducationTab.Click();
            DeleteEducation.Click();

        }
    }
}
