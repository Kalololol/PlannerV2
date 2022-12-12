namespace Planner.WebBlazor.ViewModel
{
    public class ContractViewModel
    {
        public int Id { get; set; }
        public int DeclaredHours { get; set; }
        public string ContractType { get; set; }
        public int EmployeeId { get; set; }
        public bool Deleted { get; set; }

        public ContractViewModel(){}

        public ContractViewModel(int id, bool deleted)
        {
            Id = id;
            Deleted = deleted;
        }

        public ContractViewModel(int id, int declaredHours, string contractType)
        {
            Id = id;
            DeclaredHours = declaredHours;
            ContractType = contractType;
        }

        public ContractViewModel(int declaredHours, string contractType, int employeeId)
        {
            DeclaredHours = declaredHours;
            ContractType = contractType;
            EmployeeId = employeeId;
        }
    }
}
