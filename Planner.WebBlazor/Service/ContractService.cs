using Microsoft.AspNetCore.Components;
using Planner.WebBlazor.ViewModel;
using System.Net.Http;
using System.Net.Http.Json;

namespace Planner.WebBlazor
{
    public class ContractService// : IContractService
    {
        private readonly HttpClient httpClient;

        public ContractService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<ContractViewModel> GetContractById(int id)
        {
            return await httpClient.GetFromJsonAsync<ContractViewModel>($"api/contract/getContractById/{id}");
        }
       /* public async Task<ContractViewModel> CreateContract(ContractViewModel contract)
        {
          //  return await httpClient.PostAsJsonAsync<ContractViewModel>($"api/contract/createContract", ContractViewModel contract);
          
        }
        public async Task<ContractViewModel> EditContract(ContractViewModel contract)
        {
            return await _httpClient.PostJsonAsync<ContractViewModel>($"api/contract/editContract", contract);

        }
        public async Task<EditContract> DeleteContract(EditContract contract)
        {

        }*/
    }
}
