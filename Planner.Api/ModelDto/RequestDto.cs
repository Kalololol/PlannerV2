namespace Planner.Api
{
    public class RequestDto
    {
        public int Id { get; set; }
        public DateTime DayIndisposition { get; set; }
        public string Change { get; set; }
        public string TypeRequest { get; set; }
        public int EmployeeId { get; set; }
        public bool Deleted { get; set; }
    }
}
