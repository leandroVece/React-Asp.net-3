using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cadeteria.Models;
public class Cadetes
{
    public Guid Id_cadete { get; set; }
    [NotMapped]
    [JsonIgnore]
    public Guid PedidoForeingKey { get; set; }
    public string NombreCad { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual ICollection<Pedido>? listaPedido { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual List<CadeteCliente>? CadClien { get; set; }
    [NotMapped]
    [JsonIgnore]
    public virtual List<CadetesPedido>? Cadp { get; set; }
}
