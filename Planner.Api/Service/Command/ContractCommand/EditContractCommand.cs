using MediatR;

namespace Planner.Api.Service.Command.ContractCommand
{
    public class EditContractCommand : IRequest
    {
        public int Id { get; set; }
        public int DeclaredHours { get; set; }
        public string ContractType { get; set; }

        public EditContractCommand(int id, int declaredHours, string contractType)
        {
            Id = id;
            DeclaredHours = declaredHours;
            ContractType = contractType;
        }
    }
}
