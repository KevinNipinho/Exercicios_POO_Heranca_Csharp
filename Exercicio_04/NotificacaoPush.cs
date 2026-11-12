namespace Exercicio_04
{
    public class NotificacaoPush : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando notificação Push...");
        }
    }
}