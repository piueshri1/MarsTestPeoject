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
    [Category("Sprint 5")]
    class ManageReqestTest : Base
    {
        [Test,Order(1)]
        public void AcceptRequest()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                ManageReqestPage objManageRequest = new ManageReqestPage();
            objManageRequest.AcceptReceivedRequest();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(2)]
        public void DeclineRequest()
        {
                // Create Extentreport test, name extracted from current method name
                test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                try
                {
                    ManageReqestPage objManageRequest = new ManageReqestPage();
            objManageRequest.DeclineReceivedRequest();
                }
                catch (Exception ex)
                {
                    // Log status in Extentreports
                    test.Log(Status.Fail, "Failed, action unsuccessfull.");
                    test.Log(Status.Info, ex.Message);
                }
            }
        [Test, Order(3)]
        public void WithdrawSentRequest()
        {
                    // Create Extentreport test, name extracted from current method name
                    test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                    try
                    {
                        ManageReqestPage objManageRequest = new ManageReqestPage();
            objManageRequest.WithdrawSentRequest();
                    }
                    catch (Exception ex)
                    {
                        // Log status in Extentreports
                        test.Log(Status.Fail, "Failed, action unsuccessfull.");
                        test.Log(Status.Info, ex.Message);
                    }
                }
        [Test, Order(4)]
        public void CompleteSentRequest()
        {
                        // Create Extentreport test, name extracted from current method name
                        test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                        try
                        {
                            ManageReqestPage objManageRequest = new ManageReqestPage();
            objManageRequest.CompleteSentRequest();
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
