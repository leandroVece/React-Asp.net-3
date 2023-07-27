using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cadeteria.Models;
public class Clientes
{
    public Guid Id_cliente { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string? Referencia { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual ICollection<Pedido>? listaPedido { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual List<CadeteCliente>? Cadp { get; set; }
    [NotMapped]
    [JsonIgnore]
    public virtual List<CadeteCliente>? CadClien { get; set; }
}
