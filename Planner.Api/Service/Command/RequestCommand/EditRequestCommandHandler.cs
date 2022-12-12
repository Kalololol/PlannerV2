using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command.RequestCommand
{
    public class EditRequestCommandHandler : IRequestHandler<EditRequestCommand, Unit>
    {
        private readonly IRepository<Request> _requestRepository;
        private readonly IMapper _mapper;

        public EditRequestCommandHandler(IRepository<Request> requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(EditRequestCommand request, CancellationToken cancellationToken)
        {
            var req = _requestRepository.GetById(request.Id);

            if (req != null)
            {
                req.DayIndisposition = request.DayIndisposition;
                //req.Change = request.Change;
               // req.TypeRequest = request.TypeRequest
                
            }

            _requestRepository.Update(req);


            return Task.FromResult(Unit.Value);
        }
    }
}
