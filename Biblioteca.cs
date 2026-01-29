using Biblioteca.Models;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Biblioteca
{
    public class Biblioteca
    {
        private List<Livro> livros = new();
        private int contadorId = 1;

        public void AdicionarLivro(string título, string autor, int ano)
        {
            livros.Add(new Livro { Id = contadorId++, Título = título, Autor = autor, Ano = ano });
        }

        public void RemoverLivro(int Id)
        {
            var Livro = livros.FirstOrDefault(l => l.Id == Id);
            if (Livro != null) livros.Remove(Livro);
        }

        public List<Livro> ListarLivros() => livros;

        public List<Livro> BuscarPorAutor(string autor) =>
            livros.Where(l => l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase)).ToList();

        public List<Livro> BuscarPorTitulo(string título) =>
            livros.Where(l => l.Título.Contains(título, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
