namespace Planner.Api
{
    public class ContractDto
    {
        public int Id { get; set; }
        public int DeclaredHours { get; set; }
        public string ContractType { get; set; }
        public int EmployeeId { get; set; }
        public bool Deleted { get; set; }

    }
}
