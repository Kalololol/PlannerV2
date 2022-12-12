namespace Planner.WebBlazor.ViewModel
{
    public class PlanDayViewModel
    {
        public int Id { get; set; }
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public string Change { get; set; }
        public ICollection<EmployeeViewModel> Employees { get; set; }
        public bool Deleted { get; set; }
        public int WardId { get; set; }

        public PlanDayViewModel(){}

        public PlanDayViewModel(int id, bool deleted)
        {
            Id = id;
            Deleted = deleted;
        }

        public PlanDayViewModel(int id, DateTime datePlanDay, string nameDay, string change, ICollection<EmployeeViewModel> employees)
        {
            Id = id;
            DatePlanDay = datePlanDay;
            NameDay = nameDay;
            Change = change;
            Employees = employees;
        }

        public PlanDayViewModel(DateTime datePlanDay, string nameDay, string change, ICollection<EmployeeViewModel> employees, int wardId)
        {
            DatePlanDay = datePlanDay;
            NameDay = nameDay;
            Change = change;
            Employees = employees;
            WardId = wardId;
        }
    }
}
