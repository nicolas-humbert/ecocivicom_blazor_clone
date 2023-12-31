using Microsoft.AspNetCore.Components;

namespace ecocivicom_blazor_clone.Shared
{

    public partial class NavMenu : ComponentBase
    {
        private bool collapseNavMenu = true;

        List<MainMenuElement> MenuElements = new();

        protected override void OnInitialized()
        {
            MenuElements.AddRange(new List<MainMenuElement>
        {
            new MainMenuElement {
                Name = "Accueil",
                Href = "",

            },
            new MainMenuElement {
                Name = "Nos Formations en Prévention des Risques",
                Href = "nos-formations",
                SubElements = new List<MainMenuSubElement>()
                {
                    new MainMenuSubElement("Formation Eco-Conduite", "nos-formations/eco-conduite"),
                    new MainMenuSubElement("Formation Risque Routier", "nos-formations/risque-routier"),
                    new MainMenuSubElement("Formation Sécurité & Environnement", "nos-formations/sécurité-environnement"),
                    new MainMenuSubElement("Formation en Classe Virtuelle", "nos-formations/classe-virtuelle"),
                }
            },
            new MainMenuElement {
                Name = "Journées sécurité / Safety Day en Entreprise",
                Href = "nos-ateliers",
                SubElements = new List<MainMenuSubElement>()
                {
                    new MainMenuSubElement("Atelier Eco-Conduite & Risque Routier", "nos-ateliers/eco-conduite-risque-routier"),
                    new MainMenuSubElement("Atelier Bien Etre", "nos-ateliers/bien-etre"),
                    new MainMenuSubElement("Atelier Sécurité & Environnement", "nos-ateliers/sécurité-environnement"),
                    new MainMenuSubElement("Atelier Réalité Virtuelle", "nos-ateliers/réalité-virtuelle"),
                }
            },
            new MainMenuElement {
                Name = "Vente de défibrilateurs",
                Href = "défibrilateur",
                SubElements = new List<MainMenuSubElement>()
                {
                    new MainMenuSubElement("Contrat de Maintenance", "défibrillateur/contrat-maintenance"),
                    new MainMenuSubElement("Formation Défibrillateur", "défibrillateur/formation"),
                }
            },
            new MainMenuElement {
                Name = "E-learning Sécurité",
                Href = "e-learning",
            },
            new MainMenuElement {
                Name = "Contactez-nous",
                Href = "nous-contacter",
            },
        });
        }

        private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}