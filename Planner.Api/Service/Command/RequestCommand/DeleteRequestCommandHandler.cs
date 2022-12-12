using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command.RequestCommand
{
    public class DeleteRequestCommandHandler : IRequestHandler<DeleteRequestCommand, Unit>
    {
        private readonly IRepository<Request> _requestRepository;

        public DeleteRequestCommandHandler(IRepository<Request> requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public Task<Unit> Handle(DeleteRequestCommand request, CancellationToken cancellationToken)
        {

            var req = _requestRepository.GetById(request.Id);

            if (req != null)
            {
                req.Deleted = true;
            }

            _requestRepository.Update(req);


            return Task.FromResult(Unit.Value);
        }
    }
}
