using MediatR;

namespace Planner.Api.Service.Command.RequestCommand
{
    public class CreateRequestCommand : IRequest
    {
        public DateTime DayIndisposition { get; set; }
        public string Change { get; set; }
        public string TypeRequest { get; set; }
        public int EmployeeId { get; set; }
    }
}
