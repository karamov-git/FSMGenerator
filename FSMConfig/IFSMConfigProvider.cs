using System.Collections.Generic;

namespace FSMGenerator.FSMConfig
{
    public interface IFSMConfigProvider
    {
        IEnumerable<FSMStateConfig> GetConfigs();
    }
}