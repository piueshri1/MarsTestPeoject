using MarsTestPeoject.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsTestPeoject.Pages
{
    class NotificationPage
    {
        public NotificationPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        //Page Factory
        [FindsBy(How = How.XPath, Using = "//body/div[@id='account-profile-section']/div[1]/div[1]/div[2]/div[1]/div[1]")]
        private IWebElement Notificationicon { get; set; }

        [FindsBy(How = How.XPath, Using ="//a[contains(text(),'See All...')]")]
        private IWebElement SeeAlllink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Load More...')]")]
        private IWebElement LoadMorelink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'...Show Less')]")]
        private IWebElement ShowLesslink { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='notification-section']/div[2]/div[1]/div[1]/div[3]/div[1]/div[1]/i[1]")]
        private IWebElement SelectAllIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='notification-section']/div[2]/div[1]/div[1]/div[3]/div[1]/div[2]/i[1]")]
        private IWebElement UnSelectAllIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='notification-section']/div[2]/div[1]/div[1]/div[3]/div[2]/span[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[3]/input[1]")]
        private IWebElement Checkbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='notification-section']/div[2]/div[1]/div[1]/div[3]/div[1]/div[4]/i[1]")]
        private IWebElement MarkasRead { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[@id='notification-section']/div[2]/div[1]/div[1]/div[3]/div[1]/div[3]/i[1]")]
        private IWebElement DeleteIcon { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div")]
        private IWebElement Message { get; set; }

        public void NotificationSteps()
        {
            Notificationicon.Click();
           
            Thread.Sleep(3000);
            SeeAlllink.Click();
            Thread.Sleep(5000);
            SelectNotification();
            
            UnselectNotification();
           
            SelectAllIcon.Click();
            UnSelectAllIcon.Click();
           // Thread.Sleep(5000);
           // MarkasRead.Click();
          //  Thread.Sleep(3000);
          //  DeleteIcon.Click();
        }


        private void SelectNotification()
        {
            if (Checkbox.Selected)
            {
                Checkbox.Click();
            }
        }

        private void UnselectNotification()
        {
            if (!Checkbox.Selected)
            {
                Checkbox.Click();
            }
        }
    }
}
