using static ecocivicom_blazor_clone.MainMenuSubElement;

namespace ecocivicom_blazor_clone;

/// <summary>
/// Represents a pre-configured template for main menu items
/// </summary>
public class MainMenuElement
{
    public string Name { get; set; } = String.Empty;

    public string Href { get; set; } = String.Empty;

    public List<MainMenuSubElement>? SubElements { get; set; } = new List<MainMenuSubElement>();
}