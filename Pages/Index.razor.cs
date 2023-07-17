using Microsoft.AspNetCore.Components;

namespace ecocivicom_blazor_clone.Pages
{

    public partial class Index : ComponentBase
    {
        readonly List<MainMenuSubElement> HighlightedElements = new()
                {
                    new MainMenuSubElement("Eco-Conduite & Risque Routier", "nos-formations/eco-conduite-risque-routier"),
                    new MainMenuSubElement("Sécurité des Biens et des Personnes", "nos-ateliers/sécurité-environnement"),
                    new MainMenuSubElement("Bien-être", "nos-ateliers/bien-etre"),
                    new MainMenuSubElement("Réalité Virtuelle", "nos-ateliers/réalité-virtuelle"),
                    new MainMenuSubElement("Escape Games", "escape-games/risque-routier"),
                };

        readonly string knowMoreLink = "nos-ateliers/réalité-virtuelle";
    }
}