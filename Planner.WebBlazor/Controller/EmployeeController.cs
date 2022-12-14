using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planner.Api.Service.Command.EmployeeCommand;
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
        public async Task<ActionResult<IList<EmployeeViewModel>>> GetAllEmployee()
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
        public async Task<ActionResult<EmployeeViewModel>> GetEmployeeById(int id)
        {
            try
            {
                var item = await _mediator.Send(new GetEmployeeByIdQuery(id));

                if (item == null) return NotFound();
                else
                {
                    var result = _mapper.Map<EmployeeViewModel>(item);
                    return Ok(result);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Brak użtkownika o podanym identyfikatorze");
            }
        }
        [HttpPost]
        [Route("createEmployee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<EmployeeViewModel>> CreateEmployee(EmployeeViewModel employee)
        {
            try
            {

                if (employee == null) return BadRequest();

                await _mediator.Send(_mapper.Map<CreateEmployeeCommand>(employee));

                // return Ok();
                return CreatedAtAction(nameof(GetEmployeeById), new { id = 1 }, employee);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

        [HttpPost]
        [Route("editEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<EmployeeViewModel>> EditEmployee(EmployeeViewModel employee)
        {
            try
            {
                if (employee == null) return BadRequest();
                await _mediator.Send(_mapper.Map<EditEmployeeCommand>(employee));

                return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id }, employee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

        [HttpPost]
        [Route("deleteEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EmployeeViewModel>> DeleteEmployee(EmployeeViewModel employee)
        {
            try
            {
                if (employee == null) return BadRequest();
                await _mediator.Send(_mapper.Map<EmployeeViewModel>(employee));

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }
    }
}
