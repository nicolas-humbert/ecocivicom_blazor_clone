using ecocivicom_blazor_clone.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace ecocivicom_blazor_clone.Pages
{
    public partial class Formations : ComponentBase
    {
        public List<FormationsCategory>? NosFormations { get; set; }

        private FormationsCategoriesDataContext? _context;

        // INIT
        protected override async Task OnInitializedAsync()
        {
            await ShowFormations();
        }

        // ---- READ ----
        private async Task ShowFormations()
        {
            _context ??= await FormationsCategoriesDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                NosFormations = await _context.FormationsCategories.ToListAsync();
            }
        }
    }
}