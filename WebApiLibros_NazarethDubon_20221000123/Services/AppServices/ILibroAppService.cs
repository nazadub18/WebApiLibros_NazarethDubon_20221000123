using WebApiLibros_NazarethDubon_20221000123.Models;


namespace WebApiLibros_NazarethDubon_20221000123.Services.AppServices
{
    public interface ILibroAppService
    {
        Task<IEnumerable<Libro>> GetAllAsync();
        Task<Libro?> GetByIdAsync(int id);
        Task AddAsync(Libro libro);
        Task UpdateAsync(Libro libro);
        Task DeleteAsync(int id);
    }
}
