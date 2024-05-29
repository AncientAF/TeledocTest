using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeledocTest.Application.Clients;

namespace TeledocTest.API.Controllers;
[Route("api/clients")]
[ApiController]
public class ClientsController : ControllerBase
{
    private readonly ISender _sender;

    public ClientsController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<GetClientsResponse>> GetClients()
    {
        var result = await _sender.Send(new GetClientsQuery());

        return Ok(result);
    }

    [HttpGet]
    [Route("{id:guid}")]
    public async Task<ActionResult<GetClientByIdResponse>> GetClientById(Guid id)
    {
        var result = await _sender.Send(new GetClientByIdQuery(id));

        return Ok(result);
    }

    [HttpGet]
    [Route("{taxId}")]
    public async Task<ActionResult<GetClientByTaxIdResponse>> GetClientByTaxId(string taxId)
    {
        var result = await _sender.Send(new GetClientByTaxIdQuery(taxId));

        return Ok(result);
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<CreateClientResponse>> CreateClient([FromBody] CreateClientCommand command)
    {
        var result = await _sender.Send(command);

        return Ok(result);
    }

    [HttpPut]
    [Route("")]
    public async Task<ActionResult<UpdateClientResponse>> UpdateClient([FromBody] UpdateClientCommand command)
    {
        var result = await _sender.Send(command);

        return Ok(result);
    }

    [HttpDelete]
    [Route("{id:guid}")]
    public async Task<ActionResult<DeleteClientResponse>> DeleteClient(Guid id)
    {
        var result = await _sender.Send(new DeleteClientCommand(id));

        return Ok(result);
    }
}
