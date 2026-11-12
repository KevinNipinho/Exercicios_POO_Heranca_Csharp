using Exercicios_POO;

Carro carro = new Carro();

carro.Marca = "Toyota";
carro.Modelo = "Corolla";
carro.QuantidadePortas = 4;

Motocicleta moto = new Motocicleta();

moto.Marca = "Honda";
moto.Modelo = "CB 500";
moto.Cilindradas = 500;

Console.WriteLine("=== CARRO ===");
carro.ExibirInformacoes();
Console.WriteLine($"Quantidade de portas: {carro.QuantidadePortas}");

Console.WriteLine("\n=== MOTOCICLETA ===");
moto.ExibirInformacoes();
Console.WriteLine($"Cilindradas: {moto.Cilindradas}");