using Planner.WebBlazor.ViewModel;

namespace Planner.WebBlazor
{
    public interface IEmployeeService
    {
        Task<List<EmployeeViewModel>> GetAllEmployees();
        Task<EmployeeViewModel> GetEmployeeById(int id);
        Task<EmployeeViewModel> CreateEmployee(EmployeeViewModel employee);
        Task<EmployeeViewModel> EditEmployee(EmployeeViewModel employee);
        Task<EmployeeViewModel> DeleteEmployee(EmployeeViewModel employee);
    }
}
