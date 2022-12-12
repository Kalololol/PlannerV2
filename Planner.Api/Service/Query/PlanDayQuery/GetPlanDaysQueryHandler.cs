using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query.PlanDayQuery
{
    public class GetPlanDaysQueryHandler : IRequestHandler<GetPlanDaysQuery, List<PlanDayDto>>
    {
        private readonly IRepository<PlanDay> _planDayRepository;
        private readonly IMapper _mapper;

        public GetPlanDaysQueryHandler(IRepository<PlanDay> planDayRepository, IMapper mapper)
        {
            _planDayRepository = planDayRepository;
            _mapper = mapper;
        }

        public async Task<List<PlanDayDto>> Handle(GetPlanDaysQuery request, CancellationToken cancellationToken)
        {
            var planDays = _planDayRepository.GetAll();
            List<PlanDayDto> result = new List<PlanDayDto>();

            foreach (var i in planDays)
            {
                var planDay = _mapper.Map<PlanDayDto>(i);
                result.Add(planDay);
            }

            return result;
        }
    }
}
