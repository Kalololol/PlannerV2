namespace Planner.WebBlazor.ViewModel
{
    public class WardViewModel
    {
        public int Id { get; set; }
        public string WardName { get; set; }
        public bool Deleted { get; set; }
        public IEnumerable<EmployeeViewModel> Employees { get; set; }

        public WardViewModel(){}

        public WardViewModel(int id, bool deleted)
        {
            Id = id;
            Deleted = deleted;
        }

        public WardViewModel(int id, string wardName, IEnumerable<EmployeeViewModel> employees)
        {
            Id = id;
            WardName = wardName;
            Employees = employees;
        }

        public WardViewModel(string wardName)
        {
            WardName = wardName;
        }
    }
}
