using WebApiLibros_NazarethDubon_20221000123.Models;

namespace WebApiLibros_NazarethDubon_20221000123.Services.AppServices
{
    public interface ICategoriaAppService
    {
        Task<IEnumerable<Categoria>> GetAllAsync();
        Task<Categoria?> GetByIdAsync(int id);
        Task AddAsync(Categoria categoria);
    }
}
