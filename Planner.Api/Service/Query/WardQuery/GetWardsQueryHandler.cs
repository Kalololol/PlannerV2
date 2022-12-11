using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query.WardQuery
{
    public class GetWardsQueryHandler : IRequestHandler<GetWardsQuery, List<WardDto>>
    {
        private readonly IRepository<Ward> _wardRepository;
        private readonly IMapper _mapper;

        public GetWardsQueryHandler(IRepository<Ward> wardRepository, IMapper mapper)
        {
            _wardRepository = wardRepository;
            _mapper = mapper;
        }

        public async Task<List<WardDto>> Handle(GetWardsQuery request, CancellationToken cancellationToken)
        {
            var wards = _wardRepository.GetAll();
            List<WardDto> result = new List<WardDto>();

            foreach (var i in wards)
            {
                var ward = _mapper.Map<WardDto>(i);
                result.Add(ward);
            }

            return result;
        }
    }
}
