using MediatR;

namespace Planner.Api.Service.Command.EmployeeCommand
{
    public class CreateEmployeeCommand : IRequest
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }

        public CreateEmployeeCommand(string name, string surname, string addressEmail, string phoneNumber, string licenseNumber, string password, bool deleted)
        {
            Name = name;
            Surname = surname;
            AddressEmail = addressEmail;
            PhoneNumber = phoneNumber;
            LicenseNumber = licenseNumber;
            Password = password;
            Deleted = deleted;
        }
    }
}
