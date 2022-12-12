using MediatR;

namespace Planner.Api.Service.Command.ContractCommand
{
    public class CreateContractCommand : IRequest
    {
        public int DeclaredHours { get; set; }
        public string ContractType { get; set; }
        public int EmployeeId { get; set; }


        public CreateContractCommand(int declaredHours, string contractType, int employeeId)
        {
            DeclaredHours = declaredHours;
            ContractType = contractType;
            EmployeeId = employeeId;
        }
    }
}
