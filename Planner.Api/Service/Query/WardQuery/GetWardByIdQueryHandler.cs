using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query.WardQuery
{
    public class GetWardByIdQueryHandler : IRequestHandler<GetWardByIdQuery, WardDto>
    {
        private readonly IRepository<Ward> _wardRepository;
        private readonly IMapper _mapper;

        public GetWardByIdQueryHandler(IRepository<Ward> wardRepository, IMapper mapper)
        {
            _wardRepository = wardRepository;
            _mapper = mapper;
        }

        public async Task<WardDto> Handle(GetWardByIdQuery request, CancellationToken cancellationToken)
        {
            var ward = _wardRepository.GetById(request.Id);
            var result = _mapper.Map<WardDto>(ward);

            return result;
        }
    }
}
