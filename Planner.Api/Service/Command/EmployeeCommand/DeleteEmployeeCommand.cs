using MediatR;

namespace Planner.Api.Service.Command.EmployeeCommand
{
    public class DeleteEmployeeCommand : IRequest
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }

        public DeleteEmployeeCommand(int id, bool deleted)
        {
            Id = id;
            Deleted = deleted;
        }
    }
}
