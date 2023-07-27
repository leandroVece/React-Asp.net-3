using Cadeteria.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadeteria;

public class DataContext : DbContext
{
    public DbSet<Cadetes> Cadetes { get; set; }
    public DbSet<Clientes> Clientes { get; set; }
    public DbSet<Pedido> Pedido { get; set; }
    public DbSet<CadeteCliente> CadCliente { get; set; }
    public DbSet<CadetesPedido> CadPed { get; set; }
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Cadetes> listCadete = new List<Cadetes>();
        listCadete.Add(new Cadetes() { Id_cadete = Guid.Parse("7b5e9399-8e95-4ae8-8745-9542a01e2cc0"), NombreCad = "Jaun Castellanos", Direccion = "Entre rios", Telefono = "231321231" });
        listCadete.Add(new Cadetes() { Id_cadete = Guid.Parse("0a9fa564-0604-4dfa-88df-3636fe395651"), NombreCad = "Ana Hume", Direccion = "independencia", Telefono = "231321231" });
        listCadete.Add(new Cadetes() { Id_cadete = Guid.Parse("0a9fa564-0604-4dfa-88df-3636fe395678"), NombreCad = "Fer Hume", Direccion = "independencia", Telefono = "654321" });

        modelBuilder.Entity<Cadetes>(Cadete =>
        {
            Cadete.ToTable("cadete");
            Cadete.HasKey(c => c.Id_cadete);
            Cadete.Property(c => c.Id_cadete).IsRequired().ValueGeneratedOnAdd();

            Cadete.Property(c => c.NombreCad).IsRequired().HasMaxLength(20);
            Cadete.Property(c => c.Direccion).IsRequired();
            Cadete.Property(c => c.Telefono).IsRequired();

            Cadete.Ignore(x => x.listaPedido);
            Cadete.Ignore(x => x.Cadp);
            Cadete.HasData(listCadete);
        });

        List<Clientes> listaCliente = new List<Clientes>();
        listaCliente.Add(new Clientes() { Id_cliente = Guid.Parse("7b5e9399-8e95-4ae8-8745-9542a01e2cc3"), Nombre = "Pancho Castellanos", Direccion = "Entre rios", Telefono = "5231234" });
        listaCliente.Add(new Clientes() { Id_cliente = Guid.Parse("7b5e9399-8e95-4ae8-8745-9542a01e2cc1"), Nombre = "Lucio Hume", Direccion = "independencia", Telefono = "8321156" });
        listaCliente.Add(new Clientes() { Id_cliente = Guid.Parse("7b5e9399-8e95-4ae8-8745-9542a01e2cc5"), Nombre = "Val Hume", Direccion = "independencia", Telefono = "975313" });

        modelBuilder.Entity<Clientes>(Clientes =>
        {
            Clientes.ToTable("cliente");
            Clientes.HasKey(p => p.Id_cliente);
            Clientes.Property(p => p.Id_cliente).IsRequired().ValueGeneratedOnAdd();

            Clientes.Property(p => p.Nombre).IsRequired().HasMaxLength(20);
            Clientes.Property(p => p.Direccion).IsRequired().HasMaxLength(100);
            Clientes.Property(p => p.Telefono).IsRequired().HasMaxLength(20);
            Clientes.Property(p => p.Referencia);

            Clientes.HasData(listaCliente);
        });

        modelBuilder.Entity<Pedido>(Pedido =>
        {
            List<Pedido> Listped = new List<Pedido>();
            Listped.Add(new Pedido()
            {
                Id_pedido = Guid.Parse("adc4aba6-b2b6-4ca6-a715-e563987fd02e"),
                ClienteForeingKey = Guid.Parse("7b5e9399-8e95-4ae8-8745-9542a01e2cc3"),
                Obs = "Coca",
                Estado = "Pendiente"
            });

            Pedido.ToTable("pedido");
            Pedido.HasKey(p => p.Id_pedido);
            Pedido.HasOne(cli => cli.Cliente).WithMany(ped => ped.listaPedido).HasForeignKey(c => c.ClienteForeingKey);

            Pedido.Property(p => p.Id_pedido).IsRequired().ValueGeneratedOnAdd();
            Pedido.Property(p => p.Obs).IsRequired().HasMaxLength(50);
            Pedido.Property(p => p.Estado).IsRequired().HasMaxLength(12);

            Pedido.HasData(Listped);
        });

        modelBuilder.Entity<CadeteCliente>(CC =>
        {
            CC.ToTable("cadeteCliente");
            CC.HasKey(CC => CC.Id_cadClient);
            CC.Property(CC => CC.Id_cadClient).IsRequired().ValueGeneratedOnAdd();

            CC.HasOne(c => c.Cadete).WithMany(cc => cc.CadClien).HasForeignKey(c => c.CadeteForeingKey).OnDelete(DeleteBehavior.Restrict);
            CC.HasOne(c => c.Cliente).WithMany(cc => cc.CadClien).HasForeignKey(c => c.ClienteForeingKey).OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CadetesPedido>(CP =>
        {
            CP.ToTable("cadetePedido");
            CP.HasKey(CC => CC.Id_cadPed);
            CP.Property(CC => CC.Id_cadPed).IsRequired().ValueGeneratedOnAdd();

            CP.HasOne(c => c.Cadete).WithMany(cp => cp.Cadp).HasForeignKey(c => c.CadeteForeingKey).OnDelete(DeleteBehavior.Restrict);
            CP.HasOne(p => p.Pedido).WithOne(cp => cp.Cadp).HasForeignKey<CadetesPedido>(p => p.PedidoForeingKey).OnDelete(DeleteBehavior.Restrict);
        });
    }
}