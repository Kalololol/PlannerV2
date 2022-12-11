using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query.ContractQuery
{
    public class GetContractsQueryHandler : IRequestHandler<GetContractsQuery, List<ContractDto>>
    {
        private readonly IRepository<Contract> _contractRepository;
        private readonly IMapper _mapper;

        public async Task<List<ContractDto>> Handle(GetContractsQuery request, CancellationToken cancellationToken)
        {
            var contracts = _contractRepository.GetAll();
            List<ContractDto> result = new List<ContractDto>();

            foreach (var i in contracts)
            {
                var contract = _mapper.Map<ContractDto>(i);
                result.Add(contract);
            }


            return result;
        }
    }
}
