using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query.PlanDayQuery
{
    public class GetPlanDayByIdQueryHandler : IRequestHandler<GetPlanDayByIdQuery, PlanDayDto>
    {
        private readonly IRepository<PlanDay> _planDayRepository;
        private readonly IMapper _mapper;

        public GetPlanDayByIdQueryHandler(IRepository<PlanDay> planDayRepository, IMapper mapper)
        {
            _planDayRepository = planDayRepository;
            _mapper = mapper;
        }

        public async Task<PlanDayDto> Handle(GetPlanDayByIdQuery request, CancellationToken cancellationToken)
        {
            var planDay = _planDayRepository.GetById(request.Id);
            var result = _mapper.Map<PlanDayDto>(planDay);

            return result;
        }
    }
}
