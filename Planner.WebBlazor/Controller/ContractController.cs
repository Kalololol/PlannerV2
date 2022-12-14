using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planner.Api.Service.Command.ContractCommand;
using Planner.Api.Service.Query;
using Planner.WebBlazor.ViewModel;

namespace Planner.WebBlazor.Controller
{
 
        [Route("api/[controller]")]
        [ApiController]
        public class ContractController : ControllerBase
        {
            private readonly IMapper _mapper;
            private readonly IMediator _mediator;

            public ContractController(IMapper mapper, IMediator mediator)
            {
                _mapper = mapper;
                _mediator = mediator;
            }

            [HttpGet("{id:int}")]
            [Route("getContractById/{id}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<ActionResult<ContractViewModel>> GetContractById(int id)
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
            [HttpPost]
            [Route("createContract")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<ActionResult<ContractViewModel>> CreateContract(ContractViewModel contract)
            {
                try
                {
                    if (contract == null) return BadRequest();

                    await _mediator.Send(_mapper.Map<CreateContractCommand>(contract));

                    return CreatedAtAction(nameof(GetContractById), new { id = contract.Id }, contract);
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error creating new employee record");
                }
            }
            [HttpPost]
            [Route("editContract")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]


            public async Task<ActionResult<ContractViewModel>> EditContract(ContractViewModel contract)
            {
                try
                {
                    if (contract == null)
                        return BadRequest();
                    await _mediator.Send(_mapper.Map<EditContractCommand>(contract));

                    return Ok();
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error creating new employee record");
                }
            }

        [HttpPost]
        [Route("deleteContract")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ContractViewModel>> DeleteContract(ContractViewModel contract)
        {
            try
            {
                if (contract == null) return BadRequest();
                await _mediator.Send(_mapper.Map<ContractViewModel>(contract));

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
