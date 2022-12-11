using MediatR;


namespace Planner.Api.Service.Query.RequestQuery
{
    public class GetRequestsQuery : IRequest<List<RequestDto>>
    { 
    }
}
