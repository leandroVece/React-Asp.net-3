using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cadeteria;

[ApiController]
[Route("api/[controller]")]
public class CadetePedidoController : ControllerBase
{
    private readonly DataContext _db;
    private readonly ICadetePedidoRepository _cp;
    private readonly ILogger<CadetePedidoController> _logger;

    public CadetePedidoController(ILogger<CadetePedidoController> logger, ICadetePedidoRepository cp, DataContext db)
    {
        _db = db;
        _cp = cp;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        try
        {
            var response = _db.Clientes.Join(_db.Pedido, client => client.Id_cliente, ped => ped.ClienteForeingKey,
              (client, ped) => new { ped.Id_pedido, ped.ClienteForeingKey, ped.Obs, ped.Estado, client.Nombre }).Where(x => x.Estado == "Pendiente").ToList();
            return Ok(response);
        }
        catch (System.Exception e)
        {
            Console.WriteLine("no se pudo: \n" + e.ToString());
            return Ok();
        }
    }
    [HttpGet]
    [Route("action")]
    public IActionResult GetLista(Guid id)
    {
        try
        {
            var response = _db.Clientes.Join(_db.Pedido, client => client.Id_cliente, ped => ped.ClienteForeingKey,
              (client, ped) => new
              {
                  ped.Id_pedido,
                  ped.Obs,
                  ped.ClienteForeingKey,
                  ped.Estado,
                  client.Nombre
              }).Join(_db.CadPed, cc => cc.Id_pedido, cp => cp.PedidoForeingKey,
              (cc, cp) => new { cc.ClienteForeingKey, cc.Estado, cc.Id_pedido, cc.Nombre, cc.Obs, cp.Id_cadPed })
              .Where(x => x.Estado == "En camino").ToList();

            return Ok(response);
        }
        catch (System.Exception e)
        {
            Console.WriteLine("no se pudo: \n" + e.ToString());
            return Ok();
        }
    }

    [HttpPost]
    public IActionResult Post([FromBody] CadetesPedido cadp)
    {

        try
        {
            _cp.Save(cadp);
            return Ok();
        }
        catch (System.Exception e)
        {
            Console.WriteLine("error: \n" + e.ToString());
            throw;
        }
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id_pedido, [FromBody] Pedido pedido)
    {
        //_dbcadped.Update(id_pedido, pedido);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _cp.Delete(id);
        return Ok();
    }
}
