using Microsoft.EntityFrameworkCore;
using WebApiLibros_NazarethDubon_20221000123.Models;

namespace WebApiLibros_NazarethDubon_20221000123.Data.Repositories
{
    public class LibroRepository : ILibroRepository
    {
        private readonly LibrosDbContext _context;
        public LibroRepository(LibrosDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Libro>> GetAllAsync()
        {
            return await _context.Libros.Include(l =>l.Categoria).ToListAsync();

        }

        public async Task<Libro?> GetByIdAsync(int id)
        {
            return await _context.Libros.Include(l => l.Categoria).FirstOrDefaultAsync(l =>l.Id == id);
        }

        public async Task AddAsync(Libro libro)
        {
            await _context.Libros.AddAsync(libro);
        }

        public async Task UpdateAsync(Libro libro)
        {
            _context.Libros.Update(libro);
        }


        public async Task DeleteAsync(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            if (libro != null)
                _context.Libros.Remove(libro);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }


    }
}
