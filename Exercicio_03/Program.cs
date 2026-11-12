using Exercicio_03;

JogoDigital JogoDigital = new JogoDigital("Cult of The lamb", "PC");

JogoFisico JogoFisico = new JogoFisico("Uncharted", "PlayStation 5");

Console.WriteLine("=== JOGO DIGITAL ===");
JogoDigital.ExibirInformacoes();
JogoDigital.ExibirFormato();

Console.WriteLine("\n=== JOGO FÍSICO ===");
JogoFisico.ExibirInformacoes();
JogoFisico.ExibirFormato();