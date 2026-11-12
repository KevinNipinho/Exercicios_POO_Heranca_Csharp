namespace Exercicio_03
{
    public class JogoFisico : Jogo
    {
        public JogoFisico(string nome, string plataforma)
            : base(nome, plataforma)
        {
            
        }

        public void ExibirFormato()
        {
            Console.WriteLine("Formato: Físico");
        }
    }
}