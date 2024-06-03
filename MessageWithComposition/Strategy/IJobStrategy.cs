using MessageWithComposition.DTO;

namespace MessageWithComposition.Strategy
{
    internal interface IJobStrategy
    {
        public  List<MensagemEnviarDTO> Preparar();
        public void EventoMensagemEnviada(MensagemEnviarDTO mensagem, List<dynamic> extraParams);
        public  void Finalizar();
    }
}
