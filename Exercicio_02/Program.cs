using Exercicio_02;

Ebook ebook = new Ebook("Harry Potter e a Pedra Filosofal", 29.90m, 223);

CursoOnline curso = new CursoOnline("Desenvolvimento Web", 99.90m, 40);

Console.WriteLine("=== EBOOK ===");
Console.WriteLine($"Nome: {ebook.Nome}");
Console.WriteLine($"Preço: R$ {ebook.Preco}");
Console.WriteLine($"Quantidade de páginas: {ebook.QuantidadePaginas}");

Console.WriteLine("\n=== CURSO ONLINE ===");
Console.WriteLine($"Nome: {curso.Nome}");
Console.WriteLine($"Preço: R$ {curso.Preco}");
Console.WriteLine($"Carga horária: {curso.CargaHoraria} horas");