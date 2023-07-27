using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Cadeteria.Models;

public partial class Pedido
{
    public Guid Id_pedido { get; set; }
    [NotMapped]
    [JsonIgnore]
    public virtual Guid CadeteForeingKey { get; set; }
    public virtual Guid ClienteForeingKey { get; set; }
    public string Obs { get; set; }
    public string Estado { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual Clientes? Cliente { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual Cadetes? Cadete { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual CadetesPedido? Cadp { get; set; }
}