using Microsoft.EntityFrameworkCore;
using PracticeEntityCore_One.Models;

namespace PracticeEntityCore_One.Infraestructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
            
        }
        //migration add-migration "name the migration"
        //update-database: para efectuar los cambios de vs a la db
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        //Cuando crear migraciones: cuando se crea una nueva clase 
        // Cuando agregue una nueva propiedad, que equivale a crear un campo nuevo en la bd
        //Cuando modifique un valor de campo en la clase (modificar campo en la db)





    }
}
