
using System;

namespace GoF_Patterns.Behaviour_Patterns
{
    public class ElevatorState
    {
        public int State { get; private set; }

        public ElevatorState(int state)
        {
            State = state;
        }
    }

    public class Originator
    {
        private int _state = 1;

        public void ChangeState()
        {
            Console.WriteLine("Changed state from {0} to {1}",_state,++_state);
        }

        public ElevatorState SaveState()
        {
            Console.WriteLine("Saved state {0}",_state);
            return new ElevatorState(_state);
        }
    }

    public class Caretaker
    {
        
    }
}