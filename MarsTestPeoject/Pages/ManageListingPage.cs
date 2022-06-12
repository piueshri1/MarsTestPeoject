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
    class ManageListingPage
    {
        public ManageListingPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement ManageListingstab { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement ManageListings { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(1) > i")]
        private IWebElement ManageListingsView { get; set; }
        //Finding the Edit Button
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[2]/i[1]")]
        private IWebElement Edit { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]")]
        private IWebElement EditTitle { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[1]/div[2]/div[1]/textarea[1]")]
        private IWebElement EditDescription { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[11]/div[1]/input[1]")]
        private IWebElement SaveB { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[3]")]
        private IWebElement UpdateTitle { get; set; }

        //Finding the delete Button
        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(3) > i")]
        private IWebElement Delete { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Yes')]")]
        private IWebElement DeleteYes { get; set; }
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]")]
        private IWebElement Message { get; set; }
        public void VeiwShareSkills()
        {
            ManageListingstab.Click();
            Thread.Sleep(1000);
            ManageListingsView.Click();
          
        }
        public void EditShareSkills()
        {
            ManageListingstab.Click();
            Thread.Sleep(2000);
            Edit.Click();
            Thread.Sleep(2000);
            EditTitle.Clear();
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            EditTitle.SendKeys(ExcelLib.ReadData(2, "EditTitle"));
            //Edit Description
            EditDescription.Clear();
            EditDescription.SendKeys(ExcelLib.ReadData(2, "EditDescription"));
            SaveB.Click();

        }
        public void DeleteShareSkills()
        {
            ManageListingstab.Click();
            Thread.Sleep(2000);
            Delete.Click();
        }
    }
}
