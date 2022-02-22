namespace Atc.Azure.Options;

public class NamingOptions
{
    public string SystemAbbreviation { get; set; } = string.Empty;

    public string ServiceAbbreviation { get; set; } = string.Empty;

    public string CompanyAbbreviation { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(SystemAbbreviation)}: {SystemAbbreviation}, {nameof(ServiceAbbreviation)}: {ServiceAbbreviation}, {nameof(CompanyAbbreviation)}: {CompanyAbbreviation}";
}