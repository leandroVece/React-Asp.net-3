using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cadeteria.Models;

public class CadeteCliente
{
    public Guid Id_cadClient { get; set; }
    public virtual Guid CadeteForeingKey { get; set; }
    public virtual Guid ClienteForeingKey { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual Cadetes? Cadete { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual Clientes? Cliente { get; set; }
}