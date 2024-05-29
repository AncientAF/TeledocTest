using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeledocTest.Application.Founders;

namespace TeledocTest.API.Controllers;
[Route("api/founders")]
[ApiController]
public class FoundersController : ControllerBase
{
    private readonly ISender _sender;

    public FoundersController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<GetFoundersResponse>> GetFounders()
    {
        var result = await _sender.Send(new GetFoundersQuery());

        return Ok(result);
    }

    [HttpGet]
    [Route("{id:guid}")]
    public async Task<ActionResult<GetFounderByIdResponse>> GetFounderById(Guid id)
    {
        var result = await _sender.Send(new GetFounderByIdQuery(id));

        return Ok(result);
    }

    [HttpGet]
    [Route("{taxId}")]
    public async Task<ActionResult<GetFounderByTaxIdResponse>> GetFounderByTaxId(string taxId)
    {
        var result = await _sender.Send(new GetFounderByTaxIdQuery(taxId));

        return Ok(result);
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<CreateFounderResponse>> CreateFounder([FromBody] CreateFounderCommand command)
    {
        var result = await _sender.Send(command);

        return Ok(result);
    }

    [HttpPut]
    [Route("")]
    public async Task<ActionResult<UpdateFounderResponse>> UpdateFounder([FromBody] UpdateFounderCommand command)
    {
        var result = await _sender.Send(command);

        return Ok(result);
    }

    [HttpDelete]
    [Route("{id:guid}")]
    public async Task<ActionResult<DeleteFounderResponse>> DeleteFounder(Guid id)
    {
        var result = await _sender.Send(new DeleteFounderCommand(id));

        return Ok(result);
    }
}
