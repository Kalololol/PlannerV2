using MediatR;

namespace Planner.Api.Service.Query.RequestQuery
{
    public class GetRequestByIdQuery : IRequest<RequestDto>
    {
        public int Id { get; set; }

        public GetRequestByIdQuery(int id)
        {
            Id = id;
        }
    }
}
