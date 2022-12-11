using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query.RequestQuery
{
    public class GetRequestsQueryHandler : IRequestHandler<GetRequestsQuery, List<RequestDto>>
    {
        private readonly IRepository<Request> _requestRepository;
        private readonly IMapper _mapper;

        public GetRequestsQueryHandler(IRepository<Request> requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public async Task<List<RequestDto>> Handle(GetRequestsQuery request, CancellationToken cancellationToken)
        {
            var requests = _requestRepository.GetAll();
            List<RequestDto> result = new List<RequestDto>();

            foreach (var i in requests)
            {
                var req = _mapper.Map<RequestDto>(i);
                result.Add(req);
            }

            return result;
        }
    }
}
