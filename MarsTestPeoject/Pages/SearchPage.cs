using MarsTestPeoject.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static MarsTestPeoject.Global.GlobalDefinitions;

namespace MarsTestPeoject.Pages
{
    class SearchPage
    {
        public SearchPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

        }
        //page factory design
        [FindsBy(How =How.CssSelector , Using = "#account-profile-section > div > div.ui.secondary.menu > div.ui.small.icon.input.search-box > input[type=text]")]
        private IWebElement InputSkills { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[1]/i")]
        private IWebElement SearchIcon { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[2]/input")]
        private IWebElement SearchSkillsTextBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#service-search-section > div.ui.container > div > section > div > div.twelve.wide.column > div > div:nth-child(2) > div > div > div > div:nth-child(2)")]
        private IWebElement SearchedSkillResult { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[1]")]
        private IWebElement FilterOnline { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#service-search-section > div.ui.container > div > section > div > div.four.wide.column > div:nth-child(1) > div > a.active.item.category")]
        private IWebElement GraphicAndDesignText { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#service-search-section > div.ui.container > div > section > div > div.four.wide.column > div:nth-child(1) > div > a.active.item.subcategory > b")]
        private IWebElement FLogoAndDesignText { get; set; }
        [FindsBy(How =How.XPath , Using = "//*[@id='service - search - section']/div[2]/div/section/div/div[1]/div[5]/button[3]")]
        private IWebElement FilterShowAll { get; set; }



        public void SearchSkillsByAllCategories()
        {
            InputSkills.Click();
            ExcelLib.PopulateInCollection(Base.ExcelPath, "SearchSkill");
           
            InputSkills.SendKeys(ExcelLib.ReadData(2, "SearchSkills"));
            SearchIcon.Click();
            Thread.Sleep(2000);
        }
        public void SearchSkillsBySubCategories()
        {
            SearchIcon.Click();
            ExcelLib.PopulateInCollection(Base.ExcelPath, "SearchSkill");
            SearchSkillsTextBox.SendKeys(ExcelLib.ReadData(2, "SearchSkills"));
            SearchSkillsTextBox.SendKeys(Keys.Enter);
        }
        public void SearchSkillsByFilters()
        {
            SearchIcon.Click();
            FilterOnline.Click();
            ExcelLib.PopulateInCollection(Base.ExcelPath, "SearchSkill");
            SearchSkillsTextBox.SendKeys(ExcelLib.ReadData(2, "SearchSkills"));
            SearchSkillsTextBox.SendKeys(Keys.Enter);
            
        }
        //public void ClickSearchIcon()
        //{
        //    //click search icon
        //    SearchIcon.Click();
        //}

        //public void EnterSearchSkill(string searchskill)
        //{
        //    //enter skill to search
        //    SearchSkillsTextBox.SendKeys(searchskill);

        //    //Click enter
        //    SearchSkillsTextBox.SendKeys(Keys.Enter);
        //}

        //public void ClickOnline()
        //{
        //    //click online filter
        //    FilterOnline.Click();
        //}

        public void ClickSearchedSkill()
        {

            //Click search skill
            SearchedSkillResult.Click();
        }


        public bool ValidateSearchResult()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "SearchSkill");
            string searchskill = ExcelLib.ReadData(2, "SearchSkills");
            //validate search skill result
            if (SearchedSkillResult.Text == searchskill)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
