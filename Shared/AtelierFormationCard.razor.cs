using Microsoft.AspNetCore.Components;

namespace ecocivicom_blazor_clone.Shared
{

    public partial class AtelierFormationCard : ComponentBase
    {
        [Parameter]
        public CasualLink TitleWithLink { get; set; } = new CasualLink(String.Empty, String.Empty);
        [Parameter]
        public string Description { get; set; } = String.Empty;
        [Parameter]
        public string ImageLink { get; set; } = String.Empty;
        [Parameter]
        public string ImageAlternativeText { get; set; } = "ateliers & formations";
        [Parameter]
        public string MainColor { get; set; } = String.Empty; // Orange default color see site.css
        [Parameter]
        public List<CasualLink> Links { get; set; } = new List<CasualLink>();
    }
}