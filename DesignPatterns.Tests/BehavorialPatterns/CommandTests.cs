using DesignPatterns.BehavorialPatterns.Command;

namespace DesignPatterns.Tests.BehavorialPatterns;

public class CommandTests
{
    [Fact]
    public void CalculatorCommand_ComputeMethodIsCalled_ReturnsComputeCorrectly()
    {
        var expectedResult = new List<int> { 100, 50, 500, 250 };
        var user = new User();

        user.Compute('+', 100);
        user.Compute('-', 50);
        user.Compute('*', 10);
        user.Compute('/', 2);

        Assert.Equal(expectedResult.Last(), user.Calculator.Current);
        Assert.Equal(expectedResult, user.GetCommandsInts());
    }

    [Fact]
    public void CalculatorCommand_UndoMethodIsCalled_ReturnsComputeCorrectly()
    {
        var expectedResult = new List<int> { 0, 100, 50, 500 };
        var user = new User();

        user.Compute('+', 100);
        user.Compute('-', 50);
        user.Compute('*', 10);
        user.Compute('/', 2);
        user.Undo(4);

        Assert.Equal(expectedResult.First(), user.Calculator.Current);
        Assert.Equal(expectedResult, user.GetCommandsInts());
    }

    [Fact]
    public void CalculatorCommand_RedoMethodIsCalled_ReturnsComputeCorrectly()
    {
        var expectedResult = new List<int> { 100, 50, 500, 500 };
        var user = new User();

        user.Compute('+', 100);
        user.Compute('-', 50);
        user.Compute('*', 10);
        user.Compute('/', 2);
        user.Undo(4);
        user.Redo(3);

        Assert.Equal(expectedResult.Last(), user.Calculator.Current);
        Assert.Equal(expectedResult, user.GetCommandsInts());
    }
}
