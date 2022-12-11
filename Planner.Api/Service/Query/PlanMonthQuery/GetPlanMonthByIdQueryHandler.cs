using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query.PlanMonthQuery
{
    public class GetPlanMonthByIdQueryHandler : IRequestHandler<GetPlanMonthByIdQuery, PlanMonthDto>
    {
        private readonly IRepository<PlanMonth> _planMonthRepository;
        private readonly IMapper _mapper;

        public GetPlanMonthByIdQueryHandler(IRepository<PlanMonth> planMonthRepository, IMapper mapper)
        {
            _planMonthRepository = planMonthRepository;
            _mapper = mapper;
        }

        public async Task<PlanMonthDto> Handle(GetPlanMonthByIdQuery request, CancellationToken cancellationToken)
        {
            var planMonth = _planMonthRepository.GetById(request.Id);
            var result = _mapper.Map<PlanMonthDto>(planMonth);

            return result;
        }
    }
}
