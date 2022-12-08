using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests.Hooks
{
    [Binding]
    public class HookClass
    {
        static ExtentReports extent;
        static ExtentTest feature;
        ExtentTest scenario, step;
        public static string reportpath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "Result//";

        [BeforeTestRun]
        public static void InitalizeReport()
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportpath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext Context)
        {
            feature = extent.CreateTest(Context.FeatureInfo.Title);

        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext Context)
        {
            scenario = feature.CreateNode(Context.ScenarioInfo.Title);

        }
        [BeforeStep]
        public void BeforeStep()
        {
            step = scenario;
        }

        [AfterStep]
        public void AfterStep(ScenarioContext Context)
        {
            if (Context.TestError == null)
            {
                step.Log(Status.Pass, Context.StepContext.StepInfo.Text);
            }
            else if (Context.TestError != null)
            {
                step.Log(Status.Fail, Context.StepContext.StepInfo.Text);
            }
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }

    }
}
