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
    class ChatPage 
    {
        private SearchPage objSearchPage = new SearchPage();
        private ServiceDetailsPage objServiceDetailsPage = new ServiceDetailsPage();
        public ChatPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//*[@id='chatTextBox']")]
        private IWebElement ChatTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btnSend']")]
        private IWebElement Send { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Hello I want to trade my skill']")]
        private IWebElement SentMessage { get; set; }
        public void ChatWithSeller()
        {
            objSearchPage.SearchSkillsByAllCategories();
            objSearchPage.ClickSearchedSkill();
            objServiceDetailsPage.ValidateYouAreAtServiceDetailPage();
            objServiceDetailsPage.ClickChat();
            ValidateYouAreOnChatPage();
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Chat");
            string chatmessage = ExcelLib.ReadData(2, "ChatMessage");
            EnterChatMessage(chatmessage);
            ClickSend();
        }
        public void EnterChatMessage(string chatmessage)
        {

            //enter message in chat text box
            ChatTextBox.SendKeys(chatmessage);

        }
        public void ClickSend()
        {
            //click send
            Send.Click();
        }

        public void ValidateYouAreOnChatPage()
        {
            Thread.Sleep(2000);
            bool isChatRoom = ChatTextBox.Displayed;
            Assert.IsTrue(isChatRoom);
        }

        public bool ValidateMessageSent(string chatmessage)
        {
            //validate message is sent to seller
            if (SentMessage.Text == chatmessage)
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
