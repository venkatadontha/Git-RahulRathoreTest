using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Laxmi.TestAutomation.Framework;
using System.Configuration;
using AventStack;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Model;
using BoDi;
using System.Reflection;
using System.IO;

namespace TestWebSiteTests
{
    [Binding]
    
    public sealed class HookLaxmiSetUp  :BaseTest
    {
        public static ExtentReports extent;
        public static ExtentTest featurName;
        public static ExtentTest Scenario;
        public static ExtentTest test;
        private readonly IObjectContainer _objectContainer;
        public ExtentKlovReporter extentKlovReporter;

        //public IObjectContainer ObjectContainer => objectContainer;

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public HookLaxmiSetUp(IObjectContainer objectContainer)
        {
            this._objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {

            Scenario = featurName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            //Scenario = featurName.CreateNode(ScenarioContext.Current.ScenarioInfo.Title,"hh£");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            featurName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            new BaseTest().SetUp();
        }

        [AfterFeature]
        public  static void AfterFeature()
        {
            Driver.Close();
            Driver.Quit();
        }

        [BeforeTestRun]
        public static void TestReport()
        {

            string path = Directory.GetCurrentDirectory();
//            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            //Append the html report file to current project path
            string reportPath = projectPath + "Reports\\TestRunReport.html";
            extent = new ExtentReports();// (reportPath, true);
            var html = new ExtentHtmlReporter(reportPath);
            extent.AttachReporter(html);

            //extent.CreateTest("Test", "this is my first test");

            ////string xmlPath = @"D:\\ExtentConfig.xml";
            ////extent.LoadConfig(xmlPath);

            ////Initialize Extent report before test starts
            //var htmlReporter = new ExtentHtmlReporter(@"C:\extentreport\SeleniumWithSpecflow\SpecflowParallelTest\ExtentReport.html");
            //htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            ////Attach report to reporter
            //extent = new ExtentReports();

            //ExtentKlovReporter extentKlovReporter = new ExtentKlovReporter("TestProject","proj");
            //extentKlovReporter.InitMongoDbConnection("localhost", 27017);
            //extentKlovReporter.ProjectName = "ExecuteAutomation Test";

            ////// URL of the KLOV server
            //extentKlovReporter.InitKlovServerConnection("http://localhost:5689");
            //extentKlovReporter.ReportName = "Laxmi Test Report" + DateTime.Now.ToString();
            //extent.AttachReporter(html, extentKlovReporter);



        }

        [AfterTestRun]
        public static void cleanup()
        {
            extent.Flush();
        }
        [BeforeStep]
        public void AfterStep()
        {
            //featurName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            // Scenario = featurName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            // //featurName.CreateNode<Given>
            // ScenarioStepContext ssc= ScenarioContext.Current.StepContext.Get<ScenarioStepContext>();


            //FeatureContext.Current.Get<Feature>(FeatureContext.Current.FeatureInfo.Title);

            //Scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);



            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
            //MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            //object TestResult = getter.Invoke(ScenarioContext.Current, null);

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    Scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    Scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    Scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    Scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                    Scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    Scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    Scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }

            ////Pending Status
            //if (TestResult.ToString() == "StepDefinitionPending")
            //{
            //    if (stepType == "Given")
            //        Scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
            //    else if (stepType == "When")
            //        Scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
            //    else if (stepType == "Then")
            //        Scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            //}
        }
    }
}
