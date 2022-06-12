using MarsTestPeoject.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using static MarsTestPeoject.Global.GlobalDefinitions;

namespace MarsTestPeoject.Pages
{
    class ShareSkillsPage
    {
        public ShareSkillsPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        //Finding the Share Skill Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a")]
        private IWebElement ShareSkillButton { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        private IWebElement Title { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[2]")]
        private IWebElement GraphicsDesign { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[3]")]
        private IWebElement DigitalMarketing { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[4]")]
        private IWebElement WritingTranslation { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[5]")]
        private IWebElement VideoAnimation { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[6]")]
        private IWebElement MusicAudio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]")]
        private IWebElement ProgrammingTech { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[8]")]
        private IWebElement Business { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[9]")]
        private IWebElement FunLifestyle { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[2]")]
        private IWebElement SubCategory { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        private IWebElement Tags { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement HourlyBasisService { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement OneOffService { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement Onsite { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement Online { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
        private IWebElement StartDate { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        private IWebElement EndDate { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement SkillExchange { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement Credit { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input")]
        private IWebElement CreditServiceCharge { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchangeTag { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement Active { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement Hidden { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        private IWebElement SaveButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement WorkSample { get; set; }

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
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[3]/i[1]")]
        private IWebElement Delete { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Yes')]")]
        private IWebElement DeleteYes { get; set; }
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]")]
        private IWebElement Message { get; set; }

        public void ShareSkillsSteps()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkill");
            ShareSkillButton.Click();
            //Enter Title
            Title.SendKeys(ExcelLib.ReadData(2, "Title"));
            //Enter Description
            Description.SendKeys(ExcelLib.ReadData(2, "Description"));
            SelectCategory();
            SelectSubCategory();
            //Enter Tags
            Tags.SendKeys(ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);

            SelectServiceType();
            SelectLocationType();
            EnterStartDate();
            EnterEndDate();
            SelectSkillTrade();
            //// WorkSampleMethord(driver);
            SelectActive();
            SaveButton.Click();
        }
        private void SelectCategory()
        {
            string category = ExcelLib.ReadData(2, "Category");
            switch (category)
            {
                case "Graphics & Design":

                    GraphicsDesign.Click();
                    break;

                case "Digital Marketing":
                    DigitalMarketing.Click();
                    break;

                case "Writing & Translation":
                    WritingTranslation.Click();
                    break;

                case "Video & Animation":
                    VideoAnimation.Click();
                    break;


                case "Music & Audio":
                    MusicAudio.Click();
                    break;

                case "Programming & Tech":
                    ProgrammingTech.Click();
                    break;

                case "Business":
                    Business.Click();
                    break;


                default:
                    FunLifestyle.Click();
                    break;

            }
        }

        public void SelectSubCategory()
        {

            SubCategory.Click();

        }


        public void SelectServiceType()
        {
            string serviceType = ExcelLib.ReadData(2, "ServiceType");

            if (serviceType == "Hourly basis service")
            {
                HourlyBasisService.Click();

            }
            else
            {
                OneOffService.Click();

            }

        }

        public void SelectLocationType()
        {
            string locationType = ExcelLib.ReadData(2, "LocationType");

            if (locationType == "On-site")
            {
                Onsite.Click();

            }
            else
            {
                Online.Click();
            }
        }


        public void EnterStartDate()
        {
            int addDaysToStartDate = Convert.ToInt32(ExcelLib.ReadData(2, "AddDaysInCurrentDateToStart"));
            DateTime currentDate = DateTime.Now;

            StartDate.Clear();

            StartDate.SendKeys(currentDate.AddDays(addDaysToStartDate).ToString("yyyy-MM-dd"));


        }
        public void EnterEndDate( )
        {
            int addDaysToStartDate=Convert.ToInt32(ExcelLib.ReadData(2, "AddDaysInCurrentDateToStart"));
            int addDaysToEndDate = Convert.ToInt32(ExcelLib.ReadData(2, "AddDaysInCurrentDateToEnd"));
            DateTime currentDate = DateTime.Now;
            EndDate.Clear();

            if (addDaysToStartDate > addDaysToEndDate)
            {
                EndDate.SendKeys(currentDate.AddDays(addDaysToStartDate).ToString("yyyy-MM-dd"));
            }
            else
            {
                EndDate.SendKeys(currentDate.AddDays(addDaysToEndDate).ToString("yyyy-MM-dd"));
            }
        }

        public void SelectSkillTrade()
        {
            string skillTrade = ExcelLib.ReadData(2, "SkillTrade");

            if (skillTrade == "Skill-exchange")
            {
                SkillExchange.Click();
                SkillExchangeTag.SendKeys(ExcelLib.ReadData(2, "SkillExchangeTag"));
                SkillExchangeTag.SendKeys(Keys.Enter);
            }
            else
            {
                Credit.Click();
                CreditServiceCharge.Clear();
                CreditServiceCharge.SendKeys(ExcelLib.ReadData(2, "CreditServiceCharge"));
            }
        }
        public void SelectActive()
        {
            string active = ExcelLib.ReadData(2, "Active");

            if (active == "Active")
            {
                Active.Click();
            }
            else
            {
                Hidden.Click();
            }
        }
    }
    
}
