using Planner.WebBlazor.ViewModel;

namespace Planner.WebBlazor
{
    public interface IRequestService
    {
        Task<List<RequestViewModel>> GetAllRequest();
        Task<RequestViewModel> GetRequestById(int id);
        Task<RequestViewModel> CreateRequest(RequestViewModel employee);
        Task<RequestViewModel> EditRequest(RequestViewModel employee);
        Task<RequestViewModel> DeleteRequest(RequestViewModel employee);
    }
}
