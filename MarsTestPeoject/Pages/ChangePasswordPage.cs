using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsTestPeoject.Pages
{
    class ChangePasswordPage
    {
        public ChangePasswordPage()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
       [FindsBy(How = How.XPath, Using = "//body/div[@id='account-profile-section']/div[1]/div[1]/div[2]/div[1]/span[1]")]
        private IWebElement ProfileName { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Change Password')]")]
        private IWebElement ChangePass { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[4]/div[1]/div[2]/form[1]/div[1]/input[1]")]
        private IWebElement CurrentPass { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[4]/div[1]/div[2]/form[1]/div[2]/input[1]")]
        private IWebElement NewPass { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[4]/div[1]/div[2]/form[1]/div[3]/input[1]")]
        private IWebElement ConfirmPass { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[4]/div[1]/div[2]/form[1]/div[4]/button[1]")]
        private IWebElement SavePassword { get; set; }
        public void ChangePassword()
        {
            ProfileName.Click();
            Thread.Sleep(2000);
            ChangePass.Click();
            Thread.Sleep(2000);
             CurrentPass.SendKeys("");
             NewPass.SendKeys("");
             ConfirmPass.SendKeys("");
             SavePassword.Click();
        }
    }
}
