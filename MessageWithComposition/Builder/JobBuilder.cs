using MessageWithComposition.Delegates;
using MessageWithComposition.Job;

namespace MessageWithComposition.Builder
{
    public class JobBuilder: IJobBuilder
    {
        private GeneralJob _job;

        public JobBuilder()
        {
            _job = new GeneralJob();
        }

        public IJobBuilder WithPreparar(JobDelegates.PrepararDelegate preparar)
        {
            _job.Preparar = preparar;
            return this;
        }

        public IJobBuilder WithEventoMensagemEnviada(JobDelegates.EventoMensagemEnviadaDelegate MensagemEnviada)
        {
            _job.EventoMensagemEnviada = MensagemEnviada;
            return this;
        }

        public IJobBuilder WithFinalizar(JobDelegates.FinalizarDelegate Finalizar)
        {
            _job.Finalizar = Finalizar;
            return this;
        }

        public GeneralJob Build()
        {
            return _job;
        }
    }
}
