namespace ecocivicom_blazor_clone;

/// <summary>
/// Represents a pre-configured template for main menu sub items
/// </summary>
public class MainMenuSubElement
{
    public MainMenuSubElement(string name, string href)
    {
        Name = name;
        Href = href;
    }
    public string Name { get; set; } = String.Empty;

    public string Href { get; set; } = String.Empty;

}