using MediatR;

namespace Planner.Api.Service.Query
{
    public class GetContractByIdQuery : IRequest<ContractDto>
    {
        public int Id { get; set; }

        public GetContractByIdQuery(int id)
        {
            Id = id;
        }
    }
}
