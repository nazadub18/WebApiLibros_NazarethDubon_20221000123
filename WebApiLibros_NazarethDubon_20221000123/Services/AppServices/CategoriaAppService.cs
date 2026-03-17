using WebApiLibros_NazarethDubon_20221000123.Data.Repositories;
using WebApiLibros_NazarethDubon_20221000123.Models;
using WebApiLibros_NazarethDubon_20221000123.Services.DomainServices;



namespace WebApiLibros_NazarethDubon_20221000123.Services.AppServices
{
    public class CategoriaAppService : ICategoriaAppService
    {
        private readonly ICategoriaRepository _repository;
        private readonly ICategoriaDomainService _domainService;

        public CategoriaAppService(ICategoriaRepository repository, ICategoriaDomainService domainService)
        {
            _repository = repository;
            _domainService = domainService;
        }


        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            return await _repository.GetAllAsync(); 
        }


        public async Task<Categoria?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Categoria categoria)
        {
            _domainService.ValidarCategoria(categoria);
            await _repository.AddAsync(categoria);
            await _repository.SaveChangesAsync();   
        }
    }
}
