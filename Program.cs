using Biblioteca;

class Program
{
    static void Main()
    {
        var biblioteca = new Biblioteca.Biblioteca();
        bool rodando = true;

        while (rodando)
        {
            Console.WriteLine("\n--- Sistema de Biblioteca ---");
            Console.WriteLine("1 - Adicionar Livro");
            Console.WriteLine("2 - Remover Livro");
            Console.WriteLine("3 - Listar Livros");
            Console.WriteLine("4 - Buscar por autor");
            Console.WriteLine("5 - Buscar por título");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Título: ");
                    var título = Console.ReadLine();
                    Console.WriteLine("Autor: ");
                    var autor = Console.ReadLine();
                    Console.WriteLine("Ano: ");
                    var ano = int.Parse(Console.ReadLine() ?? "0");
                    biblioteca.AdicionarLivro(título!, autor!, ano);
                    break;

                case "2":
                    Console.WriteLine("ID do livro: ");
                    var id = int.Parse(Console.ReadLine() ?? "0");
                    biblioteca.RemoverLivro(id);
                    break;

                case "3":
                    foreach (var livro in biblioteca.ListarLivros())
                        Console.WriteLine($"{livro.Id} - {livro.Título} - {livro.Autor} - ({livro.Ano})");
                    break;

                case "4":
                    Console.WriteLine("Autor: ");
                    var buscaAutor = Console.ReadLine();
                    foreach (var livro in biblioteca.BuscarPorAutor(buscaAutor!))
                        Console.WriteLine($"{livro.Id} - {livro.Título} - {livro.Autor} - ({livro.Ano})");
                    break;

                case "5":
                    Console.WriteLine("Título: ");
                    var buscaTitulo = Console.ReadLine();
                    foreach (var livro in biblioteca.BuscarPorTitulo(buscaTitulo!))
                        Console.WriteLine($"{livro.Id} - {livro.Título} - {livro.Autor} - ({livro.Ano})");
                    break;

                case "0":
                    rodando = false;
                    break;            

            }
        }
    }
}
