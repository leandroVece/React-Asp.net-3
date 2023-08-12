using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using System.Data.SQLite;


namespace Cadeteria;


public interface IProfileRepository
{
    IEnumerable<Profile> Get();
    public Profile GetById(Guid id);
    Task Save(Profile cliente);
    Task Update(Guid id, Profile cliente);
    Task Delete(Guid id);

}

