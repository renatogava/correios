namespace Correios.Demo.Services.Models
{
    public class MessageResponse
    {
        /// <summary>
        /// Mensagens
        /// </summary>
        public string[] msgs { get; set; }

        /// <summary>
        /// Data e hora de ocorrência do evento.
        /// </summary>
        public string date { get; set; }

        /// <summary>
        /// Método HTTP que foi requisitado.
        /// </summary>
        public string method { get; set; }

        /// <summary>
        /// URL que foi requisitada.
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// A causa da mensagem.
        /// </summary>
        public string causa { get; set; }

        /// <summary>
        /// Detalhe da mensagem.
        /// </summary>
        public string stackTrace { get; set; }
    }
}
