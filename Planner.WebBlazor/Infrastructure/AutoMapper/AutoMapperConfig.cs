using AutoMapper;

namespace Planner.WebBlazor.Infrastructure
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
