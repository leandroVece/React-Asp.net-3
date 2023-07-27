using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cadeteria.Models;

public class CadetesPedido
{

    public Guid Id_cadPed { get; set; }
    public virtual Guid CadeteForeingKey { get; set; }
    public virtual Guid PedidoForeingKey { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual Cadetes? Cadete { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual Pedido? Pedido { get; set; }

}