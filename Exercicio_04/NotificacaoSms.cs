namespace Exercicio_04
{
    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando notificação por SMS...");
        }
    }
}