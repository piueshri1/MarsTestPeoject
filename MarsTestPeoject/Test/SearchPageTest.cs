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
    [Category("Sprint 6")]
    class SearchPageTest : Base
    {
        [Test,Order(1)]
        public void SearchSkillsByAllCategoriesTest()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                SearchPage searchPageObj = new SearchPage();
            searchPageObj.SearchSkillsByAllCategories();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(2)]
        public void SearchSkillsByFilterTest()
        {
                // Create Extentreport test, name extracted from current method name
                test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                try
                {
                    SearchPage searchPageObj = new SearchPage();
            searchPageObj.SearchSkillsByFilters();
                }
                catch (Exception ex)
                {
                    // Log status in Extentreports
                    test.Log(Status.Fail, "Failed, action unsuccessfull.");
                    test.Log(Status.Info, ex.Message);
                }
            }
        [Test, Order(3)]
        public void SearchSkillsBySubCategoriesTest()
        {
                    // Create Extentreport test, name extracted from current method name
                    test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                    try
                    {
                        SearchPage searchPageObj = new SearchPage();
            searchPageObj.SearchSkillsBySubCategories();
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
