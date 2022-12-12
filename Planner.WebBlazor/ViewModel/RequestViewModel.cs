namespace Planner.WebBlazor.ViewModel
{
    public class RequestViewModel
    {
        public int Id { get; set; }
        public DateTime DayIndisposition { get; set; }
        public string Change { get; set; }
        public string TypeRequest { get; set; }
        public int EmployeeId { get; set; }
        public bool Deleted { get; set; }

        public RequestViewModel(){}

        public RequestViewModel(int id, bool deleted)
        {
            Id = id;
            Deleted = deleted;
        }

        public RequestViewModel(int id, DateTime dayIndisposition, string change, string typeRequest)
        {
            Id = id;
            DayIndisposition = dayIndisposition;
            Change = change;
            TypeRequest = typeRequest;
        }

        public RequestViewModel(DateTime dayIndisposition, string change, string typeRequest, int employeeId)
        {
            DayIndisposition = dayIndisposition;
            Change = change;
            TypeRequest = typeRequest;
            EmployeeId = employeeId;
        }
    }
}
