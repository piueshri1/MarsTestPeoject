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
    [Category("Sprint3")]
    class ChangePasswordTest : Base
    {
        [Test]
       public void ChangePasswordPageTest()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                ChangePasswordPage objChangePsd = new ChangePasswordPage();
            objChangePsd.ChangePassword();
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
