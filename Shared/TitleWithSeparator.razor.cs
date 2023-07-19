using Microsoft.AspNetCore.Components;

namespace ecocivicom_blazor_clone.Shared
{

    public partial class TitleWithSeparator : ComponentBase
    {
        [Parameter]
        public string Name { get; set; } = String.Empty;
        [Parameter]
        public string MainColor { get; set; } = "f-lightgray";
    }
}