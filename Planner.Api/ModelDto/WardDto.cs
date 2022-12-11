namespace Planner.Api
{
    public class WardDto
    {
        public int Id { get; set; }
        public string WardName { get; set; }
        public bool Deleted { get; set; }
        public IEnumerable<EmployeeDto> Employees { get; set; }
    }
}
