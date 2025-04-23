namespace CommandPattern.Services
{
    public interface ICommand
    {
        string Execute();
        string Undo();
    }
}
