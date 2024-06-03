using static MessageWithComposition.Delegates.JobDelegates;

namespace MessageWithComposition.Job
{
    public class GeneralJob
    {

        public PrepararDelegate? Preparar { get; set; }
        public EventoMensagemEnviadaDelegate? EventoMensagemEnviada { get; set; }
        public FinalizarDelegate? Finalizar { get; set; }

        public void Execute()
        {
            //preparar
            if (Preparar == null) throw new System.Exception("Preparar não foi definido");
            var mensagens = Preparar();
            //iterarEnvio
            mensagens.ForEach(mensagem =>
            {
                //enviar
                //aqui ficaria o código de envio da mensagem
                Console.WriteLine($"Enviando mensagem {mensagem.MessageName} para {mensagem.Contato}");
                if(EventoMensagemEnviada != null)
                    EventoMensagemEnviada(mensagem, new List<dynamic>());
            });

            //Finalizar
            if(Finalizar != null)
                Finalizar();
        }
    }
}
