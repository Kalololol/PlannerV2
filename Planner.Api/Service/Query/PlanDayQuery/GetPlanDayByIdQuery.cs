using MediatR;

namespace Planner.Api.Service.Query
{
    public class GetPlanDayByIdQuery : IRequest<PlanDayDto>
    {
        public int Id { get; set; }
    }
}
}
