namespace Biblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Título { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int Ano { get; set; }
    }
}
