using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using static MarsTestPeoject.Global.GlobalDefinitions;

namespace MarsTestPeoject.Pages
{
    class SignUp
    {
        public SignUp()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Find signUp link

        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
        private IWebElement SignUpLink { get; set; }


        // enter first name 
        [FindsBy(How = How.Name, Using = "firstName")]
        private IWebElement FirstName { get; set; }

        // enter lastnamE...
        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement LastName { get; set; }

        //enter email addeess
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement EmailAddress { get; set; }

        // enter password
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //enter confirm password
        [FindsBy(How = How.Name, Using = "confirmPassword")]
        private IWebElement ConfirmPassword { get; set; }

        // agree for term and condition
        [FindsBy(How = How.Name, Using = "terms")]
        private IWebElement AgreeForTermCondition { get; set; }

        //click join button
        [FindsBy(How = How.Id, Using = "submit-btn")]
        private IWebElement ClickJoinButton { get; set; }

        internal void register()
        {
            //Populate the excel data
            ExcelLib.PopulateInCollection("Base.ExcelPath", "Register");

            //Click on Join button
            SignUpLink.Click();

            //Enter FirstName
            FirstName.SendKeys(ExcelLib.ReadData(2, "FirstName"));

            //Enter LastName
            LastName.SendKeys(ExcelLib.ReadData(2, "LastName"));

            //Enter Email
            EmailAddress.SendKeys(ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password.SendKeys(ExcelLib.ReadData(2, "Password"));

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(ExcelLib.ReadData(2, "ConfirmPswd"));

            //Click on Checkbox
            AgreeForTermCondition.Click();

            //Click on join button to Sign Up
            ClickJoinButton.Click();
        }
    }
}
