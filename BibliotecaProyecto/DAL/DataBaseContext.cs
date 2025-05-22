using BibliotecaProyecto.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaProyecto.DAL
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) 
        {

        }

        //Sirve para configurar los indices de cada campo de una tabla en la BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); 
        }

        #region Dbsets
        public DbSet<Country> Countries { get; set; }
        
        #endregion
    }
}
