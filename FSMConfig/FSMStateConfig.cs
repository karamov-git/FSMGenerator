using System.Collections.Generic;

namespace FSMGenerator.FSMConfig
{
    public class FSMStateConfig
    {
        public string State;
        public IEnumerable<StateDirection> Directions;
    }
}