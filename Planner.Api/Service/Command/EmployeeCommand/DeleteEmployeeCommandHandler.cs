using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command.EmployeeCommand
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IRepository<Employee> _employeeRepository;

        public DeleteEmployeeCommandHandler(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {

            var employee = _employeeRepository.GetById(request.Id);

            if (employee != null)
            {
                employee.Deleted = true;
            }

            _employeeRepository.Update(employee);


            return Task.FromResult(Unit.Value);
        }
    }
}
