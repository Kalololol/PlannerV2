using MediatR;

namespace Planner.Api.Service.Command.PlanDayCommand
{
    public class EditPlanDayCommand : IRequest
    {
        public int Id { get; set; }
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public string Change { get; set; }
        public ICollection<EmployeeDto> Employees { get; set; }
    }
}
