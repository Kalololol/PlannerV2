using MediatR;

namespace Planner.Api.Service.Query.WardQuery
{
    public class GetWardsQuery : IRequest<List<WardDto>>
    {
    }
}
