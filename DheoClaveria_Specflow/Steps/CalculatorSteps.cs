using TechTalk.SpecFlow.Assist;

namespace DheoClaveria_Specflow.Steps;

[Binding]
public sealed class CalculatorSteps
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;

    public CalculatorSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        Console.WriteLine($"GivenTheFirstNumberIs : {number}");
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 
        Console.WriteLine($"GivenTheSecondNumberIs : {number}");
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        Console.WriteLine($"WhenTheTwoNumbersAreAdded :");
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        Console.WriteLine($"Result : {result}");
    }

    [Given(@"I enter the following number:")]
    public void GivenIEnterTheFollowingNumber(Table table)
    {
        dynamic datatable = table.CreateDynamicSet();
        foreach (var data in datatable)
        {
            Console.WriteLine($"The Number : {data.number} | Digit : {data.digits}");
        }
    }
}