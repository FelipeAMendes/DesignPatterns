namespace DesignPatterns.BehavorialPatterns.Command;

// Invoker class
public class User
{
    public readonly Calculator Calculator = new();
    public readonly List<Command> Commands = new();
    private int _current;

    public void Redo(int levels)
    {
        for (var i = 0; i < levels; i++)
        {
            if (_current >= Commands.Count - 1) continue;

            var command = Commands[_current++];
            command.Execute();
        }
    }

    public void Undo(int levels)
    {
        for (var i = 0; i < levels; i++)
        {
            if (_current > 0)
            {
                var command = Commands[--_current];
                command.UnExecute();
            }
        }
    }

    public void Compute(char @operator, int operand)
    {
        Command command = new CalculatorCommand(Calculator, @operator, operand);
        command.Execute();
        Commands.Add(command);
        _current++;
    }

    public List<int> GetCommandsInts()
    {
        return Commands.Select(x => x.Current).ToList();
    }
}
