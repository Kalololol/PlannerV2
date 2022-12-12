using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command.ContractCommand
{
    public class EditContractCommandHandler : IRequestHandler<EditContractCommand, Unit>
    {
        private readonly IRepository<Contract> _contractRepository;
        private readonly IMapper _mapper;

        public EditContractCommandHandler(IRepository<Contract> contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(EditContractCommand request, CancellationToken cancellationToken)
        {
            var contract = _contractRepository.GetById(request.Id);

            if (contract != null)
            {
                contract.DeclaredHours = request.DeclaredHours;
                //contract.ContractType = request.ContractType;
            }

            _contractRepository.Update(contract);


            return Task.FromResult(Unit.Value);
        }
    }
}
