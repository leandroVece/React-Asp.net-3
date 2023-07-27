//using System.Data.SQLite;
//using AutoMapper;
using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cadeteria;

public class ClienteRepository : IClienteRepository
{

    DataContext context;
    public ClienteRepository(DataContext dbContext)
    {
        context = dbContext;
    }

    public IEnumerable<Clientes> Get()
    {
        return context.Clientes;
    }

    public Clientes GetById(Guid id)
    {
        return context.Clientes.Find(id);
    }

    public async Task Save(Clientes cliente)
    {
        context.Add(cliente);
        await context.SaveChangesAsync();
    }


    public async Task Update(Guid id, Clientes cliente)
    {
        var clienteAux = context.Clientes.Find(id);

        if (clienteAux != null)
        {
            clienteAux.Nombre = cliente.Nombre;
            clienteAux.Direccion = cliente.Direccion;
            clienteAux.Telefono = cliente.Telefono;

            await context.SaveChangesAsync();
        }

    }

    public async Task Delete(Guid id)
    {
        var clienteAux = context.Clientes.Find(id);

        if (clienteAux != null)
        {
            context.Remove(clienteAux);
            await context.SaveChangesAsync();
        }

    }

}