using AutoMapper.Internal.Mappers;
using Cadeteria.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadeteria;

public class DataContext : DbContext
{
    public DbSet<Profile> Profile { get; set; }
    public DbSet<Pedido> Pedido { get; set; }
    public DbSet<Historial> CadCliente { get; set; }
    public DbSet<CadetesPedido> CadPed { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Rol> rols { get; set; }
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<User>(User =>
        {

            User.ToTable("usuario");
            User.HasKey(User => User.Id);
            User.Property(User => User.userName).IsRequired().HasMaxLength(15).IsUnicode();
            User.Property(User => User.password).IsRequired().HasMaxLength(80);
            //User.Property(User => User.rolForeikey).HasDefaultValue(Guid.Parse("E2A4980F-7C50-45B0-ABA5-6A46D79CF328"));

            User.HasOne(r => r.Rol).WithMany(us => us.User).HasForeignKey(r => r.rolForeikey);

            User.HasData(listaDb.ListUser());
        });

        modelBuilder.Entity<Profile>(profile =>
       {
           profile.ToTable("perfil");
           profile.HasKey(p => p.id);
           profile.Property(p => p.id).IsRequired().ValueGeneratedOnAdd();

           profile.Property(p => p.Nombre).IsRequired().HasMaxLength(20);
           profile.Property(p => p.Direccion).IsRequired().HasMaxLength(100);
           profile.Property(p => p.Telefono).IsRequired().HasMaxLength(20);
           profile.Property(p => p.Referencia);

           profile.HasOne(us => us.User).WithOne(p => p.Profile)
           .HasForeignKey<Profile>(p => p.userForeiKey)
           .OnDelete(DeleteBehavior.Cascade);

           profile.HasData(listaDb.listaPerfil());
       });

        modelBuilder.Entity<Rol>(R =>
       {

           R.ToTable("rol");
           R.HasKey(rol => rol.Id);
           R.Property(rol => rol.rolName).IsRequired().HasMaxLength(15).IsUnicode();

           R.HasData(listaDb.listRol());
       });


        modelBuilder.Entity<Pedido>(Pedido =>
        {

            Pedido.ToTable("pedido");
            Pedido.HasKey(p => p.id);
            Pedido.HasOne(cli => cli.Cliente)
            .WithMany(ped => ped.listaPedido)
            .HasForeignKey(c => c.ClienteForeingKey);

            Pedido.Property(p => p.id).IsRequired().ValueGeneratedOnAdd();
            Pedido.Property(p => p.Obs).IsRequired().HasMaxLength(50);
            Pedido.Property(p => p.Estado).IsRequired().HasMaxLength(12);

            Pedido.HasData(listaDb.listPedido());
        });

        modelBuilder.Entity<CadetesPedido>(CP =>
        {
            CP.ToTable("cadetePedido");
            CP.HasKey(CC => CC.id);
            CP.Property(CC => CC.id).IsRequired().ValueGeneratedOnAdd();

            CP.HasOne(c => c.Cadete).
            WithMany(cp => cp.Cadp).HasForeignKey(c => c.userForeingKey)
            .OnDelete(DeleteBehavior.Restrict);

            CP.HasOne(p => p.Pedido)
            .WithOne(cp => cp.Cadp)
            .HasForeignKey<CadetesPedido>(p => p.pedidoForeingKey)
            .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Historial>(CC =>
        {
            CC.ToTable("historial");
            CC.HasKey(CC => CC.id);
            CC.Property(CC => CC.id).IsRequired().ValueGeneratedOnAdd();
        });
    }
}