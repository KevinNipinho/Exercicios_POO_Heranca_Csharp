namespace Exercicio_06
{
    public class Relatorio : IImprimivel, IExportavel
    {
        public void Exportar()
        {
            Console.WriteLine("Relatório Exportado.");
        }

        public void Imprimir()
        {
           Console.WriteLine("Relatório impresso.");
        }
    }
}