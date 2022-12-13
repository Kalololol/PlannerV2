using AutoMapper;
using Planner.Api;
using Planner.WebBlazor.ViewModel;

namespace Planner.WebBlazor.Infrastructure
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
          => new MapperConfiguration(cfg =>
          {
              cfg.CreateMap<ContractViewModel, ContractDto>().ReverseMap();
              cfg.CreateMap<EmployeeViewModel, EmployeeDto>().ReverseMap();

              cfg.CreateMap<PlanDayViewModel, PlanDayDto>().ReverseMap();
              cfg.CreateMap<PlanMonthViewModel, PlanMonthDto>().ReverseMap();
              cfg.CreateMap<RequestViewModel, RequestDto>().ReverseMap();
              cfg.CreateMap<WardViewModel, WardDto>().ReverseMap();
           }).CreateMapper();
    }
}
