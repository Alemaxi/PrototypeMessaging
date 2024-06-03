using MessageWithComposition.Job;
using static MessageWithComposition.Delegates.JobDelegates;

namespace MessageWithComposition.Builder
{
    public interface IJobBuilder
    {
        public IJobBuilder WithPreparar(PrepararDelegate preparar);
        public IJobBuilder WithEventoMensagemEnviada(EventoMensagemEnviadaDelegate MensagemEnviada);
        public IJobBuilder WithFinalizar(FinalizarDelegate Finalizar);
        public GeneralJob Build();
    }
}
