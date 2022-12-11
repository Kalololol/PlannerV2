using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query.RequestQuery
{
    public class GetRequestByIdQueryHandler : IRequestHandler<GetRequestByIdQuery, RequestDto>
    {
        private readonly IRepository<Request> _requestRepository;
        private readonly IMapper _mapper;

        public GetRequestByIdQueryHandler(IRepository<Request> requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public async Task<RequestDto> Handle(GetRequestByIdQuery request, CancellationToken cancellationToken)
        {
            var req = _requestRepository.GetById(request.Id);
            var result = _mapper.Map<RequestDto>(req);

            return result;
        }
    }
}
