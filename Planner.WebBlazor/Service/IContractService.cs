using Planner.WebBlazor.ViewModel;

namespace Planner.WebBlazor
{
    public interface IContractService
    {
        Task<ContractViewModel> GetContractById(int id);
        Task<ContractViewModel> CreateContract(ContractViewModel contract);
        Task<ContractViewModel> EditContract(ContractViewModel contract);
       // Task<ContractViewModel> DeleteContract(ContractViewModel contract);
    }
}
