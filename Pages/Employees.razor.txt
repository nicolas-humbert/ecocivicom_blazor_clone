using ecocivicom_blazor_clone.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace ecocivicom_blazor_clone.Pages
{
    public partial class Employees : ComponentBase
    {
        // Forms 
        public bool ShowCreate { get; set; }
        public bool ShowEdit { get; set; }
        public int EditingId { get; set; }

        // Employee objects
        public Employee? NewEmployee { get; set; }          // Create
        public List<Employee>? OurEmployees { get; set; }   // Read (All)
        public Employee? EmployeeToUpdate { get; set; }     // Update
        public Employee? EmployeeToDelete { get; set; }     // Delete

        // Context
        private EmployeeDataContext? _context;


        // ---- INIT ----
        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;
            await ShowEmployees();
        }

        // ---- CREATE ----
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
            await ShowEmployees();
        }

        // ---- READ ----
        public async Task ShowEmployees()
        {
            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                OurEmployees = await _context.Employees.ToListAsync();
            }
        }

        // ---- UPDATE ----
        public async Task ShowEditForm(Employee ourEmployee)
        {

            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                EmployeeToUpdate = _context.Employees.FirstOrDefault(x => x.Id == ourEmployee.Id);
                ShowEdit = true;
                EditingId = ourEmployee.Id;
            }
        }

        public async Task UpdateEmployee()
        {
            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                if (EmployeeToUpdate is not null) _context.Employees.Update(EmployeeToUpdate);
                await _context.SaveChangesAsync();
            }
            ShowEdit = false;
        }

        // ---- DELETE ----
        public async Task DeleteEmployee(Employee ourEmployee)
        {
            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();
            if (_context is not null)
            {
                if (ourEmployee is not null) _context.Employees.Remove(ourEmployee);
                await _context.SaveChangesAsync();
            }
            await ShowEmployees();
        }
    }
}