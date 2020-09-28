namespace FSMGenerator.FSMConfig.ConfigProvider
{
    public interface IConfigSettings
    {
        string PathToConfig {get;}
    }

    public class SimpleConfigSettings : IConfigSettings
    {
        public string PathToConfig => "./settings/configSettings";
    }
}