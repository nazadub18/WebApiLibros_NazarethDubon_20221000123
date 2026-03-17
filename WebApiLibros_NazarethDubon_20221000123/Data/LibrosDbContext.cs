using Microsoft.EntityFrameworkCore;
using WebApiLibros_NazarethDubon_20221000123.Models;


namespace WebApiLibros_NazarethDubon_20221000123.Data
{
    public class LibrosDbContext : DbContext
    {
        public LibrosDbContext(DbContextOptions<LibrosDbContext> options) : base(options) 
        { 
        }

        public DbSet<Categoria> Categorias {  get; set; }
        public DbSet<Libro> Libros {  get; set; }
    }
}
