using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using Models.Models;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]

        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()

        {
            Employees = new List<Employee>();

            Employees = (await EmployeeService.GetEmployees()).ToList();

        }
    }
}
