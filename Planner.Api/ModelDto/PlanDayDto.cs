namespace Planner.Api
{
    public class PlanDayDto
    {
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public string Change { get; set; }
        public ICollection<EmployeeDto> Employees { get; set; }
        public bool Deleted { get; set; }
        public int WardId { get; set; }
    }
}
