//using System.Data.SQLite;
//using AutoMapper;
using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cadeteria;

public class ProfileRepository : IProfileRepository
{

    DataContext context;
    public ProfileRepository(DataContext dbContext)
    {
        context = dbContext;
    }

    public IEnumerable<Profile> Get()
    {
        return context.Profile;
    }

    public Profile GetById(Guid id)
    {
        return context.Profile.Find(id);
    }

    public async Task Save(Profile profile)
    {
        context.Add(profile);
        await context.SaveChangesAsync();
    }


    public async Task Update(Guid id, Profile profile)
    {
        var profileAux = context.Profile.Find(id);

        if (profileAux != null)
        {
            profileAux.Nombre = profile.Nombre;
            profileAux.Direccion = profile.Direccion;
            profileAux.Telefono = profile.Telefono;

            await context.SaveChangesAsync();
        }

    }

    public async Task Delete(Guid id)
    {
        var profileAux = context.Profile.Find(id);

        if (profileAux != null)
        {
            context.Remove(profileAux);
            await context.SaveChangesAsync();
        }

    }

}