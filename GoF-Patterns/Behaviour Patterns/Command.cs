
namespace GoF_Patterns.Behaviour_Patterns
{
    public interface ICommand
    {
        public string Execute();
        public string Undo();
    }
    
    public class Command : ICommand
    {
        private readonly Receiver _receiver;

        public Command(Receiver receiver)
        {
            _receiver = receiver;
        }
        public string Execute()
        {
            return _receiver.OnExecute();
        }

        public string Undo()
        {
            return _receiver.OnUndo();
        }
    }

    public class Receiver
    {
        public string OnExecute()
        {
            return "Command save received!";
        }

        public string OnUndo()
        {
            return "Command undo received!";
        }
    }

    public class Invoker
    {
        private readonly ICommand _command;

        public Invoker(ICommand command)
        {
            _command = command;
        }

        public string Save()
        {
            return _command.Execute();
        }

        public string Cancel()
        {
            return _command.Undo();
        }
    }
}
