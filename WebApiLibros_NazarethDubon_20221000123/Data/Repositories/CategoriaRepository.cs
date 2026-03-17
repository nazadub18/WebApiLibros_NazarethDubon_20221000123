using Microsoft.EntityFrameworkCore;
using WebApiLibros_NazarethDubon_20221000123.Models;


namespace WebApiLibros_NazarethDubon_20221000123.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly LibrosDbContext _context;
        public CategoriaRepository(LibrosDbContext context)
        {

            _context = context;
        }

        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria?> GetByIdAsync(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public async Task AddAsync(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
