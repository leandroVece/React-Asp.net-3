using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using System.Data.SQLite;


namespace Cadeteria;


public interface ICadeteClienteRepository
{
    public IEnumerable<CadeteCliente> Get();
    Task Save(CadeteCliente cadp);
    Task Delete(Guid id);

}

