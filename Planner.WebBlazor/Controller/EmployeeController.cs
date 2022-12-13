using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planner.Api.Service.Query;
using Planner.WebBlazor.ViewModel;

namespace Planner.WebBlazor.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public EmployeeController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getEmployees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<EmployeeViewModel>>> GetAll()
        {

            try
            {
                List<EmployeeViewModel> result = new List<EmployeeViewModel>();
                var employees = await _mediator.Send(new GetEmployeesQuery());

                if (employees == null) return NotFound();
                else
                {
                    foreach (var e in employees)
                    {
                        var employee = _mapper.Map<EmployeeViewModel>(e);
                        result.Add(employee);
                    }
                    return Ok(result);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Brak odpowiedzi z bazy, błąd 500");
            }
        }

        [HttpGet("{id:int}")]
        [Route("getEmployeeById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EmployeeViewModel>> GetContractById(int id)
        {
            try
            {
                var item = await _mediator.Send(new GetContractByIdQuery(id));

                if (item == null) return NotFound();
                else
                {
                    var result = _mapper.Map<ContractViewModel>(item);
                    return Ok(result);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Brak użtkownika o podanym identyfikatorze");
            }
        }
    }
}
