using AventStack.ExtentReports;
using MarsTestPeoject.Global;
using MarsTestPeoject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsTestPeoject.Test
{
    [TestFixture]
    [Category("Sprint4")]
    class ShareSkillsPageTest :Base
    {
        [Test,Order(1)]
        public void ShareSkillsTest()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                ShareSkillsPage objSkillsPage = new ShareSkillsPage();
                objSkillsPage.ShareSkillsSteps();
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test, Order(2)]
        public void VeiwShareSkillsTest()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                ManageListingPage objManageListing = new ManageListingPage();
            objManageListing.VeiwShareSkills();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(3)]
        public void EditShareSkillsTest()
        {
                // Create Extentreport test, name extracted from current method name
                test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                try
                {
                    ManageListingPage objManageListing = new ManageListingPage();
            objManageListing.EditShareSkills();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(4)]
        public void DeleteShareSkillsTest()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                ManageListingPage objManageListing = new ManageListingPage();
            objManageListing.DeleteShareSkills();
        }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
}
    }
}
