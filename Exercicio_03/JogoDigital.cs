namespace Exercicio_03
{
    public class JogoDigital : Jogo
    {
        public JogoDigital(string nome, string plataforma)
            : base(nome, plataforma)
        {

        }

        public void ExibirFormato()
        {
            Console.WriteLine("Formato: Digital");
        }
    }
}