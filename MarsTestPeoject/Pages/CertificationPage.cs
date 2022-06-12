using MarsTestPeoject.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using static MarsTestPeoject.Global.GlobalDefinitions;

namespace MarsTestPeoject.Pages
{
    class CertificationPage
    {
        public CertificationPage()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }
        //click on Certificate tab.................
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(4)")]
        private IWebElement OnClickCertiTab { get; set; }

        //Add new Certificate
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.Name, Using = "certificationName")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.Name, Using = "certificationFrom")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select > option.hidden")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select > option:nth-child(8)")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div.five.wide.field > input.ui.teal.button")]
        private IWebElement AddCerti { get; set; }
        //Cancel Ceritification
        [FindsBy(How = How.CssSelector, Using = "")]
        private IWebElement CancelCerti { get; set; }
        //added Ceritification
        [FindsBy(How = How.CssSelector, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]")]
        private IWebElement AddedCertificate { get; set; }
        //Message
        [FindsBy(How = How.CssSelector, Using = "/html/body/div[1]/div")]
        private IWebElement Message { get; set; }
        //CertificationsTab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")]
        private IWebElement CertificationsTab { get; set; }
        //EditCertificationBtn
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[4]/span[1]/i[1]")]
        private IWebElement EditCertificationBtn { get; set; }
       
        //Cancel Ceritification
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[1]/div[1]/div[1]/div[1]/input[1]")]
        private IWebElement ClearCertificationText { get; set; }
        //Cancel Ceritification
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[1]/div[1]/div[1]/div[1]/input[1]")]
        private IWebElement EditCertificationText { get; set; }
        //Cancel Ceritification
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]")]
        private IWebElement UpdateCertification { get; set; }
        //Cancel Ceritification
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[4]/span[2]/i[1]")]
        private IWebElement DeleteCertification { get; set; }
        
        public void CertificationSteps()
        {
            // Referencing to an excel file and sheet name
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ProfilePage");
            OnClickCertiTab.Click();
            AddNewCerti.Click();
            EnterCerti.SendKeys(ExcelLib.ReadData(2, "Certificate"));
            CertiFrom.SendKeys(ExcelLib.ReadData(2, "CertifiedFrom"));
            CertiYear.Click();
            CertiYearOpt.Click();
            AddCerti.Click();

        }
        public void CertificationCancelSteps()
        {
            OnClickCertiTab.Click();
            AddNewCerti.Click();

        }
        public void CertificationUpdateSteps()
        {
            // Referencing to an excel file and sheet name
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ProfilePage");
            OnClickCertiTab.Click();
            //Edit Education Button
            EditCertificationBtn.Click();

            //Edit Education
            ClearCertificationText.Clear();
            EditCertificationText.SendKeys("Testing certification");


            //Click Update Education
            UpdateCertification.Click();

        }
        public void CertificationDeleteSteps()
        {
            OnClickCertiTab.Click();
            DeleteCertification.Click();
        }
    }
}
