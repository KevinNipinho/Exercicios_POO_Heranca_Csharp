using Exercicio_04;

NotificacaoEmail email = new NotificacaoEmail();
NotificacaoSMS sms = new NotificacaoSMS();
NotificacaoPush push = new NotificacaoPush();

Console.WriteLine("=== NOTIFICAÇÕES ===");
email.Enviar();
sms.Enviar();
push.Enviar();

// Finalizado