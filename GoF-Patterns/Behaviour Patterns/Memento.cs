using System.Collections.Generic;

namespace GoF_Patterns.Behaviour_Patterns
{
    public class ElevatorState
    {
        public int Floor { get; private set; }

        public ElevatorState(int floor)
        {
            Floor = floor;
        }

        #nullable enable
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is ElevatorState second))
            {
                return false;
            }

            return this.Floor == second.Floor;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class Passenger
    {
        private int _floor = 1;

        public void GoUp()
        {
            ++_floor;
        }

        public void GoDown()
        {
           _floor = _floor > 0 ? --_floor:_floor;
        }

        public ElevatorState GetState()
        {
            return new ElevatorState(_floor);
        }

        public string RestoreState(ElevatorState elevatorState)
        {
            _floor = elevatorState.Floor;
            return $"Restored state with floor {_floor}";
        }
    }

    public class Dispatcher
    {
        private readonly Stack<ElevatorState> History;

        public Dispatcher()
        {
            History = new Stack<ElevatorState>();
        }

        public void SaveState(ElevatorState state)
        {
            History.Push(state);
        }
        
        public ElevatorState GetPreviousState()
        {
            return History.Pop();
        }
    }
}