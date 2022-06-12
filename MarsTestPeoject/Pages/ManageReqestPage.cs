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
    class ManageReqestPage
    {
        public ManageReqestPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        [FindsBy(How = How.XPath, Using= "//*[@id='account-profile-section']/div/section[1]/div/div[1]")]
        private IWebElement ManageRequests { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[1]/div/a[1]")]
        private IWebElement ReceivedRequests { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[1]/div/a[2]")]
        private IWebElement SentRequests { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='received-request-section']/div[2]/h2")]
        private IWebElement ReceivedRequestsTitle { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='sent-request-section']/div[2]/h2")]
        private IWebElement SentRequestsTitle { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='sent-request-section']/div[2]/div[1]/table/tbody/tr/td[8]/button")]
        private IWebElement ActionsButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]")]
        private IWebElement Accept { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]")]
        private IWebElement Decline { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[5]")]
        private IWebElement ReceivedRequestStatus { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='sent-request-section']/div[2]/div[1]/table/tbody/tr/td[5]")]
        private IWebElement SentRequestStatus { get; set; }

        //Read data from Excel


        
        
        
        public void AcceptReceivedRequest()
        {
         
            ClickManageRequests();
            Thread.Sleep(2000);
            ClickReceivedRequests();
            Thread.Sleep(2000);
            ValidateAtReceivedRequestsPage();
            ClickAccept();
            //ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageRequests");
            //string acceptreceived = ExcelLib.ReadData(2, "AcceptReceivedRequest");
            //bool isStatusAccepted = ValidateReceivedRequestStatus(acceptreceived);
            //Assert.IsTrue(isStatusAccepted);
        }


        //Received Request Actions - Decline
        public void DeclineReceivedRequest()
        {
         
            ClickManageRequests();
            Thread.Sleep(2000);
            ClickReceivedRequests();
            Thread.Sleep(2000);
            ValidateAtReceivedRequestsPage();
            ClickDecline();
            //ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageRequests");
            //string declinereceived = ExcelLib.ReadData(2, "DeclineReceivedRequest");
            //bool isStatusDeclined = ValidateReceivedRequestStatus(declinereceived);
            //Assert.IsTrue(isStatusDeclined);

        }
        public void ClickManageRequests()
        {
            ManageRequests.Click();
        }

        public void ClickReceivedRequests()
        {
            ReceivedRequests.Click();
        }

        public void ValidateAtReceivedRequestsPage()
        {
            bool isAtReceivedRequestsPage = ReceivedRequestsTitle.Displayed;
            Assert.IsTrue(isAtReceivedRequestsPage);
        }

        public void ClickAccept()
        {
            Accept.Click();
        }

        public bool ValidateReceivedRequestStatus(string status)
        {
            if (ReceivedRequestStatus.Text == status)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void ClickDecline()
        {
            Thread.Sleep(2000);
            Decline.Click();
        }



        //Sent Request Actions - Withdraw
        public void WithdrawSentRequest()
        {
          
            ClickManageRequests();
            Thread.Sleep(2000);
            ClickSentRequests();
            Thread.Sleep(2000);
            ValidateAtSentRequestsPage();

            Thread.Sleep(2000);
            ClickActionsButton();
            //ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageRequests");
            //string withdrawsent = ExcelLib.ReadData(2, "WithdrawSentRequest");
            //bool isStatusWithdrawn = ValidateSentRequestStatus(withdrawsent);
            //Assert.IsTrue(isStatusWithdrawn);
        }


        //Sent Request Actions - Completed
        public void CompleteSentRequest()
        {
            ClickManageRequests();
            Thread.Sleep(2000);
            ClickSentRequests();
            Thread.Sleep(2000);
            ValidateAtSentRequestsPage();

            Thread.Sleep(2000);
            ClickActionsButton();
            //ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageRequests");
            //string completesent = ExcelLib.ReadData(2, "CompleteSentRequest");
            //bool isStatusCompleted = ValidateSentRequestStatus(completesent);
            //Assert.IsTrue(isStatusCompleted);
        }


        public void ClickSentRequests()
        {
            SentRequests.Click();
        }

        public void ValidateAtSentRequestsPage()
        {
            bool isSentRequestsPage = SentRequestsTitle.Displayed;
            Assert.IsTrue(isSentRequestsPage);
        }

        public void ClickActionsButton()
        {
            ActionsButton.Click();
        }

        public bool ValidateSentRequestStatus(string status)
        {

            if (SentRequestStatus.Text == status)
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
