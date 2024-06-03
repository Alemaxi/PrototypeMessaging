using MessageWithoutComposition.Dto;

namespace MessageWithoutComposition.Jobs
{
    internal class Mensagem1 : GeneralAbstractJob
    {
        public string ContextualField { get; set; }

        public override void EventoMensagemEnviada(MensagemEnviarDTO mensagem, List<dynamic> extraParams)
        {
            Console.WriteLine($"Evento para {mensagem.MessageName}");
            return;
        }

        public override void Finalizar()
        {
            Console.WriteLine(ContextualField);
        }

        public override List<MensagemEnviarDTO> Preparar()
        {
            ContextualField = "ContextualField";
            return new List<MensagemEnviarDTO>
            {
                new MensagemEnviarDTO
                {
                    MessageName = "Mensagem 1",
                    Contato = "Contato 1"
                },
                new MensagemEnviarDTO
                {
                    MessageName = "Mensagem 2",
                    Contato = "Contato 2"
                }
            };
        }
    }
}
