using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command.ContractCommand
{
    public class CreateContractCommandHandler : IRequestHandler<CreateContractCommand, Unit>
    {

        private readonly IRepository<Contract> _contractRepository;
        private readonly IMapper _mapper;

        public CreateContractCommandHandler(IRepository<Contract> contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(CreateContractCommand request, CancellationToken cancellationToken)
        {
            var contract = new ContractDto()
            {
                DeclaredHours = request.DeclaredHours,
                ContractType = request.ContractType,
                EmployeeId = request.EmployeeId
            };

            var result = _mapper.Map<Contract>(contract);
            _contractRepository.Add(result);

            return Task.FromResult(Unit.Value);

        }
    
    }
}
