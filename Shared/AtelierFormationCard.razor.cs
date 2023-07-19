using Microsoft.AspNetCore.Components;

namespace ecocivicom_blazor_clone.Shared
{

    public partial class AtelierFormationCard : ComponentBase
    {
        public AtelierFormationCard(CasualLink titleWithLink, string description, string imageLink, string imageAlternativeText, List<CasualLink> links, string bgColor = "bg-orange")
        {
            TitleWithLink = titleWithLink;
            Description = description;
            ImageLink = imageLink;
            ImageAlternativeText = imageAlternativeText;
            Links = links;
            MainColor = bgColor;
        }
        public AtelierFormationCard() { }
        [Parameter]
        public CasualLink TitleWithLink { get; set; } = new CasualLink(String.Empty, String.Empty);
        [Parameter]
        public string Description { get; set; } = String.Empty;
        [Parameter]
        public string ImageLink { get; set; } = String.Empty;
        [Parameter]
        public string ImageAlternativeText { get; set; } = "ateliers & formations";
        [Parameter]
        public string? MainColor { get; set; }
        [Parameter]
        public List<CasualLink> Links { get; set; } = new List<CasualLink>();
    }
}