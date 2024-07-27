using BoDi;


namespace DheoClaveria_Specflow.Hooks;

[Binding]
public sealed class TestHooks
{
    // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

    [BeforeTestRun]
    public static void BeforeTestRunInjection(ITestRunnerManager testRunnerManager, ITestRunner testRunner, ObjectContainer testThreadContainer)
    {
        //All parameters are resolved from the test thread container automatically.
        //Since the global container is the base container of the test thread container, globally registered services can be also injected.

        //ITestRunManager from global container
        var location = testRunnerManager.TestAssembly.Location;

        //ITestRunner from test thread container
        var threadId = testRunner.ThreadId;

        Console.WriteLine($"BeforeTestRunInjection : Initialization {threadId} | {location}");
    }

    [BeforeFeature]
    public static void BeforeFeature(FeatureContext featureContext)
    {
        Console.WriteLine($"BeforeFeature : Initialization {featureContext.FeatureInfo}");
    }

    [BeforeScenario]
    public void BeforeScenario(ScenarioContext scenarioContext)
    {
        Console.WriteLine($"BeforeScenario : Initialization " +
                          $"{scenarioContext.ScenarioInfo.Title} |" +
                          $"{scenarioContext.ScenarioInfo.ScenarioAndFeatureTags} |" +
                          $" {scenarioContext.ScenarioExecutionStatus.Equals(ScenarioExecutionStatus.OK)}");
    }

    [AfterScenario]
    public void AfterScenario()
    {
        //TODO: implement logic that has to run after executing each scenario
    }

    [AfterFeature]
    public static void AfterFeature()
    {
        Console.WriteLine($"AfterFeature : Initialization");
    }

    [AfterTestRun]
    public static void AfterTestRun()
    {
        Console.WriteLine($"AfterTestRun Initialization");
    }
}