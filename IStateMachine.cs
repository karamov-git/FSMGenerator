using System;
using System.Collections.Generic;

namespace FSMGenerator
{
    public interface IStateMachine<T>
    {
        State Next(State currentState, T inputValue );
    }

    public interface ICondition<T>
    {
        bool Success(T input);
    }

    public class SimpleStateMachine<T> : IStateMachine<T>
    {
        private Dictionary<State, Func<T, State>> transition;

        public State Next(State currentState, T inputValue)
        {
            var transitionFunction = transition[currentState];

            return transitionFunction(inputValue);
        }
    }
}