using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command
{
    public class DeletePlanDayCommandHandler : IRequestHandler<DeletePlanDayCommand, Unit>
    {
        private readonly IRepository<PlanDay> _planDayRepository;

        public DeletePlanDayCommandHandler(IRepository<PlanDay> planDayRepository)
        {
            _planDayRepository = planDayRepository;
        }

        public Task<Unit> Handle(DeletePlanDayCommand request, CancellationToken cancellationToken)
        {

            var planDay = _planDayRepository.GetById(request.Id);

            if (planDay != null)
            {
                planDay.Deleted = true;
            }

            _planDayRepository.Update(planDay);

            return Task.FromResult(Unit.Value);

        }
    }
}
