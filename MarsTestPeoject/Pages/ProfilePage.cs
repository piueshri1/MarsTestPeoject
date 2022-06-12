using MarsTestPeoject.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static MarsTestPeoject.Global.GlobalDefinitions;

namespace MarsTestPeoject.Pages
{
    class ProfilePage
    { 
        public ProfilePage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        // on click profile page.....
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section.nav-secondary > div > a:nth-child(2)")]
        private IWebElement OnClickProfile { get; set; }

        // click on profile name.....
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title > i")]
        private IWebElement OnClickProfileName { get; set; }
        // enter first name......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(2)")]
        private IWebElement EditFirstName { get; set; }
        // enter last name.......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(4)")]
        private IWebElement EditLastName { get; set; }
        // on click save button......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div:nth-child(2) > button")]
        private IWebElement SaveEdittedProfile { get; set; }

        //Click on Edit button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //validate profile is added...
        // [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title")]
        // private IWebElement ValProfileAdded { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Availability Hour icon
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > i")]
        private IWebElement WorkinHour { get; set; }

        //Click on salary
        [FindsBy(How = How.Name, Using = "availabiltyHour")]
        private IWebElement DwopDownForWorkingHours { get; set; }

        //SelectedWorkinHours
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span")]
        private IWebElement SelectedWorkinHours { get; set; }

        // click on earnTaget icon .......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i")]
        private IWebElement EarnTaget { get; set; }

        // availabilityTarget......
        [FindsBy(How = How.Name, Using = "availabiltyTarget")]
        private IWebElement AvailabilityTarget { get; set; }

        // availabilityToEarn.....
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select > option:nth-child(3) ")]
        private IWebElement AvailabilityToEarn { get; set; }

        public void ProfileSteps()
        {
            OnClickProfile.Click();
            OnClickProfileName.Click();
            Thread.Sleep(2000);
            EditFirstName.Clear();
            // Referencing to an excel file and sheet name
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ProfilePage");
            EditFirstName.SendKeys(ExcelLib.ReadData(2, "EditFirstName"));
            EditLastName.Clear();
            EditLastName.SendKeys(ExcelLib.ReadData(2, "EditLastName"));
            SaveEdittedProfile.Click();
            Thread.Sleep(2000);
            AvailabilityTimeEdit.Click();
            
            AvailabilityTime.Click();
            AvailabilityTimeOpt.Click();
            WorkinHour.Click();
            DwopDownForWorkingHours.Click();
            SelectedWorkinHours.Click();
            EarnTaget.Click();
            AvailabilityTarget.Click();
            AvailabilityToEarn.Click();
        }
    }
}
