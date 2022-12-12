namespace Planner.WebBlazor.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
        public int ContractId { get; set; }

        public EmployeeViewModel(){}

        public EmployeeViewModel(int id, bool deleted)
        {
            Id = id;
            Deleted = deleted;
        }

        public EmployeeViewModel(int id, string name, string surname, string addressEmail, string phoneNumber, string licenseNumber, string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            AddressEmail = addressEmail;
            PhoneNumber = phoneNumber;
            LicenseNumber = licenseNumber;
            Password = password;
        }

        public EmployeeViewModel(string name, string surname, string addressEmail, string phoneNumber, string licenseNumber, string password)
        {
            Name = name;
            Surname = surname;
            AddressEmail = addressEmail;
            PhoneNumber = phoneNumber;
            LicenseNumber = licenseNumber;
            Password = password;
        }
    }
}
