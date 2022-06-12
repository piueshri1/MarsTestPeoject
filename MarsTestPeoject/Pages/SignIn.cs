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
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

        }
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement EmailAddress { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "rememberDetails")]
        private IWebElement RememberMe { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        public void LoginSteps()
        {
            // Referencing to an excel file and sheet name
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Login");

            // Go to base Url
            driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "Url"));

            // Click signin button
            SignIntab.Click();
            Thread.Sleep(2000);

            // Picking up excel data from "Username" column, in row 2
            EmailAddress.SendKeys(ExcelLib.ReadData(2, "EmailAddress"));

            // Picking up excel data from "Password" column, in row 2
            Password.SendKeys(ExcelLib.ReadData(2, "Password"));

            // Click RememberMe
            RememberMe.Click();
            // Click login button
            LoginBtn.Click();

            // Wait for profile page to load 
            WaitForElement(driver, By.XPath("//th[contains(text(),'Language')]"), 10);
        }
    }
}
