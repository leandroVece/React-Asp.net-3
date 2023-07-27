using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cadeteria;

[ApiController]
[Route("api/[controller]")]
public class PedidoController : ControllerBase
{
    private readonly DataContext _db;
    private readonly IPedidoRepository _dbPedido;
    private readonly ILogger<PedidoController> _logger;


    public PedidoController(ILogger<PedidoController> logger, IPedidoRepository pedido, DataContext db)
    {
        _dbPedido = pedido;
        _db = db;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        try
        {
            var respose = _db.Clientes.Join(_db.Pedido, client => client.Id_cliente, ped => ped.ClienteForeingKey,
              (client, ped) => new { ped.Id_pedido, ped.ClienteForeingKey, ped.Obs, ped.Estado, client.Nombre }).ToList();
            return Ok(respose);
        }
        catch (System.Exception e)
        {
            Console.WriteLine("no se pudo: \n" + e.ToString());
            return Ok(_dbPedido.Get());
        }
    }

    [HttpPost]
    public IActionResult Post([FromBody] Pedido pedido)
    {
        _dbPedido.Save(pedido);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] Pedido pedido)
    {
        _dbPedido.Update(id, pedido);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        try
        {
            Console.WriteLine(id);
            _dbPedido.Delete(id);
            return Ok();

        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.ToString());
            throw;
        }
    }

}
