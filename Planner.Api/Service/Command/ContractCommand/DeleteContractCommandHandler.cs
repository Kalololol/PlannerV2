using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command.ContractCommand
{
    public class DeleteContractCommandHandler : IRequestHandler<DeleteContractCommand, Unit>
    {
        private readonly IRepository<Contract> _contracteRepository;

        public DeleteContractCommandHandler(IRepository<Contract> contractRepository)
        {
            _contracteRepository = contractRepository;
        }

        public Task<Unit> Handle(DeleteContractCommand request, CancellationToken cancellationToken)
        {
            var contract = _contracteRepository.GetById(request.Id);

            if (contract != null)
            {
                contract.Deleted = false;
            }

            _contracteRepository.Update(contract);


            return Task.FromResult(Unit.Value);
        }
    }
}
