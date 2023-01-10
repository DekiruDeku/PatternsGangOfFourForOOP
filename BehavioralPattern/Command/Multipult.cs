using System.Collections.Generic;

namespace Command
{
    public class Multipult
    {
        private List<ICommand> _commands; // список комманд
        private Stack<ICommand> _history; // история комманд

        public Multipult()
        {
            _commands = new List<ICommand>() {null, null};
            _history = new Stack<ICommand>();
        }

        public void SetCommand(int button, ICommand command)
        {
            _commands[button] = command;
        }

        public void PressOn(int button)
        {
            _commands[button].Positive();
            _history.Push(_commands[button]);
        }

        public void PressCancel()
        {
            if (_history.Count != 0)
            {
                _history.Pop().Negative();
            }
        }
    }
}