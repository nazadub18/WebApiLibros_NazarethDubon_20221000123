using Microsoft.AspNetCore.Mvc;
using WebApiLibros_NazarethDubon_20221000123.Models;
using WebApiLibros_NazarethDubon_20221000123.Services.AppServices;


namespace WebApiLibros_NazarethDubon_20221000123.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaAppService _service;
        public CategoriasController(ICategoriaAppService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categorias = await _service.GetAllAsync();
            return Ok(categorias);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Categoria categoria)
        {
            try
            {
                await _service.AddAsync(categoria);
                return Ok(categoria);

            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}
