using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query.ContractQuery
{
    public class GetContractByIdQueryHandler : IRequestHandler<GetContractByIdQuery, ContractDto>
    {

        private readonly IRepository<Contract> _contractRepository;
        private readonly IMapper _mapper;

        public GetContractByIdQueryHandler(IRepository<Contract> contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public async Task<ContractDto> Handle(GetContractByIdQuery request, CancellationToken cancellationToken)
        {
            var contract = _contractRepository.GetById(request.Id);
            var result = _mapper.Map<ContractDto>(contract);

            return result;
        }
    }
}
