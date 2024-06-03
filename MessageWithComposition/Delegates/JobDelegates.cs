using MessageWithComposition.DTO;

namespace MessageWithComposition.Delegates
{
    public class JobDelegates
    {
        public delegate List<MensagemEnviarDTO> PrepararDelegate();
        public delegate void EventoMensagemEnviadaDelegate(MensagemEnviarDTO mensagem, List<dynamic> extraParams);
        public delegate void FinalizarDelegate();
    }
}
