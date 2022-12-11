using MediatR;

namespace Planner.Api.Service.Query.PlanMonthQuery
{
    public class GetPlanMonthsQuery : IRequest<List<PlanMonthDto>>
    {
    }
}
