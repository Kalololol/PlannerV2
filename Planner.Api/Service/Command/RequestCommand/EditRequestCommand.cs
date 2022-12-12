using MediatR;

namespace Planner.Api.Service.Command.RequestCommand
{
    public class EditRequestCommand : IRequest
    {
        public int Id { get; set; }
        public DateTime DayIndisposition { get; set; }
        public string Change { get; set; }
        public string TypeRequest { get; set; }
    }
}
