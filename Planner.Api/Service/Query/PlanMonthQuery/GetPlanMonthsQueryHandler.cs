using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query.PlanMonthQuery
{
    public class GetPlanMonthsQueryHandler : IRequestHandler<GetPlanMonthsQuery, List<PlanMonthDto>>
    {
        private readonly IRepository<PlanMonth> _planMonthRepository;
        private readonly IMapper _mapper;

        public GetPlanMonthsQueryHandler(IRepository<PlanMonth> planMonthRepository, IMapper mapper)
        {
            _planMonthRepository = planMonthRepository;
            _mapper = mapper;
        }

        public async Task<List<PlanMonthDto>> Handle(GetPlanMonthsQuery request, CancellationToken cancellationToken)
        {
            var planMonths = _planMonthRepository.GetAll();
            List<PlanMonthDto> result = new List<PlanMonthDto>();

            foreach (var i in planMonths)
            {
                var planMonth = _mapper.Map<PlanMonthDto>(i);
                result.Add(planMonth);
            }

            return result;
        }
    }
}
