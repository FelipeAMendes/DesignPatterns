namespace DesignPatterns.BehavorialPatterns.Command;

// ConcreteCommand class
public class CalculatorCommand : Command
{
    public int Operand;
    private readonly char _operator;
    private readonly Calculator _calculator;

    public CalculatorCommand(Calculator calculator, char @operator, int operand)
    {
        _calculator = calculator;
        _operator = @operator;
        Operand = operand;
    }

    public override void Execute()
    {
        Current = _calculator.Operation(_operator, Operand);
    }

    public override void UnExecute()
    {
        Current = _calculator.Operation(Undo(_operator), Operand);
    }

    private static char Undo(char @operator)
    {
        return @operator switch
        {
            '+' => '-',
            '-' => '+',
            '*' => '/',
            '/' => '*',
            _ => throw new ArgumentException("@operator")
        };
    }
}
