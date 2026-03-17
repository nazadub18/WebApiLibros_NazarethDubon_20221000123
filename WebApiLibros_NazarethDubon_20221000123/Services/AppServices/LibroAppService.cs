using WebApiLibros_NazarethDubon_20221000123.Data.Repositories;
using WebApiLibros_NazarethDubon_20221000123.Models;
using WebApiLibros_NazarethDubon_20221000123.Services.DomainServices;


namespace WebApiLibros_NazarethDubon_20221000123.Services.AppServices
{
    public class LibroAppService : ILibroAppService
    {
        private readonly ILibroRepository _repository;
        private readonly ILibroDomainService _domainService;

        public LibroAppService(ILibroRepository repository, ILibroDomainService domainService)
        {
            _repository = repository;
            _domainService = domainService;
        }

        public async Task<IEnumerable<Libro>> GetAllAsync() 
        { 
            return await _repository.GetAllAsync();
        }

        public async Task<Libro?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Libro libro)
        {
            _domainService.ValidarLibro(libro);
            await _repository.AddAsync(libro);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Libro libro)
        {
            _domainService.ValidarLibro(libro);
            await _repository.UpdateAsync(libro);
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            await _repository.SaveChangesAsync();

        }
    }

}
