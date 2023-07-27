using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Cadeteria;


public interface ICadeteRepository
{

    IEnumerable<Cadetes> Get();
    Task Save(Cadetes cadete);
    Task Update(Guid id, Cadetes cadete);
    Task Delete(Guid id);

}

