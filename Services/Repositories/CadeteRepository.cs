using Cadeteria.Models;

namespace Cadeteria;

public class CadeteRepository : ICadeteRepository
{
    DataContext context;
    public CadeteRepository(DataContext dbContext)
    {
        context = dbContext;    
    }
    public IEnumerable<Cadetes> Get()
    {
        return context.Cadetes;
    }
    public async Task Save(Cadetes cadete)
    {
        context.Add(cadete);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid id, Cadetes cadete)
    {
        var cadeteAux = context.Cadetes.Find(id);

        if (cadeteAux != null)
        {
            cadeteAux.NombreCad = cadete.NombreCad;
            cadeteAux.Direccion = cadete.Direccion;
            cadeteAux.Telefono = cadete.Telefono;

            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
    {
        var cadeteAux = context.Cadetes.Find(id);

        if (cadeteAux != null)
        {
            context.Remove(cadeteAux);
            await context.SaveChangesAsync();
        }
    }
}
