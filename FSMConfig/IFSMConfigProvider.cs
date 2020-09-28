using System.Collections.Generic;
using FSMGenerator.FSMConfig.ConfigProvider;
using Newtonsoft.Json;

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
            return JsonConvert.DeserializeObject<FSMStateConfig[]>(rawConfig);
        }
    }
}