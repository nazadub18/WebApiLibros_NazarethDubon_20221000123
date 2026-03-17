using WebApiLibros_NazarethDubon_20221000123.Models;



namespace WebApiLibros_NazarethDubon_20221000123.Services.DomainServices
{
    public class CategoriaDomainService : ICategoriaDomainService
    {
        public void ValidarCategoria(Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                throw new ArgumentException("El nombre de la categoria es obligatorio");

            if (categoria.Nombre.Length>100)
                throw new ArgumentException("El nombre de la categoria no debe superar los 100 caracteres");

        }
    }
}
