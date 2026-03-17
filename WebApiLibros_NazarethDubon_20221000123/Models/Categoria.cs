namespace WebApiLibros_NazarethDubon_20221000123.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool Activo {  get; set; }

        public ICollection<Libro> Libros { get; set; } = new List<Libro>();

    }
}
