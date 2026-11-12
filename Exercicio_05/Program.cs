using Exercicio_05;

Entrega expressa = new EntregaExpressa(100);
Entrega economico = new EntregaEconomica(100);
Entrega local = new RetiradaLocal(100);

List<Entrega> listaFrete = new()
{
    expressa,
    economico,
    local
};

Console.WriteLine("=== FRETE ===");
foreach (var lista in listaFrete)
{
    Console.WriteLine($"Frete: {lista.CalcularFrete():C2}");
}

// Finalizado