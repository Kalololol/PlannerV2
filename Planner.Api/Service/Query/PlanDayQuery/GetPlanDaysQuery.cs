using MediatR;

namespace Planner.Api.Service.Query.PlanDayQuery
{
    public class GetPlanDaysQuery : IRequest<List<PlanDayDto>>
    {
    }
}
