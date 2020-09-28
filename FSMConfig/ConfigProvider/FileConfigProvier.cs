using System.IO;

namespace FSMGenerator.FSMConfig.ConfigProvider
{
    public class FileConfigProvier : IFileConfigProvider
    {
        private IConfigSettings configSettings;
        public string GetRawConfig()
        {
            var streamReader = new StreamReader(configSettings.PathToConfig);
            return streamReader.ReadToEnd();
        }
    }
}