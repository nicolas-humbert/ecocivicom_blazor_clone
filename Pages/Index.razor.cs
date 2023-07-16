using ecocivicom_blazor_clone.Data;
using Microsoft.AspNetCore.Components;

namespace ecocivicom_blazor_clone.Pages
{
    public partial class Index : ComponentBase
    {
        public bool ShowCreate { get; set; }
        public Employee? NewEmployee { get; set; }
        private EmployeeDataContext? _context;

        protected override async Task OnInitializedAsync()
        {
            NewEmployee = new Employee();
            ShowCreate = false;
        }

        public void ShowCreateForm()
        {
            NewEmployee = new Employee();
            ShowCreate = true;
        }

        public async Task CreateNewEmployee()
        {
            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();

            if (NewEmployee is not null)
            {
                _context?.Employees.Add(NewEmployee);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;
        }
    }
}