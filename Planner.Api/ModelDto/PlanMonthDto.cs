namespace Planner.Api
{
    public class PlanMonthDto
    {
        public DateTime DateMonth { get; set; }
        public string NameMonth { get; set; }
        public ICollection<PlanDayDto> PlanDays { get; set; }
        public bool Deleted { get; set; }
        public int WardId { get; set; }
    }
}
