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
    class DescriptionPage
    {
        public DescriptionPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        //Click Desctiption icon...
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span")]
        private IWebElement DescriptionIcon { get; set; }

        //Add Desctiption
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > div.field > textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > button")]
        private IWebElement Save { get; set; }
        public void DescriptionSteps()
        {
            // Referencing to an excel file and sheet name
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ProfilePage");
            Thread.Sleep(2000);
            DescriptionIcon.Click();
            Description.Clear();
            Description.SendKeys(ExcelLib.ReadData(2, "ProfileDescription"));
            Save.Click();

        }
    }
}
