namespace Exercicio_04
{
    public class NotificacaoEmail : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando notificação por E-mail...");
        }
    }
}