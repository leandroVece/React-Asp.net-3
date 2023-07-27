using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cadeteria;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IClienteRepository _dbcliente;
    private readonly ILogger<ClienteController> _logger;


    public ClienteController(ILogger<ClienteController> logger, IClienteRepository cliente)
    {
        _dbcliente = cliente;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_dbcliente.Get());
    }
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        return Ok(_dbcliente.GetById(id));
    }
    [HttpPost]
    public IActionResult Post([FromBody] Clientes cliente)
    {
        _dbcliente.Save(cliente);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] Clientes cliente)
    {
        _dbcliente.Update(id, cliente);
        _dbcliente.Save(cliente);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _dbcliente.Delete(id);
        return Ok();
    }
}
