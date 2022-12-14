using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planner.Api.Service.Command.EmployeeCommand;
using Planner.Api.Service.Command.RequestCommand;
using Planner.Api.Service.Query;
using Planner.Api.Service.Query.RequestQuery;
using Planner.WebBlazor.ViewModel;

namespace Planner.WebBlazor.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public RequestController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getRequest")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<RequestViewModel>>> GetAllRequest()
        {

            try
            {
                List<RequestViewModel> result = new List<RequestViewModel>();
                var requests = await _mediator.Send(new GetRequestsQuery());

                if (requests == null) return NotFound();
                else
                {
                    foreach (var e in requests)
                    {
                        var request = _mapper.Map<RequestViewModel>(e);
                        result.Add(request);
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
        [Route("getRequestById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RequestViewModel>> GetRequestById(int id)
        {
            try
            {
                var item = await _mediator.Send(new GetRequestByIdQuery(id));

                if (item == null) return NotFound();
                else
                {
                    var result = _mapper.Map<RequestViewModel>(item);
                    return Ok(result);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Brak użtkownika o podanym identyfikatorze");
            }
        }
        [HttpPost]
        [Route("createRequest")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RequestViewModel>> CreateRequest(RequestViewModel request)
        {
            try
            {

                if (request == null) return BadRequest();

                await _mediator.Send(_mapper.Map<CreateRequestCommand>(request));

                // return Ok();
                return CreatedAtAction(nameof(GetRequestById), new { id = 1 }, request);

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

        public async Task<ActionResult<RequestViewModel>> EditRequest(RequestViewModel request)
        {
            try
            {
                if (request == null) return BadRequest();
                await _mediator.Send(_mapper.Map<CreateRequestCommand>(request));

                return CreatedAtAction(nameof(GetRequestById), new { id = request.Id }, request);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }
    }
}
