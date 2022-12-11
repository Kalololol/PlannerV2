using MediatR;

namespace Planner.Api.Service.Query.WardQuery
{
    public class GetWardByIdQuery : IRequest<WardDto>
    {
        public int Id { get; set; }
    }
}
}
