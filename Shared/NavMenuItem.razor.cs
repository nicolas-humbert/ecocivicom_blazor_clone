using Microsoft.AspNetCore.Components;

namespace ecocivicom_blazor_clone.Shared
{

    public partial class NavMenuItem : ComponentBase
    {
        [CascadingParameter(Name = "Name")]
        public string Name { get; set; } = String.Empty;
        [CascadingParameter(Name = "Href")]
        public string Href { get; set; } = String.Empty;

        [CascadingParameter]
        public List<MainMenuSubElement> SubElements { get; set; } = new List<MainMenuSubElement>();

        public bool isHovered = false;

        public void triggerMenu()
        {
            isHovered = !isHovered;
        }
    }
}