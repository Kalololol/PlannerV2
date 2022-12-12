using AutoMapper;
using Planner.Domain;

namespace Planner.Api.Infrastructure.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
           => new MapperConfiguration(cfg =>
           {
               cfg.CreateMap<ContractDto, Contract>().ReverseMap();
               cfg.CreateMap<EmployeeDto, Employee>().ReverseMap();
               cfg.CreateMap<PlanDayDto, PlanDay>().ReverseMap();
               cfg.CreateMap<PlanMonthDto, PlanMonth>().ReverseMap();
               cfg.CreateMap<RequestDto, Request>().ReverseMap();
               cfg.CreateMap<WardDto, Ward>().ReverseMap();
           }).CreateMapper();
    }
}
