using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command.RequestCommand
{
    public class CreateRequestCommandHandler : IRequestHandler<CreateRequestCommand, Unit>
    {
        private readonly IRepository<Request> _requestRepository;
        private readonly IMapper _mapper;

        public CreateRequestCommandHandler(IRepository<Request> requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(CreateRequestCommand request, CancellationToken cancellationToken)
        {

            var req = new RequestDto()
            {
                DayIndisposition = request.DayIndisposition,
                Change = request.Change,
                TypeRequest = request.TypeRequest,
                EmployeeId = request.EmployeeId
            };
            var result = _mapper.Map<Request>(req);
            _requestRepository.Add(result);

            return Task.FromResult(Unit.Value);
        }
    }
}
