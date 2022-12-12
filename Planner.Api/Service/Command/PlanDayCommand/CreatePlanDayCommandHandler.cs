using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command.PlanDayCommand
{
    public class CreatePlanDayCommandHandler : IRequestHandler<CreatePlanDayCommand, Unit>
    {

        private readonly IRepository<PlanDay> _planDayRepository;
        private readonly IMapper _mapper;

        public CreatePlanDayCommandHandler(IRepository<PlanDay> planDayRepository, IMapper mapper)
        {
            _planDayRepository = planDayRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(CreatePlanDayCommand request, CancellationToken cancellationToken)
        {
            var planDay = new PlanDayDto()
            {
                DatePlanDay = request.DatePlanDay,
                NameDay = request.NameDay,
                Change = request.Change,
                Employees = request.Employees,
                WardId = request.WardId
            };

            var result = _mapper.Map<PlanDay>(planDay);
            _planDayRepository.Add(result);

            return Task.FromResult(Unit.Value);

        }
    }
}