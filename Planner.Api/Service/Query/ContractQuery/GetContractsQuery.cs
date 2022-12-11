using MediatR;

namespace Planner.Api.Service.Query
{
    public class GetContractsQuery : IRequest<List<ContractDto>>
    {
    }
}
