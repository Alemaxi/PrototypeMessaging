using MessageWithComposition.Builder;
using MessageWithComposition.Strategy;

namespace MessageWithComposition
{
    public class MainWithComposition
    {
        public void MainMethod()
        {
            new JobBuilder()
                .WithPreparar(() => new System.Collections.Generic.List<DTO.MensagemEnviarDTO>
                {
                    new DTO.MensagemEnviarDTO
                    {
                        Contato = "Contato 3 with builder",
                        MessageName = "Mensagem 3"
                    },
                })
                .WithEventoMensagemEnviada((mensagem, extraParams) => { Console.WriteLine("Mensagem enviada por lambda"); })
                .WithFinalizar(() => { Console.WriteLine("Finalizado por lambda"); }).Build().Execute();

            var strategy1 = new Mensagem1Strategy();
            new JobBuilder()
                .WithPreparar(strategy1.Preparar)
                .WithEventoMensagemEnviada(strategy1.EventoMensagemEnviada)
                .WithFinalizar(strategy1.Finalizar)
                .Build().Execute();
        }
    }
}
