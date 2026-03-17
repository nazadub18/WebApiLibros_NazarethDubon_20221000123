using WebApiLibros_NazarethDubon_20221000123.Models;

namespace WebApiLibros_NazarethDubon_20221000123.Data.Repositories
{
    public interface ICategoriaRepository
    {
      
        Task<IEnumerable<Categoria>> GetAllAsync();
        Task<Categoria?> GetByIdAsync(int id);
        Task AddAsync(Categoria categoria);
        Task SaveChangesAsync();
    
    }
}
