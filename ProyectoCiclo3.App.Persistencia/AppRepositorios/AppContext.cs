using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Aviones> Aviones { get; set; }
        public DbSet<Rutas> Rutas { get; set; }
        public DbSet<Aeropuertos> Aeropuertos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Server=localhost,1433\\MSSQLLocalDB;Database=ProyectoCiclo3Aviones;User Id=sa;Password=Strong.Pwd-123");
            }
        }
    }
}
