using AutoMapper;

namespace Planner.Api.Infrastructure.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
           => new MapperConfiguration(cfg =>
           {
                // cfg.CreateMap<CreateEmployee, EmployeeViewModel>().ReverseMap();
               

           }).CreateMapper();
    }
}
