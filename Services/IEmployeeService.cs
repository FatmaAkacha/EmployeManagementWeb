using Models.Models;

namespace EmployeeManagement.Web.Services
{
    public interface IEmployeeService
    {
        Task<Employee> GetEmployee(int id);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<HttpResponseMessage> UpdateEmployee(Employee updatedemployee);
        Task<HttpResponseMessage> CreateEmployee(Employee Newemployee);
        Task DeleteEmployee(int id);
    }
}
