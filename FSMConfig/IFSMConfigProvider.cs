using System.Collections.Generic;
using System;

namespace FSMGenerator.FSMConfig
{
    public interface IFSMConfigProvider
    {
        IEnumerable<FSMStateConfig> GetConfigs();
    }

    public class SimpleJsonFSMConfigProvider : IFSMConfigProvider
    {

        private IFileConfigProvider fileConfigProvider;

        public IEnumerable<FSMStateConfig> GetConfigs()
        {
            var rawConfig = fileConfigProvider.GetRawConfig();
            throw new NotImplementedException("");
        }
    }
}