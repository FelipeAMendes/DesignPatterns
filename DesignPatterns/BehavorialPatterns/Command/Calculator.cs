namespace DesignPatterns.BehavorialPatterns.Command;

// Receiver class
public class Calculator
{
    public int Current { get; set; }

    public int Operation(char @operator, int operand)
    {
        switch (@operator)
        {
            case '+': Current += operand; break;
            case '-': Current -= operand; break;
            case '*': Current *= operand; break;
            case '/': Current /= operand; break;
        }

        return Current;
    }
}
