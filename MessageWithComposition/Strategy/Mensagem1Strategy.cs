using MessageWithComposition.DTO;

namespace MessageWithComposition.Strategy
{
    public class Mensagem1Strategy : IJobStrategy
    {
        public void EventoMensagemEnviada(MensagemEnviarDTO mensagem, List<dynamic> extraParams)
        {
            Console.WriteLine($"Mensagem {mensagem.MessageName} Enviada por strategy");
        }

        public void Finalizar()
        {
            Console.WriteLine("Finalizado por strategy");
            return;
        }

        public List<MensagemEnviarDTO> Preparar()
        {
            return new List<MensagemEnviarDTO>
            {
                new MensagemEnviarDTO
                {
                    Contato = "Contato 1 with strategy",
                    MessageName = "Mensagem 1"
                },
                new MensagemEnviarDTO
                {
                    Contato = "Contato 2 with strategy",
                    MessageName = "Mensagem 2"
                }
            };
        }
    }
}
