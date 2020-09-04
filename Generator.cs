using FSMGenerator.FSMConfig;

namespace FSMGenerator
{
    public interface IGenerator<T>
    {
        IStateMachine<T> Generate();
    }
    public class Generator<T> : IGenerator<T>
    {

        private IFSMConfigProvider configProvider;
        public IStateMachine<T> Generate()
        {
            var config = configProvider.GetConfigs();
            
            throw new System.NotImplementedException();
        }
    }
}