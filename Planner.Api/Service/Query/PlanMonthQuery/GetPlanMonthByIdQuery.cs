using MediatR;

namespace Planner.Api.Service.Query.PlanMonthQuery
{
    public class GetPlanMonthByIdQuery : IRequest<PlanMonthDto>
    {
        public int Id { get; set; }
    }
}
}
