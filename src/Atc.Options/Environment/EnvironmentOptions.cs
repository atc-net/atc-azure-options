namespace Atc.Options.Environment
{
    public class EnvironmentOptions : SystemOptions
    {
        public EnvironmentType EnvironmentType { get; set; }

        public string EnvironmentName { get; set; } = string.Empty;
    }
}