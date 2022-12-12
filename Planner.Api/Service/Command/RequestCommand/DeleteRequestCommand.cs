using MediatR;

namespace Planner.Api.Service.Command.RequestCommand
{
    public class DeleteRequestCommand : IRequest
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }

        public DeleteRequestCommand(int id, bool deleted)
        {
            Id = id;
            Deleted = deleted;
        }
    }
}
