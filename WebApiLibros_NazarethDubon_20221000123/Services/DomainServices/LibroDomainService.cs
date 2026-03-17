using WebApiLibros_NazarethDubon_20221000123.Models;


namespace WebApiLibros_NazarethDubon_20221000123.Services.DomainServices
{
    public class LibroDomainService : ILibroDomainService
    {
        public void ValidarLibro(Libro libro)
        {
            if (string.IsNullOrWhiteSpace(libro.Nombre))
                throw new ArgumentException("El nombre del libro es obligatorio");
            if (libro.Nombre.Length > 200)
                throw new ArgumentException("El nombre del libro no debe de tener más de 200 caracteres");
            if (string.IsNullOrWhiteSpace(libro.Descripcion))
                throw new ArgumentException("La descripcion del libro es obligatoria");
            if (libro.CategoriaId <= 0)
                throw new ArgumentException("Categoría inválida");

        }
    }
}
