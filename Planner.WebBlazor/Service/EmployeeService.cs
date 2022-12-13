using Planner.WebBlazor.ViewModel;
using System.Net.Http;
using System.Net.Http.Json;

namespace Planner.WebBlazor
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public Task<EmployeeViewModel> CreateEmployee(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeViewModel> DeleteEmployee(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeViewModel> EditEmployee(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {

            return await _httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("api/employee/getEmployees");
        }

        public Task<EmployeeViewModel> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
