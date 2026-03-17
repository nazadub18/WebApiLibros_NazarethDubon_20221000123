using Microsoft.AspNetCore.Mvc;
using WebApiLibros_NazarethDubon_20221000123.Models;
using WebApiLibros_NazarethDubon_20221000123.Services.AppServices;




namespace WebApiLibros_NazarethDubon_20221000123.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibrosController : ControllerBase
    {
        private readonly ILibroAppService _service;

        public LibrosController(ILibroAppService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var libros = await _service.GetAllAsync();
            return Ok(libros);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var libro=await _service.GetByIdAsync(id);
            if (libro == null)
                return NotFound("Libro no encontrado");
            return Ok(libro);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Libro libro)
        {
            try
            {
                await _service.AddAsync(libro);
                return Ok(libro);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Libro libro)
        {
            try
            {
                libro.Id = id;
                await _service.UpdateAsync(libro);
                return Ok(libro);

            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Libro eliminado correctamente");
        }
    }
}
