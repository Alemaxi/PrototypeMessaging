using MessageWithoutComposition.Dto;

namespace MessageWithoutComposition.Jobs
{
    public abstract class GeneralAbstractJob
    {
        public void Execute()
        {
            //preparar
            var mensagens = Preparar();
            //iterarEnvio
            mensagens.ForEach(mensagem =>
            {
                //enviar
                //aqui ficaria o código de envio da mensagem
                Console.WriteLine($"Enviando mensagem {mensagem.MessageName} para {mensagem.Contato}");
                EventoMensagemEnviada(mensagem, new List<dynamic>());
            });

            //Finalizar
            Finalizar();
        }


        public abstract List<MensagemEnviarDTO> Preparar();

        public abstract void EventoMensagemEnviada(MensagemEnviarDTO mensagem, List<dynamic> extraParams);

        public abstract void Finalizar();
    }
}
