using MediatR;

namespace Planner.Api.Service.Command.PlanDayCommand
{
    public class CreatePlanDayCommand : IRequest
    {
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public string Change { get; set; }
        public ICollection<EmployeeDto> Employees { get; set; }
        public int WardId { get; set; }

        public CreatePlanDayCommand(DateTime datePlanDay, string nameDay, string change, ICollection<EmployeeDto> employees, int wardId)
        {
            DatePlanDay = datePlanDay;
            NameDay = nameDay;
            Change = change;
            Employees = employees;
            WardId = wardId;
        }
    }
}
