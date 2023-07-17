using static ecocivicom_blazor_clone.MainMenuSubElement;

namespace ecocivicom_blazor_clone;

/// <summary>
/// Represents a pre-configured template for any link.
/// </summary>
public class CasualLink
{
    public CasualLink(string name, string href)
    {
        Name = name;
        Href = href;
    }
    public string Name { get; set; } = String.Empty;

    public string Href { get; set; } = String.Empty;
}