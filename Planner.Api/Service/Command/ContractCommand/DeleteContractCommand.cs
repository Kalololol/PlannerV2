using MediatR;

namespace Planner.Api.Service.Command.ContractCommand
{
    public class DeleteContractCommand : IRequest
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}
