namespace Exercicios_POO
{
    class Veiculo
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }
    }
}