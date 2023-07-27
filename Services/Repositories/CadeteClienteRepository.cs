//using System.Data.SQLite;
//using AutoMapper;
using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cadeteria;

public class CadeteClienteRepository : ICadeteClienteRepository
{

    DataContext context;
    public CadeteClienteRepository(DataContext dbContext)
    {
        context = dbContext;
    }

    public IEnumerable<CadeteCliente> Get()
    {
        return context.CadCliente;
    }

    public async Task Save(CadeteCliente cadClient)
    {
        context.Add(cadClient);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var cp = context.CadPed.Find(id);
        //Console.WriteLine(pedidoAux.Nombre + " " + id);
        if (cp != null)
        {
            context.Remove(cp);
            await context.SaveChangesAsync();
        }
    }
}
