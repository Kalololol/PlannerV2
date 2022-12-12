namespace Planner.WebBlazor.ViewModel
{
    public class PlanMonthViewModel
    {
        public int Id { get; set; }
        public DateTime DateMonth { get; set; }
        public string NameMonth { get; set; }
        public ICollection<PlanDayViewModel> PlanDays { get; set; }
        public bool Deleted { get; set; }
        public int WardId { get; set; }

        public PlanMonthViewModel(){}

        public PlanMonthViewModel(int id, bool deleted)
        {
            Id = id;
            Deleted = deleted;
        }

        public PlanMonthViewModel(DateTime dateMonth, string nameMonth, ICollection<PlanDayViewModel> planDays, int wardId)
        {
            DateMonth = dateMonth;
            NameMonth = nameMonth;
            PlanDays = planDays;
            WardId = wardId;
        }

        public PlanMonthViewModel(int id, DateTime dateMonth, string nameMonth, ICollection<PlanDayViewModel> planDays)
        {
            Id = id;
            DateMonth = dateMonth;
            NameMonth = nameMonth;
            PlanDays = planDays;
        }
    }
}
