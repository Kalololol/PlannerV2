using MediatR;

namespace Planner.Api.Service.Command
{
    public class DeletePlanDayCommand : IRequest
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }

        public DeletePlanDayCommand(int id, bool deleted)
        {
            Id = id;
            Deleted = deleted;
        }
    }
}
