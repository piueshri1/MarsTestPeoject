using MarsTestPeoject.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using static MarsTestPeoject.Global.GlobalDefinitions;

namespace MarsTestPeoject.Pages
{
    class LanguagePage
    {
        public LanguagePage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        // Navigate to Language  tab

        //Click on  Language tab........
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(1)")]
        private IWebElement OnClickLanguage { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(1)")]
        private IWebElement ChooseLang { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(3)")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button")]
        private IWebElement AddLang { get; set; }


        // Update new  language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(1) > i")]
        private IWebElement EditLaguage { get; set; }
        //  clear old and update new language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(1) > input[type=text]")]
        private IWebElement SaveEditLaguage { get; set; }
        // dropdown to  update language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(2) > select")]
        private IWebElement ClickToUpdateLaguage { get; set; }
        // select language to update......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(2) > select > option:nth-child(5)")]
        private IWebElement SelectLanguageToUpdate { get; set; }
        // click to update......
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button")]
        private IWebElement ClickUpdate { get; set; }

        // delete language...
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td.right.aligned > span:nth-child(2) > i")]
        private IWebElement DeleteLanguages { get; set; }

        public void AddNewLanguageSteps()
        {

            OnClickLanguage.Click();
            AddNewLangBtn.Click();
            AddLangText.Clear();
            // Referencing to an excel file and sheet name
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ProfilePage");
            AddLangText.SendKeys(ExcelLib.ReadData(2, "Language"));
            ChooseLang.Click();


            ChooseLangOpt.Click();
            AddLang.Click();
        }

        public void UpdateLanguageSteps()
        {
            OnClickLanguage.Click();
            EditLaguage.Click();
            SaveEditLaguage.Clear();
            // Referencing to an excel file and sheet name
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ProfilePage");
            SaveEditLaguage.SendKeys(ExcelLib.ReadData(2, "EditLanguage"));
            ClickToUpdateLaguage.Click();
            SelectLanguageToUpdate.Click();
            ClickUpdate.Click();
        }

        public void DeleteLanguageSteps()
        {
            OnClickLanguage.Click();
            DeleteLanguages.Click();
        }
    }
}
