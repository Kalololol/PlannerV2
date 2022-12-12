using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command.PlanDayCommand
{
    public class EditPlanDayCommandHandler : IRequestHandler<EditPlanDayCommand, Unit>
    {
        private readonly IRepository<PlanDay> _planDayRepository;
        private readonly IMapper _mapper;

        public EditPlanDayCommandHandler(IRepository<PlanDay> planDayRepository, IMapper mapper)
        {
            _planDayRepository = planDayRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(EditPlanDayCommand request, CancellationToken cancellationToken)
        {
            var planDay = _planDayRepository.GetById(request.Id);

            if (planDay != null)
            {
                planDay.DatePlanDay = request.DatePlanDay;
                planDay.NameDay = request.NameDay;
               // planDay.Change = request.Change;                
            }
            _planDayRepository.Update(planDay);


            return Task.FromResult(Unit.Value);
        }
    }
}

