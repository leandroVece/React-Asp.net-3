using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using System.Data.SQLite;


namespace Cadeteria;


public interface IClienteRepository
{
    IEnumerable<Clientes> Get();
    public Clientes GetById(Guid id);
    Task Save(Clientes cliente);
    Task Update(Guid id, Clientes cliente);
    Task Delete(Guid id);

}

