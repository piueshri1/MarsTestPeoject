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
    class ServiceDetailsPage
    {
        private SearchPage objSearchPage = new SearchPage();
        public ServiceDetailsPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
            //page factory design pattern
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/div/a")]
        private IWebElement ChatButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[3]")]
        private IWebElement Request { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/textarea")]
        private IWebElement MessageTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[3]/button[1]")]
        private IWebElement Yes { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div")]
        private IWebElement Message { get; set; }
        public void SendServiceRequest(IWebDriver driver)
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ServiceDetail");
              string messagetoseller = ExcelLib.ReadData(2, "MessageToSeller");
              string sentrequestmessage = ExcelLib.ReadData(2, "SentRequestMessage");
            objSearchPage.SearchSkillsByAllCategories();
            objSearchPage.ClickSearchedSkill();
            ValidateYouAreAtServiceDetailPage();
            EnterMessageToSeller(messagetoseller);
            ClickRequest();
            ClickYes();
            bool isRequestSent = ValidateRequestSent(driver, sentrequestmessage);
            Assert.IsTrue(isRequestSent);

        }


        public void ValidateYouAreAtServiceDetailPage()
        {
            bool isServicePage = ChatButton.Displayed;
            Assert.IsTrue(isServicePage);
        }

        public void ClickChat()
        {
            //click chat button
            ChatButton.Click();
        }


        public void EnterMessageToSeller(string messagetoseller)
        {
            //enter message in message text box
            MessageTextBox.SendKeys(messagetoseller);

        }

        public void ClickRequest()
        {
            //click request button
            Request.Click();
        }


        public void ClickYes()
        {
            //click yes on confirm popup
            Yes.Click();
        }

        public bool ValidateRequestSent(IWebDriver driver, string sentrequestmessage)
        {
         
            //validate request is sent
            if (Message.Text == sentrequestmessage)
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
