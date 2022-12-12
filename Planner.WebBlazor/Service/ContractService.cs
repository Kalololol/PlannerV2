using Microsoft.AspNetCore.Components;
using Planner.WebBlazor.ViewModel;

namespace Planner.WebBlazor
{
    public class ContractService : IContractService
    {
        private readonly HttpClient httpClient;

        public ContractService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ContractViewModel> GetContractById(int id)
        {
            return await httpClient.GetJsonAsync<ContractViewModel>($"api/contract/getContractById/{id}");

        }
        public async Task<ContractViewModel> CreateContract(ContractViewModel contract)
        {
            return await httpClient.PostJsonAsync<ContractViewModel>($"api/contract/createContract", contract);

        }
        public async Task<ContractViewModel> EditContract(ContractViewModel contract)
        {
            return await httpClient.PostJsonAsync<ContractViewModel>($"api/contract/editContract", contract);

        }
        /*   public async Task<EditContract> DeleteContract(EditContract contract)
           {

           }*/
    }
}
