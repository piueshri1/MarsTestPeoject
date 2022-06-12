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
    [Category("Sprint1")]
    class ProfilePageTest :Base
    {
        // Methord for add education detail.....
        [Test,Order(1)]
        public void EducationAddTest()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                EducationPage ObjEducation = new EducationPage();
            ObjEducation.EducationTestSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        // Methord for Cancel education detail.....
        [Test, Order(2)]
        public void EducationCancelTest()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                EducationPage ObjEducation = new EducationPage();
            ObjEducation.EducationCancelSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        // Methord for Update education detail.....
        [Test, Order(3)]
        public void EducationUpdateTest()
        {
                // Create Extentreport test, name extracted from current method name
                test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                try
                {
                    EducationPage ObjEducation = new EducationPage();
            ObjEducation.EducationUpdateSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        // Methord for Delete education detail.....
        [Test, Order(4)]
        public void EducationDeleteTest()
        {
                    // Create Extentreport test, name extracted from current method name
                    test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                    try
                    {
                        EducationPage ObjEducation = new EducationPage();
            ObjEducation.EducationDeleteSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(5)]
        public void CertificationAddTest()
        {
                        // Create Extentreport test, name extracted from current method name
                        test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                        try
                        {
                            CertificationPage ObjCertification = new CertificationPage();
            ObjCertification.CertificationSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(6)]
        public void CertificationCancelTest()
        {
                            // Create Extentreport test, name extracted from current method name
                            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                            try
                            {
                                CertificationPage ObjCertification = new CertificationPage();
            ObjCertification.CertificationCancelSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(7)]
        public void CertificationUpdateTest()
        {
                                // Create Extentreport test, name extracted from current method name
                                test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                                try
                                {
                                    CertificationPage ObjCertification = new CertificationPage();
            ObjCertification.CertificationUpdateSteps();
                }
                catch (Exception ex)
                {
                    // Log status in Extentreports
                    test.Log(Status.Fail, "Failed, action unsuccessfull.");
                    test.Log(Status.Info, ex.Message);
                }
            }
        [Test, Order(8)]
        public void CertificationDeleteTest()
        {
                                    // Create Extentreport test, name extracted from current method name
                                    test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                                    try
                                    {
                                        CertificationPage ObjCertification = new CertificationPage();
            ObjCertification.CertificationDeleteSteps();
                }
                catch (Exception ex)
                {
                    // Log status in Extentreports
                    test.Log(Status.Fail, "Failed, action unsuccessfull.");
                    test.Log(Status.Info, ex.Message);
                }

            }
        [Test,Order(9)]
        public void DescriptionTest()
        {
                                        // Create Extentreport test, name extracted from current method name
                                        test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                                        try
                                        {
                                            DescriptionPage objDescription = new DescriptionPage();
            objDescription.DescriptionSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test, Order(10)]
        public void ProfilePaseTest()
        {
                                            // Create Extentreport test, name extracted from current method name
                                            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                                            try
                                            {
                                                ProfilePage objProfile = new ProfilePage();
            objProfile.ProfileSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(11)]
        public void AddLanguage()
        {
                                                // Create Extentreport test, name extracted from current method name
                                                test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                                                try
                                                {
                                                    LanguagePage objLanguage = new LanguagePage();
            objLanguage.AddNewLanguageSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(12)]
        public void UpdateLanguage()
        {
                                                    // Create Extentreport test, name extracted from current method name
                                                    test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                                                    try
                                                    {
                                                        LanguagePage objLanguage = new LanguagePage();
            objLanguage.UpdateLanguageSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(13)]
        public void DeleteLanguage()
        {
                                                        // Create Extentreport test, name extracted from current method name
                                                        test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                                                        try
                                                        {
                                                            LanguagePage objLanguage = new LanguagePage();
            objLanguage.DeleteLanguageSteps();
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test, Order(14)]
        public void AddSkills()
        {
                                                            // Create Extentreport test, name extracted from current method name
                                                            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                                                            try
                                                            {
                                                                SkillsPage objSkillsPage = new SkillsPage();
            objSkillsPage.AddSkills();
                }
                catch (Exception ex)
                {
                    // Log status in Extentreports
                    test.Log(Status.Fail, "Failed, action unsuccessfull.");
                    test.Log(Status.Info, ex.Message);
                }

            }
        [Test, Order(15)]
        public void UpdateSkills()
        {
                                                                // Create Extentreport test, name extracted from current method name
                                                                test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                                                                try
                                                                {
                                                                    SkillsPage objSkillsPage = new SkillsPage();
            objSkillsPage.UpdateSkills();
                    }
                    catch (Exception ex)
                    {
                        // Log status in Extentreports
                        test.Log(Status.Fail, "Failed, action unsuccessfull.");
                        test.Log(Status.Info, ex.Message);
                    }
                }
        [Test, Order(16)]
        public void DeleteSkills()
        {
                                                                    // Create Extentreport test, name extracted from current method name
                                                                    test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

                                                                    try
                                                                    {
                                                                        SkillsPage objSkillsPage = new SkillsPage();
            objSkillsPage.DeleteSkills();
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
