using Microsoft.AspNetCore.Mvc;
using Planner.WebBlazor.ViewModel;
using System.Net.Http;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;


namespace Planner.WebBlazor
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            return await _httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("api/employee/getEmployees");
        }

        public async Task<EmployeeViewModel> GetEmployeeById(int id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeViewModel>($"api/employee/getEmployees/{id}");
        }

        public async Task CreateEmployee(EmployeeViewModel employee)
        {
            var result = await _httpClient.PostAsJsonAsync("api/employee/createEmployee", employee);
           // await SetHeroes(result);

        }
        public Task<EmployeeViewModel> EditEmployee(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeViewModel> DeleteEmployee(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }

        

    }
}
