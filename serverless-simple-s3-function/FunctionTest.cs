using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

namespace serverless_setep_function_hello_world.Tests;

public class FunctionTest
{
    public FunctionTest()
    {
    }

    [Fact]
    public void TestGreeting()
    {
        TestLambdaContext context = new TestLambdaContext();

        StepFunctionTasks functions = new StepFunctionTasks();

        var state = new State
        {
            Name = "MyStepFunctions"
        };


        state = functions.Greeting(state, context);

        Assert.Equal(5, state.WaitInSeconds);
        Assert.Equal("Hello MyStepFunctions", state.Message);
    }
}